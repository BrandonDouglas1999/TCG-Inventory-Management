namespace InventoryApp
{
    partial class add_cards
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
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            card_qnty = new NumericUpDown();
            label9 = new Label();
            label8 = new Label();
            api_price = new TextBox();
            api_ctype = new TextBox();
            s_price = new TextBox();
            label6 = new Label();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            api_crace = new TextBox();
            rare_label = new Label();
            api_rare = new TextBox();
            image_url = new TextBox();
            api_setname = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            api_setcode = new TextBox();
            api_id = new TextBox();
            api_cn = new TextBox();
            cn_label = new Label();
            card_gridview = new DataGridView();
            srch_option = new ComboBox();
            set_gridview = new DataGridView();
            add_bttn = new Button();
            rtv_card = new Button();
            card_srch = new TextBox();
            label23 = new Label();
            panel2 = new Panel();
            card_input_vals_panel = new Panel();
            label13 = new Label();
            panel1 = new Panel();
            label14 = new Label();
            label12 = new Label();
            panel3 = new Panel();
            label21 = new Label();
            panel4 = new Panel();
            label10 = new Label();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)card_qnty).BeginInit();
            ((System.ComponentModel.ISupportInitialize)card_gridview).BeginInit();
            ((System.ComponentModel.ISupportInitialize)set_gridview).BeginInit();
            panel2.SuspendLayout();
            card_input_vals_panel.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // card_qnty
            // 
            card_qnty.Location = new Point(110, 47);
            card_qnty.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            card_qnty.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            card_qnty.Name = "card_qnty";
            card_qnty.Size = new Size(100, 23);
            card_qnty.TabIndex = 62;
            card_qnty.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Constantia", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(795, 301);
            label9.Name = "label9";
            label9.Size = new Size(205, 23);
            label9.TabIndex = 58;
            label9.Text = "Selected Card Details:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ControlDark;
            label8.Location = new Point(20, 130);
            label8.Name = "label8";
            label8.Size = new Size(102, 21);
            label8.TabIndex = 55;
            label8.Text = "Market Price";
            // 
            // api_price
            // 
            api_price.Cursor = Cursors.No;
            api_price.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            api_price.Location = new Point(128, 128);
            api_price.Name = "api_price";
            api_price.ReadOnly = true;
            api_price.Size = new Size(100, 25);
            api_price.TabIndex = 54;
            // 
            // api_ctype
            // 
            api_ctype.Cursor = Cursors.No;
            api_ctype.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            api_ctype.Location = new Point(127, 124);
            api_ctype.Name = "api_ctype";
            api_ctype.ReadOnly = true;
            api_ctype.Size = new Size(300, 25);
            api_ctype.TabIndex = 51;
            // 
            // s_price
            // 
            s_price.Location = new Point(110, 9);
            s_price.Name = "s_price";
            s_price.PlaceholderText = "0.00";
            s_price.Size = new Size(100, 23);
            s_price.TabIndex = 41;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlDark;
            label6.Location = new Point(38, 124);
            label6.Name = "label6";
            label6.Size = new Size(83, 21);
            label6.TabIndex = 50;
            label6.Text = "Card Type";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(10, 7);
            label4.Name = "label4";
            label4.Size = new Size(94, 21);
            label4.TabIndex = 42;
            label4.Text = "Store Price:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlDark;
            label5.Location = new Point(38, 86);
            label5.Name = "label5";
            label5.Size = new Size(83, 21);
            label5.TabIndex = 49;
            label5.Text = "Card Race";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(15, 44);
            label7.Name = "label7";
            label7.Size = new Size(76, 21);
            label7.TabIndex = 53;
            label7.Text = "Quantity:";
            // 
            // api_crace
            // 
            api_crace.Cursor = Cursors.No;
            api_crace.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            api_crace.Location = new Point(127, 86);
            api_crace.Name = "api_crace";
            api_crace.ReadOnly = true;
            api_crace.Size = new Size(100, 25);
            api_crace.TabIndex = 48;
            // 
            // rare_label
            // 
            rare_label.AutoSize = true;
            rare_label.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            rare_label.ForeColor = SystemColors.ControlDark;
            rare_label.Location = new Point(70, 95);
            rare_label.Name = "rare_label";
            rare_label.Size = new Size(52, 21);
            rare_label.TabIndex = 47;
            rare_label.Text = "Rarity";
            // 
            // api_rare
            // 
            api_rare.Cursor = Cursors.No;
            api_rare.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            api_rare.Location = new Point(128, 93);
            api_rare.Name = "api_rare";
            api_rare.ReadOnly = true;
            api_rare.Size = new Size(100, 25);
            api_rare.TabIndex = 46;
            // 
            // image_url
            // 
            image_url.Location = new Point(253, 93);
            image_url.Name = "image_url";
            image_url.ReadOnly = true;
            image_url.Size = new Size(87, 23);
            image_url.TabIndex = 43;
            image_url.Visible = false;
            // 
            // api_setname
            // 
            api_setname.Cursor = Cursors.No;
            api_setname.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            api_setname.Location = new Point(128, 15);
            api_setname.Name = "api_setname";
            api_setname.ReadOnly = true;
            api_setname.Size = new Size(300, 25);
            api_setname.TabIndex = 40;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlDark;
            label3.Location = new Point(41, 17);
            label3.Name = "label3";
            label3.Size = new Size(81, 21);
            label3.TabIndex = 39;
            label3.Text = "Set Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlDark;
            label2.Location = new Point(45, 53);
            label2.Name = "label2";
            label2.Size = new Size(77, 21);
            label2.TabIndex = 38;
            label2.Text = "Set Code";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlDark;
            label1.Location = new Point(57, 48);
            label1.Name = "label1";
            label1.Size = new Size(64, 21);
            label1.TabIndex = 37;
            label1.Text = "Card ID";
            // 
            // api_setcode
            // 
            api_setcode.Cursor = Cursors.No;
            api_setcode.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            api_setcode.Location = new Point(128, 53);
            api_setcode.Name = "api_setcode";
            api_setcode.ReadOnly = true;
            api_setcode.Size = new Size(100, 25);
            api_setcode.TabIndex = 36;
            // 
            // api_id
            // 
            api_id.Cursor = Cursors.No;
            api_id.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            api_id.Location = new Point(127, 48);
            api_id.Name = "api_id";
            api_id.ReadOnly = true;
            api_id.Size = new Size(100, 25);
            api_id.TabIndex = 35;
            // 
            // api_cn
            // 
            api_cn.Cursor = Cursors.No;
            api_cn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            api_cn.Location = new Point(127, 10);
            api_cn.Name = "api_cn";
            api_cn.ReadOnly = true;
            api_cn.Size = new Size(300, 25);
            api_cn.TabIndex = 32;
            // 
            // cn_label
            // 
            cn_label.AutoSize = true;
            cn_label.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cn_label.ForeColor = SystemColors.ControlDark;
            cn_label.Location = new Point(30, 13);
            cn_label.Name = "cn_label";
            cn_label.Size = new Size(91, 21);
            cn_label.TabIndex = 31;
            cn_label.Text = "Card Name";
            // 
            // card_gridview
            // 
            card_gridview.AllowUserToAddRows = false;
            card_gridview.AllowUserToDeleteRows = false;
            card_gridview.AllowUserToResizeColumns = false;
            card_gridview.AllowUserToResizeRows = false;
            card_gridview.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            card_gridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            card_gridview.BackgroundColor = Color.WhiteSmoke;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.Control;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            card_gridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            card_gridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            card_gridview.EnableHeadersVisualStyles = false;
            card_gridview.GridColor = SystemColors.ActiveCaption;
            card_gridview.Location = new Point(49, 342);
            card_gridview.MultiSelect = false;
            card_gridview.Name = "card_gridview";
            card_gridview.ReadOnly = true;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = SystemColors.Control;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            card_gridview.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            card_gridview.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            card_gridview.RowTemplate.Height = 25;
            card_gridview.Size = new Size(698, 177);
            card_gridview.TabIndex = 57;
            card_gridview.CellClick += card_view_CellContentClick;
            // 
            // srch_option
            // 
            srch_option.Cursor = Cursors.Hand;
            srch_option.DropDownStyle = ComboBoxStyle.DropDownList;
            srch_option.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            srch_option.FormattingEnabled = true;
            srch_option.Items.AddRange(new object[] { "Card Name", "Card ID", "Set Name" });
            srch_option.Location = new Point(16, 27);
            srch_option.Name = "srch_option";
            srch_option.Size = new Size(121, 29);
            srch_option.TabIndex = 56;
            srch_option.SelectedIndexChanged += srch_option_SelectedIndexChanged;
            // 
            // set_gridview
            // 
            set_gridview.AllowUserToAddRows = false;
            set_gridview.AllowUserToDeleteRows = false;
            set_gridview.AllowUserToResizeColumns = false;
            set_gridview.AllowUserToResizeRows = false;
            set_gridview.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            set_gridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            set_gridview.BackgroundColor = Color.WhiteSmoke;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = SystemColors.Control;
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            set_gridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            set_gridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            set_gridview.EnableHeadersVisualStyles = false;
            set_gridview.Location = new Point(49, 588);
            set_gridview.MultiSelect = false;
            set_gridview.Name = "set_gridview";
            set_gridview.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = SystemColors.Control;
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            set_gridview.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            set_gridview.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            set_gridview.RowTemplate.Height = 25;
            set_gridview.Size = new Size(698, 179);
            set_gridview.TabIndex = 45;
            set_gridview.CellClick += api_gridview_CellContentClick;
            // 
            // add_bttn
            // 
            add_bttn.BackColor = Color.FromArgb(50, 55, 143);
            add_bttn.FlatStyle = FlatStyle.Popup;
            add_bttn.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            add_bttn.ForeColor = Color.White;
            add_bttn.ImageAlign = ContentAlignment.BottomCenter;
            add_bttn.Location = new Point(252, 14);
            add_bttn.Name = "add_bttn";
            add_bttn.Size = new Size(247, 43);
            add_bttn.TabIndex = 44;
            add_bttn.Text = "Add To Inventory";
            add_bttn.UseVisualStyleBackColor = false;
            add_bttn.Click += add_bttn_Click;
            // 
            // rtv_card
            // 
            rtv_card.BackColor = Color.FromArgb(50, 55, 143);
            rtv_card.Cursor = Cursors.Hand;
            rtv_card.FlatStyle = FlatStyle.Popup;
            rtv_card.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            rtv_card.ForeColor = Color.White;
            rtv_card.Location = new Point(386, 28);
            rtv_card.Name = "rtv_card";
            rtv_card.Size = new Size(130, 29);
            rtv_card.TabIndex = 34;
            rtv_card.Text = "Search";
            rtv_card.UseVisualStyleBackColor = false;
            rtv_card.Click += rtv_card_Click;
            // 
            // card_srch
            // 
            card_srch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            card_srch.Location = new Point(153, 27);
            card_srch.Name = "card_srch";
            card_srch.PlaceholderText = "Eg. Dark Magician Girl";
            card_srch.Size = new Size(210, 29);
            card_srch.TabIndex = 33;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Sylfaen", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label23.ForeColor = Color.White;
            label23.Location = new Point(17, 22);
            label23.Name = "label23";
            label23.Size = new Size(224, 25);
            label23.TabIndex = 1;
            label23.Text = "Add Cards to Inventory";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDark;
            panel2.Controls.Add(label23);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1500, 63);
            panel2.TabIndex = 63;
            // 
            // card_input_vals_panel
            // 
            card_input_vals_panel.BackColor = Color.White;
            card_input_vals_panel.BorderStyle = BorderStyle.Fixed3D;
            card_input_vals_panel.Controls.Add(srch_option);
            card_input_vals_panel.Controls.Add(rtv_card);
            card_input_vals_panel.Controls.Add(card_srch);
            card_input_vals_panel.Location = new Point(49, 135);
            card_input_vals_panel.Name = "card_input_vals_panel";
            card_input_vals_panel.Size = new Size(540, 86);
            card_input_vals_panel.TabIndex = 64;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Constantia", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(49, 93);
            label13.Name = "label13";
            label13.Size = new Size(139, 23);
            label13.TabIndex = 65;
            label13.Text = "1. Card Search:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(api_id);
            panel1.Controls.Add(api_ctype);
            panel1.Controls.Add(api_cn);
            panel1.Controls.Add(api_crace);
            panel1.Controls.Add(cn_label);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(795, 341);
            panel1.Name = "panel1";
            panel1.Size = new Size(558, 177);
            panel1.TabIndex = 66;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Constantia", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(49, 301);
            label14.Name = "label14";
            label14.Size = new Size(207, 23);
            label14.TabIndex = 67;
            label14.Text = "2. Select Card Version:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Constantia", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(49, 553);
            label12.Name = "label12";
            label12.Size = new Size(176, 23);
            label12.TabIndex = 68;
            label12.Text = "3. Select Card Info:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label11);
            panel3.Controls.Add(api_setname);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(rare_label);
            panel3.Controls.Add(api_price);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(api_rare);
            panel3.Controls.Add(api_setcode);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(image_url);
            panel3.Location = new Point(795, 588);
            panel3.Name = "panel3";
            panel3.Size = new Size(558, 179);
            panel3.TabIndex = 69;
            // 
            // label21
            // 
            label21.BorderStyle = BorderStyle.Fixed3D;
            label21.Location = new Point(194, 262);
            label21.Name = "label21";
            label21.Size = new Size(1000, 2);
            label21.TabIndex = 70;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(s_price);
            panel4.Controls.Add(card_qnty);
            panel4.Controls.Add(add_bttn);
            panel4.Location = new Point(795, 135);
            panel4.Name = "panel4";
            panel4.Size = new Size(558, 86);
            panel4.TabIndex = 71;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Constantia", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(795, 93);
            label10.Name = "label10";
            label10.Size = new Size(174, 23);
            label10.TabIndex = 72;
            label10.Text = "4. Product Details:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.Black;
            label11.Location = new Point(234, 128);
            label11.Name = "label11";
            label11.Size = new Size(283, 30);
            label11.TabIndex = 56;
            label11.Text = "*Market Price displayed is after converting from USD\r\n  to CAD";
            // 
            // add_cards
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(label10);
            Controls.Add(panel4);
            Controls.Add(label21);
            Controls.Add(panel3);
            Controls.Add(label9);
            Controls.Add(label12);
            Controls.Add(label14);
            Controls.Add(panel1);
            Controls.Add(label13);
            Controls.Add(card_input_vals_panel);
            Controls.Add(panel2);
            Controls.Add(set_gridview);
            Controls.Add(card_gridview);
            Name = "add_cards";
            Size = new Size(1500, 850);
            ((System.ComponentModel.ISupportInitialize)card_qnty).EndInit();
            ((System.ComponentModel.ISupportInitialize)card_gridview).EndInit();
            ((System.ComponentModel.ISupportInitialize)set_gridview).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            card_input_vals_panel.ResumeLayout(false);
            card_input_vals_panel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label9;
        private DataGridView card_gridview;
        private ComboBox srch_option;
        private Label label8;
        private TextBox api_price;
        private Label label7;
        private NumericUpDown card_qnty;
        private TextBox api_ctype;
        private Label label6;
        private Label label5;
        private TextBox api_crace;
        private Label rare_label;
        private TextBox api_rare;
        private DataGridView set_gridview;
        private Button add_bttn;
        private TextBox image_url;
        private Label label4;
        private TextBox s_price;
        private TextBox api_setname;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox api_setcode;
        private TextBox api_id;
        private Button rtv_card;
        private TextBox card_srch;
        private TextBox api_cn;
        private Label cn_label;
        private NumericUpDown numericUpDown1;
        private Panel panel2;
        private Label label23;
        private Panel card_input_vals_panel;
        private Label label13;
        private Panel panel1;
        private Label label14;
        private Label label12;
        private Panel panel3;
        private Label label21;
        private Panel panel4;
        private Label label10;
        private Label label11;
    }
}
