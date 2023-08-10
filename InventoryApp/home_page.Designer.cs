namespace InventoryApp
{
    partial class home_page
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
            user_label = new Label();
            logged_user = new Label();
            SuspendLayout();
            // 
            // user_label
            // 
            user_label.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            user_label.AutoSize = true;
            user_label.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            user_label.Location = new Point(24, 36);
            user_label.Name = "user_label";
            user_label.Size = new Size(58, 25);
            user_label.TabIndex = 1;
            user_label.Text = "User:";
            // 
            // logged_user
            // 
            logged_user.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            logged_user.AutoSize = true;
            logged_user.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            logged_user.Location = new Point(88, 36);
            logged_user.Name = "logged_user";
            logged_user.Size = new Size(65, 25);
            logged_user.TabIndex = 2;
            logged_user.Text = "label1";
            // 
            // home_page
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(logged_user);
            Controls.Add(user_label);
            Name = "home_page";
            Size = new Size(835, 576);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label user_label;
        private Label logged_user;
    }
}
