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
            this.update_card = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // update_card
            // 
            this.update_card.Location = new System.Drawing.Point(256, 263);
            this.update_card.Name = "update_card";
            this.update_card.Size = new System.Drawing.Size(191, 62);
            this.update_card.TabIndex = 0;
            this.update_card.Text = "update";
            this.update_card.UseVisualStyleBackColor = true;
            this.update_card.Click += new System.EventHandler(this.update_card_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(279, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // Full_ImageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 845);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.update_card);
            this.Name = "Full_ImageForm";
            this.Text = "Full_ImageForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button update_card;
        private Label label1;
    }
}