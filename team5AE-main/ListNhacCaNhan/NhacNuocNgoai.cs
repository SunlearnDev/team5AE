using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataTablePrettyPrinter;

namespace ListNhacCaNhan
{



    public class NhacNuocNgoai
    {
        private string description;

        public string Description
        {
            set { this.description = value; }
            get { return this.description; }
        }

        public NhacNuocNgoai : base() {
        
        }   

        public NhacNuocNgoai(string id, string name, string description) : base(string id, string name)
        {
            this.description = description;
        }

        DataTable table2 = new DataTable("NhacNuocNgoai");

        table.Columns.Add("ID", typeof(Int32));
        table.Columns.Add("Name", typeof(String));
        table.Columns.Add("Description", typeof(String));

        table.Rows.Add('1', 'Shape of You', 'Catchy love song');
        table.Rows.Add('2', 'All of Me ', 'Romantic devotion anthem');
        table.Rows.Add('3', 'Rolling the Deepm', 'Soulful breakup anthemu');
        table.Rows.Add('4', 'Love Yourself ', 'Self-love empowerment ballad');
    }

    public void override Nhap() {

    }
}
