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
            this.card_image = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.card_image)).BeginInit();
            this.SuspendLayout();
            // 
            // card_image
            // 
            this.card_image.Dock = System.Windows.Forms.DockStyle.Fill;
            this.card_image.Location = new System.Drawing.Point(0, 0);
            this.card_image.Name = "card_image";
            this.card_image.Size = new System.Drawing.Size(355, 450);
            this.card_image.TabIndex = 0;
            this.card_image.TabStop = false;
            // 
            // Full_ImageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 450);
            this.Controls.Add(this.card_image);
            this.Name = "Full_ImageForm";
            this.Text = "Full_ImageForm";
            ((System.ComponentModel.ISupportInitialize)(this.card_image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox card_image;
    }
}