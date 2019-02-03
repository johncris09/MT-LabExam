using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MT_06_MANABO
{
    public partial class frmCalculator : Form
    {
        public frmCalculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtfnum.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtfnum.Text == "" || txtsnum.Text == "")
                {
                    MessageBox.Show("Please Input some fields", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                else
                {
                    double fnum = Double.Parse(txtfnum.Text);
                    double snum = Double.Parse(txtsnum.Text);
                    double result = fnum + snum;
                    lblResult.Text = Convert.ToString(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtfnum.Text == "" || txtsnum.Text == "")
                {
                    MessageBox.Show("Please Input some fields", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                else
                {
                    double fnum = Double.Parse(txtfnum.Text);
                    double snum = Double.Parse(txtsnum.Text);
                    double result = fnum - snum;
                    lblResult.Text = Convert.ToString(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtfnum.Text == "" || txtsnum.Text == "")
                {
                    MessageBox.Show("Please Input fields", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                else
                {
                    double fnum = Double.Parse(txtfnum.Text);
                    double snum = Double.Parse(txtsnum.Text);
                    double result = fnum * snum;
                    lblResult.Text = Convert.ToString(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtfnum.Text == "" || txtsnum.Text == "")
                {
                    MessageBox.Show("Please Input some fields", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                else
                {
                    double fnum = Double.Parse(txtfnum.Text);
                    double snum = Double.Parse(txtsnum.Text);
                    double result = fnum / snum;
                    lblResult.Text = Convert.ToString(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtfnum.Text == "" )
                {
                    MessageBox.Show("Please Input some fields", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                else
                {
                    double fnum = Double.Parse(txtfnum.Text);
                    double result = fnum %  2;
                    lblResult.Text = Convert.ToString(result);
                }
             }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        }
    }
}
