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
    public partial class Site1 : System.Web.UI.MasterPage
    {
        SqlConnection con = new SqlConnection("server=DESKTOP-EOKQ1OG\\SQLEXPRESS;database=quiz11_aspblog;trusted_connection=true;");
        //int sayac = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            KonularList();
            DuyurularList();
            //sayac=(DateTime.Now.Minute);
            //for (int i = 0; i < 10; i++)
            //{
            //    if (sayac % 2 == 0)
            //    {
            //        SozlerList();
            //    }
            //    sayac++;
            //}
            SozlerList();
            HakkındaList();
            //AltKonularList();
        }
        public void SozlerList()
        {
            SqlDataAdapter da = new SqlDataAdapter("select top 1 soz from GununSozu where id=@id", con);
            Random rand = new Random();
            da.SelectCommand.Parameters.AddWithValue("id", rand.Next(1, 11));
            DataTable dt = new DataTable("sozList");
            da.Fill(dt);
            sozlerrepeater.DataSource = dt;
            sozlerrepeater.DataBind();

        }

        public void KonularList()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from Konu_Baslıklar", con);
            DataTable dt = new DataTable("konuList");
            da.Fill(dt);
            lstkonu.DataSource = dt;
            lstkonu.DataBind();

        }
        public void AltKonularList()
        {
            // string bid = Request.QueryString["baslıkid"];
            // //Response.Write(bid);
            //SqlDataAdapter da = new SqlDataAdapter("select altbaslık from Konu_AltBaslıklar a join Konu_Baslıklar b on a.üstbaslık_id=b.id where a.üstbaslık_id=@id", con);
            // da.SelectCommand.Parameters.AddWithValue("@id", bid);
            // DataTable dt = new DataTable("konuList");
            // da.Fill(dt);

        }

        public void DuyurularList()
        {
            SqlDataAdapter da = new SqlDataAdapter("select baslık from duyurular", con);
            DataTable dt = new DataTable("duyuruList");
            da.Fill(dt);
            lstDuyuru.DataSource = dt;
            lstDuyuru.DataBind();
        }

        public void HakkındaList()
        {
            SqlDataAdapter da = new SqlDataAdapter("select baslık from Hakkında", con);

            DataTable dt = new DataTable("hakkındaList");
            da.Fill(dt);
            lsthakkında.DataSource = dt;
            lsthakkında.DataBind();
        }

    }
}