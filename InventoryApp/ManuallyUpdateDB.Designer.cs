namespace InventoryApp
{
    partial class ManuallyUpdateDB
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
            this.update_card.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.update_card.Location = new System.Drawing.Point(73, 165);
            this.update_card.Name = "update_card";
            this.update_card.Size = new System.Drawing.Size(191, 62);
            this.update_card.TabIndex = 0;
            this.update_card.Text = "Update Database";
            this.update_card.UseVisualStyleBackColor = true;
            this.update_card.Click += new System.EventHandler(this.update_card_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(54, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Database has not been update";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ManuallyUpdateDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 239);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.update_card);
            this.Name = "ManuallyUpdateDB";
            this.Text = "Database Update";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button update_card;
        private Label label1;
    }
}