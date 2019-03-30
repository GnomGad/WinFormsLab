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
            this.listViewTasks = new System.Windows.Forms.ListView();
            this.HeaderDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HeaderTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HeaderEvent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxView = new System.Windows.Forms.GroupBox();
            this.comboBoxTask = new System.Windows.Forms.ComboBox();
            this.radioButtonAllEvents = new System.Windows.Forms.RadioButton();
            this.radioButtonAllByCategory = new System.Windows.Forms.RadioButton();
            this.groupBoxOperations = new System.Windows.Forms.GroupBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonFind = new System.Windows.Forms.Button();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBoxView.SuspendLayout();
            this.groupBoxOperations.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 159F));
            this.tableLayoutPanel2.Controls.Add(this.listViewTasks, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.groupBoxView, 0, 0);
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
            // listViewTasks
            // 
            this.listViewTasks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.HeaderDate,
            this.HeaderTime,
            this.HeaderEvent});
            this.tableLayoutPanel2.SetColumnSpan(this.listViewTasks, 3);
            this.listViewTasks.FullRowSelect = true;
            this.listViewTasks.GridLines = true;
            this.listViewTasks.Location = new System.Drawing.Point(3, 119);
            this.listViewTasks.Name = "listViewTasks";
            this.listViewTasks.ShowItemToolTips = true;
            this.listViewTasks.Size = new System.Drawing.Size(514, 408);
            this.listViewTasks.TabIndex = 1;
            this.listViewTasks.UseCompatibleStateImageBehavior = false;
            this.listViewTasks.View = System.Windows.Forms.View.Details;
            this.listViewTasks.ItemActivate += new System.EventHandler(this.listViewTasks_ItemActivate);
            this.listViewTasks.Click += new System.EventHandler(this.listViewTasks_Click);
            // 
            // HeaderDate
            // 
            this.HeaderDate.Text = "Date";
            this.HeaderDate.Width = 99;
            // 
            // HeaderTime
            // 
            this.HeaderTime.Text = "Time";
            this.HeaderTime.Width = 70;
            // 
            // HeaderEvent
            // 
            this.HeaderEvent.Text = "Event";
            this.HeaderEvent.Width = 335;
            // 
            // groupBoxView
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.groupBoxView, 3);
            this.groupBoxView.Controls.Add(this.comboBoxTask);
            this.groupBoxView.Controls.Add(this.radioButtonAllEvents);
            this.groupBoxView.Controls.Add(this.radioButtonAllByCategory);
            this.groupBoxView.Location = new System.Drawing.Point(3, 3);
            this.groupBoxView.Name = "groupBoxView";
            this.groupBoxView.Size = new System.Drawing.Size(514, 107);
            this.groupBoxView.TabIndex = 0;
            this.groupBoxView.TabStop = false;
            this.groupBoxView.Text = "View";
            // 
            // comboBoxTask
            // 
            this.comboBoxTask.FormattingEnabled = true;
            this.comboBoxTask.Location = new System.Drawing.Point(244, 19);
            this.comboBoxTask.Name = "comboBoxTask";
            this.comboBoxTask.Size = new System.Drawing.Size(264, 21);
            this.comboBoxTask.TabIndex = 2;
            this.comboBoxTask.SelectedIndexChanged += new System.EventHandler(this.comboBoxTask_SelectedIndexChanged);
            // 
            // radioButtonAllEvents
            // 
            this.radioButtonAllEvents.AutoSize = true;
            this.radioButtonAllEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonAllEvents.ForeColor = System.Drawing.Color.Teal;
            this.radioButtonAllEvents.Location = new System.Drawing.Point(15, 58);
            this.radioButtonAllEvents.Name = "radioButtonAllEvents";
            this.radioButtonAllEvents.Size = new System.Drawing.Size(109, 28);
            this.radioButtonAllEvents.TabIndex = 1;
            this.radioButtonAllEvents.TabStop = true;
            this.radioButtonAllEvents.Text = "All events";
            this.radioButtonAllEvents.UseVisualStyleBackColor = true;
            this.radioButtonAllEvents.CheckedChanged += new System.EventHandler(this.radioButtonAllEvents_CheckedChanged);
            // 
            // radioButtonAllByCategory
            // 
            this.radioButtonAllByCategory.AutoSize = true;
            this.radioButtonAllByCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonAllByCategory.ForeColor = System.Drawing.Color.Teal;
            this.radioButtonAllByCategory.Location = new System.Drawing.Point(14, 29);
            this.radioButtonAllByCategory.Name = "radioButtonAllByCategory";
            this.radioButtonAllByCategory.Size = new System.Drawing.Size(151, 28);
            this.radioButtonAllByCategory.TabIndex = 0;
            this.radioButtonAllByCategory.TabStop = true;
            this.radioButtonAllByCategory.Text = "All by category";
            this.radioButtonAllByCategory.UseVisualStyleBackColor = true;
            this.radioButtonAllByCategory.CheckedChanged += new System.EventHandler(this.radioButtonAllByCategory_CheckedChanged);
            // 
            // groupBoxOperations
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.groupBoxOperations, 3);
            this.groupBoxOperations.Controls.Add(this.buttonAdd);
            this.groupBoxOperations.Controls.Add(this.buttonFind);
            this.groupBoxOperations.Controls.Add(this.buttonFilter);
            this.groupBoxOperations.Location = new System.Drawing.Point(3, 533);
            this.groupBoxOperations.Name = "groupBoxOperations";
            this.groupBoxOperations.Size = new System.Drawing.Size(514, 78);
            this.groupBoxOperations.TabIndex = 1;
            this.groupBoxOperations.TabStop = false;
            this.groupBoxOperations.Text = "Operations";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(362, 23);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(146, 45);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(185, 23);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(146, 45);
            this.buttonFind.TabIndex = 1;
            this.buttonFind.Text = "Find";
            this.buttonFind.UseVisualStyleBackColor = true;
            // 
            // buttonFilter
            // 
            this.buttonFilter.Location = new System.Drawing.Point(6, 23);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(146, 45);
            this.buttonFilter.TabIndex = 0;
            this.buttonFilter.Text = "Filter";
            this.buttonFilter.UseVisualStyleBackColor = true;
            // 
            // Organizer
            // 
            this.ClientSize = new System.Drawing.Size(544, 638);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "Organizer";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBoxView.ResumeLayout(false);
            this.groupBoxView.PerformLayout();
            this.groupBoxOperations.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBoxView;
        private System.Windows.Forms.GroupBox groupBoxOperations;
        private System.Windows.Forms.ListView listViewTasks;
        private System.Windows.Forms.ColumnHeader HeaderDate;
        private System.Windows.Forms.ColumnHeader HeaderTime;
        private System.Windows.Forms.ColumnHeader HeaderEvent;
        private System.Windows.Forms.ComboBox comboBoxTask;
        private System.Windows.Forms.RadioButton radioButtonAllEvents;
        private System.Windows.Forms.RadioButton radioButtonAllByCategory;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonFind;
    }
}