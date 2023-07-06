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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
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
            this.api_gridview = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.api_gridview)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(335, 10);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(133, 23);
            comboBox1.TabIndex = 51;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(3, 4);
            label8.Name = "label8";
            label8.Size = new Size(206, 16);
            label8.TabIndex = 50;
            label8.Text = "Current Price";
            // 
            // api_price
            // 
            api_price.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            api_price.Location = new Point(3, 36);
            api_price.Name = "api_price";
            api_price.ReadOnly = true;
            api_price.Size = new Size(206, 23);
            api_price.TabIndex = 49;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(427, 4);
            label7.Name = "label7";
            label7.Size = new Size(166, 16);
            label7.TabIndex = 48;
            label7.Text = "Quantity ";
            // 
            // card_qnty
            // 
            card_qnty.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            card_qnty.Location = new Point(427, 36);
            card_qnty.Name = "card_qnty";
            card_qnty.Size = new Size(166, 23);
            card_qnty.TabIndex = 47;
            // 
            // api_ctype
            // 
            api_ctype.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            api_ctype.Location = new Point(476, 24);
            api_ctype.Name = "api_ctype";
            api_ctype.ReadOnly = true;
            api_ctype.Size = new Size(117, 23);
            api_ctype.TabIndex = 46;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(476, 1);
            label6.Name = "label6";
            label6.Size = new Size(117, 16);
            label6.TabIndex = 45;
            label6.Text = "Card Type";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(308, 1);
            label5.Name = "label5";
            label5.Size = new Size(162, 16);
            label5.TabIndex = 44;
            label5.Text = "Card Race";
            // 
            // api_crace
            // 
            api_crace.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            api_crace.Location = new Point(308, 24);
            api_crace.Name = "api_crace";
            api_crace.ReadOnly = true;
            api_crace.Size = new Size(162, 23);
            api_crace.TabIndex = 43;
            // 
            // rare_label
            // 
            rare_label.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            rare_label.AutoSize = true;
            rare_label.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            rare_label.Location = new Point(406, 4);
            rare_label.Name = "rare_label";
            rare_label.Size = new Size(98, 16);
            rare_label.TabIndex = 42;
            rare_label.Text = "Rarity";
            // 
            // api_rare
            // 
            api_rare.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            api_rare.Location = new Point(406, 35);
            api_rare.Name = "api_rare";
            api_rare.ReadOnly = true;
            api_rare.Size = new Size(98, 23);
            api_rare.TabIndex = 41;
            // 
            // api_gridview
            // 
            api_gridview.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            api_gridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            api_gridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            api_gridview.Location = new Point(80, 290);
            api_gridview.Name = "api_gridview";
            api_gridview.RowTemplate.Height = 25;
            api_gridview.Size = new Size(596, 186);
            api_gridview.TabIndex = 40;
            api_gridview.CellContentClick += api_gridview_CellContentClick;
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
            image_url.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            image_url.Location = new Point(510, 35);
            image_url.Name = "image_url";
            image_url.ReadOnly = true;
            image_url.Size = new Size(83, 23);
            image_url.TabIndex = 38;
            image_url.Visible = false;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(215, 4);
            label4.Name = "label4";
            label4.Size = new Size(206, 16);
            label4.TabIndex = 37;
            label4.Text = "Store Price ";
            // 
            // s_price
            // 
            s_price.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            s_price.Location = new Point(215, 36);
            s_price.Name = "s_price";
            s_price.Size = new Size(206, 23);
            s_price.TabIndex = 36;
            // 
            // api_setname
            // 
            api_setname.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            api_setname.Location = new Point(159, 35);
            api_setname.Name = "api_setname";
            api_setname.ReadOnly = true;
            api_setname.Size = new Size(241, 23);
            api_setname.TabIndex = 35;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(159, 4);
            label3.Name = "label3";
            label3.Size = new Size(241, 16);
            label3.TabIndex = 34;
            label3.Text = "Set Name";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 4);
            label2.Name = "label2";
            label2.Size = new Size(150, 16);
            label2.TabIndex = 33;
            label2.Text = "Set Code";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 1);
            label1.Name = "label1";
            label1.Size = new Size(120, 16);
            label1.TabIndex = 32;
            label1.Text = "Card ID";
            // 
            // api_setcode
            // 
            api_setcode.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            api_setcode.Location = new Point(3, 35);
            api_setcode.Name = "api_setcode";
            api_setcode.ReadOnly = true;
            api_setcode.Size = new Size(150, 23);
            api_setcode.TabIndex = 31;
            // 
            // api_id
            // 
            api_id.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            api_id.Location = new Point(3, 24);
            api_id.Name = "api_id";
            api_id.ReadOnly = true;
            api_id.Size = new Size(120, 23);
            api_id.TabIndex = 30;
            // 
            // rtv_card
            // 
            rtv_card.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            rtv_card.AutoSize = true;
            rtv_card.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            rtv_card.Location = new Point(474, 9);
            rtv_card.Name = "rtv_card";
            rtv_card.Size = new Size(119, 26);
            rtv_card.TabIndex = 29;
            rtv_card.Text = "Search Database";
            rtv_card.UseVisualStyleBackColor = true;
            rtv_card.Click += rtv_card_Click;
            // 
            // card_srch
            // 
            card_srch.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            card_srch.Location = new Point(3, 10);
            card_srch.Name = "card_srch";
            card_srch.PlaceholderText = "Card Name";
            card_srch.Size = new Size(326, 23);
            card_srch.TabIndex = 28;
            // 
            // api_cn
            // 
            api_cn.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            api_cn.Location = new Point(129, 24);
            api_cn.Name = "api_cn";
            api_cn.ReadOnly = true;
            api_cn.Size = new Size(173, 23);
            api_cn.TabIndex = 27;
            // 
            // cn_label
            // 
            cn_label.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cn_label.AutoSize = true;
            cn_label.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            cn_label.Location = new Point(129, 1);
            cn_label.Name = "cn_label";
            cn_label.Size = new Size(173, 16);
            cn_label.TabIndex = 26;
            cn_label.Text = "Card Name";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70.48832F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.5116768F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 124F));
            tableLayoutPanel1.Controls.Add(comboBox1, 1, 0);
            tableLayoutPanel1.Controls.Add(card_srch, 0, 0);
            tableLayoutPanel1.Controls.Add(rtv_card, 2, 0);
            tableLayoutPanel1.Location = new Point(80, 29);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(596, 44);
            tableLayoutPanel1.TabIndex = 52;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 41.4835167F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 58.5164833F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 168F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 122F));
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(cn_label, 1, 0);
            tableLayoutPanel2.Controls.Add(label5, 2, 0);
            tableLayoutPanel2.Controls.Add(label6, 3, 0);
            tableLayoutPanel2.Controls.Add(api_id, 0, 1);
            tableLayoutPanel2.Controls.Add(api_cn, 1, 1);
            tableLayoutPanel2.Controls.Add(api_ctype, 3, 1);
            tableLayoutPanel2.Controls.Add(api_crace, 2, 1);
            tableLayoutPanel2.Location = new Point(80, 79);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 35.294117F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 64.70588F));
            tableLayoutPanel2.Size = new Size(596, 53);
            tableLayoutPanel2.TabIndex = 53;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.AutoSize = true;
            tableLayoutPanel3.ColumnCount = 4;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.83249F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 61.16751F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 104F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 88F));
            tableLayoutPanel3.Controls.Add(image_url, 3, 1);
            tableLayoutPanel3.Controls.Add(api_rare, 2, 1);
            tableLayoutPanel3.Controls.Add(rare_label, 2, 0);
            tableLayoutPanel3.Controls.Add(label3, 1, 0);
            tableLayoutPanel3.Controls.Add(api_setname, 1, 1);
            tableLayoutPanel3.Controls.Add(api_setcode, 0, 1);
            tableLayoutPanel3.Controls.Add(label2, 0, 0);
            tableLayoutPanel3.Location = new Point(80, 138);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 34.2857132F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 65.71429F));
            tableLayoutPanel3.Size = new Size(596, 70);
            tableLayoutPanel3.TabIndex = 54;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel4.AutoSize = true;
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 172F));
            tableLayoutPanel4.Controls.Add(label7, 2, 0);
            tableLayoutPanel4.Controls.Add(card_qnty, 2, 1);
            tableLayoutPanel4.Controls.Add(api_price, 0, 1);
            tableLayoutPanel4.Controls.Add(label8, 0, 0);
            tableLayoutPanel4.Controls.Add(label4, 1, 0);
            tableLayoutPanel4.Controls.Add(s_price, 1, 1);
            tableLayoutPanel4.Location = new Point(80, 214);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 35.7142868F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 64.28571F));
            tableLayoutPanel4.Size = new Size(596, 70);
            tableLayoutPanel4.TabIndex = 55;
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
            this.tabPage1.Controls.Add(this.api_gridview);
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
            ((System.ComponentModel.ISupportInitialize)(this.api_gridview)).EndInit();
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

        private ComboBox comboBox1;
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
        private DataGridView api_gridview;
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
