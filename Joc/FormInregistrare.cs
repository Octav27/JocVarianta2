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

namespace Joc
{
    
    public partial class FormInregistrare : Form
    {

        private static string nume="";

         static public string getNume()
        {
            return nume;
        }
        


        public FormInregistrare()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (numeJucator.Text=="")
            {
                labelError.Text = "Numele trebuie să conțină caractere!";
                labelError.ForeColor = Color.Red;
            }
            else if (numeJucator.Text.Contains(' '))
            {
                labelError.Text = "Numele nu trebuie să conțină spații!";
                labelError.ForeColor = Color.Red;

            }
            else
            {
          
                if(new FileInfo(@"C:\\Users\\Octav\\source\\repos\\Joc\Joc\\Jucatori.txt").Length == 0)
                {
                    nume = numeJucator.Text;
                    this.Hide();
                    Form1 joc = new Form1();
                    joc.ShowDialog();
                    this.Close();
                }

                bool notOk = false;
                foreach(string line in File.ReadLines(@"C:\\Users\\Octav\\source\\repos\\Joc\Joc\\Jucatori.txt"))
                {
                    int index = line.IndexOf(' ');
                    string numele = line.Substring(0, index);
                    if (numele.Equals(numeJucator.Text))
                    {
                        labelError.Text = "Exista deja asa un jucator";
                        labelError.ForeColor = Color.Red;
                        notOk = true;
                    }
                }

                if (!notOk)
                {
                    nume = numeJucator.Text;
                    this.Hide();
                    Form1 joc = new Form1();
                    joc.ShowDialog();
                    this.Close();
                }

            }
        }

        private void Inchide(object sender, FormClosedEventArgs e)
        {
            
            
        }

        private void FormInregistrare_Load(object sender, EventArgs e)
        {

        }

        private void labelError_Click(object sender, EventArgs e)
        {

        }
    }
}
