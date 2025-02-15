using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Ado.net

            //Menü
            Console.WriteLine("****** C# Veri Tabai Ürün - Katagori Bilgi Sistemi ******");

            Console.WriteLine("");
            Console.WriteLine("");


            Console.WriteLine("------------------");
            Console.WriteLine("1. Katagoriler ");
            Console.WriteLine("2. Ürünler ");
            Console.WriteLine("3. Siparisler ");
            Console.WriteLine("4. Çikis Yap ");

            Console.WriteLine("");
            Console.Write("Lütfen Girmek Istediginiz Tablo Numarasini Yazin  :   ");
            string tableNumber = Console.ReadLine();

            //Veri Tabanı Bağlantı
            SqlConnection connection = new SqlConnection(@"Data Source=SABBATH\SQLEXPRESS;Initial Catalog=EgitimKapiDb;Integrated Security=True");
            connection.Open();

            
            SqlCommand command = new SqlCommand("Select * From TblCatagory", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            connection.Close();

            //Katagori Listeleme
            foreach (DataRow row in dataTable.Rows)
            {

                foreach (var item in row.ItemArray)
                {
                    Console.Write(item.ToString());
                    Console.Write(" - ");
                }
                Console.WriteLine("");
            }





            #endregion



            Console.Read();
        }
    }
}
