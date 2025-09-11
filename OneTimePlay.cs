using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GAMEZONE
{

    public partial class OneTimePlay : Form
    {
        public string Name {  get; set; }
        //public decimal price;
        public OneTimePlay(string PlayerName)
        {

            InitializeComponent();
            Name = PlayerName;
        }
        public int userid { get; set; }

        private void OneTimePlay_Load(object sender, EventArgs e)
        {
          txtbxName.Text = Name;
            clsGameZone OBJ = new clsGameZone();
            DataTable dt = new DataTable();
            dt = OBJ.fetchGamingmode();
            CMBBXGAMEMODEONETIME.ValueMember = "ID";
            CMBBXGAMEMODEONETIME.DisplayMember = "GAMINGMODE";
            CMBBXGAMEMODEONETIME.DataSource = dt;

        }

        private void CMBBXGAMEMODEONETIME_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(CMBBXGAMEMODEONETIME.SelectedValue.ToString());
            clsGameZone objOnline = new clsGameZone(id);
            DataTable dtT = new DataTable();
            dtT = objOnline.FetchGamingType();
            CMBBXGAMETYPEONETIME.ValueMember = "ID";
            CMBBXGAMETYPEONETIME.DisplayMember = "GAMINGTYPE";
            CMBBXGAMETYPEONETIME.DataSource = dtT;
        }

        private void CMBBXGAMETYPEONETIME_SelectedIndexChanged(object sender, EventArgs e)
        {
            int TypeID = Convert.ToInt32(CMBBXGAMETYPEONETIME.SelectedValue.ToString());

            clsGameZone objD = new clsGameZone(TypeID);
            DataTable dtD = new DataTable();
            dtD = objD.FetchGame();
            CMBBXGAMESONETIME.ValueMember = "TypeID";
            CMBBXGAMESONETIME.DisplayMember = "Games";
            CMBBXGAMESONETIME.DataSource = dtD;
        }

        private void CMBBXDURATIONONETIME_SelectedIndexChanged(object sender, EventArgs e)
        {
            int TypeId = Convert.ToInt32(CMBBXDURATIONONETIME.SelectedValue.ToString());

            clsGameZone obJ = new clsGameZone(TypeId);
            DataTable dt = new DataTable();
            dt = obJ.FetchPrice();
            TXTBXPRICEONETIME.Text = dt.Rows[0]["Price"].ToString();

        }

        private void CMBBXGAMESONETIME_SelectedIndexChanged(object sender, EventArgs e)
        {
            int TypeId = Convert.ToInt32(CMBBXGAMESONETIME.SelectedValue.ToString());

            clsGameZone obJ = new clsGameZone(TypeId);
            DataTable dt = new DataTable();
            dt = obJ.fetchDuration();
            CMBBXDURATIONONETIME.ValueMember = "DurationID";
            CMBBXDURATIONONETIME.DisplayMember = "Duration";
            CMBBXDURATIONONETIME.DataSource = dt;
          
        }

        private void BTNBOOKONETIMEPACKAGE_Click(object sender, EventArgs e)
        {
            string playername = txtbxName.Text;
            string game = CMBBXGAMESONETIME.SelectedText.ToString();
            string duration = CMBBXDURATIONONETIME.Text;
            decimal price = Convert.ToDecimal(TXTBXPRICEONETIME.Text);
            DateTime date = DateTime.Now;


            clsGameZone obj = new clsGameZone(playername, game, duration, price, date);
            obj.SaveOneTime();
            MessageBox.Show("your data saved succesfully");
        }
    }
    }

