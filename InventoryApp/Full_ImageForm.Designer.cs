namespace InventoryApp
{
    partial class Full_ImageForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.chart = new ScottPlot.FormsPlot();
            this.increaseTable = new System.Windows.Forms.DataGridView();
            this.chart2 = new ScottPlot.FormsPlot();
            this.date_label = new System.Windows.Forms.Label();
            this.rate_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.increaseTable)).BeginInit();
            this.SuspendLayout();
            // 
            // chart
            // 
            this.chart.Location = new System.Drawing.Point(13, 12);
            this.chart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chart.Name = "chart";
            this.chart.Size = new System.Drawing.Size(637, 445);
            this.chart.TabIndex = 0;
            // 
            // increaseTable
            // 
            this.increaseTable.AllowUserToAddRows = false;
            this.increaseTable.AllowUserToDeleteRows = false;
            this.increaseTable.AllowUserToResizeColumns = false;
            this.increaseTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.increaseTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.increaseTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.increaseTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.increaseTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.increaseTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.increaseTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(76)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.increaseTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.increaseTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.increaseTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.increaseTable.Location = new System.Drawing.Point(11, 542);
            this.increaseTable.Name = "increaseTable";
            this.increaseTable.ReadOnly = true;
            this.increaseTable.RowHeadersVisible = false;
            this.increaseTable.RowTemplate.Height = 25;
            this.increaseTable.Size = new System.Drawing.Size(1200, 276);
            this.increaseTable.TabIndex = 4;
            this.increaseTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.increaseTable_CellContentClick);
            // 
            // chart2
            // 
            this.chart2.Location = new System.Drawing.Point(714, 81);
            this.chart2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chart2.Name = "chart2";
            this.chart2.Size = new System.Drawing.Size(497, 339);
            this.chart2.TabIndex = 5;
            this.chart2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.currency_MouseMove);
            // 
            // date_label
            // 
            this.date_label.AutoSize = true;
            this.date_label.Location = new System.Drawing.Point(804, 63);
            this.date_label.Name = "date_label";
            this.date_label.Size = new System.Drawing.Size(0, 15);
            this.date_label.TabIndex = 6;
            // 
            // rate_label
            // 
            this.rate_label.AutoSize = true;
            this.rate_label.Location = new System.Drawing.Point(940, 63);
            this.rate_label.Name = "rate_label";
            this.rate_label.Size = new System.Drawing.Size(0, 15);
            this.rate_label.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(761, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Date: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(904, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Rate:";
            // 
            // Full_ImageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 845);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rate_label);
            this.Controls.Add(this.date_label);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.increaseTable);
            this.Controls.Add(this.chart);
            this.Name = "Full_ImageForm";
            this.Text = "Full_ImageForm";
            ((System.ComponentModel.ISupportInitialize)(this.increaseTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ScottPlot.FormsPlot chart;
        private DataGridView increaseTable;
        private ScottPlot.FormsPlot chart2;
        private Label date_label;
        private Label rate_label;
        private Label label1;
        private Label label2;
    }
}