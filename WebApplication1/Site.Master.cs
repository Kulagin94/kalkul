using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class SiteMaster : MasterPage
    {
        char znak;
        string a;
        string b;
        bool pomnish = false;

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void b1_Click(object sender, EventArgs e)
        {
            TextBox1.Text += "1";
        }

        protected void b2_Click(object sender, EventArgs e)
        {
            TextBox1.Text += "2";
        }

        protected void b3_Click(object sender, EventArgs e)
        {
            TextBox1.Text += "3";
        }


        protected void b4_Click(object sender, EventArgs e)
        {
            TextBox1.Text += "4";
        }

        protected void b5_Click(object sender, EventArgs e)
        {
            TextBox1.Text += "5";
        }

        protected void b6_Click(object sender, EventArgs e)
        {
            TextBox1.Text += "6";
        }
        protected void b7_Click(object sender, EventArgs e)
        {
            TextBox1.Text += "7";
        }

        protected void b8_Click(object sender, EventArgs e)
        {
            TextBox1.Text += "8";
        }

        protected void b9_Click(object sender, EventArgs e)
        {
            TextBox1.Text += "9";
        }

        protected void b0_Click(object sender, EventArgs e)
        {
            TextBox1.Text += "0";
        }

        protected void bdel_Click(object sender, EventArgs e)
        {
            if (pomnish) { schjt(); }
            znak = '/';
            TextBox3.Text = Convert.ToString(znak);
            a = TextBox1.Text;
            TextBox2.Text = a;
            TextBox1.Text += "/";
            pomnish = true;
        }

        protected void bym_Click(object sender, EventArgs e)
        {
            if (pomnish) { schjt(); }
            znak = '*';
            TextBox3.Text = Convert.ToString(znak);
            a = TextBox1.Text;
            TextBox2.Text = a;
            TextBox1.Text += "*";
            pomnish = true;
        }

        protected void bpl_Click(object sender, EventArgs e)
        {
            if (pomnish) { schjt(); }
            znak = '+';
            TextBox3.Text = Convert.ToString(znak);
            a = TextBox1.Text;
            TextBox2.Text = a;
            TextBox1.Text += "+";
            pomnish = true;
        }

        protected void brav_Click(object sender, EventArgs e)
        {
            schjt();
            pomnish = false;
        }
        protected void bmin_Click(object sender, EventArgs e)
        {
            if (pomnish) { schjt(); }
            znak = '-';
            TextBox3.Text = Convert.ToString(znak);
            a = TextBox1.Text;
            TextBox2.Text = a;
            TextBox1.Text += "-";
            pomnish = true;
        }

        protected void btochka_Click(object sender, EventArgs e)
        {
            string rez = "";
            byte i = 0;
            while (i < TextBox1.Text.Length - 1)
            {
                rez += TextBox1.Text[i];
                i++;
            }
            TextBox1.Text = rez;
        }

        public void schjt()
        {
            a = TextBox2.Text;
            znak = Convert.ToChar(TextBox3.Text);
            int i = a.Length + 1;
            
            while (i < TextBox1.Text.Length)
            {
                b += TextBox1.Text[i];
                i++;
           
            }
            TextBox4.Text = b;
            if (znak == '+') { TextBox1.Text = Convert.ToString(Convert.ToDouble(a) + Convert.ToDouble(b)); }
            if (znak == '-') { TextBox1.Text = Convert.ToString(Convert.ToDouble(a) - Convert.ToDouble(b)); }
            if (znak == '*') { TextBox1.Text = Convert.ToString(Convert.ToDouble(a) * Convert.ToDouble(b)); }
            if (znak == '/') { TextBox1.Text = Convert.ToString(Convert.ToDouble(a) / Convert.ToDouble(b)); }
            b = null;
        }

        protected void bc_Click(object sender, EventArgs e)
        {
            TextBox1.Text = null;
            pomnish = false;
        }

        protected void btoch_Click(object sender, EventArgs e)
        {
            TextBox1.Text += ",";
        }

        protected void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}