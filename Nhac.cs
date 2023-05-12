using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListNhacCaNhan
{
     class Nhac
    {
        protected string id;
        protected string name;

        public string Name
        {
            set { this.name = value; }
            get { return this.name; }
        }
        public  string Id
        {
            set { this.id = value; }
            get { return this.id; }
        }
        public Nhac() { }
        public Nhac(string id, string name) { this.id = id; this.name = name; }

        public virtual void Nhap()
        {
            Console.Write("Nhap id:  ");
            this.id=Console.ReadLine();
            Console.Write("Nhap name ");
            this.name=Console.ReadLine();
        }
        public virtual void Xuat()
        {
            Console.WriteLine("Id  " + this.id);
            Console.WriteLine("Ten  " + this.name);
        }
    }
}
