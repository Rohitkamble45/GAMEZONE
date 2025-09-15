using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

using System.Data.SqlClient;


namespace GAMEZONE
{
    public partial class RegisterUser : Form

    { 
    
    
        public RegisterUser()
        {
            InitializeComponent();
        }

        private void cmbbxUserType_SelectedIndexChanged(object sender, EventArgs e)
        {
            uuuuuuplokiujynbfvrtyujpoiufc;lkjfdfjklkjfdjkjfdd;

        }

        private void RegisterUser_Load(object sender, EventArgs e)
        {
            cmbbxUserType.Items.Clear();
            cmbbxUserType.Items.Add("Admin");
            cmbbxUserType.Items.Add("player");

            cmbbxUserState.Items.Add("MAHARASTRA");
            cmbbxUserState.Items.Add("GUJRAT");
            cmbbxUserState.Items.Add("SOUTH INDIA");
            //cmbbxUserState.Items.Add("MADHAPRADESH");
            //cmbbxUserState.Items.Add("UTTERPRADESH");
            //cmbbxUserState.Items.Add("DELLI");
        }

        private void btnUserSave_Click(object sender, EventArgs e)
        {
            string Type = cmbbxUserType.Text;
            string Name = txtbxUserName.Text;
            string Passward = txtbxUserPassword.Text;
            string Email = txtbxUserEmail.Text;
            string Phone = txtbxUserPhone.Text;
            string State = cmbbxUserState.Text;
            string City = cmbbxUserCity.Text;
            string Gender = cmbbxUserGender.Text;

            clsGameZone obj = new clsGameZone(Type, Name, Passward, Email, Phone, State, City, Gender);
            obj.SaveData();
            MessageBox.Show("Your data Successfully Saved....");


        }

        private void cmbbxUserState_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbbxUserCity.Items.Clear();
            if (cmbbxUserState.SelectedItem.ToString() == "MAHARASTRA")
            {
                cmbbxUserCity.Items.Add("Pune");
                cmbbxUserCity.Items.Add("Mumbai"); 
                cmbbxUserCity.Items.Add("Beed");

            }
            if (cmbbxUserState.SelectedItem.ToString() == "GUJRAT")
            {
                cmbbxUserCity.Items.Add("Surat");
                cmbbxUserCity.Items.Add("Vadodra");
                cmbbxUserCity.Items.Add("Bhavniagar");

            }
            if (cmbbxUserState.SelectedItem.ToString() == "SOUTH INDIA")
            {
                cmbbxUserCity.Items.Add("Banglore");
                cmbbxUserCity.Items.Add("Hydrabad");
                cmbbxUserCity.Items.Add("Chennai");
            }
            //if (cmbbxUserState.SelectedItem.ToString() == "MADHEPRADESH")
            //{
            //    cmbbxUserCity.Items.Add("bhopal");
            //    cmbbxUserCity.Items.Add("indore");
            //    cmbbxUserCity.Items.Add("ujjain");

            //}
            //if (cmbbxUserState.SelectedItem.ToString() == "UTTERPRADESH")
            //{
            //    cmbbxUserCity.Items.Add("lucknow");
            //    cmbbxUserCity.Items.Add("kanpur");
            //    cmbbxUserCity.Items.Add("badoda");

            //}
            //if (cmbbxUserState.SelectedItem.ToString() == "PUNJAB")
            //{
            //    cmbbxUserCity.Items.Add("jalandar");
            //    cmbbxUserCity.Items.Add("kapurthala");
            //    cmbbxUserCity.Items.Add("mansa");

            //}

        }

        private void btnUserShow_Click(object sender, EventArgs e)
        {
            //con.Open();
            //SqlCommand cmd = new SqlCommand("select * from tblRegister where ID = '"+txtbxUserId.Text+"'", con);
            //SqlDataReader dr;
            //dr = cmd.ExecuteReader();

            //while(dr.Read())
            //{
            //    cmbbxUserType.Text = dr["Type"].ToString();
            //    txtbxUserName.Text = dr["Name"].ToString();
            //    txtbxUserPassword.Text = dr["Password"].ToString();
            //    txtbxUserEmail.Text = dr["email"].ToString();
            //    txtbxUserPhone.Text = dr["Phone"].ToString();
            //    cmbbxUserState.Text = dr["State"].ToString();
            //    cmbbxUserCity.Text = dr["City"].ToString() ;
            //    cmbbxUserGender.Text = dr["gender"].ToString();
            //}

            //dr.Close();
            //con.Close();
            //int Id =  ( Convert.ToInt32( txtbxUserId.Text));
            //string Type = cmbbxUserType.Text;
            //string Name = txtbxUserName.Text;
            //string Passward = txtbxUserPassword.Text;
            //string Email = txtbxUserEmail.Text;
            //string Phone = txtbxUserPhone.Text;
            //string State = cmbbxUserState.Text;
            //string City = cmbbxUserCity.Text;
            //string Gender = cmbbxUserGender.Text;

            //clsGameZone obj = new clsGameZone(Id,Type, Name, Passward, Email, Phone, State, City, Gender);
            //obj.SaveData();
            


        }

        private void btnUserClear_Click(object sender, EventArgs e)
        {
            //int Id = (Convert.ToInt32(txtbxUserId.Text));
            //clsGameZone obj = new clsGameZone(Id);
            //obj.ClearData();
            //MessageBox.Show("Your Data is clear");

            cmbbxUserType.Text = " ";
            txtbxUserName.Text = " ";
            txtbxUserEmail.Text = " ";
            cmbbxUserGender.Text = " ";
            txtbxUserPhone.Text = " ";


            cmbbxUserState.Text = string.Empty;
            cmbbxUserCity.Text = string.Empty;
            txtbxUserPassword.Text = " ";


        }

        private void txtbxUserId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbxUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbbxUserGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}