namespace InventoryApp
{
    partial class sales_report
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
            this.filter_label = new System.Windows.Forms.Label();
            this.time_frame_combo = new System.Windows.Forms.ComboBox();
            this.filter_view = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.filter_view)).BeginInit();
            this.SuspendLayout();
            // 
            // filter_label
            // 
            this.filter_label.AutoSize = true;
            this.filter_label.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.filter_label.Location = new System.Drawing.Point(201, 62);
            this.filter_label.Name = "filter_label";
            this.filter_label.Size = new System.Drawing.Size(63, 30);
            this.filter_label.TabIndex = 0;
            this.filter_label.Text = "Filter";
            // 
            // time_frame_combo
            // 
            this.time_frame_combo.FormattingEnabled = true;
            this.time_frame_combo.Location = new System.Drawing.Point(292, 69);
            this.time_frame_combo.Name = "time_frame_combo";
            this.time_frame_combo.Size = new System.Drawing.Size(121, 23);
            this.time_frame_combo.TabIndex = 1;
            // 
            // filter_view
            // 
            this.filter_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.filter_view.Location = new System.Drawing.Point(98, 156);
            this.filter_view.Name = "filter_view";
            this.filter_view.RowTemplate.Height = 25;
            this.filter_view.Size = new System.Drawing.Size(618, 318);
            this.filter_view.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(430, 69);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.Value = new System.DateTime(2023, 8, 11, 0, 0, 0, 0);
            // 
            // sales_report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.filter_view);
            this.Controls.Add(this.time_frame_combo);
            this.Controls.Add(this.filter_label);
            this.Name = "sales_report";
            this.Size = new System.Drawing.Size(858, 560);
            ((System.ComponentModel.ISupportInitialize)(this.filter_view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label filter_label;
        private ComboBox time_frame_combo;
        private DataGridView filter_view;
        private DateTimePicker dateTimePicker1;
    }
}
