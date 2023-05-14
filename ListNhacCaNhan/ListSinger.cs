using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTablePrettyPrinter;

namespace ListNhacCaNhan
{
    internal class ListSinger
    {

        Dictionary<String, Human> singers;
        public ListSinger()
        {
            this.singers = new Dictionary<string, Human>();
        }
        public void Nhap()
        {
            char c = 'y';
            while (c == 'y')
            {
                Human singer = new Singer();
                try
                {
                    Console.Write("ID: ");
                    var id = Console.ReadLine();
                    if (this.singers.ContainsKey(id))
                    {
                        Console.WriteLine("ID da ton tai!");
                        singer = null;
                    }
                    else
                    {
                        singer.ID = id;
                        singer.Nhap();
                    }
                }
                catch
                {
                    Console.WriteLine("Du lieu nhap vao sai dinh dang!");
                    singer = null;
                }
                if (singer != null)
                {
                    this.singers.Add(singer.ID, singer);
                    WriteDB(singer);
                }
                Console.Write("\nNhap ky tu 'y' de tiep tuc: ");
                c = Convert.ToChar(Console.ReadLine().ToLower());
            }
        }
        public void Xuat()
        {
            DataTable table = new DataTable("DANH SACH CA SI");
            table.Columns.Add("ID", typeof(String));
            table.Columns.Add("Ho ten", typeof(String));
            table.Columns.Add("Ngay sinh", typeof(String));
            table.Columns.Add("Gioi tinh", typeof(String));
            foreach (Human singer in singers.Values)
                table.Rows.Add(singer.ID, singer.Name, singer.Birthday.ToString("dd/MM/yyyy"), singer.Gender);
            Console.WriteLine(table.ToPrettyPrintedString());
        }
        public Human Tim()
        {
            Console.Write("Nhap ID: ");
            String id = Console.ReadLine();
            try
            {
                return this.singers[id];
            }
            catch
            {
                Console.WriteLine("ID khong ton tai!");
                return null;
            }
        }
        public void Xoa()
        {
            Console.Write("Nhap ID: ");
            String id = Console.ReadLine();
            if (this.singers.Remove(id))
                Console.WriteLine("Da xoa!");
            else Console.WriteLine("ID khong ton tai!");
        }
        public void Sua()
        {
            var temp = this.Tim();
            if (temp != null)
            {
                Human singer = new Singer();
                try
                {
                    singer.Nhap();
                    Console.Write("Nhap 'y' de xac nhan: ");
                    char c = Convert.ToChar(Console.ReadLine().ToLower());
                    if (c == 'y' && singer != null)
                    {
                        singer.ID = temp.ID;
                        this.singers[temp.ID] = singer;
                        Console.WriteLine("Da cap nhat!");
                    }
                    else Console.WriteLine("Cap nhat that bai!");
                }
                catch
                {
                    Console.WriteLine("Du lieu nhap vao sai dinh dang!");
                }
            }
        }
        public void WriteDB(Human singer)
        {
            using (MySqlConnection connection = new MySqlConnection())
            {
                string connectionString = "server=localhost;database=music;uid=root;password=;";
                connection.ConnectionString = connectionString;
                connection.Open();
                string query = "INSERT INTO singer VALUES (@v1, @v2, @v3, @v4)";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@v1", singer.ID);
                cmd.Parameters.AddWithValue("@v2", singer.Name);
                cmd.Parameters.AddWithValue("@v3", singer.Birthday);
                cmd.Parameters.AddWithValue("@v4", singer.Gender);
                if (cmd.ExecuteNonQuery() > 0) Console.WriteLine("Them thanh cong!");
                else Console.WriteLine("Them that bai");
            }
        }
        public void ReadDB()
        {
            using (MySqlConnection connection = new MySqlConnection())
            {
                string connectionString = "server=localhost;database=music;uid=root;password=;";
                connection.ConnectionString = connectionString;
                connection.Open();
                string query = "SELECT * FROM singer";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Human singer = new Singer(reader[0].ToString(), reader[1].ToString(), Convert.ToDateTime(reader[2]), reader[3].ToString());
                    this.singers.Add(singer.ID, singer);
                }
            }
        }
    }
}
