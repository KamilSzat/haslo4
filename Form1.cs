using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace haslo1
{
    public partial class Form1 : Form
    {
        string imie, nazwisko, stanowisko;
        int haslodl;
        public Form1()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (imie == "" || nazwisko == "" ||  stanowisko == "" )
            {
                MessageBox.Show($"Dane pracownika: {imie}{nazwisko}, Stanowisko: {stanowisko} Hasło: {haslo1}");
                return;
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            nazwisko = textBox1.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            stanowisko = comboBox1.Text;
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            imie = textBox2.Text;
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                if(int.TryParse(checkBox3.Text, out int dlugosc) && dlugosc > 0)
                {
                    haslo1 = maleLitery("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ", dlugosc);
                }
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                if (int.TryParse(checkBox3.Text, out int dlugosc) && dlugosc > 0)
                {
                    haslo1 = cyfry("0123456789", dlugosc);
                }
            }

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                if (int.TryParse(checkBox3.Text, out int dlugosc) && dlugosc > 0)
                {
                    haslo1 = specjalne("!@#$%^&*().,", dlugosc);
                }
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        
    }
}
