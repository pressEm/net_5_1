using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace net_5_1_ui
{
    class DrawNotebook : Notebook
    {
        public int Format { get; set; }
        private int Price { get; set; }
        private int Count_pages { get; set; }
        private int[] Pages { get; set; }
        private string Lining { get; set; }
        private int Density { get; set; }
        private string Colour { get; set; }
        public int[] get_pages()
        {
            return Pages;
        }
        
        public DrawNotebook(int format, int count, string lining, int price, int density, string colour) : base(format, count, lining, price)
        {
            Format = format;
            Count_pages = count;
            Lining = lining;
            Price = price;
            Pages = new int[count];
            Colour = colour;
            Density = density;
        }
        public void draw(int page)
        {
            System.Console.WriteLine("Нарисовать в тетради на странице: " + page);
            Pages[page - 1] = 1;
            for (int i = 0; i < Pages.Length; i++)
            {
                Console.Write(Pages[i] + " ");
            }
            Console.WriteLine();

        }
        public void erase(int page)
        {
            for (int i = 0; i < Pages.Length; i++)
            {
                Console.Write(Pages[i] + " ");
            }
            Console.WriteLine();
            System.Console.WriteLine("Стереть рисунок на стртанице: " + page);
            Pages[page - 1] = 0;
            for (int i = 0; i < Pages.Length; i++)
            {
                Console.Write(Pages[i] + " ");
            }
            Console.WriteLine();

        }

        public void tear_out(int page)
        {
            Console.WriteLine("Вырвать страницу тетради: " + page);
            for (int i = 0; i < Pages.Length; i++)
            {
                Console.Write(Pages[i] + " ");
            }
            Console.WriteLine();
            Count_pages = Count_pages - 1;
            int[] arr = new int[Count_pages];
            Array.Copy(Pages, arr, page);
            Array.Copy(Pages, page, arr, page - 1, arr.Length - page - 1);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            Pages = arr;
        }
         public  string get_string()
        {
            return "Плотность: " + Density + "; Формат: " + Format + "; Цена: " + Price + ";  Количество страниц: " + Count_pages + "; Цвет страниц: " + Colour;

        }

         public override string ToString()
         {
            return "Плотность: " + Density + "; Формат: " + Format + "; Цена: " + Price + "; Количество страниц: " + Count_pages + "; Цвет страниц:: " + Colour;
         }
        
    }
}