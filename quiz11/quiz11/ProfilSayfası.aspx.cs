using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace quiz11
{
    public partial class ProfilSayfası : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("server=DESKTOP-EOKQ1OG\\SQLEXPRESS;database=quiz11_aspblog;trusted_connection=true;");
        protected void Page_Load(object sender, EventArgs e)
        {
            profil();
            profilfoto();
        }

        public void profil()
        {
           

            SqlDataAdapter da = new SqlDataAdapter("select isim,meslek,konum,foto from Profil", con);

            DataTable dt = new DataTable("profiller");
            da.Fill(dt);
            lstprofil.DataSource = dt;
            lstprofil.DataBind();
        }
        public void profilfoto()
        {
            //SqlDataAdapter da = new SqlDataAdapter("select ad,soyad,meslek,hakkında from Profil", con);

            //DataTable dt = new DataTable("profiller");
            //da.Fill(dt);
            //lstprofil.DataSource = dt;
            //lstprofil.DataBind();
        }
    }
}