﻿namespace Tornado14Lab.TextTransformer.Controls
{
    partial class NumericFilter
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelSplitterLine = new System.Windows.Forms.Panel();
            this.panelWrapper = new System.Windows.Forms.Panel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.labelDescription = new System.Windows.Forms.Label();
            this.panelWrapper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSplitterLine
            // 
            this.panelSplitterLine.BackColor = System.Drawing.Color.White;
            this.panelSplitterLine.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelSplitterLine.Location = new System.Drawing.Point(0, 56);
            this.panelSplitterLine.Name = "panelSplitterLine";
            this.panelSplitterLine.Size = new System.Drawing.Size(300, 4);
            this.panelSplitterLine.TabIndex = 20;
            // 
            // panelWrapper
            // 
            this.panelWrapper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panelWrapper.Controls.Add(this.numericUpDown1);
            this.panelWrapper.Controls.Add(this.labelDescription);
            this.panelWrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWrapper.Location = new System.Drawing.Point(0, 0);
            this.panelWrapper.Name = "panelWrapper";
            this.panelWrapper.Padding = new System.Windows.Forms.Padding(5);
            this.panelWrapper.Size = new System.Drawing.Size(300, 60);
            this.panelWrapper.TabIndex = 19;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Dock = System.Windows.Forms.DockStyle.Top;
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(5, 26);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(290, 26);
            this.numericUpDown1.TabIndex = 15;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.ForeColor = System.Drawing.Color.Black;
            this.labelDescription.Location = new System.Drawing.Point(5, 5);
            this.labelDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 4);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(47, 21);
            this.labelDescription.TabIndex = 14;
            this.labelDescription.Text = "Label";
            // 
            // NumericFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelSplitterLine);
            this.Controls.Add(this.panelWrapper);
            this.Name = "NumericFilter";
            this.Size = new System.Drawing.Size(300, 60);
            this.panelWrapper.ResumeLayout(false);
            this.panelWrapper.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSplitterLine;
        private System.Windows.Forms.Panel panelWrapper;
        protected System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}
