using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace net_5_1_ui
{
    public partial class FormAdd : Form
    {
        public event EventHandler e;
        
        //List<IPaper> list = new List<IPaper>();
        //List<string> ls = new List<string>();
        private IPaper p;

        internal IPaper P { get => p; set => p = value; }

        public FormAdd()
        {
            InitializeComponent();
            

        }
        /*
        public List<IPaper> Get()
        {
            return list;
        }
        */

        private void FormAdd_Load(object sender, EventArgs e)
        {

        }

       
        public void button1_Click_1(object sender, EventArgs e)
        {
            int format = Convert.ToInt32(textBox1.Text);
            int pages = Convert.ToInt32(textBox2.Text);
            string linear = textBox3.Text;
            int price = Convert.ToInt32(textBox4.Text);
            int ro = Convert.ToInt32(textBox5.Text);
            string color = textBox6.Text;
            this.P = new DrawNotebook(format, pages, linear, price, ro, color);
            Close();
            //string str = "Плотность: " + ro + "; Формат: " + format + "; Цена: " + price + ";  Количество страниц: " + pages + "; Цвет страниц: " + color;
            //list.Add(P);
            //ls.Add(str);

            //IPaper p2 = new DrawNotebook(8, 48, "line", 50, 120, "white");
            //string st = p2.ToString();

        }

      

        /*
        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(Convert.ToInt32(textBox7.Text));
        }
        */


    }
}
