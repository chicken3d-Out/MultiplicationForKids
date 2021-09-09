using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computer_Assisted_Instruction
{
    public partial class random_Num1 : Form
    {
        public random_Num1()
        {
            InitializeComponent();
        }

        private void btn_new_RandomNum_Click(object sender, EventArgs e)
        {
            
            Random rnd = new Random();
            int randomnum1 = rnd.Next(0, 9);
            int randomnum2 = rnd.Next(0, 9);

            randomNum1.Text = randomnum1.ToString();
            randomNum2.Text = randomnum2.ToString();
        }
        private void check_Click(object sender, EventArgs e)
        {
            int num1, num2,product_Num,answer_Num;

            num1 = Convert.ToInt32(randomNum1.Text);
            num2 = Convert.ToInt32(randomNum2.Text);

            product_Num = num1 * num2;
            answer_Num = Convert.ToInt32(answer.Text);
            
            if (product_Num == answer_Num)
            {
                MessageBox.Show("Very Good!","Good Job!");
                Random rnd = new Random();

                int randomnum1 = rnd.Next(0, 9);
                int randomnum2 = rnd.Next(0, 9);

                randomNum1.Text = randomnum1.ToString();
                randomNum2.Text = randomnum2.ToString();
                answer.Text = "";
            }
            else
            {
                if (product_Num!= answer_Num)
                {
                    while (product_Num!= answer_Num)
                    {
                        MessageBox.Show("Please Try Again!", "Incorrect",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        break;
                    }
                }
            }
        }
    }
}
