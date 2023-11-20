using CalculatorPrivateAssembly;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BasicCalculator
{
    public partial class FrmBasicCalcultor : Form
    {
        public FrmBasicCalcultor()
        {
            InitializeComponent();
        }

        private void FrmBasicCalcultor_Load(object sender, EventArgs e)
        {

        }

        private void btnCompute_Click(object sender, EventArgs e)
        {

            if (txtBox1.Text.Equals("")|| txtBox2.Text.Equals(""))
            {
                MessageBox.Show("Please input number!");
            }
            else
            {
                float num1 = (float)Convert.ToDouble(txtBox1.Text);
                float num2 = (float)Convert.ToDouble(txtBox2.Text);

                if (comboBox1.Text == "+")
                {
                    float total = BasicComputation.Addition(num1, num2);
                    //string total = total.ToString();
                    richTextBox1.Text = "Total: /n" + total.ToString();
                }
                else if (comboBox1.Text.Equals("-"))
                {
                    float total = BasicComputation.Subtraction(num1, num2);
                    richTextBox1.Text = "Total: " + total.ToString();
                }
                else if (comboBox1.Text.Equals("*"))
                {
                    float total = BasicComputation.Multiplication(num1, num2);
                    richTextBox1.Text = "Total: " + total.ToString();
                }
                else if (comboBox1.Text.Equals("/"))
                {
                    float total = BasicComputation.Division(num1, num2);
                    richTextBox1.Text = "Total: " + total.ToString();
                }
                else
                {
                    MessageBox.Show("Please Select Operator");
                }
            }
            
            
        }
    }
}
