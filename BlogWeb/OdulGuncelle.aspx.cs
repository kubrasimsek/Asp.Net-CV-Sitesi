using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class OdulGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(Request.QueryString["ID"]);
            txtID.Text = id.ToString();
            txtID.Enabled = false;
            if (Page.IsPostBack == false)
            {
                DataSetTableAdapters.TBLODULLERTableAdapter dtOdul = new DataSetTableAdapters.TBLODULLERTableAdapter();
                txtOdul.Text = dtOdul.OdulGetir(Convert.ToInt16(id))[0].ODUL;
            }
        }

        protected void btnGuncelle_Click(object sender, EventArgs e)
        {
            DataSetTableAdapters.TBLODULLERTableAdapter dtOdul = new DataSetTableAdapters.TBLODULLERTableAdapter();
            dtOdul.OdulGuncelle(txtOdul.Text, Convert.ToInt16(txtID.Text));
            Response.Redirect("OdulListesi.aspx");
        }
    }
}