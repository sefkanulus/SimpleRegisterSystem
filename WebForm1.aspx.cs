using RegisterSystem.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RegisterSystem
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            

            //Bağlantıyı kontrol et
            SqlConnectionClass.CheckConnection();

            //Kullanıcıdan alınan verileri SQL sorgusuna ekle
            string customername = TextBox1.Text;
            string city = TextBox2.Text;
            string birthdate = TextBox3.Text;
            string district = TextBox4.Text;
            string gender = TextBox5.Text;

            //SQL sorgusunu oluştur
            string query = "INSERT INTO CUSTOMERS (CUSTOMERNAME, CITY, BIRTHDATE, DISTRICT, GENDER) VALUES (@CUSTOMERNAME, @CITY, @BIRTHDATE, @DISTRICT, @GENDER)";

            SqlCommand command = new SqlCommand(query, SqlConnectionClass.connection);

            //parametreleri ekleyerek SQL enjeksiyonunu önle

            command.Parameters.AddWithValue("@CUSTOMERNAME", customername);
            command.Parameters.AddWithValue("@CITY", city);
            command.Parameters.AddWithValue("@BIRTHDATE", birthdate);
            command.Parameters.AddWithValue("DISTRICT", district);
            command.Parameters.AddWithValue("GENDER", gender);

            //Sorguyu çalıştır
            int rowsAffected = command.ExecuteNonQuery();

            //Eğer kayıt başarılı bir şekilde eklendiyse mesaj göster
            if (rowsAffected > 0)
            {
                Label1.Text = "Succesfully registered.";
            }
            else
            {
                //Kaydetme işlemi başarısız olduysa hata mesajı göster
                Label1.Text = "Registration failed error occured.";

            }

            //Bağlantıyı kapat
            SqlConnectionClass.connection.Close();
        }


    }
}