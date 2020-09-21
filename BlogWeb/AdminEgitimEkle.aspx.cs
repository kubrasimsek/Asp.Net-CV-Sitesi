using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class AdminEgitimEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSetTableAdapters.TBLEGITIMTableAdapter dtEgitim = new DataSetTableAdapters.TBLEGITIMTableAdapter();
            dtEgitim.EgitimEkle(txtBaslik.Text, txtAltBaslik.Text, txtAciklama.Text, txtGnot.Text, txtTarih.Text);
            Response.Redirect("AdminEgitimler.aspx");
        }
    }
}