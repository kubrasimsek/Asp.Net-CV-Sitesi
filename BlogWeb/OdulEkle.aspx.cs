using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class OdulEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            DataSetTableAdapters.TBLODULLERTableAdapter dtOdul = new DataSetTableAdapters.TBLODULLERTableAdapter();
            dtOdul.OdulEkle(txtOdul.Text);
            Response.Redirect("OdulListesi.aspx");
        }
    }
}