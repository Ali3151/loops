using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace whileLoop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEven_Click(object sender, EventArgs e)
        {
            int i = 1;
            int j = 0;
            while (i < 30)
            {
                i++;
                j = i % 2;
                if(j == 0)
                {
                    Even.Items.Add(i);
                }
            }
          
            }

        private void btnOdd_Click(object sender, EventArgs e)
        {
            int i = 0;
            int j = 0;
            while (i < 30)
            {
                i++;
                j = i % 2;
               
                if (j != 0)
                {
                        Odd.Items.Add(i);
                }
            }

        }
    }
}
