using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace string_substring_practise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string t;
            t = textBox1.Text;
            this.maskedTextBox1.Text = t.Length.ToString();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.birthday_TextBox6.Text = this.birthdate_TB.Text.Substring(0, 2);
            this.birthMonth_TextBox5.Text = this.birthdate_TB.Text.Substring(3, 2);
            this.birthdayYear_TextBox3.Text = this.birthdate_TB.Text.Substring(6, 4);
            Int32 i;
            i = birthdate_TB.Text.Length;
            this.maskedTextBox2.Text = this.birthdate_TB.Text.Substring(i - 4, 4);
            //----------------
            Int32 m;
            Int32.TryParse(birthMonth_TextBox5.Text, out m);
            string a;
            switch (m)
            {
                case 1:
                    a = "January";
                    break;
                case 2:
                    a = "Febrary";
                    break;
                case 3:
                    a = "March";
                    break;
                case 4:
                    a = "april";
                    break;
                case 5:
                    a = "may ";
                    break;
                case 6:
                    a = "june";
                    break;
                case 7:
                    a = "July";
                    break;
                case 8:
                    a = "August";
                    break;
                case 9:
                    a = "September";
                    break;
                case 10:
                    a = "october ";
                    break;
                case 11:
                    a = "novemeber";
                    break;
                case 12:
                    a = "decemeber";
                    break;
                default:
                    a = "unknown";
                    break;
                  
            }
            this.textBox2.Text = a;
        }
    }
}
