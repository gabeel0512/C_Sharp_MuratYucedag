using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("****** Menü Siparis Islem Paneli ******");
            Console.WriteLine("");

            Console.WriteLine("-----------------------------");

            #region Katagori ekleme




            //Console.WriteLine(" Eklemek Istediginiz Katagori Adi ");
            //string catagoryName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection(@"Data Source=SABBATH\SQLEXPRESS;Initial Catalog=EgitimKapiDb;Integrated Security=True");

            //connection.Open();

            //SqlCommand command = new SqlCommand("insert into TblCatagory (CatagoryName) values (@p1)", connection);
            //command.Parameters.AddWithValue("@p1", catagoryName);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.WriteLine("Katagori Eklendi");
            #endregion

            #region Ürün ekleme

            //string productName;
            //decimal productPrice;
            //bool productStatus;

            //Console.WriteLine("Eklemek Istediginiz Ürün Adi ");
            //productName = Console.ReadLine();

            //Console.WriteLine("Eklemek Istediginiz Ürün Fiyati ");
            //productPrice = Convert.ToDecimal(Console.ReadLine());

            ////Console.WriteLine("Stok Durumu (1/0) ");
            ////productStatus = Convert.ToBoolean(Console.ReadLine());

            //SqlConnection connection = new SqlConnection(@"Data Source=SABBATH\SQLEXPRESS;Initial Catalog=EgitimKapiDb;Integrated Security=True");
            //connection.Open();

            //SqlCommand command = new SqlCommand("insert into TblProduct (ProductName,ProductPrice,ProductStatus) values (@p1,@p2,@p3)", connection);
            //command.Parameters.AddWithValue("@p1", productName);
            //command.Parameters.AddWithValue("@p2", productPrice);
            //command.Parameters.AddWithValue("@p3", true);


            //command.ExecuteNonQuery();
            //connection.Close();


            //Console.WriteLine("Ürün Eklendi");


            #endregion

            #region Ürün Listeleme Islemi

            //SqlConnection connection = new SqlConnection(@"Data Source=SABBATH\SQLEXPRESS;Initial Catalog=EgitimKapiDb;Integrated Security=True");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Select * From TblProduct", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);

            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString());
            //        Console.Write(" - ");
            //    }
            //    Console.WriteLine("");
            //}


            //connection.Close();

            #endregion

            #region Ürün Silme Islemi

            //Console.Write("Silinecek ürün id numarasini girin :  ");
            //int productId = int.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection(@"Data Source=SABBATH\SQLEXPRESS;Initial Catalog=EgitimKapiDb;Integrated Security=True");

            //connection.Open();

            //SqlCommand command = new SqlCommand("Delete From TblProduct where ProductId=@p1", connection);
            //command.Parameters.AddWithValue("@p1", productId);
            //command.ExecuteNonQuery();

            //Console.WriteLine("Ürün Silindi");


            //connection.Close();

            #endregion

            #region Ürün Güncelleme Islemi

            //Console.WriteLine("Güncellenecek ürünün id numarasi :  ");
            //int productId = int.Parse(Console.ReadLine());

            //Console.WriteLine("Yeni Ürün Adi :  ");
            //string productName = Console.ReadLine();

            //Console.WriteLine("Yeni Ürün Fiyati :  ");
            //decimal productPrice = Convert.ToDecimal(Console.ReadLine());

            //SqlConnection connection = new SqlConnection(@"Data Source=SABBATH\SQLEXPRESS;Initial Catalog=EgitimKapiDb;Integrated Security=True");
            //connection.Open();
            //SqlCommand command = connection.CreateCommand();
            //command.CommandText = "Update TblProduct set ProductName=@p1,ProductPrice=@p2 where ProductId=@p3";
            //command.Parameters.AddWithValue("@p1", productName);
            //command.Parameters.AddWithValue("@p2", productPrice);
            //command.Parameters.AddWithValue("@p3", productId);

            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Ürün Güncellendi");



            #endregion
        }
    }
}
