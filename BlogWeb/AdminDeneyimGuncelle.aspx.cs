using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class AdminDeneyimGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(Request.QueryString["ID"]);
            txtID.Enabled = false;
            txtID.Text = id.ToString();
            if (Page.IsPostBack == false)
            {
                DataSetTableAdapters.TBLDENEYIMTableAdapter dtDeneyim = new DataSetTableAdapters.TBLDENEYIMTableAdapter();
                txtBaslik.Text = dtDeneyim.DeneyimGetir(Convert.ToInt16(id))[0].BASLIK;
                txtAltBaslik.Text = dtDeneyim.DeneyimGetir(Convert.ToInt16(id))[0].ALTBASLIK;
                txtAciklama.Text = dtDeneyim.DeneyimGetir(Convert.ToInt16(id))[0].ACIKLAMA;
                txtTarih.Text = dtDeneyim.DeneyimGetir(Convert.ToInt16(id))[0].TARIH;
            }
        }

        protected void btnGuncelle_Click(object sender, EventArgs e)
        {
            DataSetTableAdapters.TBLDENEYIMTableAdapter dtDeneyim = new DataSetTableAdapters.TBLDENEYIMTableAdapter();
            dtDeneyim.DeneyimGuncelle(txtBaslik.Text, txtAltBaslik.Text, txtAciklama.Text, txtTarih.Text,Convert.ToInt16(txtID.Text));
            Response.Redirect("AdminDeneyimler.aspx");
        }
    }
}