using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstTest.Items.Add(new clsFunction("1"));
            lstTest.Items.Add(new clsFunction("2"));
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if(lstTest.SelectedIndex != -1)
            {
                lstTest.Items.RemoveAt(lstTest.SelectedIndex);
            }
        }
    }
}
