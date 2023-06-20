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
            comboBox1 = new ComboBox();
            label8 = new Label();
            api_price = new TextBox();
            label7 = new Label();
            card_qnty = new TextBox();
            api_ctype = new TextBox();
            label6 = new Label();
            label5 = new Label();
            api_crace = new TextBox();
            rare_label = new Label();
            api_rare = new TextBox();
            api_gridview = new DataGridView();
            add_bttn = new Button();
            image_url = new TextBox();
            label4 = new Label();
            s_price = new TextBox();
            api_setname = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            api_setcode = new TextBox();
            api_id = new TextBox();
            rtv_card = new Button();
            card_srch = new TextBox();
            api_cn = new TextBox();
            cn_label = new Label();
            ((System.ComponentModel.ISupportInitialize)api_gridview).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(463, 22);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 51;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(51, 205);
            label8.Name = "label8";
            label8.Size = new Size(102, 16);
            label8.TabIndex = 50;
            label8.Text = "Current Price";
            // 
            // api_price
            // 
            api_price.Location = new Point(51, 224);
            api_price.Name = "api_price";
            api_price.ReadOnly = true;
            api_price.Size = new Size(100, 23);
            api_price.TabIndex = 49;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(341, 205);
            label7.Name = "label7";
            label7.Size = new Size(74, 16);
            label7.TabIndex = 48;
            label7.Text = "Quantity ";
            // 
            // card_qnty
            // 
            card_qnty.Location = new Point(341, 224);
            card_qnty.Name = "card_qnty";
            card_qnty.Size = new Size(100, 23);
            card_qnty.TabIndex = 47;
            // 
            // api_ctype
            // 
            api_ctype.Location = new Point(489, 90);
            api_ctype.Name = "api_ctype";
            api_ctype.ReadOnly = true;
            api_ctype.Size = new Size(100, 23);
            api_ctype.TabIndex = 46;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(489, 71);
            label6.Name = "label6";
            label6.Size = new Size(80, 16);
            label6.TabIndex = 45;
            label6.Text = "Card Type";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(336, 71);
            label5.Name = "label5";
            label5.Size = new Size(80, 16);
            label5.TabIndex = 44;
            label5.Text = "Card Race";
            // 
            // api_crace
            // 
            api_crace.Location = new Point(336, 91);
            api_crace.Name = "api_crace";
            api_crace.ReadOnly = true;
            api_crace.Size = new Size(100, 23);
            api_crace.TabIndex = 43;
            // 
            // rare_label
            // 
            rare_label.AutoSize = true;
            rare_label.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            rare_label.Location = new Point(489, 135);
            rare_label.Name = "rare_label";
            rare_label.Size = new Size(50, 16);
            rare_label.TabIndex = 42;
            rare_label.Text = "Rarity";
            // 
            // api_rare
            // 
            api_rare.Location = new Point(489, 154);
            api_rare.Name = "api_rare";
            api_rare.ReadOnly = true;
            api_rare.Size = new Size(100, 23);
            api_rare.TabIndex = 41;
            // 
            // api_gridview
            // 
            api_gridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            api_gridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            api_gridview.Location = new Point(29, 281);
            api_gridview.Name = "api_gridview";
            api_gridview.RowTemplate.Height = 25;
            api_gridview.Size = new Size(680, 186);
            api_gridview.TabIndex = 40;
            // 
            // add_bttn
            // 
            add_bttn.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            add_bttn.ImageAlign = ContentAlignment.BottomCenter;
            add_bttn.Location = new Point(272, 471);
            add_bttn.Name = "add_bttn";
            add_bttn.Size = new Size(164, 38);
            add_bttn.TabIndex = 39;
            add_bttn.Text = "Add Card";
            add_bttn.UseVisualStyleBackColor = true;
            // 
            // image_url
            // 
            image_url.Location = new Point(595, 154);
            image_url.Name = "image_url";
            image_url.ReadOnly = true;
            image_url.Size = new Size(87, 23);
            image_url.TabIndex = 38;
            image_url.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(196, 205);
            label4.Name = "label4";
            label4.Size = new Size(90, 16);
            label4.TabIndex = 37;
            label4.Text = "Store Price ";
            // 
            // s_price
            // 
            s_price.Location = new Point(196, 224);
            s_price.Name = "s_price";
            s_price.Size = new Size(100, 23);
            s_price.TabIndex = 36;
            // 
            // api_setname
            // 
            api_setname.Location = new Point(196, 153);
            api_setname.Name = "api_setname";
            api_setname.ReadOnly = true;
            api_setname.Size = new Size(261, 23);
            api_setname.TabIndex = 35;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(196, 134);
            label3.Name = "label3";
            label3.Size = new Size(77, 16);
            label3.TabIndex = 34;
            label3.Text = "Set Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(51, 134);
            label2.Name = "label2";
            label2.Size = new Size(72, 16);
            label2.TabIndex = 33;
            label2.Text = "Set Code";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(51, 71);
            label1.Name = "label1";
            label1.Size = new Size(61, 16);
            label1.TabIndex = 32;
            label1.Text = "Card ID";
            // 
            // api_setcode
            // 
            api_setcode.Location = new Point(51, 154);
            api_setcode.Name = "api_setcode";
            api_setcode.ReadOnly = true;
            api_setcode.Size = new Size(100, 23);
            api_setcode.TabIndex = 31;
            // 
            // api_id
            // 
            api_id.Location = new Point(51, 91);
            api_id.Name = "api_id";
            api_id.ReadOnly = true;
            api_id.Size = new Size(100, 23);
            api_id.TabIndex = 30;
            // 
            // rtv_card
            // 
            rtv_card.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            rtv_card.Location = new Point(590, 21);
            rtv_card.Name = "rtv_card";
            rtv_card.Size = new Size(126, 23);
            rtv_card.TabIndex = 29;
            rtv_card.Text = "Search Database";
            rtv_card.UseVisualStyleBackColor = true;
            // 
            // card_srch
            // 
            card_srch.Location = new Point(51, 22);
            card_srch.Name = "card_srch";
            card_srch.Size = new Size(406, 23);
            card_srch.TabIndex = 28;
            // 
            // api_cn
            // 
            api_cn.Location = new Point(196, 91);
            api_cn.Name = "api_cn";
            api_cn.ReadOnly = true;
            api_cn.Size = new Size(100, 23);
            api_cn.TabIndex = 27;
            // 
            // cn_label
            // 
            cn_label.AutoSize = true;
            cn_label.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            cn_label.Location = new Point(196, 71);
            cn_label.Name = "cn_label";
            cn_label.Size = new Size(87, 16);
            cn_label.TabIndex = 26;
            cn_label.Text = "Card Name";
            // 
            // add_cards
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(comboBox1);
            Controls.Add(label8);
            Controls.Add(api_price);
            Controls.Add(label7);
            Controls.Add(card_qnty);
            Controls.Add(api_ctype);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(api_crace);
            Controls.Add(rare_label);
            Controls.Add(api_rare);
            Controls.Add(api_gridview);
            Controls.Add(add_bttn);
            Controls.Add(image_url);
            Controls.Add(label4);
            Controls.Add(s_price);
            Controls.Add(api_setname);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(api_setcode);
            Controls.Add(api_id);
            Controls.Add(rtv_card);
            Controls.Add(card_srch);
            Controls.Add(api_cn);
            Controls.Add(cn_label);
            Name = "add_cards";
            Size = new Size(732, 534);
            ((System.ComponentModel.ISupportInitialize)api_gridview).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
    }
}
