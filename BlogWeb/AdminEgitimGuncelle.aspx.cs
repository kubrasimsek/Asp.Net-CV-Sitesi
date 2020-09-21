using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class AdminEgitimGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(Request.QueryString["ID"]);
            txtID.Enabled = false;
            txtID.Text = id.ToString();

            if (Page.IsPostBack == false)
            {
                DataSetTableAdapters.TBLEGITIMTableAdapter dtEgitim = new DataSetTableAdapters.TBLEGITIMTableAdapter();
                txtBaslik.Text = dtEgitim.EgitimGetir(Convert.ToInt16(id))[0].BASLIK;
                txtAltBaslik.Text = dtEgitim.EgitimGetir(Convert.ToInt16(id))[0].ALTBASLIK; ;
                txtAciklama.Text = dtEgitim.EgitimGetir(Convert.ToInt16(id))[0].ACIKLAMA; ;
                txtGnot.Text = dtEgitim.EgitimGetir(Convert.ToInt16(id))[0].GNOT; ;
                txtTarih.Text = dtEgitim.EgitimGetir(Convert.ToInt16(id))[0].TARIH; ;
            }
        }

        protected void btnGuncelle_Click(object sender, EventArgs e)
        {
            DataSetTableAdapters.TBLEGITIMTableAdapter dtEgitim = new DataSetTableAdapters.TBLEGITIMTableAdapter();
            dtEgitim.EgitimGuncelle(txtBaslik.Text, txtAltBaslik.Text, txtAciklama.Text, txtGnot.Text, txtTarih.Text, Convert.ToInt16(txtID.Text));
            Response.Redirect("AdminEgitimler.aspx");
        }
    }
}