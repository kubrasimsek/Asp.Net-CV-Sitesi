using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class OdulListesi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSetTableAdapters.TBLODULLERTableAdapter dtOdul = new DataSetTableAdapters.TBLODULLERTableAdapter();
            Repeater1.DataSource = dtOdul.OdulListesi();
            Repeater1.DataBind();

        }
    }
}