using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace System.Windows.Forms.Calendar
{
    public class CalendarProfessionalRenderer
        : CalendarSystemRenderer
    {
        #region Fields

        public Color HeaderA = FromHex("#E4ECF6");
        public Color HeaderB = FromHex("#D6E2F1");
        public Color HeaderC = FromHex("#C2D4EB");
        public Color HeaderD = FromHex("#D0DEEF");

        public Color TodayA = FromHex("#F8D478");
        public Color TodayB = FromHex("#F8D478");
        public Color TodayC = FromHex("#F2AA36");
        public Color TodayD = FromHex("#F7C966");

        #endregion

        #region Ctor

        public CalendarProfessionalRenderer(Calendar c)
            : base(c)
        {
            
            ColorTable.Background = FromHex("#1e1e1e");//Dark0
            ColorTable.DayBackgroundEven = FromHex("#252526");//Dark1
            ColorTable.DayBackgroundOdd = FromHex("#1e1e1e");//Dark0

            ColorTable.DayBackgroundSelected = FromHex("#252526");
            ColorTable.DayBorder = FromHex("#646464"); //Green 2b655a
            ColorTable.DayHeaderBackground = Color.Blue;
            ColorTable.DayHeaderText = Color.Red;
            ColorTable.DayHeaderSecondaryText = Color.Pink;
            ColorTable.DayTopBorder = FromHex("#646464"); //Green 2b655a
            ColorTable.DayTopSelectedBorder = Color.Purple;
            ColorTable.DayTopBackground = FromHex("#252526");//Dark1
            ColorTable.DayTopSelectedBackground = FromHex("#294C7A");

            ColorTable.ItemBorder = Color.Black;
            
            ColorTable.ItemBackground = Color.YellowGreen;
            ColorTable.ItemText = Color.White;
            ColorTable.ItemSecondaryText = Color.White;
            ColorTable.ItemSelectedBorder = Color.Black;
            ColorTable.ItemSelectedBackground = FromHex("#3399ff");//Selected Blue
            ColorTable.ItemSelectedText = Color.White;

            ColorTable.WeekHeaderBackground = FromHex("#1e1e1e");//Dark0
            ColorTable.WeekHeaderBorder = FromHex("#646464");//Green 2b655a
            ColorTable.WeekHeaderText = FromHex("#646464");//Green 2b655a

            ColorTable.TodayBorder = FromHex("#3399ff");// Selected Blue
            ColorTable.TodayTopBackground = Color.Green;

            ColorTable.TimeScaleLine = FromHex("#646464");// Green 2b655a
            ColorTable.TimeScaleHours = Color.White;//
            ColorTable.TimeScaleMinutes = Color.White;//
            ColorTable.TimeUnitBackground = FromHex("#1e1e1e");//Dark0
            ColorTable.TimeUnitHighlightedBackground = FromHex("#2a2a2a");//
            ColorTable.TimeUnitSelectedBackground = FromHex("#646464");//Green 2b655a
            ColorTable.TimeUnitBorderLight = FromHex("#252526");//Dark2
            ColorTable.TimeUnitBorderDark = FromHex("#1a1a1b");//Dark1
            ColorTable.WeekDayName = FromHex("#646464");//Green 2b655a

            SelectedItemBorder = 1f;
            ItemRoundness = 0;
        }

        #endregion

        #region Private Method

        public static void GradientRect(Graphics g, Rectangle bounds, Color a, Color b)
        {

        }

        public static void GlossyRect(Graphics g, Rectangle bounds, Color a, Color b, Color c, Color d)
        {
            Rectangle top = new Rectangle(bounds.Left, bounds.Top, bounds.Width, bounds.Height / 2);
            Rectangle bot = Rectangle.FromLTRB(bounds.Left, top.Bottom, bounds.Right, bounds.Bottom);

            GradientRect(g, top, a, b);
            GradientRect(g, bot, c, d);

        }

        /// <summary>
        /// Shortcut to one on CalendarColorTable
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        private static Color FromHex(string color)
        {
            return CalendarColorTable.FromHex(color);
        }

        #endregion

        #region Overrides

        public override void OnInitialize(CalendarRendererEventArgs e)
        {
            base.OnInitialize(e);

            e.Calendar.Font = SystemFonts.CaptionFont;
        }

        public override void OnDrawDayHeaderBackground(CalendarRendererDayEventArgs e)
        {
            Rectangle r = e.Day.HeaderBounds;

            if (e.Day.Date == DateTime.Today)
            {
                GlossyRect(e.Graphics, e.Day.HeaderBounds, TodayA, TodayB, TodayC, TodayD);
            }
            else
            {
                GlossyRect(e.Graphics, e.Day.HeaderBounds, HeaderA, HeaderB, HeaderC, HeaderD);
            }

            if (e.Calendar.DaysMode == CalendarDaysMode.Short)
            {
                using (Pen p = new Pen(ColorTable.DayBorder))
                {
                    e.Graphics.DrawLine(p, r.Left, r.Top, r.Right, r.Top);
                    e.Graphics.DrawLine(p, r.Left, r.Bottom, r.Right, r.Bottom);
                } 
            }
        }

        public override void OnDrawItemBorder(CalendarRendererItemBoundsEventArgs e)
        {
            base.OnDrawItemBorder(e);

            using (Pen p = new Pen(Color.Transparent))
            {
                e.Graphics.DrawLine(p, e.Bounds.Left + ItemRoundness, e.Bounds.Top + 1, e.Bounds.Right - ItemRoundness, e.Bounds.Top + 1); 
            }

            if (e.Item.Selected && !e.Item.IsDragging)
            {
                bool horizontal = false;
                bool vertical = false;
                Rectangle r1 = new Rectangle(0, 0, 5, 5);
                Rectangle r2 = new Rectangle(0, 0, 5, 5);

                horizontal = e.Item.IsOnDayTop;
                vertical = !e.Item.IsOnDayTop && e.Calendar.DaysMode == CalendarDaysMode.Expanded;

                if (horizontal)
                {
                    r1.X = e.Bounds.Left - 2;
                    r2.X = e.Bounds.Right - r1.Width + 2;
                    r1.Y = e.Bounds.Top + (e.Bounds.Height - r1.Height) / 2;
                    r2.Y = r1.Y;
                }

                if (vertical)
                {
                    r1.Y = e.Bounds.Top - 2;
                    r2.Y = e.Bounds.Bottom - r1.Height + 2;
                    r1.X = e.Bounds.Left + (e.Bounds.Width - r1.Width) / 2;
                    r2.X = r1.X;
                }

                if ((horizontal || vertical) && Calendar.AllowItemResize)
                {
                    if (!e.Item.IsOpenStart && e.IsFirst)
                    {
                        e.Graphics.FillRectangle(Brushes.Black, r1);
                        e.Graphics.DrawRectangle(Pens.Black, r1);
                    }

                    if (!e.Item.IsOpenEnd && e.IsLast)
                    {
                        e.Graphics.FillRectangle(Brushes.Black, r2);
                        e.Graphics.DrawRectangle(Pens.Black, r2);
                    }
                } 
            }
        }

        #endregion
    }
}
