using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Security.Cryptography;
using System.Net.Configuration;
using System.Diagnostics;

namespace GAMEZONE
{

   
    internal class clsGameZone
    {
        SqlConnection con = new SqlConnection("Data Source=ROHITS_LAPY;Initial Catalog=GameZone;Integrated Security=True;Encrypt=False");


        // define property
        public int UserID {  get; set; }
        //public int Id {get; set;}
        public string UserType { get; set; }
        public string UserName { get; set; }    

        public  string Passward {  get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string State { get; set; }

        public string City { get; set; }            

        public string Gender { get; set; }

        public string Gamingmode { get; set; }

        public string GameType { get; set; }

        public string Game { get; set; }

        public int MODEID { get; set; }

        public int TypeID { get; set; }

        public string Games {  get; set; }

        public string Duration { get; set; }

        public decimal Price {  get; set; }

        public DateTime Date { get; set; }

        public string PlayerName { get; set; }

        public int DurationID { get; set; }

        public int PlayerID { get; set; }

        public int GameID { get; set; }



        //empty constructor
        public clsGameZone()
        {

        }

        //Parameterize constructor
        public clsGameZone(string playername,string game,string duration,decimal price,DateTime date)
        {
            PlayerName = playername;
            Game = game;
            Duration = duration;
            Price = price;
            Date = date;
            
        }
        public clsGameZone (string email,string usertype)
        {
            Email = email;
            UserType = usertype;
        }
            
        public clsGameZone(int Typeid, int MODEid,int Gameid, string duration,decimal price , DateTime date)
        {

            TypeID = Typeid;
            MODEID = MODEid;
            GameID = Gameid;
            Duration = duration;
             Price = price;
            Date = date;

        }
        public clsGameZone(int typeid, string game, DateTime date)
        {
            TypeID = typeid;
            Game = game;
            

            Date = date;
        }


        public clsGameZone(string Usertype, string email,string passward)
        {
            UserType = Usertype;
            Email = email;
            Passward = passward;
        }
        public clsGameZone( string Usertype, string name, string passward, string email, string phone, string state, string city, string gender) { 
        
            UserType = Usertype; 
            UserName = name;
            Passward = passward;    
            Email = email;
            Phone = phone; 
            State = state; 
            City = city;
            Gender = gender;
        
        }
        public clsGameZone( int id ,string Usertype, string name, string passward, string email, string phone, string state, string city, string gender)
        {
            UserID = id;
            UserType = Usertype;
            UserName = name;
            Passward = passward;
            Email = email;
            Phone = phone;
            State = state;
            City = city;
            Gender = gender;

        }
        public clsGameZone(int id)
        {
            MODEID = id;
        }
        public clsGameZone(string gamingmode)
        {
            Gamingmode=gamingmode;
        }

        public clsGameZone(int id, string gametype)
        {
            MODEID = id;
            GameType=gametype;
        }
  
        // function
        public void SaveData()
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("GameZone", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "SaveData");
            cmd.Parameters.AddWithValue("@type", UserType );
            cmd.Parameters.AddWithValue("@Name", UserName);     //parameters
            cmd.Parameters.AddWithValue("@password", Passward);
            cmd.Parameters.AddWithValue("@email", Email);       //cmd - commands
            cmd.Parameters.AddWithValue("@phone", Phone);
            cmd.Parameters.AddWithValue("@state", State);
            cmd.Parameters.AddWithValue("@city", City);
            cmd.Parameters.AddWithValue("@gender", Gender);

            cmd.ExecuteNonQuery();

            con.Close();
        } 
        public SqlDataReader GetLoginData()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("GameZone", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag","SaveLoginData");
            cmd.Parameters.AddWithValue("@type", UserType);
            cmd.Parameters.AddWithValue("@email", Email);
            cmd.Parameters.AddWithValue("@password", Passward);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }
        public void SaveGamingMode()
        {
        
            con.Open();
            SqlCommand cmd = new SqlCommand("GameZone", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "SaveGamingData");
            cmd.Parameters.AddWithValue("@GamingMode",Gamingmode);
            cmd.ExecuteNonQuery();
            con.Close() ;
        }
        public void SaveGamingType()
        { 
        
            con.Open();
            SqlCommand cmd = new SqlCommand("GameZone", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "SaveGamingType");
            cmd.Parameters.AddWithValue("@GAMINGTYPE", GameType);
            cmd.Parameters.AddWithValue("@MODEID", MODEID);
 
            cmd.ExecuteNonQuery();
            con.Close() ;
        }
        public void savegames()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("GameZone", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "SaveGames");
            cmd.Parameters.AddWithValue("@TypeID", TypeID);
            cmd.Parameters.AddWithValue("@Games", Game);
          //cmd.Parameters.AddWithValue("@Duration", Duration);
          //cmd.Parameters.AddWithValue("@Price", Price);
          //cmd.Parameters.AddWithValue("@Date", Date);
          //cmd.Parameters.AddWithValue("")
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public DataTable fetchGamingmode()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("GameZone", con);
            cmd.CommandType= CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "FetchGamingMode");
            cmd.Parameters.AddWithValue("@ID", UserID);
            //cmd.Parameters.AddWithValue("@MODEID", MODEID );
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
        }
        //public DataTable fetchgamingtype()
        //{
        //    con.Open();
        //    SqlCommand cmd = new SqlCommand("GameZone", con);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.AddWithValue("@Flag", "FetchGamingType");
        //    cmd.Parameters.AddWithValue("ID",MODEID);
        //    //cmd.Parameters.AddWithValue("@GamingMode", Gamingmode);
        //    SqlDataAdapter adpt = new SqlDataAdapter();
        //    DataTable dt = new DataTable();
        //    adpt.Fill(dt);
        //    return dt;
        //    //con.Close();
        //}

        //public DataTable Fetchgametype2()
        //{
        //    con.Open() ;
        //    SqlCommand cmd = new SqlCommand("GameZone", con);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.AddWithValue("@Flag", "FetchGametype1");
        //    cmd.Parameters.AddWithValue("@GamingMode", Gamingmode);
        //    SqlDataAdapter adpt = new SqlDataAdapter();
        //    DataTable dt = new DataTable();
        //    adpt.Fill(dt);
        //    return dt;
        //    //con.Close() ;

         
        //}
        public DataTable FetchGamingType()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("GameZone", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "Fetchgames");
            cmd.Parameters.AddWithValue("@ID", MODEID);
           // cmd.Parameters.AddWithValue("@TypeID", TypeID);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            con.Close();
            return dt;
         }
        public DataTable FetchGame()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("GameZone",con);
            cmd.CommandType= CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "FetchGame");
            cmd.Parameters.AddWithValue("@TypeID", MODEID);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            con.Close();
            return dt;
        }
        public void saveplayerdata()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("GameZone", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "SaveplayerData");
            cmd.Parameters.AddWithValue("@MODEID", MODEID);
            cmd.Parameters.AddWithValue("@TypeID", TypeID);
            cmd.Parameters.AddWithValue("@GameID", GameID);
            cmd.Parameters.AddWithValue("@Duration", Duration);
            cmd.Parameters.AddWithValue("@price", Price);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        //public DataTable FetchGamesByTypes()
        //{
        //    con.Open();
        //    SqlCommand cmd = new SqlCommand("GameZone", con);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.AddWithValue("@Flag", "Fetchgames");
        //    cmd.Parameters.AddWithValue("@ID", MODEID);
        //    cmd.Parameters.AddWithValue("@TypeID", TypeID);
        //    SqlDataAdapter adpt = new SqlDataAdapter(cmd);
        //    DataTable dt = new DataTable();
        //    adpt.Fill(dt);
        //    con.Close();
        //    return dt;
        //}
        public DataTable ShowAllGames()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("GameZone", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "ShowAllGames");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            con.Close();
            return dt;

        }
         public DataTable fetchDuration()
         {
            con.Open();
            SqlCommand cmd = new SqlCommand("GameZone", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "FetchDuration");
            cmd.Parameters.AddWithValue("@GameID",MODEID);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            con.Close();
            return dt;
         }

        public DataTable FetchPrice()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("GameZone", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "FetchPrice");
            cmd.Parameters.AddWithValue("@DurationID", MODEID);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            con.Close();
            return dt;
            
        }
        public DataTable FetchUser()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("GameZone", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag","FetchUser");
            cmd.Parameters.AddWithValue("@email", Email);
            cmd.Parameters.AddWithValue("@type", UserType);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;

        }
        public void SaveOneTime()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("GameZone", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "SaveOneTime");
            cmd.Parameters.AddWithValue("@PlayerName",PlayerName);
            cmd.Parameters.AddWithValue("@Games", Game);
            cmd.Parameters.AddWithValue("@Duration",Duration);
            cmd.Parameters.AddWithValue("@price",Price);
            cmd.Parameters.AddWithValue("@Date",Date);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}

