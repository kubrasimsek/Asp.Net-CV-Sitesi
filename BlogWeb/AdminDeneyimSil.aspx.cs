using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class AdminDeneyimSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt16( Request.QueryString["ID"]);
            DataSetTableAdapters.TBLDENEYIMTableAdapter dtDeneyim = new DataSetTableAdapters.TBLDENEYIMTableAdapter();
            dtDeneyim.DeneyimSil(Convert.ToInt16(id));
            Response.Redirect("AdminDeneyimler.aspx");
        }
    }
}