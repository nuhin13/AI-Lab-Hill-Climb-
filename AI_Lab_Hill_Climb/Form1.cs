using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AI_Lab_Hill_Climb
{
    public partial class Form1 : Form
    {
        Random rd = new Random();

        public Form1()
        {
            InitializeComponent();
           
        }

        private void button17_Click(object sender, EventArgs e)
        {
            button1.Text = rd.Next(1, 10).ToString();
            button2.Text = rd.Next(1, 10).ToString();
            button3.Text = rd.Next(1, 10).ToString();
            button4.Text = rd.Next(1, 10).ToString();
            button5.Text = rd.Next(1, 10).ToString();
            button6.Text = rd.Next(1, 10).ToString();
            button7.Text = rd.Next(1, 10).ToString();
            button8.Text = rd.Next(1, 10).ToString();
            button9.Text = rd.Next(1, 10).ToString();
            button10.Text = rd.Next(1, 10).ToString();
            button11.Text = rd.Next(1, 10).ToString();
            button15.Text = rd.Next(1, 10).ToString();
            button12.Text = rd.Next(1, 10).ToString();
            button13.Text = rd.Next(1, 10).ToString();
            button14.Text = rd.Next(1, 10).ToString();
            button16.Text = rd.Next(1, 10).ToString();


            //For Level 4
            int strt = rd.Next(1, 4);
            int flag = 0;

            if (strt == 1) {

                button16.ForeColor = Color.Red;
                flag = 1;
            }
            else  if (strt == 2)
            {
                flag = 2;
                button15.ForeColor = Color.Red;
            }
            else if (strt == 3)
            {
                flag = 3;

                button14.ForeColor = Color.Red;
            }
            else if (strt == 4)
            {
                flag = 4;
                button13.ForeColor = Color.Red;
            }


            int a, b, c,d;
            int minimum, minmum1, minmum2;

            if (flag == 1)
            {
                a = Convert.ToInt32(button12.Text);
                b = Convert.ToInt32(button11.Text);
                minimum = Math.Min(a, b);

                if (minimum == a)
                {

                    button12.ForeColor = Color.Brown;
                }
                else {

                    button11.ForeColor = Color.Brown;
                
                }

            }
           else if (flag == 2)
            {
                a = Convert.ToInt32(button10.Text);
                b = Convert.ToInt32(button11.Text);
                d = Convert.ToInt32(button12.Text);


                minmum1 = Math.Min(a,b);
                minmum2 = Math.Min(b,d);

                minimum = Math.Min(minmum1, minmum2);

                if (minimum == a)
                {

                    button10.ForeColor = Color.Brown;
                }
                else if (minimum == b)
                {

                    button11.ForeColor = Color.Brown;

                }
                else
                {

                    button12.ForeColor = Color.Brown;

                }

            }
            else if (flag == 3)
            {
                a = Convert.ToInt32(button9.Text);
                b = Convert.ToInt32(button10.Text);
                d = Convert.ToInt32(button11.Text);

                minmum1 = Math.Min(a, b);
                minmum2 = Math.Min(b, d);

                minimum = Math.Min(minmum1, minmum2);

                if (minimum == a)
                {

                    button9.ForeColor = Color.Brown;
                }
                else if (minimum == b)
                {

                    button10.ForeColor = Color.Brown;

                }
                else
                {

                    button11.ForeColor = Color.Brown;

                }
            }
            else if (flag == 4)
            {
                a = Convert.ToInt32(button9.Text);
                b = Convert.ToInt32(button10.Text);
                minimum = Math.Min(a, b);

                if (minimum == a)
                {

                    button9.ForeColor = Color.Brown;
                }
                else
                {

                    button10.ForeColor = Color.Brown;

                }

            }

            //For Level 3
            if (button9.ForeColor == Color.Brown) {

                a = Convert.ToInt32(button5.Text);
                b = Convert.ToInt32(button6.Text);
                minimum = Math.Min(a, b);

                if (minimum == a)
                {

                    button5.ForeColor = Color.Blue;
                }
                else
                {

                    button6.ForeColor = Color.Blue;

                }
            
            }

            else if (button10.ForeColor == Color.Brown)
            {
                a = Convert.ToInt32(button5.Text);
                b = Convert.ToInt32(button6.Text);
                d = Convert.ToInt32(button7.Text);

                minmum1 = Math.Min(a, b);
                minmum2 = Math.Min(b, d);

                minimum = Math.Min(minmum1, minmum2);

                if (minimum == a)
                {

                    button5.ForeColor = Color.Blue;
                }
                else if (minimum == b)
                {

                    button6.ForeColor = Color.Blue;

                }
                else
                {

                    button7.ForeColor = Color.Blue;

                }
            }
            else if (button11.ForeColor == Color.Brown)
            {
                a = Convert.ToInt32(button8.Text);
                b = Convert.ToInt32(button6.Text);
                d = Convert.ToInt32(button7.Text);

                minmum1 = Math.Min(a, b);
                minmum2 = Math.Min(b, d);

                minimum = Math.Min(minmum1, minmum2);

                if (minimum == a)
                {

                    button8.ForeColor = Color.Blue;
                }
                else if (minimum == b)
                {

                    button6.ForeColor = Color.Blue;

                }
                else
                {

                    button7.ForeColor = Color.Blue;

                }
            }
            else if (button12.ForeColor == Color.Brown)
            {

                a = Convert.ToInt32(button7.Text);
                b = Convert.ToInt32(button8.Text);
                minimum = Math.Min(a, b);

                if (minimum == a)
                {

                    button7.ForeColor = Color.Blue;
                }
                else
                {

                    button8.ForeColor = Color.Blue;

                }

            }
            //For Level 2

            if (button5.ForeColor == Color.Blue)
            {

                a = Convert.ToInt32(button1.Text);
                b = Convert.ToInt32(button2.Text);
                minimum = Math.Min(a, b);

                if (minimum == a)
                {

                    button1.ForeColor = Color.DarkOrange;
                }
                else
                {

                    button2.ForeColor = Color.DarkOrange;

                }

            }


            else if (button6.ForeColor == Color.Blue)
            {
                a = Convert.ToInt32(button1.Text);
                b = Convert.ToInt32(button2.Text);
                d = Convert.ToInt32(button3.Text);

                minmum1 = Math.Min(a, b);
                minmum2 = Math.Min(b, d);

                minimum = Math.Min(minmum1, minmum2);

                if (minimum == a)
                {

                    button1.ForeColor = Color.DarkOrange;
                }
                else if (minimum == b)
                {

                    button2.ForeColor = Color.DarkOrange;

                }
                else
                {

                    button3.ForeColor = Color.DarkOrange;

                }
            }

            else if (button7.ForeColor == Color.Blue)
            {
                a = Convert.ToInt32(button4.Text);
                b = Convert.ToInt32(button2.Text);
                d = Convert.ToInt32(button3.Text);

                minmum1 = Math.Min(a, b);
                minmum2 = Math.Min(b, d);

                minimum = Math.Min(minmum1, minmum2);

                if (minimum == a)
                {

                    button4.ForeColor = Color.DarkOrange;
                }
                else if (minimum == b)
                {

                    button2.ForeColor = Color.DarkOrange;

                }
                else
                {

                    button3.ForeColor = Color.DarkOrange;

                }
            }
            else if (button8.ForeColor == Color.Blue)
            {

                a = Convert.ToInt32(button3.Text);
                b = Convert.ToInt32(button4.Text);
                minimum = Math.Min(a, b);

                if (minimum == a)
                {

                    button3.ForeColor = Color.DarkOrange;
                }
                else
                {

                    button4.ForeColor = Color.DarkOrange;

                }

            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            button1.Text = "1";
            button2.Text = "2";
            button3.Text = "3";
            button4.Text = "4";
            button5.Text = "5";
            button6.Text = "6";
            button7.Text = "7";
            button8.Text = "8";
            button9.Text = "9";
            button10.Text = "10";
            button11.Text = "11";
            button12.Text = "12";
            button13.Text = "13";
            button14.Text = "14";
            button15.Text = "15";
            button16.Text = "16";

            button1.ForeColor = Color.Black;
            button2.ForeColor = Color.Black;
            button3.ForeColor = Color.Black;
            button4.ForeColor = Color.Black;
            button5.ForeColor = Color.Black;
            button6.ForeColor = Color.Black;
            button7.ForeColor = Color.Black;
            button8.ForeColor = Color.Black;
            button9.ForeColor = Color.Black;
            button10.ForeColor = Color.Black;
            button11.ForeColor = Color.Black;
            button12.ForeColor = Color.Black;
            button13.ForeColor = Color.Black;
            button14.ForeColor = Color.Black;
            button15.ForeColor = Color.Black;
            button16.ForeColor = Color.Black;
        }

        
    }
}
