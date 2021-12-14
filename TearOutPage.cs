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
    public partial class TearOutPage : Form
    {

        //public int ind;
        public int page;
        public TearOutPage()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
          
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.ind = Convert.ToInt32(textBox1.Text);
            this.page = Convert.ToInt32(textBox2.Text);
            Close();
        }
    }
}
