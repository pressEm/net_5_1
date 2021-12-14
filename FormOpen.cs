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
    public partial class FormOpen : Form
    {
        public int[] pages;
        private IPaper p;

        internal IPaper P { get => p; set => p = value; }

        public FormOpen (int[] pages)
        {
            this.pages = pages;
            //this.p = p;
            InitializeComponent();
            richTextBox1.Text = set_pages(pages);
        }

        private string set_pages(int[] pages)
        {
            string str = "";

            for (int i = 0; i < pages.Length; i++)
            {
                str += Convert.ToString(pages[i]) + " ";

            }
            return str;
        }


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

      
       
        private static void CleanAllTextBoxesIn(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c.GetType() == typeof(TextBox))
                    c.Text = string.Empty;

                if (c.GetType() == typeof(GroupBox))
                    CleanAllTextBoxesIn(c);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}

