using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InterfataUtilizator_WindowsForms
{
    public partial class PaginaLogare : Form
    {
        public PaginaLogare()
        {
            InitializeComponent();
        }

        private void butLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(txtNume.Text == string.Empty))
                {
                    if (!(txtParola.Text == string.Empty))
                    {
                        
                        
                        if (txtNume.Text=="Adriana"&&txtParola.Text=="1234")
                        {
                            this.Hide();
                            Form1 f2 = new Form1();  
                            f2.ShowDialog();
                          
                        }
                        else
                        if (txtNume.Text != "Adriana" && txtParola.Text == "1234")
                        {
                            MessageBox.Show(" Numele este incorect!", "Logare Pagina");
                            txtNume.Text = string.Empty;
                        }
                        else
                        if (txtNume.Text == "Adriana" && txtParola.Text != "1234")
                        {
                            MessageBox.Show(" Parola este incorect!", "Logare Pagina");
                            txtParola.Text = string.Empty;
                        }
                        else
                        {
                            MessageBox.Show(" Numele si parola sunt incorecte!", "Logare Pagina");
                            txtNume.Text = txtParola.Text = string.Empty;
                        }
                    }
                    else
                    {
                        MessageBox.Show(" Camp Parola necompletat!", "Logare Pagina");
                      
                    }
                }
                else
                {
                    MessageBox.Show(" Camp Nume necompletat", "Logare Pagina");
                }
             
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void butIntoarcere_Click(object sender, EventArgs e)
        {
            this.Hide();
            PrimaPagina f2 = new PrimaPagina();
            f2.ShowDialog();
        }

        private void PaginaLogare_Load(object sender, EventArgs e)
        {

        }

        private void txtNume_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

