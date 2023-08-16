namespace InventoryApp
{
    partial class create_account
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(create_account));
            user_input = new TextBox();
            label4 = new Label();
            pw_input = new MaskedTextBox();
            label2 = new Label();
            label1 = new Label();
            repw_input = new MaskedTextBox();
            repw_label = new Label();
            create_account_button = new Button();
            back_button = new Button();
            email_input = new TextBox();
            email_label = new Label();
            error_label = new Label();
            SuspendLayout();
            // 
            // user_input
            // 
            user_input.BackColor = Color.FromArgb(26, 28, 60);
            user_input.BorderStyle = BorderStyle.None;
            user_input.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            user_input.ForeColor = Color.FromArgb(237, 33, 125);
            user_input.Location = new Point(204, 168);
            user_input.Name = "user_input";
            user_input.PlaceholderText = "User Name";
            user_input.Size = new Size(401, 26);
            user_input.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semilight", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.LightCoral;
            label4.Location = new Point(101, 72);
            label4.Name = "label4";
            label4.Size = new Size(452, 65);
            label4.TabIndex = 9;
            label4.Text = "Create New Account";
            // 
            // pw_input
            // 
            pw_input.BackColor = Color.FromArgb(26, 28, 60);
            pw_input.BorderStyle = BorderStyle.None;
            pw_input.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            pw_input.ForeColor = Color.FromArgb(237, 33, 125);
            pw_input.Location = new Point(204, 272);
            pw_input.Name = "pw_input";
            pw_input.PasswordChar = '*';
            pw_input.Size = new Size(401, 26);
            pw_input.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(101, 273);
            label2.Name = "label2";
            label2.Size = new Size(97, 25);
            label2.TabIndex = 8;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(84, 168);
            label1.Name = "label1";
            label1.Size = new Size(109, 25);
            label1.TabIndex = 7;
            label1.Text = "User Name";
            // 
            // repw_input
            // 
            repw_input.BackColor = Color.FromArgb(26, 28, 60);
            repw_input.BorderStyle = BorderStyle.None;
            repw_input.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            repw_input.ForeColor = Color.FromArgb(237, 33, 125);
            repw_input.Location = new Point(204, 323);
            repw_input.Name = "repw_input";
            repw_input.PasswordChar = '*';
            repw_input.Size = new Size(401, 26);
            repw_input.TabIndex = 4;
            // 
            // repw_label
            // 
            repw_label.AutoSize = true;
            repw_label.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            repw_label.ForeColor = Color.White;
            repw_label.Location = new Point(19, 323);
            repw_label.Name = "repw_label";
            repw_label.Size = new Size(179, 25);
            repw_label.TabIndex = 11;
            repw_label.Text = "Re-enter Password";
            // 
            // create_account_button
            // 
            create_account_button.BackColor = Color.FromArgb(86, 95, 240);
            create_account_button.FlatStyle = FlatStyle.Popup;
            create_account_button.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            create_account_button.ForeColor = Color.White;
            create_account_button.Location = new Point(154, 380);
            create_account_button.Name = "create_account_button";
            create_account_button.Size = new Size(298, 32);
            create_account_button.TabIndex = 5;
            create_account_button.Text = "Create Account";
            create_account_button.UseVisualStyleBackColor = false;
            create_account_button.Click += create_account_button_Click;
            // 
            // back_button
            // 
            back_button.BackColor = Color.Transparent;
            back_button.Cursor = Cursors.Hand;
            back_button.FlatAppearance.BorderSize = 0;
            back_button.FlatAppearance.MouseDownBackColor = Color.Transparent;
            back_button.FlatAppearance.MouseOverBackColor = Color.Transparent;
            back_button.FlatStyle = FlatStyle.Flat;
            back_button.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            back_button.ForeColor = Color.White;
            back_button.Image = (Image)resources.GetObject("back_button.Image");
            back_button.ImageAlign = ContentAlignment.MiddleLeft;
            back_button.Location = new Point(21, 19);
            back_button.Name = "back_button";
            back_button.Size = new Size(100, 33);
            back_button.TabIndex = 26;
            back_button.Text = "Sign in";
            back_button.TextAlign = ContentAlignment.MiddleRight;
            back_button.UseVisualStyleBackColor = false;
            back_button.Click += back_button_Click;
            // 
            // email_input
            // 
            email_input.BackColor = Color.FromArgb(26, 28, 60);
            email_input.BorderStyle = BorderStyle.None;
            email_input.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            email_input.ForeColor = Color.FromArgb(237, 33, 125);
            email_input.Location = new Point(204, 221);
            email_input.Name = "email_input";
            email_input.PlaceholderText = "example@domain.com";
            email_input.Size = new Size(401, 26);
            email_input.TabIndex = 2;
            // 
            // email_label
            // 
            email_label.AutoSize = true;
            email_label.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            email_label.ForeColor = Color.White;
            email_label.Location = new Point(134, 221);
            email_label.Name = "email_label";
            email_label.Size = new Size(59, 25);
            email_label.TabIndex = 28;
            email_label.Text = "Email";
            // 
            // error_label
            // 
            error_label.AutoSize = true;
            error_label.BackColor = Color.Transparent;
            error_label.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            error_label.ForeColor = Color.Red;
            error_label.Location = new Point(204, 438);
            error_label.Name = "error_label";
            error_label.Size = new Size(0, 21);
            error_label.TabIndex = 29;
            error_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // create_account
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 28, 60);
            Controls.Add(error_label);
            Controls.Add(email_input);
            Controls.Add(email_label);
            Controls.Add(back_button);
            Controls.Add(create_account_button);
            Controls.Add(repw_input);
            Controls.Add(repw_label);
            Controls.Add(user_input);
            Controls.Add(label4);
            Controls.Add(pw_input);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "create_account";
            Size = new Size(660, 540);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox user_input;
        private Label label4;
        private MaskedTextBox pw_input;
        private Label label2;
        private Label label1;
        private MaskedTextBox repw_input;
        private Label repw_label;
        private Button create_account_button;
        private Button back_button;
        private TextBox email_input;
        private Label email_label;
        private Label error_label;
    }
}
