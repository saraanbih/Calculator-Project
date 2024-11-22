using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculater
{
    public partial class FrmCalculator : Form
    {
        public FrmCalculator()
        {
            InitializeComponent();
        }

        float Number;
        int Count = 0;

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtStore.Clear();
            txtResult.Clear();
        }

        private void btnzero_Click(object sender, EventArgs e)
        {
            txtStore.Text += "0";
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            txtStore.Text += "1";
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            txtStore.Text += "2";
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            txtStore.Text += "3";
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            txtStore.Text += "4";
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            txtStore.Text += "5";
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            txtStore.Text += "6";
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            txtStore.Text += "7";
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            txtStore.Text += "8";
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            txtStore.Text += "9";
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            txtStore.Text += ".";
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            if(txtStore.Text != "")
            {
                Number = float.Parse(txtStore.Text);
                txtResult.Text = txtStore.Text + " - ";
                txtStore.Clear();
                Count = 1;  
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if(txtStore.Text != "")
            {
                Number = float.Parse(txtStore.Text);
                txtResult.Text = txtStore.Text + " + ";
                txtStore.Clear();
                Count = 2;
            }
        }

        private void BtnMulti_Click(object sender, EventArgs e)
        {
            if(txtStore.Text != "")
            {
                Number = float.Parse(txtStore.Text);
                txtResult.Text = txtStore.Text + " x ";
                txtStore.Clear();
                Count = 3;
            }
        }

        private void btnDevide_Click(object sender, EventArgs e)
        {
            if(txtStore.Text != "")
            {
                Number = float.Parse(txtStore.Text);
                txtResult.Text = txtStore.Text + " / ";
                txtStore.Clear();
                Count = 4;
            }
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            if (txtStore.Text != "")
            {
                Number = float.Parse (txtStore.Text);
                txtResult.Text = txtStore.Text + " % ";
                txtStore.Clear();
                Count = 5;
            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            
            float ans;
            switch (Count)
            {
             case 1:
                    ans = Number - float.Parse(txtStore.Text);
                    txtResult.Text = txtResult.Text + txtStore.Text + " = " + ans;
                    txtStore.Text = ans.ToString();
                    break;
             case 2:
                    ans = Number + float.Parse(txtStore.Text);
                    txtResult.Text = txtResult.Text + txtStore.Text + " = " + ans;
                    txtStore.Text = ans.ToString();
                    break;
            case 3:
                    ans = Number * float.Parse(txtStore.Text);
                    txtResult.Text = txtResult.Text + txtStore.Text + " = " + ans;
                    txtStore.Text = ans.ToString();
                    break;
            case 4:
                    ans = Number / float.Parse(txtStore.Text);
                    txtResult.Text = txtResult.Text + txtStore.Text + " = " + ans;
                    txtStore.Text = ans.ToString();
                    txtStore.Clear();
                    break;
            case 5:
                    ans = Number % float.Parse(txtStore.Text);
                    txtResult.Text = txtResult.Text + txtStore.Text + " = " + ans;
                    txtStore.Text = ans.ToString();
                    break;
            }
        }

        
    }
}