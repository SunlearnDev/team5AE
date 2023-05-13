using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                if (singer != null) this.singers.Add(singer.ID, singer);
                Console.Write("\nNhap ky tu 'y' de tiep tuc: ");
                c = Convert.ToChar(Console.ReadLine().ToLower());
            }
        }
        public void Xuat()
        {
            Console.WriteLine("DANH SACH CA SI\n");
            foreach (Human singer in this.singers.Values)
            {
                singer.Xuat();
            }        
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
    }
}
