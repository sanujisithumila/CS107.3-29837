using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Sheet08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btnClear_Click(object sender, EventArgs e)
        {
            txtGrossSal.Text = "";
            txtTaxP.Text = "";
            lblTaxAmt.Text = "";
            lblNetSal.Text = "";

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            CalcTax();
            CalcNetSalary();
            MessageBox.Show("Net Salary:" + lblNetSal.Text, "Net Salary", MessageBoxButtons.OK, MessageBoxIcon.Information);

            /*double sal = Convert.ToDouble(txtGrossSal.Text);
             double taxper = Convert.ToDouble(txtTaxP.Text);
            double tax = CalcTax(sal,taxper);
            double netSal = CalcNetSal(sal,tax);
            lblTaxSal.Text = tax.Tostring();
            lblNetSal.Text = netSal.Tostring();
             */

        }

        public void CalcTax()
        {

            double sal = Convert.ToDouble(txtGrossSal.Text);
            double taxper = Convert.ToDouble(txtTaxP.Text);
            double tax = (sal * taxper) / 100;
            lblTaxAmt.Text = Convert.ToDouble(tax).ToString();

        }



        public void CalcNetSalary()
        {
            double sal = Convert.ToDouble(txtGrossSal.Text);
            double tax = Convert.ToDouble(lblTaxAmt.Text);
            double netSal = sal - tax;
            lblNetSal.Text = Convert.ToDouble(netSal).ToString();
        }

        /*private double CalcTax(double sal, double taxPer)
         {
            return (sal * taxper) / 100;
         }

          private void CalcNetSal(double sal, double tax)
          {
                return netSal = sal - tax;
          } */

    }
}
