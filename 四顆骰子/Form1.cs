using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 四顆骰子
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblTimes.Visible=false;
            lblResult.Visible=false;
            lblPoint.Visible=false;
            lblTimes.Text = String.Empty;
            lblResult.Text = String.Empty;
            lblPoint.Text = String.Empty;
        }
        int times = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            
            int seed = Guid.NewGuid().GetHashCode();
            var random = new Random(seed);
            int number1 = random.Next(1, 7);
            int number2 = random.Next(1, 7);
            int number3 = random.Next(1, 7);
            int number4 = random.Next(1, 7);
            int point;
            int result;
            while (number1 != number2 && number1 != number3&&
                   number1 != number4 && number2 != number3&&
                   number2 != number4 && number3 != number4)
            {
                number2 = random.Next(1, 7);
                number3 = random.Next(1, 7);
                number4 = random.Next(1, 7);
            }
            int[] numberAr = { number1, number2, number3, number4 };
            result = number1 * 1000 + number2 * 100 + number3 * 10 + number4;
            Array.Sort(numberAr);

            if (numberAr[0]== numberAr[1])
            {
                point = numberAr[2] + numberAr[3];
            } 
            else if(numberAr[1] == numberAr[2])
            {
                point = numberAr[0] + numberAr[3];
            }
            else
            {
                point = numberAr[0] + numberAr[1];
            }
            times += 1;
            lblTimes.Visible = true;
            lblResult.Visible = true;
            lblPoint.Visible = true;
            lblTimes.Text += $"{times}\r\n";
            lblResult.Text += $"{result}\r\n";
            lblPoint.Text += $"{point}\r\n";
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            times = 0;
            lblTimes.Text = String.Empty;
            lblResult.Text = String.Empty;
            lblPoint.Text = String.Empty;
        }
    }
}
