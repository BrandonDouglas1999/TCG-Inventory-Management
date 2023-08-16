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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.card_qnty = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.api_price = new System.Windows.Forms.TextBox();
            this.api_ctype = new System.Windows.Forms.TextBox();
            this.s_price = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.api_crace = new System.Windows.Forms.TextBox();
            this.rare_label = new System.Windows.Forms.Label();
            this.api_rare = new System.Windows.Forms.TextBox();
            this.image_url = new System.Windows.Forms.TextBox();
            this.api_setname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.api_setcode = new System.Windows.Forms.TextBox();
            this.api_id = new System.Windows.Forms.TextBox();
            this.api_cn = new System.Windows.Forms.TextBox();
            this.cn_label = new System.Windows.Forms.Label();
            this.card_gridview = new System.Windows.Forms.DataGridView();
            this.srch_option = new System.Windows.Forms.ComboBox();
            this.set_gridview = new System.Windows.Forms.DataGridView();
            this.add_bttn = new System.Windows.Forms.Button();
            this.rtv_card = new System.Windows.Forms.Button();
            this.card_srch = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.card_input_vals_panel = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.card_qnty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card_gridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.set_gridview)).BeginInit();
            this.panel2.SuspendLayout();
            this.card_input_vals_panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // card_qnty
            // 
            this.card_qnty.Location = new System.Drawing.Point(110, 47);
            this.card_qnty.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.card_qnty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.card_qnty.Name = "card_qnty";
            this.card_qnty.Size = new System.Drawing.Size(100, 23);
            this.card_qnty.TabIndex = 62;
            this.card_qnty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(795, 301);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(205, 23);
            this.label9.TabIndex = 58;
            this.label9.Text = "Selected Card Details:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label8.Location = new System.Drawing.Point(20, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 21);
            this.label8.TabIndex = 55;
            this.label8.Text = "Market Price";
            // 
            // api_price
            // 
            this.api_price.Cursor = System.Windows.Forms.Cursors.No;
            this.api_price.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.api_price.Location = new System.Drawing.Point(128, 128);
            this.api_price.Name = "api_price";
            this.api_price.ReadOnly = true;
            this.api_price.Size = new System.Drawing.Size(100, 25);
            this.api_price.TabIndex = 54;
            // 
            // api_ctype
            // 
            this.api_ctype.Cursor = System.Windows.Forms.Cursors.No;
            this.api_ctype.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.api_ctype.Location = new System.Drawing.Point(127, 124);
            this.api_ctype.Name = "api_ctype";
            this.api_ctype.ReadOnly = true;
            this.api_ctype.Size = new System.Drawing.Size(300, 25);
            this.api_ctype.TabIndex = 51;
            // 
            // s_price
            // 
            this.s_price.Location = new System.Drawing.Point(110, 9);
            this.s_price.Name = "s_price";
            this.s_price.PlaceholderText = "0.00";
            this.s_price.Size = new System.Drawing.Size(100, 23);
            this.s_price.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label6.Location = new System.Drawing.Point(38, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 21);
            this.label6.TabIndex = 50;
            this.label6.Text = "Card Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(10, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 21);
            this.label4.TabIndex = 42;
            this.label4.Text = "Store Price:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label5.Location = new System.Drawing.Point(38, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 21);
            this.label5.TabIndex = 49;
            this.label5.Text = "Card Race";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(15, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 21);
            this.label7.TabIndex = 53;
            this.label7.Text = "Quantity:";
            // 
            // api_crace
            // 
            this.api_crace.Cursor = System.Windows.Forms.Cursors.No;
            this.api_crace.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.api_crace.Location = new System.Drawing.Point(127, 86);
            this.api_crace.Name = "api_crace";
            this.api_crace.ReadOnly = true;
            this.api_crace.Size = new System.Drawing.Size(100, 25);
            this.api_crace.TabIndex = 48;
            // 
            // rare_label
            // 
            this.rare_label.AutoSize = true;
            this.rare_label.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rare_label.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.rare_label.Location = new System.Drawing.Point(70, 95);
            this.rare_label.Name = "rare_label";
            this.rare_label.Size = new System.Drawing.Size(52, 21);
            this.rare_label.TabIndex = 47;
            this.rare_label.Text = "Rarity";
            // 
            // api_rare
            // 
            this.api_rare.Cursor = System.Windows.Forms.Cursors.No;
            this.api_rare.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.api_rare.Location = new System.Drawing.Point(128, 93);
            this.api_rare.Name = "api_rare";
            this.api_rare.ReadOnly = true;
            this.api_rare.Size = new System.Drawing.Size(100, 25);
            this.api_rare.TabIndex = 46;
            // 
            // image_url
            // 
            this.image_url.Location = new System.Drawing.Point(353, 105);
            this.image_url.Name = "image_url";
            this.image_url.ReadOnly = true;
            this.image_url.Size = new System.Drawing.Size(87, 23);
            this.image_url.TabIndex = 43;
            this.image_url.Visible = false;
            // 
            // api_setname
            // 
            this.api_setname.Cursor = System.Windows.Forms.Cursors.No;
            this.api_setname.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.api_setname.Location = new System.Drawing.Point(128, 15);
            this.api_setname.Name = "api_setname";
            this.api_setname.ReadOnly = true;
            this.api_setname.Size = new System.Drawing.Size(300, 25);
            this.api_setname.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(41, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 21);
            this.label3.TabIndex = 39;
            this.label3.Text = "Set Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(45, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 21);
            this.label2.TabIndex = 38;
            this.label2.Text = "Set Code";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(57, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 21);
            this.label1.TabIndex = 37;
            this.label1.Text = "Card ID";
            // 
            // api_setcode
            // 
            this.api_setcode.Cursor = System.Windows.Forms.Cursors.No;
            this.api_setcode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.api_setcode.Location = new System.Drawing.Point(128, 53);
            this.api_setcode.Name = "api_setcode";
            this.api_setcode.ReadOnly = true;
            this.api_setcode.Size = new System.Drawing.Size(100, 25);
            this.api_setcode.TabIndex = 36;
            // 
            // api_id
            // 
            this.api_id.Cursor = System.Windows.Forms.Cursors.No;
            this.api_id.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.api_id.Location = new System.Drawing.Point(127, 48);
            this.api_id.Name = "api_id";
            this.api_id.ReadOnly = true;
            this.api_id.Size = new System.Drawing.Size(100, 25);
            this.api_id.TabIndex = 35;
            // 
            // api_cn
            // 
            this.api_cn.Cursor = System.Windows.Forms.Cursors.No;
            this.api_cn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.api_cn.Location = new System.Drawing.Point(127, 10);
            this.api_cn.Name = "api_cn";
            this.api_cn.ReadOnly = true;
            this.api_cn.Size = new System.Drawing.Size(300, 25);
            this.api_cn.TabIndex = 32;
            // 
            // cn_label
            // 
            this.cn_label.AutoSize = true;
            this.cn_label.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cn_label.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.cn_label.Location = new System.Drawing.Point(30, 13);
            this.cn_label.Name = "cn_label";
            this.cn_label.Size = new System.Drawing.Size(91, 21);
            this.cn_label.TabIndex = 31;
            this.cn_label.Text = "Card Name";
            // 
            // card_gridview
            // 
            this.card_gridview.AllowUserToAddRows = false;
            this.card_gridview.AllowUserToDeleteRows = false;
            this.card_gridview.AllowUserToResizeColumns = false;
            this.card_gridview.AllowUserToResizeRows = false;
            this.card_gridview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.card_gridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.card_gridview.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.card_gridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.card_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.card_gridview.EnableHeadersVisualStyles = false;
            this.card_gridview.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.card_gridview.Location = new System.Drawing.Point(49, 342);
            this.card_gridview.MultiSelect = false;
            this.card_gridview.Name = "card_gridview";
            this.card_gridview.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.card_gridview.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.card_gridview.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.card_gridview.RowTemplate.Height = 25;
            this.card_gridview.Size = new System.Drawing.Size(698, 177);
            this.card_gridview.TabIndex = 57;
            this.card_gridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.card_view_CellContentClick);
            // 
            // srch_option
            // 
            this.srch_option.Cursor = System.Windows.Forms.Cursors.Hand;
            this.srch_option.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.srch_option.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.srch_option.FormattingEnabled = true;
            this.srch_option.Items.AddRange(new object[] {
            "Card Name",
            "Card ID",
            "Set Name"});
            this.srch_option.Location = new System.Drawing.Point(16, 27);
            this.srch_option.Name = "srch_option";
            this.srch_option.Size = new System.Drawing.Size(121, 29);
            this.srch_option.TabIndex = 56;
            this.srch_option.Click += new System.EventHandler(this.srch_option_SelectedIndexChanged);
            // 
            // set_gridview
            // 
            this.set_gridview.AllowUserToAddRows = false;
            this.set_gridview.AllowUserToDeleteRows = false;
            this.set_gridview.AllowUserToResizeColumns = false;
            this.set_gridview.AllowUserToResizeRows = false;
            this.set_gridview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.set_gridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.set_gridview.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.set_gridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.set_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.set_gridview.EnableHeadersVisualStyles = false;
            this.set_gridview.Location = new System.Drawing.Point(49, 588);
            this.set_gridview.MultiSelect = false;
            this.set_gridview.Name = "set_gridview";
            this.set_gridview.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.set_gridview.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.set_gridview.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.set_gridview.RowTemplate.Height = 25;
            this.set_gridview.Size = new System.Drawing.Size(698, 179);
            this.set_gridview.TabIndex = 45;
            this.set_gridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.api_gridview_CellContentClick);
            // 
            // add_bttn
            // 
            this.add_bttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(143)))));
            this.add_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add_bttn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.add_bttn.ForeColor = System.Drawing.Color.White;
            this.add_bttn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.add_bttn.Location = new System.Drawing.Point(252, 14);
            this.add_bttn.Name = "add_bttn";
            this.add_bttn.Size = new System.Drawing.Size(247, 43);
            this.add_bttn.TabIndex = 44;
            this.add_bttn.Text = "Add To Inventory";
            this.add_bttn.UseVisualStyleBackColor = false;
            this.add_bttn.Click += new System.EventHandler(this.add_bttn_Click);
            // 
            // rtv_card
            // 
            this.rtv_card.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(143)))));
            this.rtv_card.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rtv_card.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rtv_card.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rtv_card.ForeColor = System.Drawing.Color.White;
            this.rtv_card.Location = new System.Drawing.Point(386, 28);
            this.rtv_card.Name = "rtv_card";
            this.rtv_card.Size = new System.Drawing.Size(130, 29);
            this.rtv_card.TabIndex = 34;
            this.rtv_card.Text = "Search";
            this.rtv_card.UseVisualStyleBackColor = false;
            this.rtv_card.Click += new System.EventHandler(this.rtv_card_Click);
            // 
            // card_srch
            // 
            this.card_srch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.card_srch.Location = new System.Drawing.Point(153, 27);
            this.card_srch.Name = "card_srch";
            this.card_srch.PlaceholderText = "Eg. Dark Magician Girl";
            this.card_srch.Size = new System.Drawing.Size(210, 29);
            this.card_srch.TabIndex = 33;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Sylfaen", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(17, 22);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(224, 25);
            this.label23.TabIndex = 1;
            this.label23.Text = "Add Cards to Inventory";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.label23);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1500, 63);
            this.panel2.TabIndex = 63;
            // 
            // card_input_vals_panel
            // 
            this.card_input_vals_panel.BackColor = System.Drawing.Color.White;
            this.card_input_vals_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.card_input_vals_panel.Controls.Add(this.srch_option);
            this.card_input_vals_panel.Controls.Add(this.rtv_card);
            this.card_input_vals_panel.Controls.Add(this.card_srch);
            this.card_input_vals_panel.Location = new System.Drawing.Point(49, 135);
            this.card_input_vals_panel.Name = "card_input_vals_panel";
            this.card_input_vals_panel.Size = new System.Drawing.Size(540, 86);
            this.card_input_vals_panel.TabIndex = 64;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(49, 93);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(139, 23);
            this.label13.TabIndex = 65;
            this.label13.Text = "1. Card Search:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.api_id);
            this.panel1.Controls.Add(this.api_ctype);
            this.panel1.Controls.Add(this.api_cn);
            this.panel1.Controls.Add(this.api_crace);
            this.panel1.Controls.Add(this.cn_label);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(795, 341);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(558, 177);
            this.panel1.TabIndex = 66;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(49, 301);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(176, 23);
            this.label14.TabIndex = 67;
            this.label14.Text = "2. Select Card Info:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(49, 553);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(207, 23);
            this.label12.TabIndex = 68;
            this.label12.Text = "3. Select Card Version:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.api_setname);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.rare_label);
            this.panel3.Controls.Add(this.api_price);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.api_rare);
            this.panel3.Controls.Add(this.api_setcode);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.image_url);
            this.panel3.Location = new System.Drawing.Point(795, 588);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(558, 179);
            this.panel3.TabIndex = 69;
            // 
            // label21
            // 
            this.label21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label21.Location = new System.Drawing.Point(194, 262);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(1000, 2);
            this.label21.TabIndex = 70;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.s_price);
            this.panel4.Controls.Add(this.card_qnty);
            this.panel4.Controls.Add(this.add_bttn);
            this.panel4.Location = new System.Drawing.Point(795, 135);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(558, 86);
            this.panel4.TabIndex = 71;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(795, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(174, 23);
            this.label10.TabIndex = 72;
            this.label10.Text = "4. Product Details:";
            // 
            // add_cards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.card_input_vals_panel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.set_gridview);
            this.Controls.Add(this.card_gridview);
            this.Name = "add_cards";
            this.Size = new System.Drawing.Size(1500, 850);
            ((System.ComponentModel.ISupportInitialize)(this.card_qnty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card_gridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.set_gridview)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.card_input_vals_panel.ResumeLayout(false);
            this.card_input_vals_panel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}
