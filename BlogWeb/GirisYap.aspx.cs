using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace BlogWeb
{
    public partial class GirisYap : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        SqlConnection conn = new SqlConnection(@"Data Source=localhost;Initial Catalog=BlogWebDB;Integrated Security=True");
        protected void btnGirisYap_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM TBLADMIN WHERE KULLANICI=@kullanici AND SIFRE=@sifre",conn);
                cmd.Parameters.AddWithValue("@kullanici", txtKullanici.Text);
                cmd.Parameters.AddWithValue("@sifre", txtSifre.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Response.Redirect("AdminDeneyimler.aspx");
                }
                else
                {                    
                    Response.Write("HAtalı kullanıcı adı ve/veya şifre");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}