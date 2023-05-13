using System;
using System.Collections.Generic;
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
            base.Xuat();
        }
        public Singer() : base() { }
        public Singer(String id, String name, DateTime birth, String gender) : base(id, name, birth, gender) {}
    }
}
