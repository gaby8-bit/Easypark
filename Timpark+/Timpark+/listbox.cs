using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace Timpark_
{
    public partial class listbox : Form
    {
        List<Parcare> lista = new List<Parcare>();
        public listbox()
        {
            InitializeComponent();
           
            string cale = Path.Combine(Environment.CurrentDirectory, "locuri.txt");
            try
            {
                foreach(string linie in File.ReadAllLines(cale))
                    {
                    string[] date = linie.Split(',');
                    int numar = int.Parse(date[0]);
                    string timp = string.IsNullOrEmpty(date[1])?null:date[1];
                    Parcare p = new Parcare(numar, timp);
                    lista.Add(p);
                }
                foreach(var parc in lista)
                {
                    listBox();
                    listBoxOcupate();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void listBox()
        {
            ParcareBox.Items.Clear();
            foreach (var s in lista)
            {
                if (s.Timp!="8-18")
                    ParcareBox.Items.Add(s.afisare_finala());
       
            }
        }
        private void listBoxOcupate()
        {
            ocupate.Items.Clear();
            foreach (var s in lista)
            {
                if (s.Timp != null)
                    ocupate.Items.Add(s.afisare_finala());

            }
        }
        private void listbox_Load(object sender, EventArgs e)
        {

        }

        private void btnRezerva_Click(object sender, EventArgs e)
        {
            if (ParcareBox.SelectedItem == null)
            {
                MessageBox.Show("Te rog selectează un loc din listă.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string cauta;
            cauta = ParcareBox.SelectedItem.ToString();
            foreach (var a in lista)
            {
               
                int pozitie_start = cauta.IndexOf(":") + 1;
                int pozitie_end = cauta.IndexOf(" ", pozitie_start);
                int cifra = int.Parse(cauta.Substring(pozitie_start, pozitie_end - pozitie_start));
                string timp_cmb = cmbTimp.Text.ToString();
                if (a.Numar==cifra)
                {
                    if (a.Timp == timp_cmb)
                    {
                        MessageBox.Show($"Locul {a.Numar} este deja rezervat între orele {timp_cmb}.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    a.Timp = timp_cmb;
                    ocupate.Items.Add(a.afisare_finala());
                    if(timp_cmb=="8-18")
                    ParcareBox.Items.Remove(cauta);
                   else
                    {
                       
                        if(a.Timp!=timp_cmb)
                        {
                            
                            ocupate.Items.Add("Locul:"+a.Numar+" este rezervat intre orele:"+timp_cmb);
                           
                        

                        }
                          
                      
                    }

                }
            }
          
                
        }
    }
}
