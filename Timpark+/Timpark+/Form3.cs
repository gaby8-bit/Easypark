using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timpark_
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            timer1 = new Timer();
            timer1.Interval = 100;
            timer1.Tick += new EventHandler(timer1_Tick);
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(progressBar1.Value>=progressBar1.Maximum)
            {
                timer1.Stop();
                MessageBox.Show("V-ati logat cu succes");
                listbox l = new listbox();
                l.ShowDialog();

            }
            else
            {
                progressBar1.Value += 2;
            }
        }

        private void confirmare_Click(object sender, EventArgs e)
        {
            string cale_fisier= Path.Combine(Environment.CurrentDirectory, "conturi.txt");
            string numele = nume.Text;
            string parol = parola.Text;
            bool logat=false;
            try
            {
                string[] linii=File.ReadAllLines(cale_fisier);
                foreach(string line in linii)
                {
                    string[] parti=line.Split(',');
                    if(parti.Length>1)
                    {
                        string numefisier=parti[0];
                        string parolfisier=parti[1];
                        if(numefisier==numele && parolfisier==parol)
                        {
                            logat = true;
                            break;
                        }

                    }
                }
                if (logat)
                {
                    progressBar1.Value = 0;
                    timer1.Start();
               
                }
                else
                { 
                    MessageBox.Show("Nume/parola gresite","Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
           
            catch (Exception ex)
            {
                MessageBox.Show("A apărut o eroare: " + ex.Message);
            }
          
        }
    }
}
