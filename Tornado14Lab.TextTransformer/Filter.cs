﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Tornado14Lab.TextTransformer.Controls;

/// <summary>
/// Add new Enumeration, filterDescriptionList item, new Method
/// </summary>
namespace Tornado14Lab.TextTransformer
{
    public enum Filter
    {
        empty = 0,
        StartToString = 10,
        StringToEnd = 20,
        StartToCharNumber = 30,
        CharNumberToEnd = 40,
        Breakline = 50,

        EmptyLines = 100,
        StartsWith = 110,
        NotStartsWith = 120,
        EndsWidh = 130,
        NotEndsWidh = 140,
        Contains = 150,
        NotContains = 160,
        GiveEachLineNo = 170,

        AddAtStartAndAtEnd = 200,
        SplitAndDuplicate = 210,

        GetDuplicateLines = 300,
        GetNotDuplicateLines = 310,
        RemoveDuplicateLines = 320
    }

    public class FilterHelper
    {
        public Dictionary<Filter, FilterInfo> filterDescriptionList = new Dictionary<Filter, FilterInfo>()
        {
            { Filter.StartToString, new FilterInfo() { Description = "Remove in line from start to string", FilterType = typeof(TextboxFilter) } },
            { Filter.StringToEnd, new FilterInfo() { Description = "Remove in line from string to end", FilterType = typeof(TextboxFilter) }},
            { Filter.StartToCharNumber, new FilterInfo() { Description = "Remove in line from start to char number", FilterType = typeof(NumericFilter) }},
            { Filter.CharNumberToEnd, new FilterInfo() { Description = "Remove in line from char to end", FilterType = typeof(NumericFilter) } },
            { Filter.Breakline, new FilterInfo() { Description = "Remove in line breaklines", FilterType = typeof(NoDataFilter) } },


            { Filter.EmptyLines, new FilterInfo() { Description = "Remove Empty lines", FilterType = typeof(NoDataFilter) } },
            { Filter.StartsWith, new FilterInfo() { Description = "Remove lines Starts with", FilterType = typeof(TextboxFilter) } },
            { Filter.NotStartsWith, new FilterInfo() { Description = "Remove lines not starts with", FilterType = typeof(TextboxFilter) } },
            { Filter.EndsWidh, new FilterInfo() { Description = "Remove lines ends with", FilterType = typeof(TextboxFilter) } },
            { Filter.NotEndsWidh, new FilterInfo() { Description = "Remove lines not ends with", FilterType = typeof(TextboxFilter) } },
            { Filter.Contains, new FilterInfo() { Description = "Remove lines contains", FilterType = typeof(TextboxFilter) } },
            { Filter.NotContains, new FilterInfo() { Description = "Remove lines not contains", FilterType = typeof(TextboxFilter) } },
            { Filter.GiveEachLineNo, new FilterInfo() { Description = "Give each line no", FilterType = typeof(NumericFilter) } },
            { Filter.AddAtStartAndAtEnd, new FilterInfo() { Description = "Add at start and at end, each line", FilterType = typeof(DoubleTextboxFiler) } },
            { Filter.SplitAndDuplicate, new FilterInfo() { Description = "Split and duplicate lines", FilterType = typeof(TextboxFilter) } },

            { Filter.GetDuplicateLines, new FilterInfo() { Description = "Get duplicates lines", FilterType = typeof(NoDataFilter) } },
            { Filter.GetNotDuplicateLines, new FilterInfo() { Description = "Get not duplicates lines", FilterType = typeof(NoDataFilter) } },
            { Filter.RemoveDuplicateLines, new FilterInfo() { Description = "Remove duplicate lines", FilterType = typeof(NoDataFilter) } },
        };

        public Dictionary<Filter, Func<FilterContext, FilterResult>> filterList;

        public FilterHelper()
        {
            filterList = new Dictionary<Filter, Func<FilterContext, FilterResult>>();
            foreach (Filter filter in Enum.GetValues(typeof(Filter)))
            {
                try
                {
                    if (filter != Filter.empty)
                    {
                        string methodName = filter.ToString() + "Filter";
                        MethodInfo info = typeof(FilterHelper).GetMethod(methodName);
                        Func<FilterContext, FilterResult> action = (Func<FilterContext, FilterResult>)Delegate.CreateDelegate(typeof(Func<FilterContext, FilterResult>), info);
                        filterList.Add(filter, action);
                    }
                }
                catch (Exception ex)
                {
                    throw;
                }
            }

        }

        public BaseFilter GetFilter(Filter filter)
        {
            Type filterType = filterDescriptionList[filter].FilterType;
            string description = filterDescriptionList[filter].Description;
            BaseFilter result = (BaseFilter)Activator.CreateInstance(filterType);
            result.Key = filter;
            result.Description = description;
            return result;
        }

        #region FilterMethods

        public static FilterResult StartToStringFilter(FilterContext context)
        {
            string toText = (string)context.Parameters[0];
            FilterResult result = new FilterResult();
            using (StringWriter resultWriter = new StringWriter())
            {
                using (StringReader sr = new StringReader(context.Text))
                {
                    string line = String.Empty;
                    while ((line = sr.ReadLine()) != null)
                    {
                        int positionOftoText = line.IndexOf(toText) + 1;
                        string newLine = line.Substring(positionOftoText);
                        resultWriter.WriteLine(newLine);
                    }
                }
                result.Text = resultWriter.ToString();
            }
            return result;
        }

        public static FilterResult StringToEndFilter(FilterContext context)
        {
            string toText = (string)context.Parameters[0];
            FilterResult result = new FilterResult();
            using (StringWriter resultWriter = new StringWriter())
            {
                using (StringReader sr = new StringReader(context.Text))
                {
                    string line = String.Empty;
                    while ((line = sr.ReadLine()) != null)
                    {
                        int positionOftoText = line.IndexOf(toText);
                        string newLine = line.Substring(0, positionOftoText);
                        resultWriter.WriteLine(newLine);
                    }
                }
                result.Text = resultWriter.ToString();
            }
            return result;
        }

        public static FilterResult StartToCharNumberFilter(FilterContext context)
        {
            int toPosition = Decimal.ToInt32((Decimal)context.Parameters[0]);
            FilterResult result = new FilterResult();
            using (StringWriter resultWriter = new StringWriter())
            {
                using (StringReader sr = new StringReader(context.Text))
                {
                    string line = String.Empty;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string newLine = line.Substring((line.Length > toPosition) ? toPosition : line.Length);
                        resultWriter.WriteLine(newLine);
                    }
                }
                result.Text = resultWriter.ToString();
            }
            return result;
        }

        public static FilterResult CharNumberToEndFilter(FilterContext context)
        {
            int toPosition = Decimal.ToInt32((Decimal)context.Parameters[0]) - 1;
            FilterResult result = new FilterResult();
            using (StringWriter resultWriter = new StringWriter())
            {
                using (StringReader sr = new StringReader(context.Text))
                {
                    string line = String.Empty;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string newLine = line.Substring(0, (line.Length >= toPosition) ? toPosition : line.Length);
                        resultWriter.WriteLine(newLine);
                    }
                }
                result.Text = resultWriter.ToString();
            }
            return result;
        }

        public static FilterResult BreaklineFilter(FilterContext context)
        {
            FilterResult result = new FilterResult();
            using (StringWriter resultWriter = new StringWriter())
            {
                using (StringReader sr = new StringReader(context.Text))
                {
                    string line = String.Empty;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string newLine = line.Replace(System.Environment.NewLine, string.Empty);
                        resultWriter.Write(newLine);
                    }
                }
                result.Text = resultWriter.ToString();
            }
            return result;
        }


        public static FilterResult EmptyLinesFilter(FilterContext context)
        {
            FilterResult result = new FilterResult();
            using (StringWriter resultWriter = new StringWriter())
            {
                using (StringReader sr = new StringReader(context.Text))
                {
                    string line = String.Empty;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (!String.IsNullOrWhiteSpace(line))
                        {
                            resultWriter.WriteLine(line);
                        }
                    }
                }
                result.Text = resultWriter.ToString();
            }
            return result;
        }

        public static FilterResult StartsWithFilter(FilterContext context)
        {
            string startsWith = (string)context.Parameters[0];
            FilterResult result = new FilterResult();
            using (StringWriter resultWriter = new StringWriter())
            {
                using (StringReader sr = new StringReader(context.Text))
                {
                    string line = String.Empty;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (!line.StartsWith(startsWith))
                        {
                            resultWriter.WriteLine(line);
                        }
                    }
                }
                result.Text = resultWriter.ToString();
            }
            return result;
        }

        public static FilterResult NotStartsWithFilter(FilterContext context)
        {
            string startsWith = (string)context.Parameters[0];
            FilterResult result = new FilterResult();
            using (StringWriter resultWriter = new StringWriter())
            {
                using (StringReader sr = new StringReader(context.Text))
                {
                    string line = String.Empty;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line.StartsWith(startsWith))
                        {
                            resultWriter.WriteLine(line);
                        }
                    }
                }
                result.Text = resultWriter.ToString();
            }
            return result;
        }

        public static FilterResult EndsWidhFilter(FilterContext context)
        {
            string endsWith = (string)context.Parameters[0];
            FilterResult result = new FilterResult();
            using (StringWriter resultWriter = new StringWriter())
            {
                using (StringReader sr = new StringReader(context.Text))
                {
                    string line = String.Empty;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (!line.EndsWith(endsWith))
                        {
                            resultWriter.WriteLine(line);
                        }
                    }
                }
                result.Text = resultWriter.ToString();
            }
            return result;
        }

        public static FilterResult NotEndsWidhFilter(FilterContext context)
        {
            string endsWith = (string)context.Parameters[0];
            FilterResult result = new FilterResult();
            using (StringWriter resultWriter = new StringWriter())
            {
                using (StringReader sr = new StringReader(context.Text))
                {
                    string line = String.Empty;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line.EndsWith(endsWith))
                        {
                            resultWriter.WriteLine(line);
                        }
                    }
                }
                result.Text = resultWriter.ToString();
            }
            return result;
        }

        public static FilterResult ContainsFilter(FilterContext context)
        {
            string containsText = (string)context.Parameters[0];
            FilterResult result = new FilterResult();
            using (StringWriter resultWriter = new StringWriter())
            {
                using (StringReader sr = new StringReader(context.Text))
                {
                    string line = String.Empty;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (!line.Contains(containsText))
                        {
                            resultWriter.WriteLine(line);
                        }
                    }
                }
                result.Text = resultWriter.ToString();
            }
            return result;
        }

        public static FilterResult NotContainsFilter(FilterContext context)
        {
            string notContainsText = (string)context.Parameters[0];
            FilterResult result = new FilterResult();
            using (StringWriter resultWriter = new StringWriter())
            {
                using (StringReader sr = new StringReader(context.Text))
                {
                    string line = String.Empty;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line.Contains(notContainsText))
                        {
                            resultWriter.WriteLine(line);
                        }
                    }
                }
                result.Text = resultWriter.ToString();
            }
            return result;
        }

        public static FilterResult GiveEachLineNoFilter(FilterContext context)
        {
            int lineNoStep = Decimal.ToInt32((Decimal)context.Parameters[0]);
            int lineCount = 0;
            FilterResult result = new FilterResult();
            using (StringWriter resultWriter = new StringWriter())
            {
                using (StringReader sr = new StringReader(context.Text))
                {
                    string line = String.Empty;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (lineCount == lineNoStep)
                        {
                            resultWriter.WriteLine(line);
                            lineCount = 0;
                        }
                        lineCount++;
                    }
                }
                result.Text = resultWriter.ToString();
            }
            return result;
        }



        public static FilterResult AddAtStartAndAtEndFilter(FilterContext context)
        {
            FilterResult result = new FilterResult();
            using (StringWriter resultWriter = new StringWriter())
            {
                using (StringReader sr = new StringReader(context.Text))
                {
                    string line = String.Empty;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string leftText = (string)context.Parameters[0];
                        string rightText = (string)context.Parameters[1];
                        string newLine = string.Format("{0}{1}{2}", leftText, line, rightText);
                        resultWriter.WriteLine(newLine);
                    }
                }
                result.Text = resultWriter.ToString();
            }
            return result;
        }

        public static FilterResult SplitAndDuplicateFilter(FilterContext context)
        {
            string splitter = (string)context.Parameters[0];
            FilterResult result = new FilterResult();
            using (StringWriter resultWriter = new StringWriter())
            {
                using (StringReader sr = new StringReader(context.Text))
                {
                    string line = String.Empty;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string newLine = string.Format("{0}{1}{0}", line, splitter);
                        resultWriter.WriteLine(newLine);
                    }
                }
                result.Text = resultWriter.ToString();
            }
            return result;
        }

        
        public static FilterResult GetDuplicateLinesFilter(FilterContext context)
        {
            FilterResult result = new FilterResult();

            List<string> inputTextLinesList = new List<string>();
            List<string> dulicateLinesLineList = new List<string>();

            using (StringReader sr = new StringReader(context.Text))
            {
                string line = String.Empty;
                while ((line = sr.ReadLine()) != null)
                {
                    inputTextLinesList.Add(line);
                }
            }

            inputTextLinesList.Sort();

            for (int count = 0; count < inputTextLinesList.Count; count++)
            {
                int b = count;
                if (count < inputTextLinesList.Count)
                {
                    b++;
                }
                if (inputTextLinesList.Count > b)
                {
                    if (inputTextLinesList[count] == inputTextLinesList[b])
                    {
                        if (!dulicateLinesLineList.Contains(inputTextLinesList[count]))
                        {
                            dulicateLinesLineList.Add(inputTextLinesList[count]);
                        }
                    }
                }
            }

            StringBuilder resultStringBuilder = new StringBuilder();
            foreach (string line in dulicateLinesLineList)
            {
                resultStringBuilder.AppendLine(line);
            }
            result.Text = resultStringBuilder.ToString();

            return result;
        }
        //-
        public static FilterResult GetNotDuplicateLinesFilter(FilterContext context)
        {
            FilterResult result = new FilterResult();

            List<string> inputTextLinesList = new List<string>();
            List<string> dulicateLinesLineList = new List<string>();

            using (StringReader sr = new StringReader(context.Text))
            {
                string line = String.Empty;
                while ((line = sr.ReadLine()) != null)
                {
                    inputTextLinesList.Add(line);
                }
            }

            inputTextLinesList.Sort();

            for (int count = 0; count < inputTextLinesList.Count; count++)
            {
                int b = count;
                if (count < inputTextLinesList.Count)
                {
                    b++;
                }
                if (inputTextLinesList.Count > b)
                {
                    if (inputTextLinesList[count] == inputTextLinesList[b])
                    {
                        if (!dulicateLinesLineList.Contains(inputTextLinesList[count]))
                        {
                            dulicateLinesLineList.Add(inputTextLinesList[count]);
                        }
                    }
                }
            }

            StringBuilder resultStringBuilder = new StringBuilder();
            foreach (string line in inputTextLinesList)
            {
                if (!dulicateLinesLineList.Contains(line))
                {
                    resultStringBuilder.AppendLine(line);
                }
            }
            result.Text = resultStringBuilder.ToString();

            return result;
        }
        //-
        public static FilterResult RemoveDuplicateLinesFilter(FilterContext context)
        {
            FilterResult result = new FilterResult();

            List<string> inputTextLinesList = new List<string>();

            using (StringReader sr = new StringReader(context.Text))
            {
                string line = String.Empty;
                while ((line = sr.ReadLine()) != null)
                {
                    if (!inputTextLinesList.Contains(line))
                    {
                        inputTextLinesList.Add(line);
                    }
                }
            }

            StringBuilder resultStringBuilder = new StringBuilder();
            foreach (string line in inputTextLinesList)
            {
                resultStringBuilder.AppendLine(line);
            }
            result.Text = resultStringBuilder.ToString();

            return result;
        }

        #endregion
    }

    public class FilterContext
    {
        public List<object> Parameters { get; set; }
        public string Text { get; set; }
    }

    public class FilterResult
    {
        public string Text { get; set; }
    }

    public class FilterInfo
    {
        public string Description { get; set; }
        public Type FilterType { get; set; }
    }
}
