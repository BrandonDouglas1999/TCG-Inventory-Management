namespace InventoryApp
{
    partial class EditCardForm
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
            this.CardImage = new System.Windows.Forms.PictureBox();
            this.delete_card = new System.Windows.Forms.Button();
            this.upate_card = new System.Windows.Forms.Button();
            this.cancel_bttn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.card_details_panel = new System.Windows.Forms.Panel();
            this.market_price = new System.Windows.Forms.TextBox();
            this.card_rarity = new System.Windows.Forms.TextBox();
            this.set_name = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.set_code = new System.Windows.Forms.TextBox();
            this.card_race = new System.Windows.Forms.TextBox();
            this.card_type = new System.Windows.Forms.TextBox();
            this.card_name = new System.Windows.Forms.TextBox();
            this.card_id = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.inventory_panel = new System.Windows.Forms.Panel();
            this.card_copies = new System.Windows.Forms.TextBox();
            this.store_price = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CardImage)).BeginInit();
            this.card_details_panel.SuspendLayout();
            this.inventory_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CardImage
            // 
            this.CardImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CardImage.Location = new System.Drawing.Point(216, 110);
            this.CardImage.Name = "CardImage";
            this.CardImage.Size = new System.Drawing.Size(297, 378);
            this.CardImage.TabIndex = 0;
            this.CardImage.TabStop = false;
            // 
            // delete_card
            // 
            this.delete_card.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(60)))));
            this.delete_card.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.delete_card.ForeColor = System.Drawing.Color.White;
            this.delete_card.Location = new System.Drawing.Point(303, 574);
            this.delete_card.Name = "delete_card";
            this.delete_card.Size = new System.Drawing.Size(160, 45);
            this.delete_card.TabIndex = 1;
            this.delete_card.Text = "Delete From Inventory";
            this.delete_card.UseVisualStyleBackColor = false;
            this.delete_card.Click += new System.EventHandler(this.delete_card_Click);
            // 
            // upate_card
            // 
            this.upate_card.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(60)))));
            this.upate_card.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.upate_card.ForeColor = System.Drawing.Color.White;
            this.upate_card.Location = new System.Drawing.Point(546, 574);
            this.upate_card.Name = "upate_card";
            this.upate_card.Size = new System.Drawing.Size(160, 45);
            this.upate_card.TabIndex = 2;
            this.upate_card.Text = "Save Changes";
            this.upate_card.UseVisualStyleBackColor = false;
            // 
            // cancel_bttn
            // 
            this.cancel_bttn.BackColor = System.Drawing.SystemColors.Control;
            this.cancel_bttn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cancel_bttn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(60)))));
            this.cancel_bttn.Location = new System.Drawing.Point(790, 574);
            this.cancel_bttn.Name = "cancel_bttn";
            this.cancel_bttn.Size = new System.Drawing.Size(160, 45);
            this.cancel_bttn.TabIndex = 3;
            this.cancel_bttn.Text = "Cancel";
            this.cancel_bttn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(60)))));
            this.label1.Location = new System.Drawing.Point(546, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Card Details:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(15, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Card ID";
            // 
            // card_details_panel
            // 
            this.card_details_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.card_details_panel.Controls.Add(this.market_price);
            this.card_details_panel.Controls.Add(this.card_rarity);
            this.card_details_panel.Controls.Add(this.set_name);
            this.card_details_panel.Controls.Add(this.label10);
            this.card_details_panel.Controls.Add(this.set_code);
            this.card_details_panel.Controls.Add(this.card_race);
            this.card_details_panel.Controls.Add(this.card_type);
            this.card_details_panel.Controls.Add(this.card_name);
            this.card_details_panel.Controls.Add(this.card_id);
            this.card_details_panel.Controls.Add(this.label9);
            this.card_details_panel.Controls.Add(this.label8);
            this.card_details_panel.Controls.Add(this.label7);
            this.card_details_panel.Controls.Add(this.label6);
            this.card_details_panel.Controls.Add(this.label5);
            this.card_details_panel.Controls.Add(this.label4);
            this.card_details_panel.Controls.Add(this.label2);
            this.card_details_panel.Location = new System.Drawing.Point(546, 84);
            this.card_details_panel.Name = "card_details_panel";
            this.card_details_panel.Size = new System.Drawing.Size(508, 284);
            this.card_details_panel.TabIndex = 6;
            // 
            // market_price
            // 
            this.market_price.Cursor = System.Windows.Forms.Cursors.No;
            this.market_price.Location = new System.Drawing.Point(142, 233);
            this.market_price.Name = "market_price";
            this.market_price.ReadOnly = true;
            this.market_price.Size = new System.Drawing.Size(100, 23);
            this.market_price.TabIndex = 19;
            // 
            // card_rarity
            // 
            this.card_rarity.Cursor = System.Windows.Forms.Cursors.No;
            this.card_rarity.Location = new System.Drawing.Point(17, 233);
            this.card_rarity.Name = "card_rarity";
            this.card_rarity.ReadOnly = true;
            this.card_rarity.Size = new System.Drawing.Size(100, 23);
            this.card_rarity.TabIndex = 18;
            // 
            // set_name
            // 
            this.set_name.Cursor = System.Windows.Forms.Cursors.No;
            this.set_name.Location = new System.Drawing.Point(142, 168);
            this.set_name.Name = "set_name";
            this.set_name.ReadOnly = true;
            this.set_name.Size = new System.Drawing.Size(300, 23);
            this.set_name.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label10.Location = new System.Drawing.Point(143, 209);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 21);
            this.label10.TabIndex = 11;
            this.label10.Text = "Market Price";
            // 
            // set_code
            // 
            this.set_code.Cursor = System.Windows.Forms.Cursors.No;
            this.set_code.Location = new System.Drawing.Point(17, 168);
            this.set_code.Name = "set_code";
            this.set_code.ReadOnly = true;
            this.set_code.Size = new System.Drawing.Size(100, 23);
            this.set_code.TabIndex = 16;
            // 
            // card_race
            // 
            this.card_race.Cursor = System.Windows.Forms.Cursors.No;
            this.card_race.Location = new System.Drawing.Point(17, 98);
            this.card_race.Name = "card_race";
            this.card_race.ReadOnly = true;
            this.card_race.Size = new System.Drawing.Size(100, 23);
            this.card_race.TabIndex = 15;
            // 
            // card_type
            // 
            this.card_type.Cursor = System.Windows.Forms.Cursors.No;
            this.card_type.Location = new System.Drawing.Point(142, 98);
            this.card_type.Name = "card_type";
            this.card_type.ReadOnly = true;
            this.card_type.Size = new System.Drawing.Size(100, 23);
            this.card_type.TabIndex = 14;
            // 
            // card_name
            // 
            this.card_name.Cursor = System.Windows.Forms.Cursors.No;
            this.card_name.Location = new System.Drawing.Point(142, 33);
            this.card_name.Name = "card_name";
            this.card_name.ReadOnly = true;
            this.card_name.Size = new System.Drawing.Size(300, 23);
            this.card_name.TabIndex = 13;
            // 
            // card_id
            // 
            this.card_id.Cursor = System.Windows.Forms.Cursors.No;
            this.card_id.Location = new System.Drawing.Point(17, 33);
            this.card_id.Name = "card_id";
            this.card_id.ReadOnly = true;
            this.card_id.Size = new System.Drawing.Size(100, 23);
            this.card_id.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label9.Location = new System.Drawing.Point(17, 209);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 21);
            this.label9.TabIndex = 11;
            this.label9.Text = "Rarity";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label8.Location = new System.Drawing.Point(143, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 21);
            this.label8.TabIndex = 10;
            this.label8.Text = "Set Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label7.Location = new System.Drawing.Point(16, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 21);
            this.label7.TabIndex = 9;
            this.label7.Text = "Set Code";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label6.Location = new System.Drawing.Point(142, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 21);
            this.label6.TabIndex = 8;
            this.label6.Text = "Card Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label5.Location = new System.Drawing.Point(15, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Card Race";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label4.Location = new System.Drawing.Point(142, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Card Name";
            // 
            // inventory_panel
            // 
            this.inventory_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inventory_panel.Controls.Add(this.card_copies);
            this.inventory_panel.Controls.Add(this.store_price);
            this.inventory_panel.Controls.Add(this.label12);
            this.inventory_panel.Controls.Add(this.label11);
            this.inventory_panel.Location = new System.Drawing.Point(546, 410);
            this.inventory_panel.Name = "inventory_panel";
            this.inventory_panel.Size = new System.Drawing.Size(508, 99);
            this.inventory_panel.TabIndex = 6;
            // 
            // card_copies
            // 
            this.card_copies.Cursor = System.Windows.Forms.Cursors.No;
            this.card_copies.Location = new System.Drawing.Point(142, 38);
            this.card_copies.Name = "card_copies";
            this.card_copies.ReadOnly = true;
            this.card_copies.Size = new System.Drawing.Size(100, 23);
            this.card_copies.TabIndex = 20;
            // 
            // store_price
            // 
            this.store_price.Cursor = System.Windows.Forms.Cursors.No;
            this.store_price.Location = new System.Drawing.Point(17, 38);
            this.store_price.Name = "store_price";
            this.store_price.ReadOnly = true;
            this.store_price.Size = new System.Drawing.Size(100, 23);
            this.store_price.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label12.Location = new System.Drawing.Point(142, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 21);
            this.label12.TabIndex = 13;
            this.label12.Text = "Copies";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label11.Location = new System.Drawing.Point(17, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 21);
            this.label11.TabIndex = 12;
            this.label11.Text = "Store Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(60)))));
            this.label3.Location = new System.Drawing.Point(546, 384);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Inventory:";
            // 
            // EditCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 671);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inventory_panel);
            this.Controls.Add(this.card_details_panel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancel_bttn);
            this.Controls.Add(this.upate_card);
            this.Controls.Add(this.delete_card);
            this.Controls.Add(this.CardImage);
            this.Name = "EditCardForm";
            this.Text = "EditCardForm";
            ((System.ComponentModel.ISupportInitialize)(this.CardImage)).EndInit();
            this.card_details_panel.ResumeLayout(false);
            this.card_details_panel.PerformLayout();
            this.inventory_panel.ResumeLayout(false);
            this.inventory_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox CardImage;
        private Button delete_card;
        private Button upate_card;
        private Button cancel_bttn;
        private Label label1;
        private Label label2;
        private Panel card_details_panel;
        private Panel inventory_panel;
        private Label label3;
        private Label label5;
        private Label label4;
        private Label label7;
        private Label label6;
        private Label label9;
        private Label label8;
        private Label label10;
        private Label label12;
        private Label label11;
        private TextBox card_id;
        private TextBox market_price;
        private TextBox card_rarity;
        private TextBox set_name;
        private TextBox set_code;
        private TextBox card_race;
        private TextBox card_type;
        private TextBox card_name;
        private TextBox card_copies;
        private TextBox store_price;
    }
}