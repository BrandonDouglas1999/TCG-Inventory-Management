namespace InventoryApp
{
    partial class catalog
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
            this.catalog_panel = new System.Windows.Forms.Panel();
            this.catalog_view = new System.Windows.Forms.DataGridView();
            this.catalog_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.catalog_view)).BeginInit();
            this.SuspendLayout();
            // 
            // catalog_panel
            // 
            this.catalog_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.catalog_panel.Controls.Add(this.catalog_view);
            this.catalog_panel.Location = new System.Drawing.Point(7, 7);
            this.catalog_panel.Name = "catalog_panel";
            this.catalog_panel.Size = new System.Drawing.Size(1270, 710);
            this.catalog_panel.TabIndex = 0;
            // 
            // catalog_view
            // 
            this.catalog_view.AllowUserToAddRows = false;
            this.catalog_view.AllowUserToDeleteRows = false;
            this.catalog_view.AllowUserToResizeColumns = false;
            this.catalog_view.AllowUserToResizeRows = false;
            this.catalog_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.catalog_view.Location = new System.Drawing.Point(3, 69);
            this.catalog_view.Name = "catalog_view";
            this.catalog_view.RowTemplate.Height = 25;
            this.catalog_view.Size = new System.Drawing.Size(1068, 570);
            this.catalog_view.TabIndex = 0;
            // 
            // catalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.catalog_panel);
            this.Name = "catalog";
            this.Size = new System.Drawing.Size(1280, 720);
            this.catalog_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.catalog_view)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel catalog_panel;
        private DataGridView catalog_view;
    }
}
