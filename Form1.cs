using System;
using System.Linq;
using System.Windows.Forms;

namespace haslo1
{
    public partial class Form1 : Form
    {
        private string imie = "";
        private string nazwisko = "";
        private string stanowisko = "";
        private string haslo = ""; 
        private string ZnakiLitery()
        {
            return checkBox4.Checked ? "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ" : "";
        }

        private string ZnakiSpecjalne()
        {
            return checkBox5.Checked ? "!@#$%^&*()><?:" : "";
        }

        private string ZnakiCyfry()
        {
            return checkBox6.Checked ? "0123456789" : "";
        }

        public Form1()
        {
            InitializeComponent();
            checkBox4.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(imie) || string.IsNullOrWhiteSpace(nazwisko) ||
                string.IsNullOrWhiteSpace(stanowisko) || string.IsNullOrWhiteSpace(haslo))
            {
                MessageBox.Show("Proszę wypełnić wszystkie dane pracownika oraz wygenerować hasło.",
                                "Brak danych", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                MessageBox.Show($"Dane pracownika:\nImię: {imie}\nNazwisko: {nazwisko}\nStanowisko: {stanowisko}\nHasło: {haslo}",
                                "Dane pracownika", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox3.Text, out int dlugosc) || dlugosc <= 0)
            {
                MessageBox.Show("Wprowadź odpowiednią ilość znaków (liczbę całkowitą większą od zera).",
                                "Błąd długości hasła", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (dlugosc > 20)
            {
                MessageBox.Show("Maksymalna długość hasła to 20 znaków.",
                                "Zbyt długa wartość", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }


            string znakiDostepne = ZnakiLitery() + ZnakiCyfry() + ZnakiSpecjalne();


            if (string.IsNullOrEmpty(znakiDostepne))
            {
                MessageBox.Show("Zaznacz przynajmniej jeden typ znaków do wygenerowania hasła (litery, cyfry lub znaki specjalne).",
                                "Brak wyboru znaków", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Random rnd = new Random();
            haslo = new string(Enumerable.Repeat(znakiDostepne, dlugosc)
                .Select(s => s[rnd.Next(s.Length)])
                .ToArray());

            MessageBox.Show($"Wygenerowane hasło: {haslo}", "Hasło wygenerowane", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            nazwisko = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            imie = textBox2.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            stanowisko = comboBox1.Text;
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}