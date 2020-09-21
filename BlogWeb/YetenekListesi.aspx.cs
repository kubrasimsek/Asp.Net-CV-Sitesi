using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class YetenekListesi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSetTableAdapters.TBLYETENEKLERTableAdapter dtYetenek = new DataSetTableAdapters.TBLYETENEKLERTableAdapter();
            Repeater1.DataSource = dtYetenek.YetenekListesi();
            Repeater1.DataBind();
        }
    }
}