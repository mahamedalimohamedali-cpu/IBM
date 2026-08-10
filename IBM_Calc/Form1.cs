using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IBM_Calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        struct stData 
        {
            public double Wait;
            public double Length; 
        }

        stData ConvertTobyte()
        {
            stData Data=new stData();
            Data.Wait   = Convert.ToDouble(textBox1.Text);
            Data.Length = Convert.ToDouble(textBox2.Text);
            return Data;
        }

        double CalculatTheIBM() 
        {
            stData Data  = ConvertTobyte();

            double Result =(Data.Wait/(Data.Length*Data.Length)) ;

            return Result;
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            double Result = CalculatTheIBM();

            textBox3.Text = Result.ToString();
            
        }

        private void Mouse_EnterCala(object sender, EventArgs e)
        {
            button1.BackColor = Color.Green;
        }

        private void Mouse_LeaveCala(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
        }

       
    }
}
