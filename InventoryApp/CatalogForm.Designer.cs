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
            this.prev_catalog = new System.Windows.Forms.Button();
            this.next_catalog = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.catalog_view)).BeginInit();
            this.SuspendLayout();
            // 
            // catalog_view
            // 
            this.catalog_view.AllowUserToAddRows = false;
            this.catalog_view.AllowUserToDeleteRows = false;
            this.catalog_view.AllowUserToResizeColumns = false;
            this.catalog_view.AllowUserToResizeRows = false;
            this.catalog_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.catalog_view.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.catalog_view.BackgroundColor = System.Drawing.Color.White;
            this.catalog_view.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.catalog_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.catalog_view.GridColor = System.Drawing.SystemColors.Control;
            this.catalog_view.Location = new System.Drawing.Point(12, 77);
            this.catalog_view.Name = "catalog_view";
            this.catalog_view.RowHeadersVisible = false;
            this.catalog_view.RowTemplate.Height = 25;
            this.catalog_view.Size = new System.Drawing.Size(1080, 528);
            this.catalog_view.TabIndex = 0;
            this.catalog_view.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.catalog_view_CellContentClick);
            // 
            // prev_catalog
            // 
            this.prev_catalog.Location = new System.Drawing.Point(485, 622);
            this.prev_catalog.Name = "prev_catalog";
            this.prev_catalog.Size = new System.Drawing.Size(99, 23);
            this.prev_catalog.TabIndex = 1;
            this.prev_catalog.Text = "Previous Page";
            this.prev_catalog.UseVisualStyleBackColor = true;
            this.prev_catalog.Click += new System.EventHandler(this.prev_catalog_Click);
            // 
            // next_catalog
            // 
            this.next_catalog.Location = new System.Drawing.Point(602, 622);
            this.next_catalog.Name = "next_catalog";
            this.next_catalog.Size = new System.Drawing.Size(99, 23);
            this.next_catalog.TabIndex = 2;
            this.next_catalog.Text = "Next Page";
            this.next_catalog.UseVisualStyleBackColor = true;
            this.next_catalog.Click += new System.EventHandler(this.next_catalog_Click);
            // 
            // CatalogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 671);
            this.Controls.Add(this.next_catalog);
            this.Controls.Add(this.prev_catalog);
            this.Controls.Add(this.catalog_view);
            this.Name = "CatalogForm";
            this.Text = "CatalogForm";
            this.Load += new System.EventHandler(this.CatalogForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.catalog_view)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView catalog_view;
        private Button prev_catalog;
        private Button next_catalog;
    }
}