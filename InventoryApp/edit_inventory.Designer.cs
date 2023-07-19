namespace InventoryApp
{
    partial class edit_inventory
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
            card_art_box = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)card_art_box).BeginInit();
            SuspendLayout();
            // 
            // card_art_box
            // 
            card_art_box.Image = Properties.Resources.question_mark;
            card_art_box.Location = new Point(170, 63);
            card_art_box.Name = "card_art_box";
            card_art_box.Size = new Size(240, 340);
            card_art_box.TabIndex = 0;
            card_art_box.TabStop = false;
            // 
            // edit_inventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(card_art_box);
            Name = "edit_inventory";
            Size = new Size(964, 578);
            ((System.ComponentModel.ISupportInitialize)card_art_box).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox card_art_box;
    }
}
