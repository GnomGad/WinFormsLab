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
        private void InitializeComponent( string textFromStart)
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.View = new System.Windows.Forms.GroupBox();
            this.Operations = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 139F));
            this.tableLayoutPanel1.Controls.Add(this.Operations, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.View, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.60377F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.39622F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(477, 619);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // View
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.View, 3);
            this.View.Location = new System.Drawing.Point(3, 3);
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(445, 77);
            this.View.TabIndex = 0;
            this.View.TabStop = false;
            this.View.Text = "groupBoxView";
            // 
            // Operations
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.Operations, 3);
            this.Operations.Location = new System.Drawing.Point(3, 533);
            this.Operations.Name = "Operations";
            this.Operations.Size = new System.Drawing.Size(445, 77);
            this.Operations.TabIndex = 1;
            this.Operations.TabStop = false;
            this.Operations.Text = "groupBoxOperations";
            // 
            // Organizer
            // 
            this.ClientSize = new System.Drawing.Size(501, 643);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Organizer";
            this.Load += new System.EventHandler(this.Organizer_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox Operations;
        private System.Windows.Forms.GroupBox View;
    }
}