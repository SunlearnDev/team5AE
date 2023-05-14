using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTablePrettyPrinter;

namespace ListNhacCaNhan
{
    public class NhacViet
    {
        private string description;

        public string Description
        {
            set { this.description = value; }
            get { return this.description; }
        }

        public NhacViet : base() { }

        public NhacViet(string id, string name, string description) :base(string id, string name)
        {
            this.description = description;
        }
    
        DataTable table1 = new DataTable("NhacViet");
    
        table.Columns.Add("ID", typeof(Int32));
        table.Columns.Add("Name", typeof(String));
        table.Columns.Add("Description", typeof(String));

        table.Rows.Add('1', 'Anh Không Sao Đâu', 'Bài hát hay cảm xúc');
        table.Rows.Add('2', 'Ừ Có Anh Đây', 'Bài hát vô cùng sâu lắng');
        table.Rows.Add('3', 'Buồn Của Tháng Năm', 'Bài hát êm  dịu');
        table.Rows.Add('4', 'Lạ Lùng', 'Bài hát nhẹ nhàng,dịu dàng');
    }

    public void override Nhap() {

    }

    public void override Xuat() {
        Console.WriteLine(table1.ToPrettyPrintedString());
    }
}
