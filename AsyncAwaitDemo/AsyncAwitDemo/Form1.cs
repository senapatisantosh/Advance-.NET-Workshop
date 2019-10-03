using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncAwitDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "Result = Started";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Complex Logic 
            ComplexLogic();
            label1.Text = "Result = Click Function Executed";

        }

        private void ComplexLogic()
        {
            // Complex Logic 
            Thread.Sleep(5000);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "Hello";
        }
    }
}
