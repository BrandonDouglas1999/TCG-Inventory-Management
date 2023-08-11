﻿namespace InventoryApp
{
    partial class home_page
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            user_label = new Label();
            logged_user = new Label();
            label2 = new Label();
            label1 = new Label();
            rate_label = new Label();
            date_label = new Label();
            chart2 = new ScottPlot.FormsPlot();
            chart = new ScottPlot.FormsPlot();
            increaseTable = new DataGridView();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)increaseTable).BeginInit();
            SuspendLayout();
            // 
            // user_label
            // 
            user_label.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            user_label.AutoSize = true;
            user_label.Font = new Font("Constantia", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            user_label.Location = new Point(31, 22);
            user_label.Name = "user_label";
            user_label.Size = new Size(57, 23);
            user_label.TabIndex = 1;
            user_label.Text = "User:";
            // 
            // logged_user
            // 
            logged_user.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            logged_user.AutoSize = true;
            logged_user.Font = new Font("Constantia", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            logged_user.Location = new Point(95, 22);
            logged_user.Name = "logged_user";
            logged_user.Size = new Size(61, 23);
            logged_user.TabIndex = 2;
            logged_user.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(970, 51);
            label2.Name = "label2";
            label2.Size = new Size(49, 19);
            label2.TabIndex = 15;
            label2.Text = "Rate:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(764, 51);
            label1.Name = "label1";
            label1.Size = new Size(55, 19);
            label1.TabIndex = 14;
            label1.Text = "Date: ";
            // 
            // rate_label
            // 
            rate_label.AutoSize = true;
            rate_label.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            rate_label.ForeColor = Color.White;
            rate_label.Location = new Point(1019, 51);
            rate_label.Name = "rate_label";
            rate_label.Size = new Size(73, 19);
            rate_label.TabIndex = 13;
            rate_label.Text = "fdsgsdfg";
            // 
            // date_label
            // 
            date_label.AutoSize = true;
            date_label.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            date_label.ForeColor = Color.White;
            date_label.Location = new Point(816, 51);
            date_label.Name = "date_label";
            date_label.Size = new Size(73, 19);
            date_label.TabIndex = 12;
            date_label.Text = "fdsgsdfg";
            // 
            // chart2
            // 
            chart2.ForeColor = SystemColors.Control;
            chart2.Location = new Point(77, 65);
            chart2.Margin = new Padding(4, 3, 4, 3);
            chart2.Name = "chart2";
            chart2.Size = new Size(525, 359);
            chart2.TabIndex = 11;
            // 
            // chart
            // 
            chart.ForeColor = SystemColors.Control;
            chart.Location = new Point(625, 65);
            chart.Margin = new Padding(4, 3, 4, 3);
            chart.Name = "chart";
            chart.Size = new Size(611, 359);
            chart.TabIndex = 10;
            // 
            // increaseTable
            // 
            increaseTable.AllowUserToAddRows = false;
            increaseTable.AllowUserToDeleteRows = false;
            increaseTable.AllowUserToResizeColumns = false;
            increaseTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(239, 239, 249);
            increaseTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            increaseTable.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            increaseTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            increaseTable.BackgroundColor = SystemColors.Control;
            increaseTable.BorderStyle = BorderStyle.None;
            increaseTable.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(47, 76, 100);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            increaseTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            increaseTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            increaseTable.DefaultCellStyle = dataGridViewCellStyle3;
            increaseTable.Location = new Point(95, 430);
            increaseTable.Name = "increaseTable";
            increaseTable.ReadOnly = true;
            increaseTable.RowHeadersVisible = false;
            increaseTable.RowTemplate.Height = 25;
            increaseTable.Size = new Size(1248, 237);
            increaseTable.TabIndex = 16;
            increaseTable.CellContentClick += increaseTable_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Constantia", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(95, 468);
            label3.Name = "label3";
            label3.Size = new Size(241, 23);
            label3.TabIndex = 17;
            label3.Text = "Noticeable Price Changes:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Constantia", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(248, 51);
            label4.Name = "label4";
            label4.Size = new Size(211, 23);
            label4.TabIndex = 18;
            label4.Text = "Exchange Rate History";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Constantia", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(849, 22);
            label5.Name = "label5";
            label5.Size = new Size(170, 23);
            label5.TabIndex = 19;
            label5.Text = "Card Rate History";
            // 
            // home_page
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(increaseTable);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(rate_label);
            Controls.Add(date_label);
            Controls.Add(chart2);
            Controls.Add(chart);
            Controls.Add(logged_user);
            Controls.Add(user_label);
            Name = "home_page";
            Size = new Size(1500, 850);
            ((System.ComponentModel.ISupportInitialize)increaseTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label user_label;
        private Label logged_user;
        private Label label2;
        private Label label1;
        private Label rate_label;
        private Label date_label;
        private ScottPlot.FormsPlot chart2;
        private ScottPlot.FormsPlot chart;
        private DataGridView increaseTable;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
