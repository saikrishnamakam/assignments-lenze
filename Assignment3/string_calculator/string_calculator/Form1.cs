using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace string_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void concat_btn_Click(object sender, EventArgs e)
        {
            this.concat_result.Text = this.concat_str1.Text + this.concat_str2.Text;
        }

        private void equality_btn_Click(object sender, EventArgs e)
        {
            this.equality_result.Text = this.equality_str1.Text.Equals(this.equality_str2.Text).ToString();
        }

        private void pelindrome_btn_Click(object sender, EventArgs e)
        {
            string inputString = this.pelindrome_str.Text;

            string reverseOfInputString = Reverse(inputString);

            this.pelindrome_result.Text = inputString.Equals(reverseOfInputString).ToString();
        }

        private string Reverse(string inputString)
        {
            char[] reverseOfInputStringArr = new char[inputString.Length];

            int itr = 0;
            for (int i = inputString.Length - 1; i >= 0; i--)
            {
                reverseOfInputStringArr[itr] = inputString[i];
                itr++;
            }

            return new String(reverseOfInputStringArr);
        }

        private void reverse_str_TextChanged(object sender, EventArgs e)
        {
        }

        private void reverse_btn_Click(object sender, EventArgs e)
        {
            string inputString = this.reverse_str.Text;

            string reverseOfInputString = Reverse(inputString);

            this.reverse_result.Text = reverseOfInputString;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
