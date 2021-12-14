using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_5_1_ui
{
    abstract class Notebook : IPaper
    {
        public int Format { get; set; }
        private int Count_pages { get; set; }
        private int[] Pages { get; set; }
        private string Lining { get; set; }
        private int Price { get; set; }

        public Notebook(int format, int count, string lining, int price)
        {
            Format = format;
            Count_pages = count;
            Lining = lining;
            Price = price;
            Pages = new int[count];
        }

        public void buy()
        {
            System.Console.WriteLine("Покупка тетради: " + Price);

        }
        public void sell()
        {
            System.Console.WriteLine("Продажа тетради: " + Price);

        }
        public void tear_out(int num)
        {
            System.Console.WriteLine("Вырвать страницу тетради: " + num);
            Count_pages -= Count_pages ;

        }
        public void cut()
        {
            System.Console.WriteLine("Резать тетрадь");
            Format += Format;
        }

        public void roll_up()
        {
            System.Console.WriteLine("Свернуть тетрадь");
            Format += Format;
        }

        public string get_string()
        {
            throw new NotImplementedException();
        }
    }
}
