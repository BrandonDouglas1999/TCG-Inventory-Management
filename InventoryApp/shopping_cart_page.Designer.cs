namespace InventoryApp
{
    partial class shopping_cart_page
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
            shopping_cart_view = new DataGridView();
            clear_button = new Button();
            ((System.ComponentModel.ISupportInitialize)shopping_cart_view).BeginInit();
            SuspendLayout();
            // 
            // shopping_cart_view
            // 
            shopping_cart_view.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            shopping_cart_view.Location = new Point(86, 155);
            shopping_cart_view.Margin = new Padding(3, 4, 3, 4);
            shopping_cart_view.Name = "shopping_cart_view";
            shopping_cart_view.RowHeadersWidth = 51;
            shopping_cart_view.RowTemplate.Height = 25;
            shopping_cart_view.Size = new Size(1280, 720);
            shopping_cart_view.TabIndex = 0;
            // 
            // clear_button
            // 
            clear_button.Location = new Point(664, 56);
            clear_button.Margin = new Padding(3, 4, 3, 4);
            clear_button.Name = "clear_button";
            clear_button.Size = new Size(86, 31);
            clear_button.TabIndex = 1;
            clear_button.Text = "Clear Cart";
            clear_button.UseVisualStyleBackColor = true;
            clear_button.Click += clear_button_Click;
            // 
            // shopping_cart_page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(clear_button);
            Controls.Add(shopping_cart_view);
            Margin = new Padding(3, 4, 3, 4);
            Name = "shopping_cart_page";
            Size = new Size(800, 680);
            ((System.ComponentModel.ISupportInitialize)shopping_cart_view).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView shopping_cart_view;
        private Button clear_button;
    }
}
