using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class Hakkimda : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                DataSetTableAdapters.TBLHAKKIMDATableAdapter dtHakkimda = new DataSetTableAdapters.TBLHAKKIMDATableAdapter();
                TextBox1.Text = dtHakkimda.HakkimdaListele()[0].AD;
                TextBox2.Text = dtHakkimda.HakkimdaListele()[0].SOYAD;
                TextBox3.Text = dtHakkimda.HakkimdaListele()[0].ADRES;
                TextBox4.Text = dtHakkimda.HakkimdaListele()[0].MAIL;
                TextBox5.Text = dtHakkimda.HakkimdaListele()[0].TELEFON;
                TextBox6.Text = dtHakkimda.HakkimdaListele()[0].KISANOT;
                TextBox7.Text = dtHakkimda.HakkimdaListele()[0].FOTOGRAF;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSetTableAdapters.TBLHAKKIMDATableAdapter dtGuncelle = new DataSetTableAdapters.TBLHAKKIMDATableAdapter();
            dtGuncelle.HakkimdaGuncelle(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text, TextBox7.Text);
            Response.Redirect("Default.aspx");
        }
    }
}