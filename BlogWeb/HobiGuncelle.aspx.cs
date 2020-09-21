using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class HobiGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(Request.QueryString["ID"]);
            txtID.Text = id.ToString();
            txtID.Enabled = false;
            if (Page.IsPostBack == false)
            {
                DataSetTableAdapters.TBLHOBILERTableAdapter dthobi = new DataSetTableAdapters.TBLHOBILERTableAdapter();
                txtHobi.Text = dthobi.HobiGetir(Convert.ToInt16(id))[0].HOBI;
            }
        }

        protected void btnGuncelle_Click(object sender, EventArgs e)
        {
            DataSetTableAdapters.TBLHOBILERTableAdapter dtHobi = new DataSetTableAdapters.TBLHOBILERTableAdapter();
            dtHobi.HobiGuncelle(txtHobi.Text, Convert.ToInt16(txtID.Text));
            Response.Redirect("HobiListesi.aspx");
        }
    }
}