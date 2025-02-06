using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Timpark_
{
    public partial class Form2 : Form
    {
        bool ok = false;    
        public Form2()
        {
            InitializeComponent();
        }

        private void parola_TextChanged(object sender, EventArgs e)
        {
            string input = parola.Text;


            bool isValid = Regex.IsMatch(input, @"^(?=.*[A-Z])(?=.*\d).{8,}$");


            if (isValid && nume.Text!=null && parola.Text!=null)
            {
                ok=true;
                conditie.Visible = false;
            }
            else
            {
                ok = false;
                conditie.Visible = true;
                conditie.Text = "! Parola trebuie să conțină minim o literă mare și o cifră si sa aiba 8 caractere.";
                conditie.ForeColor = Color.Red;
            }

        }

        private void confirm_Click(object sender, EventArgs e)
        {
            string cale_fisier = Path.Combine(Environment.CurrentDirectory, "conturi.txt");
            string numele = nume.Text;
            string parol = parola.Text;
            Form3 f = new Form3();
            if (ok == true)
            {
                try
                {

                    string linie = $"{numele},{parol}\n";
                    File.AppendAllText(cale_fisier, linie);

                    MessageBox.Show("V-ați înregistrat cu succes");
                    f.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("A apărut o eroare, reîncercați: ", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning); ;
                }
            }
            else
            {
                MessageBox.Show("Nu ati respectat conditiile parolei");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}


