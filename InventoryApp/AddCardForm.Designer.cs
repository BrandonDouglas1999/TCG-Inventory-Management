namespace InventoryApp
{
    partial class AddCardForm
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
            this.cn_label = new System.Windows.Forms.Label();
            this.api_cn = new System.Windows.Forms.TextBox();
            this.card_srch = new System.Windows.Forms.TextBox();
            this.rtv_card = new System.Windows.Forms.Button();
            this.api_id = new System.Windows.Forms.TextBox();
            this.api_setcode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.api_setname = new System.Windows.Forms.TextBox();
            this.s_price = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.image_url = new System.Windows.Forms.TextBox();
            this.add_bttn = new System.Windows.Forms.Button();
            this.set_gridview = new System.Windows.Forms.DataGridView();
            this.api_rare = new System.Windows.Forms.TextBox();
            this.rare_label = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.api_crace = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.api_ctype = new System.Windows.Forms.TextBox();
            this.card_qnty = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.api_price = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.srch_option = new System.Windows.Forms.ComboBox();
            this.card_gridview = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.set_gridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card_gridview)).BeginInit();
            this.SuspendLayout();
            // 
            // cn_label
            // 
            this.cn_label.AutoSize = true;
            this.cn_label.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cn_label.Location = new System.Drawing.Point(152, 128);
            this.cn_label.Name = "cn_label";
            this.cn_label.Size = new System.Drawing.Size(87, 16);
            this.cn_label.TabIndex = 0;
            this.cn_label.Text = "Card Name";
            // 
            // api_cn
            // 
            this.api_cn.Location = new System.Drawing.Point(152, 148);
            this.api_cn.Name = "api_cn";
            this.api_cn.ReadOnly = true;
            this.api_cn.Size = new System.Drawing.Size(300, 23);
            this.api_cn.TabIndex = 1;
            // 
            // card_srch
            // 
            this.card_srch.Location = new System.Drawing.Point(180, 31);
            this.card_srch.Name = "card_srch";
            this.card_srch.Size = new System.Drawing.Size(406, 23);
            this.card_srch.TabIndex = 2;
            // 
            // rtv_card
            // 
            this.rtv_card.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rtv_card.Location = new System.Drawing.Point(719, 30);
            this.rtv_card.Name = "rtv_card";
            this.rtv_card.Size = new System.Drawing.Size(126, 23);
            this.rtv_card.TabIndex = 3;
            this.rtv_card.Text = "Search Database";
            this.rtv_card.UseVisualStyleBackColor = true;
            this.rtv_card.Click += new System.EventHandler(this.rtv_card_Click);
            // 
            // api_id
            // 
            this.api_id.Location = new System.Drawing.Point(152, 90);
            this.api_id.Name = "api_id";
            this.api_id.ReadOnly = true;
            this.api_id.Size = new System.Drawing.Size(100, 23);
            this.api_id.TabIndex = 4;
            // 
            // api_setcode
            // 
            this.api_setcode.Location = new System.Drawing.Point(591, 148);
            this.api_setcode.Name = "api_setcode";
            this.api_setcode.ReadOnly = true;
            this.api_setcode.Size = new System.Drawing.Size(100, 23);
            this.api_setcode.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(152, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Card ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(591, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Set Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(591, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Set Name";
            // 
            // api_setname
            // 
            this.api_setname.Location = new System.Drawing.Point(591, 90);
            this.api_setname.Name = "api_setname";
            this.api_setname.ReadOnly = true;
            this.api_setname.Size = new System.Drawing.Size(300, 23);
            this.api_setname.TabIndex = 9;
            // 
            // s_price
            // 
            this.s_price.Location = new System.Drawing.Point(297, 256);
            this.s_price.Name = "s_price";
            this.s_price.Size = new System.Drawing.Size(100, 23);
            this.s_price.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(297, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Store Price ";
            // 
            // image_url
            // 
            this.image_url.Location = new System.Drawing.Point(697, 199);
            this.image_url.Name = "image_url";
            this.image_url.ReadOnly = true;
            this.image_url.Size = new System.Drawing.Size(87, 23);
            this.image_url.TabIndex = 12;
            this.image_url.Visible = false;
            // 
            // add_bttn
            // 
            this.add_bttn.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.add_bttn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.add_bttn.Location = new System.Drawing.Point(324, 704);
            this.add_bttn.Name = "add_bttn";
            this.add_bttn.Size = new System.Drawing.Size(164, 38);
            this.add_bttn.TabIndex = 13;
            this.add_bttn.Text = "Add Card";
            this.add_bttn.UseVisualStyleBackColor = true;
            this.add_bttn.Click += new System.EventHandler(this.add_bttn_Click);
            // 
            // set_gridview
            // 
            this.set_gridview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.set_gridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.set_gridview.BackgroundColor = System.Drawing.SystemColors.Control;
            this.set_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.set_gridview.Location = new System.Drawing.Point(135, 504);
            this.set_gridview.Name = "set_gridview";
            this.set_gridview.RowTemplate.Height = 25;
            this.set_gridview.Size = new System.Drawing.Size(798, 186);
            this.set_gridview.TabIndex = 14;
            this.set_gridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.api_gridview_CellContentClick);
            // 
            // api_rare
            // 
            this.api_rare.Location = new System.Drawing.Point(591, 199);
            this.api_rare.Name = "api_rare";
            this.api_rare.ReadOnly = true;
            this.api_rare.Size = new System.Drawing.Size(100, 23);
            this.api_rare.TabIndex = 15;
            // 
            // rare_label
            // 
            this.rare_label.AutoSize = true;
            this.rare_label.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rare_label.Location = new System.Drawing.Point(591, 180);
            this.rare_label.Name = "rare_label";
            this.rare_label.Size = new System.Drawing.Size(50, 16);
            this.rare_label.TabIndex = 16;
            this.rare_label.Text = "Rarity";
            // 
            // api_crace
            // 
            this.api_crace.Location = new System.Drawing.Point(152, 199);
            this.api_crace.Name = "api_crace";
            this.api_crace.ReadOnly = true;
            this.api_crace.Size = new System.Drawing.Size(100, 23);
            this.api_crace.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(152, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Card Race";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(297, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Card Type";
            // 
            // api_ctype
            // 
            this.api_ctype.Location = new System.Drawing.Point(297, 199);
            this.api_ctype.Name = "api_ctype";
            this.api_ctype.ReadOnly = true;
            this.api_ctype.Size = new System.Drawing.Size(100, 23);
            this.api_ctype.TabIndex = 20;
            // 
            // card_qnty
            // 
            this.card_qnty.Location = new System.Drawing.Point(442, 256);
            this.card_qnty.Name = "card_qnty";
            this.card_qnty.Size = new System.Drawing.Size(100, 23);
            this.card_qnty.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(442, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "Quantity ";
            // 
            // api_price
            // 
            this.api_price.Location = new System.Drawing.Point(152, 256);
            this.api_price.Name = "api_price";
            this.api_price.ReadOnly = true;
            this.api_price.Size = new System.Drawing.Size(100, 23);
            this.api_price.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(152, 237);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 16);
            this.label8.TabIndex = 24;
            this.label8.Text = "Current Price";
            // 
            // srch_option
            // 
            this.srch_option.FormattingEnabled = true;
            this.srch_option.Items.AddRange(new object[] {
            "Card Name",
            "Card ID",
            "Set Name"});
            this.srch_option.Location = new System.Drawing.Point(592, 31);
            this.srch_option.Name = "srch_option";
            this.srch_option.Size = new System.Drawing.Size(121, 23);
            this.srch_option.TabIndex = 25;
            // 
            // card_gridview
            // 
            this.card_gridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.card_gridview.BackgroundColor = System.Drawing.SystemColors.Control;
            this.card_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.card_gridview.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.card_gridview.Location = new System.Drawing.Point(135, 300);
            this.card_gridview.Name = "card_gridview";
            this.card_gridview.RowTemplate.Height = 25;
            this.card_gridview.Size = new System.Drawing.Size(798, 186);
            this.card_gridview.TabIndex = 26;
            this.card_gridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.card_view_CellContentClick);
            // 
            // AddCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 702);
            this.Controls.Add(this.card_gridview);
            this.Controls.Add(this.srch_option);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.api_price);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.card_qnty);
            this.Controls.Add(this.api_ctype);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.api_crace);
            this.Controls.Add(this.rare_label);
            this.Controls.Add(this.api_rare);
            this.Controls.Add(this.set_gridview);
            this.Controls.Add(this.add_bttn);
            this.Controls.Add(this.image_url);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.s_price);
            this.Controls.Add(this.api_setname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.api_setcode);
            this.Controls.Add(this.api_id);
            this.Controls.Add(this.rtv_card);
            this.Controls.Add(this.card_srch);
            this.Controls.Add(this.api_cn);
            this.Controls.Add(this.cn_label);
            this.Name = "AddCardForm";
            this.Text = "AddCardForm";
            this.Load += new System.EventHandler(this.AddCardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.set_gridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card_gridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label cn_label;
        private TextBox api_cn;
        private TextBox card_srch;
        private Button rtv_card;
        private TextBox api_id;
        private TextBox api_setcode;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox api_setname;
        private TextBox s_price;
        private Label label4;
        private TextBox image_url;
        private Button add_bttn;
        private DataGridView set_gridview;
        private TextBox api_rare;
        private Label rare_label;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox api_crace;
        private Label label5;
        private Label label6;
        private TextBox api_ctype;
        private TextBox card_qnty;
        private Label label7;
        private TextBox api_price;
        private Label label8;
        private ComboBox srch_option;
        private DataGridView card_gridview;
    }
}