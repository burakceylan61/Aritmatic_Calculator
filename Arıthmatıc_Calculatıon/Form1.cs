using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arıthmatıc_Calculatıon
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

            //kare kenar 
            try
            {
                int kenaruzunluk = Convert.ToInt32(textBox1.Text);
                int alan = kenaruzunluk * kenaruzunluk;
                label4.Text = alan.ToString();

              
            }
            catch (Exception)
            {

                //throw;
            }
            try
            {
                // dikdörtgen alan

                int dikdörtgenkısa = Convert.ToUInt16(textBox7.Text);
                int dikdörtgenuzun = Convert.ToUInt16(textBox2.Text);
                int dikalan = dikdörtgenkısa * dikdörtgenuzun;
                label5.Text = dikalan.ToString();

            }
            catch (Exception)
            {

      
            }
            try
            {

                // daire alan 

                int daire = Convert.ToInt16(textBox5.Text);
                int dairealan = (int)Math.PI * (daire * daire);
                label9.Text = dairealan.ToString();
            }
            catch (Exception)
            {

               
            }          


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if(textBox7.Text != null  || textBox7.Text != "")
            {
                int dikdörtgenkısa = Convert.ToUInt16(textBox7.Text);
                int dikdörtgenuzun = Convert.ToUInt16(textBox2.Text);
                int dikalan = dikdörtgenkısa * dikdörtgenuzun;
                label5.Text = dikalan.ToString();
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text != null || textBox1.Text  !="")
            {
                int kenaruzunluk = Convert.ToInt32(textBox1.Text);
                int alan = kenaruzunluk * kenaruzunluk;
                label4.Text = alan.ToString();
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text != null || textBox5.Text != "")
            {
                int daire = Convert.ToInt16(textBox5.Text);
                int dairealan = (int)Math.PI * (daire * daire);
                label9.Text = dairealan.ToString();
            }
        }
    }
}
