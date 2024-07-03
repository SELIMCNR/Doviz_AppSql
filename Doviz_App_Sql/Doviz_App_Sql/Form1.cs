using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Convert;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Doviz_App_Sql
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-BC3LOP2\SQLEXPRESS;Initial Catalog=doviz_app;Integrated Security=True;");


        private void Form1_Load_1(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'doviz_appDataSet1.SatılanDoviz' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.satılanDovizTableAdapter.Fill(this.doviz_appDataSet1.SatılanDoviz);
            // TODO: Bu kod satırı 'doviz_appDataSet.AlınanDoviz' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.alınanDovizTableAdapter.Fill(this.doviz_appDataSet.AlınanDoviz);

        }

        private void UsdToplamSatilan(string doviz)
        {
            con.Open();
            SqlCommand com = new SqlCommand("select SUM(Miktar) FROM SatılanDoviz WHERE Doviz = @p1", con);
            com.Parameters.AddWithValue("@p1", doviz);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                Lbl_ToplamSat.Text = dr[0].ToString();
            }

            con.Close();
        }

        private void UsdToplamAlinan(string doviz)
        {
            con.Open();
            SqlCommand com = new SqlCommand("select SUM(Miktar) FROM AlınanDoviz WHERE Doviz = @p1", con);
            com.Parameters.AddWithValue("@p1", doviz);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                LblToplamAl.Text = dr[0].ToString();
            }
            con.Close();
        }


    
        private void Txt_DovizAlis_TextChanged(object sender, EventArgs e)
        {
          //  Txt_DovizAlış.Text = Txt_DovizAlış.Text.Replace(".", ",");
        }

        private void Txt_DovizSatis_TextChanged(object sender, EventArgs e)
        {
         //   Txt_DovizSatış.Text = Txt_DovizSatış.Text.Replace(".", ",");
        }

   

        

  
        private void DövizSeçCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            UsdToplamAlinan(DövizSeçCombo.Text);
            UsdToplamSatilan(DövizSeçCombo.Text);
           
        }

        private void Btn_SatışYap_Click(object sender, EventArgs e)
        {

            if (Txt_Musteri.Text == "" || Txt_Musteri.Text == " ")
            {
                MessageBox.Show("Lütfen isim alanını boş geçmeyiniz.", "Bilgilendirme", MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);
            }
            else
            {
                con.Open();
                SqlCommand com = new SqlCommand("insert into SatılanDoviz (İsim,Doviz,Miktar,Kur,Tarih) VALUES(@p1,@p2,@p3,@p4,@P5)", con);
                com.Parameters.AddWithValue("@p1", Txt_Musteri.Text);
                com.Parameters.AddWithValue("@p2", DOVİZAD.Text);
                com.Parameters.AddWithValue("@p3", Txt_SatışTutar.Text);
                com.Parameters.AddWithValue("@p4", Txt_DovizSatış.Text);

                // TextBox'tan tarih değerini alıp DateTime türüne dönüştürün
                DateTime satışTarihi;
                if (DateTime.TryParse(satıştarih.Text, out satışTarihi))
                {
                    com.Parameters.AddWithValue("@P5", satışTarihi);
                }
                else
                {
                    // Tarih değeri geçersizse hata yönetimi yapın
                    throw new Exception("Geçersiz tarih formatı. Lütfen geçerli bir tarih girin.");
                }

                com.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Satış başarılı bir şekilde yapıldı.", "Bilgilendirme", MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);
                // TODO: Bu kod satırı 'doviz_appDataSet1.SatılanDoviz' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
                this.satılanDovizTableAdapter.Fill(this.doviz_appDataSet1.SatılanDoviz);
                Txt_Musteri.Text = "";
                Txt_Miktar.Text = "";
                Txt_AlışTutar.Text = "";
                Txt_SatışTutar.Text = "";
            }
            UsdToplamSatilan(DövizSeçCombo.Text);

        }

        private void Btn_AlışYap_Click(object sender, EventArgs e)
        {
            if (Txt_Musteri.Text == "" || Txt_Musteri.Text == " ")
            {
                MessageBox.Show("Lütfen isim alanını boş geçmeyiniz.", "Bilgilendirme", MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);
            }
            else
            {
                con.Open();
         

                SqlCommand com2 = new SqlCommand("insert into AlınanDoviz (İsim,Doviz,Miktar,Kur,Tarih) VALUES(@p1,@p2,@p3,@P4,@P5)", con);
                com2.Parameters.AddWithValue("@p1", Txt_Musteri.Text);
                com2.Parameters.AddWithValue("@p2", DOVİZAD.Text);
                com2.Parameters.AddWithValue("@p3", Txt_AlışTutar.Text);
                com2.Parameters.AddWithValue("@P4", Txt_DovizAlış.Text);
                DateTime satışTarihi;
                if (DateTime.TryParse(satıştarih.Text, out satışTarihi))
                {
                    com2.Parameters.AddWithValue("@P5", satışTarihi);
                }
                else
                {
                    // Tarih değeri geçersizse hata yönetimi yapın
                    throw new Exception("Geçersiz tarih formatı. Lütfen geçerli bir tarih girin.");
                }
                com2.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Alış başarılı bir şekilde yapıldı.", "Bilgilendirme", MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);

                // TODO: Bu kod satırı 'doviz_appDataSet.AlınanDoviz' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
                this.alınanDovizTableAdapter.Fill(this.doviz_appDataSet.AlınanDoviz);
                Txt_Musteri.Text = "";
                Txt_Miktar.Text = "";
                Txt_AlışTutar.Text = "";
                Txt_SatışTutar.Text = "";
            }
            UsdToplamAlinan(DövizSeçCombo.Text);
        }

        private void DOVİZAD_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                // Dolar
                if (DOVİZAD.Text == "USD")
                {
                    string today = "https://www.tcmb.gov.tr/kurlar/today.xml";
                    var xmlDocument = new XmlDocument();
                    xmlDocument.Load(today);

                    // Dolar alış ve satış fıyatları çekildi.
                    string dolaralis = xmlDocument.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/ForexBuying").InnerXml;
                    Txt_DovizAlış.Text = dolaralis;

                    string dolarsatiş = xmlDocument.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/ForexSelling").InnerXml;
                    Txt_DovizSatış.Text = dolarsatiş;
                }

                // Euro
                if (DOVİZAD.Text == "EUR")
                {
                    string today = "https://www.tcmb.gov.tr/kurlar/today.xml";
                    var xmlDocument = new XmlDocument();
                    xmlDocument.Load(today);


                    // Euro alış ve satış fıyatları çekildi.
                    string euroAliş = xmlDocument.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/ForexBuying").InnerXml;
                    Txt_DovizAlış.Text = euroAliş;
                    string euroSatis = xmlDocument.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/ForexSelling").InnerXml;
                    Txt_DovizSatış.Text = euroSatis;

                }

                // Sterlin
                if (DOVİZAD.Text == "GBP")
                {
                    string today = "https://www.tcmb.gov.tr/kurlar/today.xml";
                    var xmlDocument = new XmlDocument();
                    xmlDocument.Load(today);


                    // Sterlin alış ve satış fıyatları çekildi.
                    string gbpAliş = xmlDocument.SelectSingleNode("Tarih_Date/Currency[@Kod='GBP']/ForexBuying").InnerXml;
                    Txt_DovizAlış.Text = gbpAliş;
                    string gbpSatis = xmlDocument.SelectSingleNode("Tarih_Date/Currency[@Kod='GBP']/ForexSelling").InnerXml;
                    Txt_DovizSatış.Text = gbpSatis;
                }

                // Avusturlya Doları
                if (DOVİZAD.Text == "AUD")
                {
                    string today = "https://www.tcmb.gov.tr/kurlar/today.xml";
                    var xmlDocument = new XmlDocument();
                    xmlDocument.Load(today);


                    // Avusturlya Doları alış ve satış fıyatları çekildi.
                    string audAliş = xmlDocument.SelectSingleNode("Tarih_Date/Currency[@Kod='AUD']/ForexBuying").InnerXml;
                    Txt_DovizAlış.Text = audAliş;
                    string audSatis = xmlDocument.SelectSingleNode("Tarih_Date/Currency[@Kod='AUD']/ForexSelling").InnerXml;
                    Txt_DovizSatış.Text = audSatis;
                }
            

        }

        private void Txt_Miktar_TextChanged_1(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(Txt_Miktar.Text))
            {
                MessageBox.Show("Lütfen miktar alanını boş geçmeyiniz.", "Bilgilendirme", MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);
            }
            else
            {
                double kurSatis, kurAlis, tutarSatis, tutarAlis, miktar;
                kurSatis = ToDouble(Txt_DovizSatış.Text);
                kurAlis = ToDouble(Txt_DovizAlış.Text);
                miktar = ToDouble(Txt_Miktar.Text);

                tutarSatis = ToDouble(miktar * kurSatis);
                tutarAlis = ToDouble(miktar * kurAlis);


                Txt_AlışTutar.Text = tutarAlis.ToString();
                Txt_SatışTutar.Text = tutarSatis.ToString();
            }
        }
    }
}
