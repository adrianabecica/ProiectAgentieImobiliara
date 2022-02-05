using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibrarieAgentie;
using NivelAccesDate;
using Agentie_Imobiliara;
using System.Collections;

namespace InterfataUtilizator_WindowsForms
{
    public partial class FormBeneficiar : Form
    {
        IStocareData_Beneficiar adminBeneficiari = StocareFactory.GetAdministratorStocareBeneficiar();
        IStocareData adminImobiliare = StocareFactory.GetAdministratorStocare();
        bool validare = true;
        public FormBeneficiar()
        {
            InitializeComponent();
        }

        private void FormBeneficiar_Load(object sender, EventArgs e)
        {

        }

   
        private void butAfisareOferta_Click_1(object sender, EventArgs e)
        {

            lstImobiliare.Items.Clear();
            var antetTabel = String.Format("{0,-10}\t{1,0}\t{2,15}\t{3,5}\t{4,5}\t{5,5}\t{6,5}\t{7,5}\t{8,5}\n", "Tip", "Suprafata", "Strada", "Nr", "Bloc", "Scara", "Numar apartament", "Pret", "Grad");
            lstImobiliare.Items.Add(antetTabel);




            List<Imobiliar> imobiliare = adminImobiliare.GetImobiliare();


            foreach (Imobiliar i in imobiliare)
            {
                if (i.Tip == "vanzare")
                {
                    var linieTabel = String.Format("{0,-10}\t{1,7}\t\t{2,-3}\t{3,5}\t{4,5}\t{5,5}\t{6,15}\t{7,5}\t{8,5}\n\n", i.Tip, i.Suprafata, i.Strada, i.Nr, i.Bloc, i.Scara, i.Nr_apartament, i.Pret, i.Grad.ToString());
                    lstImobiliare.Items.Add(linieTabel);
                }
            }
        }

        private void butCumpara_Click(object sender, EventArgs e)
        {
            bool validare = true;
            if (!DateIntrareValide())
            {
                lblNume.ForeColor = Color.Red;
                lblPrenume.ForeColor = Color.Red;
                lblCNP.ForeColor = Color.Red;
                
                MessageBox.Show("Campuri obligatoriu de completat");
                //  resetareControale();

                validare = false;
            }


            if (validare == true)
            {

                lblNume.ForeColor = Color.Black;
                lblPrenume.ForeColor = Color.Black;
                lblCNP.ForeColor = Color.Black;

                Imobiliar imobiliar_modificat = adminImobiliare.GetImobiliar(lstImobiliare.SelectedIndex);
                imobiliar_modificat.Tip = "cumparat";
                Beneficiar b = new Beneficiar(txtNume.Text, txtPrenume.Text, int.Parse(txtCNP.Text));
                adminBeneficiari.AddBeneficiar(b);
                adminImobiliare.UpdateImobiliar(imobiliar_modificat);

                lblNume.ForeColor = Color.Black;
                lblPrenume.ForeColor = Color.Black;
                lblCNP.ForeColor = Color.Black;
            }
            resetareControale();
            lblNume.ForeColor = Color.Black;
            lblPrenume.ForeColor = Color.Black;
            lblCNP.ForeColor = Color.Black;
        }


        private void lstImobiliare_SelectedIndexChanged(object sender, EventArgs e)
        {
            Imobiliar imobiliar_selectat = adminImobiliare.GetImobiliar(lstImobiliare.SelectedIndex);
          
        }

        public void resetareControale()
        {
            lblNume.ForeColor = Color.Black;
            lblPrenume.ForeColor = Color.Black;
            lblCNP.ForeColor = Color.Black;
            txtNume.Text = txtPrenume.Text = txtCNP.Text= String.Empty;
           

        }
        bool DateIntrareValide()
        {


            if (txtNume.Text == String.Empty || txtPrenume.Text == String.Empty || txtCNP.Text == String.Empty )
                return false;

            return true;
        }

        private void butIntoarcere_Click(object sender, EventArgs e)
        {
            this.Hide();
            PrimaPagina f2 = new PrimaPagina();
            f2.ShowDialog();
        }

        private void txtNume_TextChanged(object sender, EventArgs e)
        {
            validare = true;
            if (txtNume.Text == "")
            {
                lblNume.ForeColor = Color.Red;
                validare = false;
            }
            else
            {

                string s = txtNume.Text;
                for (int i = 0; i < s.Length; i++)
                    if (!char.IsLetter(s[i]))
                    {
                        lbleroareNume.Text = "SE INTODUC DOAR LITERE";
                        lbleroareNume.Visible = true;
                        lbleroareNume.ForeColor = Color.Red;
                        validare = false;


                    }


            }
            if (validare == true)
            {
                lblPrenume.ForeColor = Color.Black;

                lbleroareNume.Visible = false;
                lbleroareNume.Text = "";
                lbleroareNume.ForeColor = Color.Transparent;
                lblNume.ForeColor = Color.Black;

            }
        }

        private void txtPrenume_TextChanged(object sender, EventArgs e)
        {
            validare = true;
            if (txtPrenume.Text == "")
            {
                lblPrenume.ForeColor = Color.Red;
                validare = false;
            }
            else
            {

                string s = txtPrenume.Text;
                for (int i = 0; i < s.Length; i++)
                    if (!char.IsLetter(s[i]))
                    {
                        lbleroarePrenume.Text = "SE INTODUC DOAR LITERE";
                        lbleroarePrenume.Visible = true;
                        lbleroarePrenume.ForeColor = Color.Red;
                        validare = false;


                    }


            }
            if (validare == true)
            {
                lblPrenume.ForeColor = Color.Black;

                lbleroarePrenume.Visible = false;
                lbleroarePrenume.Text = "";
                lbleroarePrenume.ForeColor = Color.Transparent;
                lblPrenume.ForeColor = Color.Black;

            }
        }

        private void txtCNP_TextChanged(object sender, EventArgs e)
        {
            validare = true;
            if (txtCNP.Text == "")
            {
                lblCNP.ForeColor = Color.Red;
                validare = false;
            }
            else
            {

                string s = txtCNP.Text;
                for (int i = 0; i < s.Length; i++)
                    if (!char.IsDigit(s[i]))
                    {
                        lbleroareCNP.Text = "SE INTODUC DOAR CIFRE";
                        lbleroareCNP.Visible = true;
                        lbleroareCNP.ForeColor = Color.Red;
                        validare = false;


                    }


            }
            if (validare == true)
            {
                lblCNP.ForeColor = Color.Black;

                lbleroareCNP.Visible = false;
                lbleroareCNP.Text = "";
                lbleroareCNP.ForeColor = Color.Transparent;
                lblCNP.ForeColor = Color.Black;

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
