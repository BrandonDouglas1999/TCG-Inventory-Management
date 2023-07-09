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
            this.srch_option = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.api_price = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.card_qnty = new System.Windows.Forms.TextBox();
            this.api_ctype = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.api_crace = new System.Windows.Forms.TextBox();
            this.rare_label = new System.Windows.Forms.Label();
            this.api_rare = new System.Windows.Forms.TextBox();
            this.set_gridview = new System.Windows.Forms.DataGridView();
            this.add_bttn = new System.Windows.Forms.Button();
            this.image_url = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.s_price = new System.Windows.Forms.TextBox();
            this.api_setname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.api_setcode = new System.Windows.Forms.TextBox();
            this.api_id = new System.Windows.Forms.TextBox();
            this.rtv_card = new System.Windows.Forms.Button();
            this.card_srch = new System.Windows.Forms.TextBox();
            this.api_cn = new System.Windows.Forms.TextBox();
            this.cn_label = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.set_gridview)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // srch_option
            // 
            this.srch_option.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.srch_option.FormattingEnabled = true;
            this.srch_option.Items.AddRange(new object[] {
            "Card Name",
            "Card ID",
            "Set Name"});
            this.srch_option.Location = new System.Drawing.Point(341, 10);
            this.srch_option.Name = "srch_option";
            this.srch_option.Size = new System.Drawing.Size(121, 23);
            this.srch_option.TabIndex = 51;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 16);
            this.label8.TabIndex = 50;
            this.label8.Text = "Current Price";
            // 
            // api_price
            // 
            this.api_price.Location = new System.Drawing.Point(3, 28);
            this.api_price.Name = "api_price";
            this.api_price.ReadOnly = true;
            this.api_price.Size = new System.Drawing.Size(100, 23);
            this.api_price.TabIndex = 49;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(427, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 16);
            this.label7.TabIndex = 48;
            this.label7.Text = "Quantity ";
            // 
            // card_qnty
            // 
            this.card_qnty.Location = new System.Drawing.Point(427, 28);
            this.card_qnty.Name = "card_qnty";
            this.card_qnty.Size = new System.Drawing.Size(100, 23);
            this.card_qnty.TabIndex = 47;
            // 
            // api_ctype
            // 
            this.api_ctype.Location = new System.Drawing.Point(476, 21);
            this.api_ctype.Name = "api_ctype";
            this.api_ctype.ReadOnly = true;
            this.api_ctype.Size = new System.Drawing.Size(100, 23);
            this.api_ctype.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(476, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 16);
            this.label6.TabIndex = 45;
            this.label6.Text = "Card Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(308, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 16);
            this.label5.TabIndex = 44;
            this.label5.Text = "Card Race";
            // 
            // api_crace
            // 
            this.api_crace.Location = new System.Drawing.Point(308, 21);
            this.api_crace.Name = "api_crace";
            this.api_crace.ReadOnly = true;
            this.api_crace.Size = new System.Drawing.Size(100, 23);
            this.api_crace.TabIndex = 43;
            // 
            // rare_label
            // 
            this.rare_label.AutoSize = true;
            this.rare_label.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rare_label.Location = new System.Drawing.Point(406, 0);
            this.rare_label.Name = "rare_label";
            this.rare_label.Size = new System.Drawing.Size(50, 16);
            this.rare_label.TabIndex = 42;
            this.rare_label.Text = "Rarity";
            // 
            // api_rare
            // 
            this.api_rare.Location = new System.Drawing.Point(406, 26);
            this.api_rare.Name = "api_rare";
            this.api_rare.ReadOnly = true;
            this.api_rare.Size = new System.Drawing.Size(98, 23);
            this.api_rare.TabIndex = 41;
            // 
            // set_gridview
            // 
            this.set_gridview.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.set_gridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.set_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.set_gridview.Location = new System.Drawing.Point(34, 290);
            this.set_gridview.Name = "set_gridview";
            this.set_gridview.RowTemplate.Height = 25;
            this.set_gridview.Size = new System.Drawing.Size(680, 186);
            this.set_gridview.TabIndex = 40;
            this.set_gridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.api_gridview_CellContentClick);
            // 
            // add_bttn
            // 
            this.add_bttn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.add_bttn.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.add_bttn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.add_bttn.Location = new System.Drawing.Point(295, 491);
            this.add_bttn.Name = "add_bttn";
            this.add_bttn.Size = new System.Drawing.Size(164, 38);
            this.add_bttn.TabIndex = 39;
            this.add_bttn.Text = "Add Card";
            this.add_bttn.UseVisualStyleBackColor = true;
            this.add_bttn.Click += new System.EventHandler(this.add_bttn_Click);
            // 
            // image_url
            // 
            this.image_url.Location = new System.Drawing.Point(510, 26);
            this.image_url.Name = "image_url";
            this.image_url.ReadOnly = true;
            this.image_url.Size = new System.Drawing.Size(83, 23);
            this.image_url.TabIndex = 38;
            this.image_url.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(215, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 37;
            this.label4.Text = "Store Price ";
            // 
            // s_price
            // 
            this.s_price.Location = new System.Drawing.Point(215, 28);
            this.s_price.Name = "s_price";
            this.s_price.Size = new System.Drawing.Size(100, 23);
            this.s_price.TabIndex = 36;
            // 
            // api_setname
            // 
            this.api_setname.Location = new System.Drawing.Point(159, 26);
            this.api_setname.Name = "api_setname";
            this.api_setname.ReadOnly = true;
            this.api_setname.Size = new System.Drawing.Size(241, 23);
            this.api_setname.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(159, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 34;
            this.label3.Text = "Set Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 33;
            this.label2.Text = "Set Code";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 32;
            this.label1.Text = "Card ID";
            // 
            // api_setcode
            // 
            this.api_setcode.Location = new System.Drawing.Point(3, 26);
            this.api_setcode.Name = "api_setcode";
            this.api_setcode.ReadOnly = true;
            this.api_setcode.Size = new System.Drawing.Size(100, 23);
            this.api_setcode.TabIndex = 31;
            // 
            // api_id
            // 
            this.api_id.Location = new System.Drawing.Point(3, 21);
            this.api_id.Name = "api_id";
            this.api_id.ReadOnly = true;
            this.api_id.Size = new System.Drawing.Size(100, 23);
            this.api_id.TabIndex = 30;
            // 
            // rtv_card
            // 
            this.rtv_card.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rtv_card.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rtv_card.Location = new System.Drawing.Point(474, 10);
            this.rtv_card.Name = "rtv_card";
            this.rtv_card.Size = new System.Drawing.Size(119, 23);
            this.rtv_card.TabIndex = 29;
            this.rtv_card.Text = "Search Database";
            this.rtv_card.UseVisualStyleBackColor = true;
            this.rtv_card.Click += new System.EventHandler(this.rtv_card_Click);
            // 
            // card_srch
            // 
            this.card_srch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.card_srch.Location = new System.Drawing.Point(3, 10);
            this.card_srch.Name = "card_srch";
            this.card_srch.PlaceholderText = "Card Name";
            this.card_srch.Size = new System.Drawing.Size(326, 23);
            this.card_srch.TabIndex = 28;
            // 
            // api_cn
            // 
            this.api_cn.Location = new System.Drawing.Point(129, 21);
            this.api_cn.Name = "api_cn";
            this.api_cn.ReadOnly = true;
            this.api_cn.Size = new System.Drawing.Size(100, 23);
            this.api_cn.TabIndex = 27;
            // 
            // cn_label
            // 
            this.cn_label.AutoSize = true;
            this.cn_label.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cn_label.Location = new System.Drawing.Point(129, 0);
            this.cn_label.Name = "cn_label";
            this.cn_label.Size = new System.Drawing.Size(87, 16);
            this.cn_label.TabIndex = 26;
            this.cn_label.Text = "Card Name";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.48832F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.51168F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 124F));
            this.tableLayoutPanel1.Controls.Add(this.srch_option, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.card_srch, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.rtv_card, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(80, 29);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(596, 44);
            this.tableLayoutPanel1.TabIndex = 52;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.48352F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.51648F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 168F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.cn_label, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label5, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label6, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.api_id, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.api_cn, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.api_ctype, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.api_crace, 2, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(80, 79);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.29412F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.70588F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(596, 53);
            this.tableLayoutPanel2.TabIndex = 53;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.83249F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.16751F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tableLayoutPanel3.Controls.Add(this.image_url, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.api_rare, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.rare_label, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.api_setname, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.api_setcode, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(80, 138);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.28571F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.71429F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(596, 70);
            this.tableLayoutPanel3.TabIndex = 54;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 172F));
            this.tableLayoutPanel4.Controls.Add(this.label7, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.card_qnty, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.api_price, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.s_price, 1, 1);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(80, 214);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.71429F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.28571F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(596, 70);
            this.tableLayoutPanel4.TabIndex = 55;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(835, 576);
            this.tabControl1.TabIndex = 56;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.set_gridview);
            this.tabPage1.Controls.Add(this.add_bttn);
            this.tabPage1.Controls.Add(this.tableLayoutPanel4);
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Controls.Add(this.tableLayoutPanel3);
            this.tabPage1.Controls.Add(this.tableLayoutPanel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(827, 548);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(827, 548);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // add_cards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.tabControl1);
            this.Name = "add_cards";
            this.Size = new System.Drawing.Size(835, 576);
            ((System.ComponentModel.ISupportInitialize)(this.set_gridview)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox srch_option;
        private Label label8;
        private TextBox api_price;
        private Label label7;
        private TextBox card_qnty;
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
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
    }
}
