using InventoryApp.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryApp.API_Model;
using InventoryApp.Processors;
using static System.Net.Mime.MediaTypeNames;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Diagnostics;
using System.Security.AccessControl;
using System.IO;

namespace InventoryApp
{
    public partial class add_cards : UserControl
    {
        public String path = @"D:\Users\hang_\Documents\School\Capstone\GitHub\TCG-Inventory-Management-Application\InventoryApp\CardImage"; //change this to your!!!
        public double c_rate = 0;
        public string uid = null;
        YGOProCard card;

        public add_cards()
        {
            InitializeComponent();
            APIHelper.InitializeClient();
        }

        //load conversion rate on opening
        private void AddCardForm_Load(object sender, EventArgs e)
        {
            //var rate = await ConversionRate.LoadRate();
            //c_rate = rate.db_rate;
        }

        private async void rtv_card_Click(object sender, EventArgs e)
        {
            clear_boxes();
            if (card_srch.Text == "") //no input
            {
                return;
            }
            switch (srch_option.SelectedIndex)
            {
                case 0: //search card by name
                    card = await CardProcessor.LoadProData(0, card_srch.Text.ToString());
                    break;
                case 1: //search by card ID
                    card = await CardProcessor.LoadProData(1, card_srch.Text.ToString());
                    break;
                case 2: //search set
                    card = await CardProcessor.LoadProData(2, card_srch.Text.ToString());
                    break;
                default:
                    return;
            }
            if (card.data == null)
            {
                card_gridview.ColumnCount= 1;
                card_gridview.Columns[0].Name = "No card data matching your query was found in the database";
                return;
            }
            //Load card lsit from api return into gridview
            card_gridview.DataSource = card.data;
            //addbutton to cell
            cardinfo_columns();
        }

        private void card_view_CellContentClick(object sender, DataGridViewCellEventArgs e) 
        {
            if (e.ColumnIndex == 4 && e.RowIndex >= 0)
            {
                //Fill boxes with the card info and load set info into api_gridview
                api_id.Text = card.data[e.RowIndex].id.ToString();
                api_cn.Text = card.data[e.RowIndex].name;
                api_crace.Text = card.data[e.RowIndex].race;
                api_ctype.Text = card.data[e.RowIndex].type;
                image_url.Text = card.data[e.RowIndex].card_images[0].image_url;
                foreach (DataGridViewRow r in card_gridview.Rows)
                {
                    r.DefaultCellStyle.BackColor = Color.White;
                } 
                card_gridview.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Aqua;
                load_set(e.RowIndex);
                setinfo_column();
            }
        } 

        private void api_gridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5 && e.RowIndex >= 0)
            {
                //fill boxes with the selected set information
                api_setname.Text = set_gridview.Rows[e.RowIndex].Cells[0].Value.ToString();
                api_setcode.Text = set_gridview.Rows[e.RowIndex].Cells[1].Value.ToString();
                api_rare.Text = set_gridview.Rows[e.RowIndex].Cells[3].Value.ToString();
                api_price.Text = set_gridview.Rows[e.RowIndex].Cells[4].Value.ToString();
                foreach (DataGridViewRow r in set_gridview.Rows)
                {
                    r.DefaultCellStyle.BackColor = Color.White;
                }
                set_gridview.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Aqua;
            }
        }

        //---------------------------------Functions for inserting card into database---------------------------------------------
        private void InsertCardYGO(string uid, string cid, string set_code, string cname, string ctype, string crace, string set_name, string rarity, string price, string inv, string image, string s_price)
        {
            SQLHelper db = new SQLHelper();
            int status = db.InsertCard(uid, cid, set_code, cname, ctype, crace, set_name, rarity, price, inv, image, s_price);
            if (status == 0) { MessageBox.Show("Card already in database"); }
            else if (status == 1) { MessageBox.Show("Successfully added card to Inventory"); }
            return;
        }

        private void add_bttn_Click(object sender, EventArgs e)
        {
            int num;
            float num2;
            if (api_rare.Text == "" || api_setcode.Text == "" || api_setname.Text == "" || api_price.Text == "" || card_qnty.Text == "" || s_price.Text == "")
            {
                MessageBox.Show("Missing card information");
                return;
            }
            else if (int.TryParse(card_qnty.Text, out num) == false || float.TryParse(s_price.Text, out num2) == false)
            {
                MessageBox.Show("Invalid value for quantity/store price.");
            }
            else 
            {
                InsertCardYGO(uid, api_id.Text.ToString(), api_setcode.Text.ToString(), api_cn.Text.ToString(), api_ctype.Text.ToString(), api_crace.Text.ToString(),
                api_setname.Text.ToString(), api_rare.Text.ToString(), api_price.Text.ToString(), card_qnty.Text.ToString(), image_url.Text.ToString(), s_price.Text.ToString());
            }
        }

        //------------------------------------------------------------------------------------------------------------------------

        //-------------------------------------------Others-----------------------------------------------------------------------
        private void clear_boxes()
        {
            card_gridview.DataSource = null;
            set_gridview.DataSource = null;
            card_gridview.Columns.Clear();
            set_gridview.Columns.Clear();
            api_id.Text = "";
            api_cn.Text = "";
            api_crace.Text = "";
            api_ctype.Text = "";
            image_url.Text = "";
            s_price.Text = "";
            card_qnty.Text = "";
            api_setcode.Text = "";
            api_setname.Text = "";
            api_price.Text = "";
            api_rare.Text = "";
        }

        //Function to load set info of the selected card
        private void load_set(int index) 
        {
            set_gridview.DataSource = null;
            api_setcode.Text = "";
            api_setname.Text = "";
            api_price.Text = "";
            api_rare.Text = "";
            set_gridview.Columns.Clear();
            set_gridview.DataSource = card.data[index].card_sets;
        }

        //Change header name and add select button for set gridview
        private void setinfo_column()
        {
            set_gridview.Columns["set_name"].HeaderText = "Set Name";
            set_gridview.Columns["set_code"].HeaderText = "Set Code";
            set_gridview.Columns["set_rarity"].HeaderText = "Rarity";
            set_gridview.Columns["set_rarity_code"].HeaderText = "Rarity Code";
            set_gridview.Columns["set_price"].HeaderText = "Current Price";
            //set up button for selecting which card version
            DataGridViewButtonColumn select = new DataGridViewButtonColumn();
            select.Text = "Select";
            select.UseColumnTextForButtonValue = true;
            set_gridview.Columns.Add(select);
            //set_gridview.EnableHeadersVisualStyles = false;
            set_gridview.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 26, 28, 60);
            set_gridview.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void cardinfo_columns ()
        {
            card_gridview.Columns["id"].HeaderText = "Card ID";
            card_gridview.Columns["name"].HeaderText = "Card Name";
            card_gridview.Columns["type"].HeaderText = "Card Type";
            card_gridview.Columns["race"].HeaderText = "Card Race";
            DataGridViewButtonColumn card_select = new DataGridViewButtonColumn();
            card_select.Text = "Select";
            card_select.UseColumnTextForButtonValue = true;
            card_gridview.Columns.Add(card_select);
            //card_gridview.EnableHeadersVisualStyles = false;
            card_gridview.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 26, 28, 60);
            card_gridview.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
    }
}
