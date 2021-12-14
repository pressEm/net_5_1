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
    public partial class Form1 : Form
    {
        public event EventHandler add;
        List<IPaper> list = new List<IPaper>();
        List<string> ls = new List<string>();
        
        public Form1()
        {
            InitializeComponent();
            IPaper p2 = new DrawNotebook(8, 48, "line", 50, 120, "white");
            IPaper p3 = new DrawNotebook(8, 60, "empty", 100, 300, "black");
            IPaper p4 = new DrawNotebook(8, 24, "empty", 30, 30, "white");
            string st2 = p2.ToString();
            string st3 = p3.ToString();
            string st4 = p4.ToString();

            list.Add(p2);
            list.Add(p3);
            list.Add(p4);
            listBox1.Items.Add(st2);
            listBox1.Items.Add(st3);
            listBox1.Items.Add(st4);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                FormAdd fadd = new FormAdd();
                fadd.ShowDialog();
                IPaper p = fadd.P;
                list.Add(p);
                listBox1.Items.Add(p.ToString());
            }
            catch (Exception exception)
            {
                Mistake mistake = new Mistake(exception.Message);
                CleanAllTextBoxesIn(this);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                list.RemoveAt(listBox1.SelectedIndex);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);

            }
            catch(Exception exception)
            {
                Mistake mistake = new Mistake(exception.Message);
                CleanAllTextBoxesIn(this);
            }
        }

      
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                TearOutPage fadd = new TearOutPage();
                fadd.ShowDialog();
                DrawNotebook dn = (DrawNotebook)list[listBox1.SelectedIndex];
                dn.tear_out(fadd.page);
                list.RemoveAt(listBox1.SelectedIndex);
                list.Add(dn);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                listBox1.Items.Add(dn);
                // listBox1.Items.GetEnumerator
                //IPaper p = fadd.P;
                //listBox1.Items.Add(p.ToString());
            }
            catch (Exception exception)
            {
                Mistake mistake = new Mistake(exception.Message);
                CleanAllTextBoxesIn(this);
            }

        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {

                //DrawNotebook dn = (DrawNotebook)list[listBox1.SelectedIndex];
                //FormOpen fop = new FormOpen(dn.get_pages(), list, listBox1.SelectedIndex);
                //fop.ShowDialog();
               
                
               
                // listBox1.Items.GetEnumerator
                //IPaper p = fadd.P;
                //listBox1.Items.Add(p.ToString());
            }
            catch (Exception exception)
            {
                Mistake mistake = new Mistake(exception.Message);
                CleanAllTextBoxesIn(this);
            }

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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

     
    }
}
