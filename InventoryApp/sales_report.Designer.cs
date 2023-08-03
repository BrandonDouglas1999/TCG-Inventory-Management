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
            filter_label = new Label();
            time_frame_combo = new ComboBox();
            filter_view = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)filter_view).BeginInit();
            SuspendLayout();
            // 
            // filter_label
            // 
            filter_label.AutoSize = true;
            filter_label.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            filter_label.Location = new Point(201, 62);
            filter_label.Name = "filter_label";
            filter_label.Size = new Size(63, 30);
            filter_label.TabIndex = 0;
            filter_label.Text = "Filter";
            // 
            // time_frame_combo
            // 
            time_frame_combo.FormattingEnabled = true;
            time_frame_combo.Location = new Point(292, 69);
            time_frame_combo.Name = "time_frame_combo";
            time_frame_combo.Size = new Size(121, 23);
            time_frame_combo.TabIndex = 1;
            // 
            // filter_view
            // 
            filter_view.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            filter_view.Location = new Point(98, 156);
            filter_view.Name = "filter_view";
            filter_view.RowTemplate.Height = 25;
            filter_view.Size = new Size(618, 318);
            filter_view.TabIndex = 2;
            // 
            // sales_report
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(filter_view);
            Controls.Add(time_frame_combo);
            Controls.Add(filter_label);
            Name = "sales_report";
            Size = new Size(858, 560);
            ((System.ComponentModel.ISupportInitialize)filter_view).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label filter_label;
        private ComboBox time_frame_combo;
        private DataGridView filter_view;
    }
}
