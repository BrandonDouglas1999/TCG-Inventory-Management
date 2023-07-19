namespace InventoryApp
{
    partial class edit_inventory
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
            card_art_box = new PictureBox();
            label1 = new Label();
            card_id_label = new Label();
            card_name_label = new Label();
            card_type_label = new Label();
            card_race_label = new Label();
            set_id_label = new Label();
            set_name_label = new Label();
            card_rarity_label = new Label();
            label9 = new Label();
            market_price_label = new Label();
            copies_label = new Label();
            store_price_label = new Label();
            remove_button = new Button();
            save_button = new Button();
            cancel_button = new Button();
            ((System.ComponentModel.ISupportInitialize)card_art_box).BeginInit();
            SuspendLayout();
            // 
            // card_art_box
            // 
            card_art_box.Image = Properties.Resources.question_mark;
            card_art_box.Location = new Point(170, 63);
            card_art_box.Name = "card_art_box";
            card_art_box.Size = new Size(240, 340);
            card_art_box.TabIndex = 0;
            card_art_box.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(489, 63);
            label1.Name = "label1";
            label1.Size = new Size(159, 32);
            label1.TabIndex = 1;
            label1.Text = "Card Details:";
            // 
            // card_id_label
            // 
            card_id_label.AutoSize = true;
            card_id_label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            card_id_label.Location = new Point(489, 128);
            card_id_label.Name = "card_id_label";
            card_id_label.Size = new Size(62, 21);
            card_id_label.TabIndex = 2;
            card_id_label.Text = "Card ID";
            // 
            // card_name_label
            // 
            card_name_label.AutoSize = true;
            card_name_label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            card_name_label.Location = new Point(644, 128);
            card_name_label.Name = "card_name_label";
            card_name_label.Size = new Size(89, 21);
            card_name_label.TabIndex = 3;
            card_name_label.Text = "Card Name";
            // 
            // card_type_label
            // 
            card_type_label.AutoSize = true;
            card_type_label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            card_type_label.Location = new Point(489, 175);
            card_type_label.Name = "card_type_label";
            card_type_label.Size = new Size(79, 21);
            card_type_label.TabIndex = 4;
            card_type_label.Text = "Card Type";
            // 
            // card_race_label
            // 
            card_race_label.AutoSize = true;
            card_race_label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            card_race_label.Location = new Point(644, 175);
            card_race_label.Name = "card_race_label";
            card_race_label.Size = new Size(80, 21);
            card_race_label.TabIndex = 5;
            card_race_label.Text = "Card Race";
            // 
            // set_id_label
            // 
            set_id_label.AutoSize = true;
            set_id_label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            set_id_label.Location = new Point(489, 227);
            set_id_label.Name = "set_id_label";
            set_id_label.Size = new Size(51, 21);
            set_id_label.TabIndex = 6;
            set_id_label.Text = "Set ID";
            // 
            // set_name_label
            // 
            set_name_label.AutoSize = true;
            set_name_label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            set_name_label.Location = new Point(644, 227);
            set_name_label.Name = "set_name_label";
            set_name_label.Size = new Size(78, 21);
            set_name_label.TabIndex = 7;
            set_name_label.Text = "Set Name";
            // 
            // card_rarity_label
            // 
            card_rarity_label.AutoSize = true;
            card_rarity_label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            card_rarity_label.Location = new Point(489, 277);
            card_rarity_label.Name = "card_rarity_label";
            card_rarity_label.Size = new Size(88, 21);
            card_rarity_label.TabIndex = 8;
            card_rarity_label.Text = "Card Rarity";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(489, 325);
            label9.Name = "label9";
            label9.Size = new Size(218, 32);
            label9.TabIndex = 9;
            label9.Text = "Inventory Details:";
            // 
            // market_price_label
            // 
            market_price_label.AutoSize = true;
            market_price_label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            market_price_label.Location = new Point(489, 382);
            market_price_label.Name = "market_price_label";
            market_price_label.Size = new Size(97, 21);
            market_price_label.TabIndex = 10;
            market_price_label.Text = "Market Price";
            // 
            // copies_label
            // 
            copies_label.AutoSize = true;
            copies_label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            copies_label.Location = new Point(489, 435);
            copies_label.Name = "copies_label";
            copies_label.Size = new Size(57, 21);
            copies_label.TabIndex = 11;
            copies_label.Text = "Copies";
            // 
            // store_price_label
            // 
            store_price_label.AutoSize = true;
            store_price_label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            store_price_label.Location = new Point(623, 382);
            store_price_label.Name = "store_price_label";
            store_price_label.Size = new Size(84, 21);
            store_price_label.TabIndex = 12;
            store_price_label.Text = "Store Price";
            // 
            // remove_button
            // 
            remove_button.Location = new Point(202, 496);
            remove_button.Name = "remove_button";
            remove_button.Size = new Size(162, 23);
            remove_button.TabIndex = 13;
            remove_button.Text = "Remove from inventory";
            remove_button.UseVisualStyleBackColor = true;
            // 
            // save_button
            // 
            save_button.Location = new Point(389, 496);
            save_button.Name = "save_button";
            save_button.Size = new Size(162, 23);
            save_button.TabIndex = 14;
            save_button.Text = "Save Changes";
            save_button.UseVisualStyleBackColor = true;
            // 
            // cancel_button
            // 
            cancel_button.Location = new Point(571, 496);
            cancel_button.Name = "cancel_button";
            cancel_button.Size = new Size(162, 23);
            cancel_button.TabIndex = 15;
            cancel_button.Text = "Cancel";
            cancel_button.UseVisualStyleBackColor = true;
            // 
            // edit_inventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cancel_button);
            Controls.Add(save_button);
            Controls.Add(remove_button);
            Controls.Add(store_price_label);
            Controls.Add(copies_label);
            Controls.Add(market_price_label);
            Controls.Add(label9);
            Controls.Add(card_rarity_label);
            Controls.Add(set_name_label);
            Controls.Add(set_id_label);
            Controls.Add(card_race_label);
            Controls.Add(card_type_label);
            Controls.Add(card_name_label);
            Controls.Add(card_id_label);
            Controls.Add(label1);
            Controls.Add(card_art_box);
            Name = "edit_inventory";
            Size = new Size(964, 578);
            Load += edit_inventory_Load;
            ((System.ComponentModel.ISupportInitialize)card_art_box).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox card_art_box;
        private Label label1;
        private Label card_id_label;
        private Label card_name_label;
        private Label card_type_label;
        private Label card_race_label;
        private Label set_id_label;
        private Label set_name_label;
        private Label card_rarity_label;
        private Label label9;
        private Label market_price_label;
        private Label copies_label;
        private Label store_price_label;
        private Button remove_button;
        private Button save_button;
        private Button cancel_button;
    }
}
