﻿namespace Tornado14.TrayApp
{
    partial class ProjectExplorer
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectExplorer));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonKanban = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonTimePlanning = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonGantt = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonTask = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSprint = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonProject = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.projectGridPanel1 = new Tornado14.TrayApp.Controls.ProjectGridPanel();
            this.sprintGridPanel1 = new Tornado14.TrayApp.Controls.SprintGridPanel();
            this.tasksGridPanel1 = new Tornado14.TrayApp.Controls.TasksGridPanel();
            this.sprintKanbanPanel1 = new Tornado14.TrayApp.Controls.SprintKanbanPanel();
            this.taskPlanningPanel1 = new Tornado14.TrayApp.Controls.TaskPlanningPanel();
            this.toolStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 668);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1087, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripMain
            // 
            this.toolStripMain.AutoSize = false;
            this.toolStripMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.toolStripMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripMain.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonKanban,
            this.toolStripButtonTimePlanning,
            this.toolStripButtonGantt,
            this.toolStripButtonTask,
            this.toolStripButtonSprint,
            this.toolStripButtonProject,
            this.toolStripButton1});
            this.toolStripMain.Location = new System.Drawing.Point(0, 0);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(899, 66);
            this.toolStripMain.TabIndex = 8;
            this.toolStripMain.Text = "toolStripMain";
            // 
            // toolStripButtonKanban
            // 
            this.toolStripButtonKanban.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(112)))), ((int)(((byte)(50)))));
            this.toolStripButtonKanban.Image = global::Tornado14.TrayApp.Properties.Resources.to_do1;
            this.toolStripButtonKanban.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonKanban.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonKanban.Name = "toolStripButtonKanban";
            this.toolStripButtonKanban.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.toolStripButtonKanban.Size = new System.Drawing.Size(51, 63);
            this.toolStripButtonKanban.Text = "Kanban";
            this.toolStripButtonKanban.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonKanban.Click += new System.EventHandler(this.toolStripButtonKanban_Click);
            // 
            // toolStripButtonTimePlanning
            // 
            this.toolStripButtonTimePlanning.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(112)))), ((int)(((byte)(50)))));
            this.toolStripButtonTimePlanning.Image = global::Tornado14.TrayApp.Properties.Resources.tear_off_calendar;
            this.toolStripButtonTimePlanning.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonTimePlanning.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonTimePlanning.Margin = new System.Windows.Forms.Padding(0, 1, 30, 2);
            this.toolStripButtonTimePlanning.Name = "toolStripButtonTimePlanning";
            this.toolStripButtonTimePlanning.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.toolStripButtonTimePlanning.Size = new System.Drawing.Size(45, 63);
            this.toolStripButtonTimePlanning.Text = "Plan A";
            this.toolStripButtonTimePlanning.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonTimePlanning.Click += new System.EventHandler(this.toolStripButtonTimePlanning_Click);
            // 
            // toolStripButtonGantt
            // 
            this.toolStripButtonGantt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(112)))), ((int)(((byte)(50)))));
            this.toolStripButtonGantt.Image = global::Tornado14.TrayApp.Properties.Resources.outline1;
            this.toolStripButtonGantt.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonGantt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonGantt.Margin = new System.Windows.Forms.Padding(0, 1, 30, 2);
            this.toolStripButtonGantt.Name = "toolStripButtonGantt";
            this.toolStripButtonGantt.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.toolStripButtonGantt.Size = new System.Drawing.Size(50, 63);
            this.toolStripButtonGantt.Text = "Outline";
            this.toolStripButtonGantt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonGantt.Visible = false;
            this.toolStripButtonGantt.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButtonTask
            // 
            this.toolStripButtonTask.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(112)))), ((int)(((byte)(50)))));
            this.toolStripButtonTask.Image = global::Tornado14.TrayApp.Properties.Resources.checklist;
            this.toolStripButtonTask.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonTask.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonTask.Name = "toolStripButtonTask";
            this.toolStripButtonTask.Padding = new System.Windows.Forms.Padding(5);
            this.toolStripButtonTask.Size = new System.Drawing.Size(46, 63);
            this.toolStripButtonTask.Text = "Task";
            this.toolStripButtonTask.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonTask.Click += new System.EventHandler(this.toolStripButtonTask_Click);
            // 
            // toolStripButtonSprint
            // 
            this.toolStripButtonSprint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(112)))), ((int)(((byte)(50)))));
            this.toolStripButtonSprint.Image = global::Tornado14.TrayApp.Properties.Resources.date_span2;
            this.toolStripButtonSprint.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonSprint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSprint.Name = "toolStripButtonSprint";
            this.toolStripButtonSprint.Padding = new System.Windows.Forms.Padding(5);
            this.toolStripButtonSprint.Size = new System.Drawing.Size(52, 63);
            this.toolStripButtonSprint.Text = "Sprint";
            this.toolStripButtonSprint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonSprint.Click += new System.EventHandler(this.toolStripButtonSprint_Click);
            // 
            // toolStripButtonProject
            // 
            this.toolStripButtonProject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(112)))), ((int)(((byte)(50)))));
            this.toolStripButtonProject.Image = global::Tornado14.TrayApp.Properties.Resources.idea1;
            this.toolStripButtonProject.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonProject.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonProject.Name = "toolStripButtonProject";
            this.toolStripButtonProject.Padding = new System.Windows.Forms.Padding(5);
            this.toolStripButtonProject.Size = new System.Drawing.Size(58, 63);
            this.toolStripButtonProject.Text = "Project";
            this.toolStripButtonProject.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonProject.Click += new System.EventHandler(this.toolStripButtonProject_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(112)))), ((int)(((byte)(50)))));
            this.toolStripButton1.Image = global::Tornado14.TrayApp.Properties.Resources.synchronize1;
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Margin = new System.Windows.Forms.Padding(50, 1, 0, 2);
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Padding = new System.Windows.Forms.Padding(5);
            this.toolStripButton1.Size = new System.Drawing.Size(57, 63);
            this.toolStripButton1.Text = "Reload";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1087, 3);
            this.panel1.TabIndex = 10;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.toolStripMain);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1087, 66);
            this.splitContainer1.SplitterDistance = 899;
            this.splitContainer1.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(-5, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.pictureBox1.Size = new System.Drawing.Size(189, 66);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // projectGridPanel1
            // 
            this.projectGridPanel1.DataFilePath = null;
            this.projectGridPanel1.HasChanges = true;
            this.projectGridPanel1.Location = new System.Drawing.Point(106, 85);
            this.projectGridPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.projectGridPanel1.Name = "projectGridPanel1";
            this.projectGridPanel1.parentPanel = null;
            this.projectGridPanel1.Size = new System.Drawing.Size(78, 388);
            this.projectGridPanel1.TabIndex = 3;
            // 
            // sprintGridPanel1
            // 
            this.sprintGridPanel1.DataFilePath = null;
            this.sprintGridPanel1.HasChanges = true;
            this.sprintGridPanel1.Location = new System.Drawing.Point(12, 85);
            this.sprintGridPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sprintGridPanel1.Name = "sprintGridPanel1";
            this.sprintGridPanel1.parentPanel = null;
            this.sprintGridPanel1.Size = new System.Drawing.Size(69, 388);
            this.sprintGridPanel1.TabIndex = 2;
            // 
            // tasksGridPanel1
            // 
            this.tasksGridPanel1.DataFilePath = null;
            this.tasksGridPanel1.HasChanges = true;
            this.tasksGridPanel1.Location = new System.Drawing.Point(309, 85);
            this.tasksGridPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tasksGridPanel1.Name = "tasksGridPanel1";
            this.tasksGridPanel1.parentPanel = null;
            this.tasksGridPanel1.Size = new System.Drawing.Size(92, 388);
            this.tasksGridPanel1.TabIndex = 1;
            // 
            // sprintKanbanPanel1
            // 
            this.sprintKanbanPanel1.DataFilePath = null;
            this.sprintKanbanPanel1.HasChanges = false;
            this.sprintKanbanPanel1.Location = new System.Drawing.Point(207, 85);
            this.sprintKanbanPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sprintKanbanPanel1.Name = "sprintKanbanPanel1";
            this.sprintKanbanPanel1.parentPanel = null;
            this.sprintKanbanPanel1.Size = new System.Drawing.Size(64, 388);
            this.sprintKanbanPanel1.TabIndex = 0;
            // 
            // taskPlanningPanel1
            // 
            this.taskPlanningPanel1.Location = new System.Drawing.Point(424, 85);
            this.taskPlanningPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.taskPlanningPanel1.Name = "taskPlanningPanel1";
            this.taskPlanningPanel1.Size = new System.Drawing.Size(123, 629);
            this.taskPlanningPanel1.TabIndex = 12;
            // 
            // ProjectExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 690);
            this.Controls.Add(this.taskPlanningPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.projectGridPanel1);
            this.Controls.Add(this.sprintGridPanel1);
            this.Controls.Add(this.tasksGridPanel1);
            this.Controls.Add(this.sprintKanbanPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ProjectExplorer";
            this.Text = "Project Explorer";
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.ProjectGridPanel projectGridPanel1;
        private Controls.SprintGridPanel sprintGridPanel1;
        private Controls.TasksGridPanel tasksGridPanel1;
        private Controls.SprintKanbanPanel sprintKanbanPanel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripButton toolStripButtonKanban;
        private System.Windows.Forms.ToolStripButton toolStripButtonTask;
        private System.Windows.Forms.ToolStripButton toolStripButtonSprint;
        private System.Windows.Forms.ToolStripButton toolStripButtonProject;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButtonGantt;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripButton toolStripButtonTimePlanning;
        private Controls.TaskPlanningPanel taskPlanningPanel1;
    }
}