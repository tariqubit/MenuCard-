using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuCardSDPro_Maaz_
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            grpburger.Visible = false;
            grpfries.Visible = false;
            grpdrink.Visible = false;
        }

        private void chkburger_CheckedChanged(object sender, EventArgs e)
        {
            
            if (chkburger.Checked) 
            {
                grpburger.Visible = true;
                radchickenBurger.Checked = true;
            }
            else
            {
                grpburger.Visible = false;
            }
        }

        private void chkfries_CheckedChanged(object sender, EventArgs e)
        {
            if (chkfries.Checked)
            {
                grpfries.Visible = true;
                radMasalafries.Checked = true;
            }
            else
            {
                grpfries.Visible = false;
            }
        }

        private void chkdrnk_CheckedChanged(object sender, EventArgs e)
        {
            if (chkdrnk.Checked)
            {
                grpdrink.Visible = true;
                radpepsi.Checked = true;
            }
            else
            {
                grpdrink.Visible = false;
            }
        }

        private void btncost_Click(object sender, EventArgs e)
        {
            double sum = 0;
            {
                if (chkburger.Checked)
                {
                    if (radchickenBurger.Checked)
                    {
                        sum += 130;
                    }
                    else if (radBeefBurger.Checked)
                    {
                        sum += 150;
                    }
                    else if (radzinger.Checked)
                    {
                        sum += 170;
                    }
                    else if (radcheeseburger.Checked)
                    {
                        sum += 140;
                    }
                }
                {
                    if (chkfries.Checked)
                    {
                        if (radMasalafries.Checked)
                        {
                            sum += 50;
                        }
                        else if (radbbqfries.Checked)
                        {
                            sum += 60;
                        }
                        else if (radgarlic.Checked)
                        {
                            sum += 70;
                        }
                        else if (radcheesefries.Checked)
                        {
                            sum += 80;
                        }
                    }
                    {
                        if (radpepsi.Checked)
                        {
                            sum += 30;
                        }
                        else if (radsprite.Checked)
                        {
                            sum += 30;
                        }
                        else if (raddew.Checked)
                        {
                            sum += 40;
                        }
                        else if (radsting.Checked)
                        {
                            sum += 40;
                        }
                    }
                }
                lblcostresult.Text = sum.ToString("Rs: 0");
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            lblcostresult.Text = "";
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
