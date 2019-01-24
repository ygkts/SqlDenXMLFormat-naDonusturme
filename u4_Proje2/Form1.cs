using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Xml;

namespace u4_Proje2
{
    // ORDERDETAİLS TABLOSUNDAN UNİPRİCE İ XML ÜZERİNDEN DOLAR KURUNU ÇEKEREK TL OLARAK XML E LİSTELEYEN PROGRAM
    // GEREKLİ OLAN ALANLAR GETİRİLEBİLİR
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnXMLeCevir_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Server=YASEMINGOKTAS; Database = NORTHWND; Trusted_Connection=true;");
            
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("http://www.tcmb.gov.tr/kurlar/today.xml");
            XmlElement rootEleman = xmlDoc.DocumentElement; // tüm döküman
            XmlNodeList liste = rootEleman.GetElementsByTagName("Currency");    // currency = para birimi
      
            XmlElement currency = (XmlElement)liste[0];
                  
            string satisFiyat = currency.GetElementsByTagName("ForexSelling").Item(0).InnerText;
                
            SqlCommand cmd = new SqlCommand("select o.CustomerID,od.ProductID ,od.UnitPrice, od.UnitPrice*" + 
                currency.GetElementsByTagName("ForexSelling").Item(0).InnerText + "as TL from [Order Details] od inner join Orders o on od.OrderID=o.OrderID", conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            XmlTextWriter xmlYaz = new XmlTextWriter("Siparisler.xml", Encoding.GetEncoding(1254));

            xmlYaz.Formatting = Formatting.Indented;
            xmlYaz.WriteStartDocument();
            xmlYaz.WriteComment("ORDERDETAİLS TABLOSUNDAN UNİPRİCE İ XML ÜZERİNDEN DOLAR KURUNU ÇEKEREK TL OLARAK XML E LİSTELENİYOR..");
            xmlYaz.WriteStartElement("Siparisler");

            while (dr.Read())
            {
                xmlYaz.WriteStartElement("Siparis");
                for (int i = 0; i < dr.FieldCount; i++) // bütün alanları sayar
                {
                    xmlYaz.WriteElementString(dr.GetName(i), dr[i].ToString());
                }
                xmlYaz.WriteEndElement();
            }
            xmlYaz.WriteEndElement();
            xmlYaz.Close();
            MessageBox.Show("İşlem Başarılı :)");

        }
        private void btnXMLdenGetir_Click(object sender, EventArgs e)
        {
            
            XmlTextReader xmlOku = new XmlTextReader("Siparisler.xml");

            DataSet ds = new DataSet();
            ds.ReadXml(xmlOku);
            dataGridView1.DataSource = ds.Tables[0];
         
            /*
            <Tarih_Date Tarih="17.01.2019" Date="01/17/2019"  Bulten_No="2019/12" >
	            <Currency CrossOrder="0" Kod="USD" CurrencyCode="USD">
			            <Unit>1</Unit>
			            <Isim>ABD DOLARI</Isim>
			            <CurrencyName>US DOLLAR</CurrencyName>
			            <ForexBuying>5.3563</ForexBuying>
			            <ForexSelling>5.3659</ForexSelling>  ******
			            <BanknoteBuying>5.3525</BanknoteBuying>
			            <BanknoteSelling>5.3740</BanknoteSelling>
			            <CrossRateUSD/>
			            <CrossRateOther/>...
	            </Currency>...             
            */
           
        }
    }
}
