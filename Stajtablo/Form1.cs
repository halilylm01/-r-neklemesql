using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stajtablo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=HALIL\\MSSQLSERVER1;Initial Catalog=staj1;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(" INSERT INTO Table_1(UrunNo,UrunAd) VALUES (@UrunNo,@UrunAd)", baglanti);
            komut.Parameters.AddWithValue("@UrunNo", Convert.ToInt64(textBox1.Text));
            komut.Parameters.AddWithValue("@UrunAd", textBox2.Text);
           

            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("İşlem başarılı");




        }














        //Veri listeleme





        private void Listele_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand();
            komut.CommandText = " SELECT * FROM Table_1 ";
            komut.Connection = baglanti;

            SqlDataAdapter adap = new SqlDataAdapter(komut);

            DataTable tablo = new DataTable();
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            adap.Fill(tablo);

            ListelemeTablo.Items.Clear();
            for (int i= 0;i< tablo.Rows.Count; i++)
            {
                ListelemeTablo.Items.Add(tablo.Rows[i]["UrunNo"].ToString()); 

                ListelemeTablo.Items[i].SubItems.Add(tablo.Rows[i]["UrunAd"].ToString());

               
            }

     
        
        
        }


        //Veri silme



        private void Form1_Load(object sender, EventArgs e)
        {

            SqlCommand komut = new SqlCommand();
            komut.CommandText = " SELECT * FROM Table_1 ";
            komut.Connection = baglanti;

            SqlDataAdapter adap = new SqlDataAdapter(komut);

            DataTable tablo = new DataTable();

            adap.Fill(tablo);

            for (int i = 0; i < tablo.Rows.Count; i++)
            {
                SilmeTablo.Items.Add(tablo.Rows[i]["UrunNo"].ToString());

                SilmeTablo.Items[i].SubItems.Add(tablo.Rows[i]["UrunAd"].ToString());
            }


        }

        private void Silme_Click(object sender, EventArgs e)
        {
            try
            {

                SqlCommand komut = new SqlCommand("DELETE FROM Table_1 WHERE UrunNo=@UrunNo ", baglanti);
                komut.Parameters.AddWithValue("@UrunNo", Convert.ToInt64(SilmeTablo.SelectedItems[0].SubItems[0].Text));
                MessageBox.Show("Veri silindi");

                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
            }

            catch (Exception)
            
            {
                MessageBox.Show("Malesif Hiçbir veriyi seçmediniz");

            }

            SilmeTablo.Items.Clear();


            SqlCommand komut2 = new SqlCommand();
            komut2.CommandText = " SELECT * FROM Table_1 ";
            komut2.Connection = baglanti;

            SqlDataAdapter adap = new SqlDataAdapter(komut2);

            DataTable tablo = new DataTable();

            adap.Fill(tablo);

            for (int i = 0; i < tablo.Rows.Count; i++)
            {
                SilmeTablo.Items.Add(tablo.Rows[i]["UrunNo"].ToString());

                SilmeTablo.Items[i].SubItems.Add(tablo.Rows[i]["UrunAd"].ToString());
            }





        }

        private void ListelemeTablo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }














