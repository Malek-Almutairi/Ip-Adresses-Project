using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IPAddress
{
    public partial class Form1 : Form
    {
        int flag2 = -1;
        int flag1 = -1;
        string convert_to_Binary(int n)
        {
            int i;
            int[] a = new int[8];
            for (i = 0; n > 0; i++)
            {
                a[i] = n % 2;
                n = n / 2;
            }

            string x = "";
            for (i = 7; i >= 0; i--)
            {
                x += a[i];
            }
            return x;

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnDetect_Click(object sender, EventArgs e)
        {

            if (int.Parse(txt1.Text) >= 0 && int.Parse(txt1.Text) <= 127)
            {
                lblMsg.Text = "Class A";
                flag2 = 1;
            }
            else if (int.Parse(txt1.Text) >= 128 && int.Parse(txt1.Text) <= 191)
            {
                lblMsg.Text = "Class B";
                flag2 = 2;

            }
               
            else if (int.Parse(txt1.Text) >= 192 && int.Parse(txt1.Text) <= 223)
            {
                lblMsg.Text = "Class C";
                flag2 = 3;

            }
               
            else if (int.Parse(txt1.Text) >= 224 && int.Parse(txt1.Text) <= 239)
            {
                lblMsg.Text = "Class D";
                flag2 = 4;

            }
                
            else if (int.Parse(txt1.Text) >= 240 && int.Parse(txt1.Text) <= 255)
            {
                lblMsg.Text = "class E";
                flag2 = 4;

            }
                
        }

      
        private void BtnCheck_Click(object sender, EventArgs e)
        {
            lblMsg.Text = "";
            int flag5 = -1;
            int flag6 = -1;
            int flag7 = -1;
            Boolean t1 = false, t2 = false, t3 = false, t4 = false;

            if (int.Parse(txt1.Text) >= 0 && int.Parse(txt1.Text) <= 255)
            {
                t1 = true;
                
                


            }

            if (int.Parse(txt2.Text) >= 0 && int.Parse(txt2.Text) <= 255)

            {
                t2 = true;
                if (int.Parse(txt2.Text) == 0)
                {
                    flag5 = 1;
                }
            }
            if (int.Parse(txt3.Text) >= 0 && int.Parse(txt3.Text) <= 255)

            {
                t3 = true;
                if (int.Parse(txt3.Text) == 0)
                {
                    flag6 = 1;
                }
            }
            if (int.Parse(txt4.Text) >= 0 && int.Parse(txt4.Text) <= 255)
            {
                t4 = true;
                flag1 = 1;
                if (int.Parse(txt4.Text) == 0)
                {
                    flag7 = 1;
                }
            }
            if (int.Parse(txt1.Text) <= 127)
            {
                if (flag5 == -1 || flag6 == -1 || flag7 == -1)
                { 
                    if (t1 == true && t2 == true && t3 == true && t4 == true)
                    { 
                            
                        lblMsg.Text = "IP Address is Valid";
                        lblMsg.ForeColor = Color.Green;
                    }
                    else
                    {
                        lblMsg.Text = "IP Address is not Valid";
                        lblMsg.ForeColor = Color.Red;
                    }

                }
                else
                {
                    lblMsg.Text = "IP Address is not Valid";
                    lblMsg.ForeColor = Color.Red;
                }
            }

            if (int.Parse(txt1.Text) >= 128 && int.Parse(txt1.Text) <= 191)
            {
                if (flag6 == -1 || flag7 == -1)
                {
                    if (t1 == true && t2 == true && t3 == true && t4 == true)
                    {

                        lblMsg.Text = "IP Address is Valid";
                        lblMsg.ForeColor = Color.Green;
                    }
                    else
                    {
                        lblMsg.Text = "IP Address is not Valid";
                        lblMsg.ForeColor = Color.Red;
                    }
                }
                else
                {
                    lblMsg.Text = "IP Address is not Valid";
                    lblMsg.ForeColor = Color.Red;
                }
            }

            if (int.Parse(txt1.Text) >= 192 && int.Parse(txt1.Text) <= 223)
            {
                if (flag7 == -1)
                {
                    if (t1 == true && t2 == true && t3 == true && t4 == true)
                    {

                        lblMsg.Text = "IP Address is Valid";
                        lblMsg.ForeColor = Color.Green;
                    }
                    else
                    {
                        lblMsg.Text = "IP Address is not Valid";
                        lblMsg.ForeColor = Color.Red;
                    }
                }
                else
                {
                    lblMsg.Text = "IP Address is not Valid";
                    lblMsg.ForeColor = Color.Red;
                }
            }


        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            if (int.Parse(txt1.Text) >= 0 && int.Parse(txt1.Text) <= 127)
            {
               m1.Text="255";
               m2.Text = "0";
               m3.Text = "0";
               m4.Text = "0";
            }
            else if (int.Parse(txt1.Text) >= 128 && int.Parse(txt1.Text) <= 191)
            {
                m1.Text = "255";
                m2.Text = "255";
                m3.Text = "0";
                m4.Text = "0";
            }
            else if (int.Parse(txt1.Text) >= 192 && int.Parse(txt1.Text) <= 223)
            {
                m1.Text = "255";
                m2.Text = "255";
                m3.Text = "255";
                m4.Text = "0";
            }
            else 
            {
                m1.Text = "";
                m2.Text = "";
                m3.Text = "";
                m4.Text = "";
            }

        }
        
            

    private void button5_Click(object sender, EventArgs e)
        {
            {
               

               
            }
            {
               label5.Text = convert_to_Binary(int.Parse(txt1.Text));
                label6.Text = convert_to_Binary(int.Parse(txt2.Text));
                label7.Text = convert_to_Binary(int.Parse(txt3.Text));
                label8.Text = convert_to_Binary(int.Parse(txt4.Text));
            }



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(flag1==1)
            {
                if(flag2==1)
                {
                    lblMsg.Text = txt1.Text + ".255.255.255";
                }
                if (flag2 == 2)
                {
                    lblMsg.Text = txt1.Text +"."+txt2.Text+ ".255.255";
                }
                if (flag2 == 3)
                {
                    lblMsg.Text = txt1.Text + "." + txt2.Text + "."+txt3.Text+".255";
                }
                if (flag2 == 4)
                {
                    MessageBox.Show("Class D and E has no broadacast");
                }
            }


        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (flag1 == 1)
            {
                if (flag2 == 1)
                {
                    lblMsg.Text = txt1.Text + ".0.0.0";
                }
                if (flag2 == 2)
                {
                    lblMsg.Text = txt1.Text + "." + txt2.Text + ".0.0";
                }
                if (flag2 == 3)
                {
                    lblMsg.Text = txt1.Text + "." + txt2.Text + "." + txt3.Text + ".0";
                }
                if (flag2 == 4)
                {
                    MessageBox.Show("Class D and E has no broadacast");
                }
            }
        }
    }
    }

