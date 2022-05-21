using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loops
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
           
        {
            listBox1.Items.Clear();
            if (checkBox1.Checked)
            {
                for (int i = 1; i <= 30; i++)
                {
                    if(i == 11)
                    {
                        break;
                    }
                    listBox1.Items.Add(i.ToString());

                }
            }
            else
            {
                for (int i = 30; i >= 1; i--)
                {
                    if(i == 20)
                    {
                        continue;
                    }
                    listBox1.Items.Add(i.ToString());

                }
            }
            
        }

        
    }
}
