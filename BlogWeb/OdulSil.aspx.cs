using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class OdulSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(Request.QueryString["ID"]);
            DataSetTableAdapters.TBLODULLERTableAdapter dtOdul = new DataSetTableAdapters.TBLODULLERTableAdapter();
            dtOdul.OdulSil(Convert.ToInt16(id));
            Response.Redirect("OdulListesi.aspx");
        }
    }
}