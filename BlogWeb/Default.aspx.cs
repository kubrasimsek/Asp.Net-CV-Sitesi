using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSetTableAdapters.TBLHAKKIMDATableAdapter dt = new DataSetTableAdapters.TBLHAKKIMDATableAdapter();
            Repeater1.DataSource = dt.HakkimdaListele();
            Repeater1.DataBind();

            DataSetTableAdapters.TBLDENEYIMTableAdapter dtDeneyim = new DataSetTableAdapters.TBLDENEYIMTableAdapter();
            Repeater2.DataSource = dtDeneyim.DeneyimListesi();
            Repeater2.DataBind();

            DataSetTableAdapters.TBLEGITIMTableAdapter dtEgitim = new DataSetTableAdapters.TBLEGITIMTableAdapter();
            Repeater3.DataSource = dtEgitim.EgitimListesi();
            Repeater3.DataBind();

            DataSetTableAdapters.TBLHOBILERTableAdapter dtHobiler = new DataSetTableAdapters.TBLHOBILERTableAdapter();
            Repeater5.DataSource = dtHobiler.HobilerListele();
            Repeater5.DataBind();

            DataSetTableAdapters.TBLODULLERTableAdapter dtOdul = new DataSetTableAdapters.TBLODULLERTableAdapter();
            Repeater6.DataSource = dtOdul.OdulListesi();
            Repeater6.DataBind();

            DataSetTableAdapters.TBLYETENEKLERTableAdapter dtYetenek = new DataSetTableAdapters.TBLYETENEKLERTableAdapter();
            Repeater4.DataSource = dtYetenek.YetenekListesi();
            Repeater4.DataBind();

            DataSetTableAdapters.TBLHAKKIMDATableAdapter dtFotograf = new DataSetTableAdapters.TBLHAKKIMDATableAdapter();
            Repeater8.DataSource = dtFotograf.HakkimdaListele();
            Repeater8.DataBind();
        }
    }
}