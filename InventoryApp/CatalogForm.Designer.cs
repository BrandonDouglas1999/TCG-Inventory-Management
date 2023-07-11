namespace InventoryApp
{
    partial class CatalogForm
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
            this.catalog_view = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.catalog_view)).BeginInit();
            this.SuspendLayout();
            // 
            // catalog_view
            // 
            this.catalog_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.catalog_view.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.catalog_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.catalog_view.Location = new System.Drawing.Point(12, 33);
            this.catalog_view.Name = "catalog_view";
            this.catalog_view.RowTemplate.Height = 25;
            this.catalog_view.Size = new System.Drawing.Size(1049, 626);
            this.catalog_view.TabIndex = 0;
            this.catalog_view.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.catalog_view_CellContentClick);
            // 
            // CatalogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 671);
            this.Controls.Add(this.catalog_view);
            this.Name = "CatalogForm";
            this.Text = "CatalogForm";
            this.Load += new System.EventHandler(this.CatalogForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.catalog_view)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView catalog_view;
    }
}