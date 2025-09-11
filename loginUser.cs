using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

using static System.Windows.Forms.AxHost;
using System.Diagnostics.Eventing.Reader;


namespace GAMEZONE
{
    public partial class loginUser : Form


    {
        string usertype;
        string email;
        string password;
        public loginUser()
        {
            InitializeComponent();
        }

        private void loginUser_Load(object sender, EventArgs e)
        {
            cmbbxUserType.Items.Clear();
            cmbbxUserType.Items.Add("Admin");
            cmbbxUserType.Items.Add("player");
        }

        private void cmbbxUserType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtbxUserEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string UserType = cmbbxUserType.Text;
            string Email = txtbxUserEmail.Text;
            string Password = txtbxPassword.Text;

            clsGameZone objGame = new clsGameZone(cmbbxUserType.Text, txtbxUserEmail.Text, txtbxPassword.Text);
            SqlDataReader dr;
            dr = objGame.GetLoginData();
            while (dr.Read())
            {
                usertype = dr["Type"].ToString();
                email = dr["Email"].ToString();
                password = dr["Password"].ToString();
            }

            if (UserType == usertype && Email == email && Password == password)
            {
                if (cmbbxUserType.Text == "Admin")
                {
                    Admin main = new Admin();
                    main.Show();

                }
                else 
                {

                    Player main1 = new Player(email);
                    main1.Show();
                }


            }
            else
            {
                MessageBox.Show("invalid email and password");
            }


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbbxUserType.Text = " ";
            txtbxUserEmail.Text = " ";
            txtbxPassword.Text = " ";
        }
    }
}