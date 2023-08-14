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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            card_details_panel = new Panel();
            card_qnty = new NumericUpDown();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            api_price = new TextBox();
            label7 = new Label();
            api_ctype = new TextBox();
            label6 = new Label();
            label5 = new Label();
            api_crace = new TextBox();
            rare_label = new Label();
            api_rare = new TextBox();
            image_url = new TextBox();
            label4 = new Label();
            s_price = new TextBox();
            api_setname = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            api_setcode = new TextBox();
            api_id = new TextBox();
            api_cn = new TextBox();
            cn_label = new Label();
            label12 = new Label();
            label11 = new Label();
            card_gridview = new DataGridView();
            srch_option = new ComboBox();
            set_gridview = new DataGridView();
            add_bttn = new Button();
            rtv_card = new Button();
            card_srch = new TextBox();
            label23 = new Label();
            panel2 = new Panel();
            card_input_vals_panel = new Panel();
            card_details_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)card_qnty).BeginInit();
            ((System.ComponentModel.ISupportInitialize)card_gridview).BeginInit();
            ((System.ComponentModel.ISupportInitialize)set_gridview).BeginInit();
            panel2.SuspendLayout();
            card_input_vals_panel.SuspendLayout();
            SuspendLayout();
            // 
            // card_details_panel
            // 
            card_details_panel.BackColor = Color.Gainsboro;
            card_details_panel.Controls.Add(card_qnty);
            card_details_panel.Controls.Add(label10);
            card_details_panel.Controls.Add(label9);
            card_details_panel.Controls.Add(label8);
            card_details_panel.Controls.Add(api_price);
            card_details_panel.Controls.Add(label7);
            card_details_panel.Controls.Add(api_ctype);
            card_details_panel.Controls.Add(label6);
            card_details_panel.Controls.Add(label5);
            card_details_panel.Controls.Add(api_crace);
            card_details_panel.Controls.Add(rare_label);
            card_details_panel.Controls.Add(api_rare);
            card_details_panel.Controls.Add(image_url);
            card_details_panel.Controls.Add(label4);
            card_details_panel.Controls.Add(s_price);
            card_details_panel.Controls.Add(api_setname);
            card_details_panel.Controls.Add(label3);
            card_details_panel.Controls.Add(label2);
            card_details_panel.Controls.Add(label1);
            card_details_panel.Controls.Add(api_setcode);
            card_details_panel.Controls.Add(api_id);
            card_details_panel.Controls.Add(api_cn);
            card_details_panel.Controls.Add(cn_label);
            card_details_panel.Location = new Point(49, 420);
            card_details_panel.Name = "card_details_panel";
            card_details_panel.Size = new Size(911, 316);
            card_details_panel.TabIndex = 0;
            // 
            // card_qnty
            // 
            card_qnty.Location = new Point(467, 239);
            card_qnty.Name = "card_qnty";
            card_qnty.Size = new Size(92, 23);
            card_qnty.TabIndex = 62;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(159, 194);
            label10.Name = "label10";
            label10.Size = new Size(122, 16);
            label10.TabIndex = 59;
            label10.Text = "Product Details:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(22, 51);
            label9.Name = "label9";
            label9.Size = new Size(100, 16);
            label9.TabIndex = 58;
            label9.Text = "Card Details:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ControlDark;
            label8.Location = new Point(177, 219);
            label8.Name = "label8";
            label8.Size = new Size(84, 17);
            label8.TabIndex = 55;
            label8.Text = "Market Price";
            // 
            // api_price
            // 
            api_price.Cursor = Cursors.No;
            api_price.Location = new Point(177, 238);
            api_price.Name = "api_price";
            api_price.ReadOnly = true;
            api_price.Size = new Size(100, 23);
            api_price.TabIndex = 54;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ControlDark;
            label7.Location = new Point(467, 219);
            label7.Name = "label7";
            label7.Size = new Size(65, 17);
            label7.TabIndex = 53;
            label7.Text = "Quantity ";
            // 
            // api_ctype
            // 
            api_ctype.Cursor = Cursors.No;
            api_ctype.Location = new Point(644, 103);
            api_ctype.Name = "api_ctype";
            api_ctype.ReadOnly = true;
            api_ctype.Size = new Size(100, 23);
            api_ctype.TabIndex = 51;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlDark;
            label6.Location = new Point(644, 82);
            label6.Name = "label6";
            label6.Size = new Size(68, 17);
            label6.TabIndex = 50;
            label6.Text = "Card Type";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlDark;
            label5.Location = new Point(770, 82);
            label5.Name = "label5";
            label5.Size = new Size(68, 17);
            label5.TabIndex = 49;
            label5.Text = "Card Race";
            // 
            // api_crace
            // 
            api_crace.Cursor = Cursors.No;
            api_crace.Location = new Point(770, 103);
            api_crace.Name = "api_crace";
            api_crace.ReadOnly = true;
            api_crace.Size = new Size(100, 23);
            api_crace.TabIndex = 48;
            // 
            // rare_label
            // 
            rare_label.AutoSize = true;
            rare_label.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            rare_label.ForeColor = SystemColors.ControlDark;
            rare_label.Location = new Point(644, 136);
            rare_label.Name = "rare_label";
            rare_label.Size = new Size(43, 17);
            rare_label.TabIndex = 47;
            rare_label.Text = "Rarity";
            // 
            // api_rare
            // 
            api_rare.Cursor = Cursors.No;
            api_rare.Location = new Point(644, 155);
            api_rare.Name = "api_rare";
            api_rare.ReadOnly = true;
            api_rare.Size = new Size(100, 23);
            api_rare.TabIndex = 46;
            // 
            // image_url
            // 
            image_url.Location = new Point(750, 155);
            image_url.Name = "image_url";
            image_url.ReadOnly = true;
            image_url.Size = new Size(87, 23);
            image_url.TabIndex = 43;
            image_url.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlDark;
            label4.Location = new Point(322, 219);
            label4.Name = "label4";
            label4.Size = new Size(77, 17);
            label4.TabIndex = 42;
            label4.Text = "Store Price ";
            // 
            // s_price
            // 
            s_price.Location = new Point(322, 238);
            s_price.Name = "s_price";
            s_price.Size = new Size(100, 23);
            s_price.TabIndex = 41;
            // 
            // api_setname
            // 
            api_setname.Cursor = Cursors.No;
            api_setname.Location = new Point(311, 155);
            api_setname.Name = "api_setname";
            api_setname.ReadOnly = true;
            api_setname.Size = new Size(300, 23);
            api_setname.TabIndex = 40;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlDark;
            label3.Location = new Point(311, 136);
            label3.Name = "label3";
            label3.Size = new Size(67, 17);
            label3.TabIndex = 39;
            label3.Text = "Set Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlDark;
            label2.Location = new Point(177, 135);
            label2.Name = "label2";
            label2.Size = new Size(62, 17);
            label2.TabIndex = 38;
            label2.Text = "Set Code";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlDark;
            label1.Location = new Point(177, 82);
            label1.Name = "label1";
            label1.Size = new Size(53, 17);
            label1.TabIndex = 37;
            label1.Text = "Card ID";
            // 
            // api_setcode
            // 
            api_setcode.Cursor = Cursors.No;
            api_setcode.Location = new Point(177, 155);
            api_setcode.Name = "api_setcode";
            api_setcode.ReadOnly = true;
            api_setcode.Size = new Size(100, 23);
            api_setcode.TabIndex = 36;
            // 
            // api_id
            // 
            api_id.Cursor = Cursors.No;
            api_id.Location = new Point(177, 102);
            api_id.Name = "api_id";
            api_id.ReadOnly = true;
            api_id.Size = new Size(100, 23);
            api_id.TabIndex = 35;
            // 
            // api_cn
            // 
            api_cn.Cursor = Cursors.No;
            api_cn.Location = new Point(310, 102);
            api_cn.Name = "api_cn";
            api_cn.ReadOnly = true;
            api_cn.Size = new Size(300, 23);
            api_cn.TabIndex = 32;
            // 
            // cn_label
            // 
            cn_label.AutoSize = true;
            cn_label.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            cn_label.ForeColor = SystemColors.ControlDark;
            cn_label.Location = new Point(310, 82);
            cn_label.Name = "cn_label";
            cn_label.Size = new Size(76, 17);
            cn_label.TabIndex = 31;
            cn_label.Text = "Card Name";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Black;
            label12.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.White;
            label12.Location = new Point(1056, 160);
            label12.Name = "label12";
            label12.Size = new Size(105, 16);
            label12.TabIndex = 61;
            label12.Text = "Card Version:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Black;
            label11.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(1056, 411);
            label11.Name = "label11";
            label11.Size = new Size(79, 16);
            label11.TabIndex = 60;
            label11.Text = "Card Info:";
            // 
            // card_gridview
            // 
            card_gridview.AllowUserToAddRows = false;
            card_gridview.AllowUserToDeleteRows = false;
            card_gridview.AllowUserToResizeColumns = false;
            card_gridview.AllowUserToResizeRows = false;
            card_gridview.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            card_gridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            card_gridview.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            card_gridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            card_gridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            card_gridview.EnableHeadersVisualStyles = false;
            card_gridview.GridColor = SystemColors.ActiveCaption;
            card_gridview.Location = new Point(1056, 187);
            card_gridview.MultiSelect = false;
            card_gridview.Name = "card_gridview";
            card_gridview.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            card_gridview.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            card_gridview.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            card_gridview.RowTemplate.Height = 25;
            card_gridview.Size = new Size(327, 200);
            card_gridview.TabIndex = 57;
            card_gridview.CellClick += card_view_CellContentClick;
            // 
            // srch_option
            // 
            srch_option.Cursor = Cursors.Hand;
            srch_option.DropDownStyle = ComboBoxStyle.DropDownList;
            srch_option.FormattingEnabled = true;
            srch_option.Items.AddRange(new object[] { "Card Name", "Card ID", "Set Name" });
            srch_option.Location = new Point(38, 37);
            srch_option.Name = "srch_option";
            srch_option.Size = new Size(121, 23);
            srch_option.TabIndex = 56;
            // 
            // set_gridview
            // 
            set_gridview.AllowUserToAddRows = false;
            set_gridview.AllowUserToDeleteRows = false;
            set_gridview.AllowUserToResizeColumns = false;
            set_gridview.AllowUserToResizeRows = false;
            set_gridview.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            set_gridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            set_gridview.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            set_gridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            set_gridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            set_gridview.EnableHeadersVisualStyles = false;
            set_gridview.Location = new Point(1056, 439);
            set_gridview.MultiSelect = false;
            set_gridview.Name = "set_gridview";
            set_gridview.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Control;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            set_gridview.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            set_gridview.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            set_gridview.RowTemplate.Height = 25;
            set_gridview.Size = new Size(65, 200);
            set_gridview.TabIndex = 45;
            set_gridview.CellClick += api_gridview_CellContentClick;
            // 
            // add_bttn
            // 
            add_bttn.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            add_bttn.BackColor = Color.FromArgb(26, 28, 60);
            add_bttn.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            add_bttn.ForeColor = Color.White;
            add_bttn.ImageAlign = ContentAlignment.BottomCenter;
            add_bttn.Location = new Point(745, 679);
            add_bttn.Name = "add_bttn";
            add_bttn.Size = new Size(0, 43);
            add_bttn.TabIndex = 44;
            add_bttn.Text = "Add To Inventory";
            add_bttn.UseVisualStyleBackColor = false;
            add_bttn.Click += add_bttn_Click;
            // 
            // rtv_card
            // 
            rtv_card.BackColor = Color.FromArgb(38, 171, 254);
            rtv_card.Cursor = Cursors.Hand;
            rtv_card.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            rtv_card.ForeColor = Color.FromArgb(26, 28, 60);
            rtv_card.Location = new Point(38, 128);
            rtv_card.Name = "rtv_card";
            rtv_card.Size = new Size(126, 33);
            rtv_card.TabIndex = 34;
            rtv_card.Text = "Search";
            rtv_card.UseVisualStyleBackColor = false;
            rtv_card.Click += rtv_card_Click;
            // 
            // card_srch
            // 
            card_srch.Location = new Point(38, 79);
            card_srch.Name = "card_srch";
            card_srch.Size = new Size(406, 23);
            card_srch.TabIndex = 33;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Constantia", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label23.ForeColor = Color.White;
            label23.Location = new Point(17, 22);
            label23.Name = "label23";
            label23.Size = new Size(219, 23);
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
            card_input_vals_panel.Controls.Add(srch_option);
            card_input_vals_panel.Controls.Add(rtv_card);
            card_input_vals_panel.Controls.Add(card_srch);
            card_input_vals_panel.Location = new Point(49, 115);
            card_input_vals_panel.Name = "card_input_vals_panel";
            card_input_vals_panel.Size = new Size(588, 255);
            card_input_vals_panel.TabIndex = 64;
            // 
            // add_cards
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(card_input_vals_panel);
            Controls.Add(panel2);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(card_details_panel);
            Controls.Add(add_bttn);
            Controls.Add(set_gridview);
            Controls.Add(card_gridview);
            Name = "add_cards";
            Size = new Size(1500, 850);
            card_details_panel.ResumeLayout(false);
            card_details_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)card_qnty).EndInit();
            ((System.ComponentModel.ISupportInitialize)card_gridview).EndInit();
            ((System.ComponentModel.ISupportInitialize)set_gridview).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            card_input_vals_panel.ResumeLayout(false);
            card_input_vals_panel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel card_details_panel;
        private Label label12;
        private Label label11;
        private Label label10;
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
    }
}
