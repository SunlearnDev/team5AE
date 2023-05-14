using DataTablePrettyPrinter;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListNhacCaNhan
{
    internal class Singer : Human
    {
        public override void Nhap()
        {
            base.Nhap();
        }
        public override void Xuat()
        {
            DataTable table = new DataTable("THONG TIN CA SI");
            table.Columns.Add("Muc", typeof(String));
            table.Columns.Add("Thong tin", typeof(String));
            table.Rows.Add("ID", base.id);
            table.Rows.Add("Ho ten", base.name);
            table.Rows.Add("Ngay sinh", base.birthday.ToString("dd/MM/yyyy"));
            table.Rows.Add("Gioi tinh", base.gender);
            Console.WriteLine(table.ToPrettyPrintedString());
        }
        public Singer() : base() { }
        public Singer(String id, String name, DateTime birth, String gender) : base(id, name, birth, gender) {}
    }
}
