using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListNhacCaNhan
{
    internal class Singer : Human
    {
        private char hangSinger;
        
        public char HangSinger
        {
            set { this.HangSinger = value; }
            get { return this.HangSinger}
        public override void Nhap()
        {

            base.Nhap();
            Console.Write("Nhap hang ca si : ");
            this.hangSinger = Conver
        }
        public override void Xuat()
        {
            base.Xuat();
        }
        public Singer() : base() { }
        public Singer(String id, String name, DateTime birth, String gender, char HangSinger) : base() 
        {
           this.hangSinger = hangSinger;
            
        }
    }
}
