namespace WinFormsLab
{
    partial class Organizer
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.View = new System.Windows.Forms.GroupBox();
            this.groupBoxOperations = new System.Windows.Forms.GroupBox();
            this.listViewTasks = new System.Windows.Forms.ListView();
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Event = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 159F));
            this.tableLayoutPanel2.Controls.Add(this.listViewTasks, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.View, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBoxOperations, 0, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.92243F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.07757F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(520, 614);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // View
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.View, 3);
            this.View.Location = new System.Drawing.Point(3, 3);
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(514, 107);
            this.View.TabIndex = 0;
            this.View.TabStop = false;
            this.View.Text = "groupBoxView";
            // 
            // groupBoxOperations
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.groupBoxOperations, 3);
            this.groupBoxOperations.Location = new System.Drawing.Point(3, 533);
            this.groupBoxOperations.Name = "groupBoxOperations";
            this.groupBoxOperations.Size = new System.Drawing.Size(514, 78);
            this.groupBoxOperations.TabIndex = 1;
            this.groupBoxOperations.TabStop = false;
            this.groupBoxOperations.Text = "Operations";
            // 
            // listViewTasks
            // 
            this.listViewTasks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Date,
            this.Time,
            this.Event});
            this.tableLayoutPanel2.SetColumnSpan(this.listViewTasks, 3);
            this.listViewTasks.Location = new System.Drawing.Point(3, 119);
            this.listViewTasks.Name = "listViewTasks";
            this.listViewTasks.Size = new System.Drawing.Size(514, 408);
            this.listViewTasks.TabIndex = 1;
            this.listViewTasks.UseCompatibleStateImageBehavior = false;
            this.listViewTasks.View = System.Windows.Forms.View.Details;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.Width = 90;
            // 
            // Time
            // 
            this.Time.Text = "Time";
            // 
            // Event
            // 
            this.Event.Text = "Event";
            // 
            // Organizer
            // 
            this.ClientSize = new System.Drawing.Size(544, 638);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "Organizer";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox View;
        private System.Windows.Forms.GroupBox groupBoxOperations;
        private System.Windows.Forms.ListView listViewTasks;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader Time;
        private System.Windows.Forms.ColumnHeader Event;
    }
}