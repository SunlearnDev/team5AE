using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListNhacCaNhan
{
    internal class Human
    {
        protected String id;
        protected String name;
        protected DateTime birthday;
        protected String gender;
        public String ID
        {
            set { this.id = value; }
            get { return this.id; }
        }
        public String Name
        {
            set { this.name = value; }
            get { return this.name; }
        }
        public DateTime Birthday
        {
            set { this.birthday = value; }
            get { return this.birthday; }
        }
        public String Gender
        {
            set { this.gender = value; }
            get { return this.gender; }
        }
        public virtual void Xuat()
        {
            Console.WriteLine("ID: " + this.id);
            Console.WriteLine("Ho ten: " + this.name);
            Console.WriteLine("Ngay sinh: " + this.birthday.ToString("dd/MM/yyyy"));
            Console.WriteLine("Gioi tinh: " + this.gender);
        }
        public virtual void Nhap()
        {
            //Console.Write("ID: ");
            //this.id = Console.ReadLine();
            Console.Write("Ho ten: ");
            this.name = Console.ReadLine();
            Console.Write("Ngay sinh: ");
            this.birthday = DateTime.Parse(Console.ReadLine());
            Console.Write("Gioi tinh: ");
            this.gender = Console.ReadLine();
        }
        public Human() { }
        public Human(string id, string name, DateTime birthday, string gender)
        {
            this.id = id;
            this.name = name;
            this.birthday = birthday;
            this.gender = gender;
        }
    }
}
