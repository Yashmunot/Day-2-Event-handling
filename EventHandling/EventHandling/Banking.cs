using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandling
{
    class Banking
    {
        

        public int netBalance { get; set; }
        
        public void OverBalance(int amount)
        {
            double tax = amount * 0.18;
            System.Windows.Forms.MessageBox.Show("You have to pay " + tax + " tax");
        }
        public void UnderBalance()
        {
            System.Windows.Forms.MessageBox.Show("Your balance is less than 5000, please maintain it more than 5000");
        }
        
    }
}
