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
        public String path = "D:\\Users\\hang_\\Documents\\School\\Capstone\\GitHub\\TCG-Inventory-Management-Application\\InventoryApp\\CardImage"; //change this to your!!!
        public double c_rate = 0;
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
        private void cn_label_Click(object sender, EventArgs e)
        {

        }

        private void image_url_TextChanged(object sender, EventArgs e)
        {

        }

        private async void rtv_card_Click(object sender, EventArgs e)
        {
            clear_boxes();
            if (card_srch.Text == "") //no input
            {
                return;
            }
            var card = await CardProcessor.LoadProData(card_srch.Text.ToString()); //retrieve card info, add rate as parameter
            if (card.data == null)
            {
                api_gridview.ColumnCount = 1;
                api_gridview.Columns[0].Name = "No card matching your query was found in the database";
                return;
            }
            //load set info into gridview
            api_gridview.DataSource = card.data[0].card_sets;
            //auto fill some boxes
            api_id.Text = card.data[0].id.ToString();
            api_cn.Text = card.data[0].name;
            api_crace.Text = card.data[0].race;
            api_ctype.Text = card.data[0].type;
            image_url.Text = card.data[0].card_images[0].image_url;
            set_column();
        }

        private void api_gridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                api_setname.Text = api_gridview.Rows[e.RowIndex].Cells[0].Value.ToString();
                api_setcode.Text = api_gridview.Rows[e.RowIndex].Cells[1].Value.ToString();
                api_rare.Text = api_gridview.Rows[e.RowIndex].Cells[3].Value.ToString();
                api_price.Text = api_gridview.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }

        //---------------------------------Functions for inserting card into database---------------------------------------------
        private void InsertCardYGO(string cid, string set_code, string cname, string ctype, string crace, string set_name, string rarity, string price, string inv, string image, string s_price)
        {
            SQLHelper db = new SQLHelper();
            //String image_file = SaveImage(image, cid, set_code); 
            String query = String.Format("Execute AddCard {0}, '{1}', 'YGO', '{2}', '{3}', '{4}', '{5}', '{6}', {7}, {8}, '{9}', '{10}', @stat output",
                            cid, set_code, cname, ctype, crace, rarity, set_name, price, inv, image, s_price);
            MessageBox.Show(query);
            int status = db.InsertCard(query);
            if (status == 0) { MessageBox.Show("Card already in database"); }
            else if (status == 1) { MessageBox.Show("Successfully added card to Inventory"); }
            return;
        }

        private string SaveImage(string url, string card_id, string set_code)
        {
            //change the path 
            String file_name = card_id + set_code + ".jpg";
            String file = path + "\\" + file_name;
            file = file.Replace(@"\\", @"\");
            using (WebClient client = new WebClient())
            {
                client.DownloadFile(new Uri(url), file);
            }
            return file_name;
        }

        private void add_bttn_Click(object sender, EventArgs e)
        {
            int num = 0;
            if (api_rare.Text == "" || api_setcode.Text == "" || api_setname.Text == "" || api_price.Text == "" || card_qnty.Text == "" || s_price.Text == "")
            {
                MessageBox.Show("Missing card information");
                return;
            }
            else if (int.TryParse(card_qnty.Text, out num) == false || int.TryParse(s_price.Text, out num) == false)
            {
                MessageBox.Show("Invalid value for quantity/store price.");
            }
            else
            {
                InsertCardYGO(api_id.Text.ToString(), api_setcode.Text.ToString(), api_cn.Text.ToString(), api_ctype.Text.ToString(), api_crace.Text.ToString(),
                api_setname.Text.ToString(), api_rare.Text.ToString(), api_price.Text.ToString(), card_qnty.Text.ToString(), image_url.Text.ToString(), s_price.Text.ToString());
            }
        }

        //------------------------------------------------------------------------------------------------------------------------

        //-------------------------------------------Others-----------------------------------------------------------------------
        private void clear_boxes()
        {
            api_gridview.DataSource = null;
            api_gridview.Rows.Clear();
            api_gridview.Columns.Clear();
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

        private void set_column()
        {
            api_gridview.Columns["set_name"].HeaderText = "Set Name";
            api_gridview.Columns["set_code"].HeaderText = "Set Code";
            api_gridview.Columns["set_rarity"].HeaderText = "Rarity";
            api_gridview.Columns["set_rarity_code"].HeaderText = "Rarity Code";
            api_gridview.Columns["set_price"].HeaderText = "Current Price";
            //set up button for selecting which card version
            DataGridViewButtonColumn select = new DataGridViewButtonColumn();
            select.Text = "Select";
            select.UseColumnTextForButtonValue = true;
            api_gridview.Columns.Add(select);

        }
    }
}
