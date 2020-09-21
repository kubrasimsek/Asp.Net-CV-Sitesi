using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class YetenekGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(Request.QueryString["ID"]);
            DataSetTableAdapters.TBLYETENEKLERTableAdapter dtYetenek = new DataSetTableAdapters.TBLYETENEKLERTableAdapter();
            txtID.Text = id.ToString();
            txtID.Enabled = false;
            if (Page.IsPostBack == false)
            {
                txtYetenek.Text = dtYetenek.YetenekGetir(Convert.ToInt16(id))[0].YETENEK;
            }
        }
        protected void btnGuncelle_Click(object sender, EventArgs e)
        {
            DataSetTableAdapters.TBLYETENEKLERTableAdapter dtYetenek = new DataSetTableAdapters.TBLYETENEKLERTableAdapter();
            dtYetenek.YetenekGuncelle(txtYetenek.Text, Convert.ToInt16(txtID.Text));
            Response.Redirect("YetenekListesi.aspx");
        }
    }
}