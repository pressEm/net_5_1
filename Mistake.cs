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
    public partial class Mistake : Form
    {
        
        public Mistake(string message)
        {
            InitializeComponent();
            richTextBox1.Text = message;
            ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }

}
