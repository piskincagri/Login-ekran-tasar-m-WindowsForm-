using market.enumaration;
using market.model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace market.dao
{
    public class Repository
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        int returnvalue;
        List<LoginTable> loginTableList;

        public Repository()

        {

            con = new SqlConnection("Data Source=LAPTOP-L4Q67A3E\\HUSNUCAP;Initial Catalog=market;User ID=sa;Password=1;password=1");

        }

        public void baglantiAyarla()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }

            else
            {
                con.Close();
            }

        }

        public User login(string kullaniciAdi, string sifre)
        {
            con.Open();
            cmd = new SqlCommand("select * from loginTable where kullaniciAdi=@kulad and sifre=@sifre", con);
            cmd.Parameters.AddWithValue("@kulad", kullaniciAdi);
            cmd.Parameters.AddWithValue("@sifre", sifre);
            dr=cmd.ExecuteReader();

            if(dr.Read())
            {
                User user = new User();
                user.id = int.Parse(dr["id"].ToString());
                user.kullaniciAdi = dr["kullaniciAdi"].ToString();
                user.sifre = dr["sifre"].ToString() ;
           
                user.emailAdres = dr["emailAdres"].ToString();
                user.yetki = dr["yetki"].ToString();
                user.guvenlikSorusu = dr["guvenlikSorusu"].ToString();
                user.guvenlikCevabi = dr["guvenlikCevabi"].ToString();
                user.status = LoginStatus.basarili;
                return user;


            }
            else 
            { 
               User user =new User();

                user.status = LoginStatus.basarisiz;
                return user;
            
            
            }

          

           

        }

        public List<LoginTable> getLoginTable()


        {

            loginTableList = new List<LoginTable>();

            try
            {

                con.Open();

                cmd = new SqlCommand("guvenlikSorusuGetir_sp", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                dr = cmd.ExecuteReader();

                while (dr.Read())
                {

                    LoginTable loginTable = new LoginTable();
                    loginTable.id = int.Parse(dr["id"].ToString());
                    loginTable.kullaniciAdi = dr["kullaniciAdi"].ToString();
                    loginTable.sifre = dr["sifre"].ToString();
                    loginTable.yetki = dr["yetki"].ToString();
                    loginTable.emailAdres = dr["emailAdres"].ToString();
                    loginTable.guvenlikSorusu = dr["guvenlikSorusu"].ToString();
                    loginTable.guvenlikCevabi = dr["guvenlikCevabi"].ToString();
                    loginTableList.Add(loginTable);
                }
                con.Close();
            }



            catch (Exception e)
            {
                Console.WriteLine("hata oluştu");
            }
            return loginTableList;
        }
           
        public LoginStatus doAuthentication(string kullaniciAdi, string guvenlikSoru, string guvenlikCevabi)
        {
            con.Open();
            cmd = new SqlCommand("select count(*) from loginTable where kullaniciAdi=@kulad and guvenlikSorusu=@guvSorusu and guvenlikCevabi=@guvCevabi",con);
            cmd.Parameters.AddWithValue("@kulad", kullaniciAdi);
            cmd.Parameters.AddWithValue("@guvSorusu", guvenlikSoru);
            cmd.Parameters.AddWithValue("@guvCevabi", guvenlikCevabi);
            returnvalue= (int) cmd.ExecuteScalar();
            con.Close ();

            if(returnvalue==1)
            {
                return LoginStatus.basarili;
            }
            else
            {
                return LoginStatus.basarisiz;
            }

         }


        public LoginStatus changePassword(string kullaniciAdi, string sifre)
        {
            con.Open();
            cmd = new SqlCommand("sifreGuncelle_sp", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
            cmd.Parameters.AddWithValue("@sifre", sifre);
            returnvalue = cmd.ExecuteNonQuery();
                    
            con.Close ();
            return LogingStatus.basarili;


        }

        public string checkEmailAddress(string kullaniciAdi)
        {
            con.Open ();

            cmd = new SqlCommand("select emailAdres from loginTable where kullaniciAdi=@kulad", con);
            cmd.Parameters.AddWithValue("@kulad", kullaniciAdi);
            string emailAdres =(string)cmd.ExecuteScalar();
            con.Close();
            return emailAdres;  

        }
    }

        

    

    }


