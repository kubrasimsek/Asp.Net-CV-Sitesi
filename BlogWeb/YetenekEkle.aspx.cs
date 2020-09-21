using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class YetenekEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSetTableAdapters.TBLYETENEKLERTableAdapter dtYetenek = new DataSetTableAdapters.TBLYETENEKLERTableAdapter();
            dtYetenek.YetenekEkle(txtYetenek.Text);
            Response.Redirect("YetenekListesi.aspx");
        }
    }
}