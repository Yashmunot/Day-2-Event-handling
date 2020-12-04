using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventHandling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Banking bng = new Banking();
            bng.netBalance = Convert.ToInt32(textBox1.Text);
            if (bng.netBalance >= 100000)
            {
                bng.OverBalance(bng.netBalance);
            }
            else if (bng.netBalance <= 5000)
            {
                bng.UnderBalance();
            }
            else
            {
                MessageBox.Show("No need to pay tax!!!");
            }
           
            
        }
    }
}
