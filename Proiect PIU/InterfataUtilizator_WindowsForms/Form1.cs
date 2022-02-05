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
    public partial class Form1 : Form
    {

        IStocareData adminImobiliare = StocareFactory.GetAdministratorStocare();
        List<string> utilitatiSelectate = new List<string>();
        bool validare = true;
        public Form1()
        {
            InitializeComponent();
        }


        private void butAdaugareOferta_Click(object sender, EventArgs e)
        {
            bool validare = true;
            if (!DateIntrareValide())
            {
                lblTip.ForeColor = Color.Red;
                lblSuprafata.ForeColor = Color.Red;
                lblStrada.ForeColor = Color.Red;
                lblNr.ForeColor = Color.Red;
                lblBloc.ForeColor = Color.Red;
                lblScara.ForeColor = Color.Red;
                lblNrapartament.ForeColor = Color.Red;
                lblPret.ForeColor = Color.Red;
                txtSuprafata.Text = string.Empty;
                MessageBox.Show("Campuri obligatoriu de completat");
                //  resetareControale();

                validare = false;
            }


            if (validare == true)
            {

                lblTip.ForeColor = Color.Black;
                lblSuprafata.ForeColor = Color.Black;
                lblStrada.ForeColor = Color.Black;
                lblNr.ForeColor = Color.Black;
                lblBloc.ForeColor = Color.Black;
                lblScara.ForeColor = Color.Black;
                lblNrapartament.ForeColor = Color.Black;
                lblPret.ForeColor = Color.Black;

                Imobiliar i = new Imobiliar(txtTip.Text, int.Parse(txtSuprafata.Text), txtStrada.Text, int.Parse(txtNr.Text), txtBloc.Text, txtScara.Text, int.Parse(txtNrapartament.Text), int.Parse(txtPret.Text));

                Gradfinisare? gradSelectat = GetGradFinisareSelectat();
                if (gradSelectat.HasValue)
                {
                    i.Grad = gradSelectat.Value;
                }




                adminImobiliare.AddImobiliar(i);
            }




                resetareControale();

                lblTip.ForeColor = Color.Black;
                lblSuprafata.ForeColor = Color.Black;
                lblStrada.ForeColor = Color.Black;
                lblNr.ForeColor = Color.Black;
                lblBloc.ForeColor = Color.Black;
                lblScara.ForeColor = Color.Black;
                lblNrapartament.ForeColor = Color.Black;
                lblPret.ForeColor = Color.Black;
            

        }

        private void butAfisareOferta_Click(object sender, EventArgs e)
        {

            lstImobiliare.Items.Clear();
            var antetTabel = String.Format("{0,-10}\t{1,0}\t{2,15}\t{3,5}\t{4,5}\t{5,5}\t{6,5}\t{7,5}\t{8,5}\n", "Tip", "Suprafata", "Strada", "Nr", "Bloc", "Scara", "Numar apartament", "Pret", "Grad");
            lstImobiliare.Items.Add(antetTabel);




            List<Imobiliar> imobiliare = adminImobiliare.GetImobiliare();


            foreach (Imobiliar i in imobiliare)
            {

                var linieTabel = String.Format("{0,-10}\t{1,7}\t\t{2,-3}\t{3,5}\t{4,5}\t{5,5}\t{6,15}\t{7,5}\t{8,5}\n\n", i.Tip, i.Suprafata, i.Strada, i.Nr, i.Bloc, i.Scara, i.Nr_apartament, i.Pret, i.Grad.ToString());
                lstImobiliare.Items.Add(linieTabel);
            }
        }


        private void butCautare_Click(object sender, EventArgs e)
        {
            if (!DateIntrareValide())
            {
                lblTip.ForeColor = Color.Red;
                lblSuprafata.ForeColor = Color.Red;
                lblStrada.ForeColor = Color.Red;
                lblNr.ForeColor = Color.Red;
                lblBloc.ForeColor = Color.Red;
                lblScara.ForeColor = Color.Red;
                lblNrapartament.ForeColor = Color.Red;
                lblPret.ForeColor = Color.Red;

                MessageBox.Show("Campuri obligatoriu de completat");
                resetareControale();
                return;
            }
            int ok = 0;
            List<Imobiliar> imobiliare = adminImobiliare.GetImobiliare();
            foreach (Imobiliar i in imobiliare)
            {
                if (i.Tip == txtTip.Text && i.Suprafata == Convert.ToInt32(txtSuprafata.Text) && i.Strada == txtStrada.Text && i.Nr == Convert.ToInt32(txtNr.Text) && i.Bloc == txtBloc.Text && i.Scara == txtScara.Text && i.Nr_apartament == Convert.ToInt32(txtNrapartament.Text) && i.Pret == Convert.ToInt32(txtPret.Text)) ;
                {
                    lstImobiliare.SelectedItem = i.IdImobiliar;
                    MessageBox.Show("Oferta cautata a fost gasita!");
                    ok = 1;
                    break;
                }
            }
            if (ok == 0)
                MessageBox.Show("Oferta cautata  NU a fost gasita!");

            lblTip.ForeColor = Color.Black;
            lblSuprafata.ForeColor = Color.Black;
            lblStrada.ForeColor = Color.Black;
            lblNr.ForeColor = Color.Black;
            lblBloc.ForeColor = Color.Black;
            lblScara.ForeColor = Color.Black;
            lblNrapartament.ForeColor = Color.Black;
            lblPret.ForeColor = Color.Black;


        }

        private void butModifica_Click(object sender, EventArgs e)
        {
            if (!DateIntrareValide())
            {
                lblTip.ForeColor = Color.Red;
                lblSuprafata.ForeColor = Color.Red;
                lblStrada.ForeColor = Color.Red;
                lblNr.ForeColor = Color.Red;
                lblBloc.ForeColor = Color.Red;
                lblScara.ForeColor = Color.Red;
                lblNrapartament.ForeColor = Color.Red;
                lblPret.ForeColor = Color.Red;

                MessageBox.Show("Campuri obligatoriu de completat");
                resetareControale();
                return;
            }



            Imobiliar imobiliar_modificat = adminImobiliare.GetImobiliar(lstImobiliare.SelectedIndex);
            imobiliar_modificat.Tip = txtTip.Text;
            imobiliar_modificat.Suprafata = int.Parse(txtSuprafata.Text);
            imobiliar_modificat.Strada = txtStrada.Text;
            imobiliar_modificat.Nr = int.Parse(txtNr.Text);
            imobiliar_modificat.Bloc = txtBloc.Text;
            imobiliar_modificat.Scara = txtScara.Text;
            imobiliar_modificat.Nr_apartament = int.Parse(txtNrapartament.Text);
            imobiliar_modificat.Pret = int.Parse(txtPret.Text);



            adminImobiliare.UpdateImobiliar(imobiliar_modificat);

            resetareControale();
            lblTip.ForeColor = Color.Black;
            lblSuprafata.ForeColor = Color.Black;
            lblStrada.ForeColor = Color.Black;
            lblNr.ForeColor = Color.Black;
            lblBloc.ForeColor = Color.Black;
            lblScara.ForeColor = Color.Black;
            lblNrapartament.ForeColor = Color.Black;
            lblPret.ForeColor = Color.Black;
        }

        private void lstImobiliare_SelectedIndexChanged(object sender, EventArgs e)
        {
            Imobiliar imobiliar_selectat = adminImobiliare.GetImobiliar(lstImobiliare.SelectedIndex);
            if (imobiliar_selectat != null)
            {
                txtTip.Text = imobiliar_selectat.Tip;
                txtSuprafata.Text = Convert.ToString(imobiliar_selectat.Suprafata);
                txtStrada.Text = imobiliar_selectat.Strada;
                txtNr.Text = Convert.ToString(imobiliar_selectat.Nr);
                txtBloc.Text = imobiliar_selectat.Bloc;
                txtScara.Text = imobiliar_selectat.Scara;
                txtNrapartament.Text = Convert.ToString(imobiliar_selectat.Nr_apartament);
                txtPret.Text = Convert.ToString(imobiliar_selectat.Pret);
            }
        }

        bool DateIntrareValide()
        {


            if (txtTip.Text == String.Empty || txtSuprafata.Text == String.Empty || txtStrada.Text == String.Empty || txtNr.Text == String.Empty || txtBloc.Text == String.Empty || txtScara.Text == String.Empty || txtNrapartament.Text == String.Empty || txtPret.Text == String.Empty)
                return false;

            return true;
        }

        public void resetareControale()
        {
            lblTip.ForeColor = Color.Black;
            lblSuprafata.ForeColor = Color.Black;
            lblStrada.ForeColor = Color.Black;
            lblNr.ForeColor = Color.Black;
            lblBloc.ForeColor = Color.Black;
            lblScara.ForeColor = Color.Black;
            lblNrapartament.ForeColor = Color.Black;
            lblPret.ForeColor = Color.Black;
            txtTip.Text = txtSuprafata.Text = txtStrada.Text = txtNr.Text = txtBloc.Text = txtScara.Text = txtNrapartament.Text = txtPret.Text = String.Empty;
            rbtRosu.Checked = false;
            rbtGri.Checked = false;
            rbtAlb.Checked = false;
            rbtCheie.Checked = false;

        }

        private Gradfinisare? GetGradFinisareSelectat()
        {

            if (rbtRosu.Checked)
                return Gradfinisare.Rosu;
            if (rbtGri.Checked)
                return Gradfinisare.Gri;
            if (rbtAlb.Checked)
                return Gradfinisare.Alb;
            if (rbtCheie.Checked)
                return Gradfinisare.Cheie;
            return null;
        }




        private void ckbUtilitati_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBoxControl = sender as CheckBox; //operator 'as'
            //sau
            //CheckBox checkBoxControl = (CheckBox)sender;  //operator cast

            string utilitateSelectata = checkBoxControl.Text;

            //verificare daca checkbox-ul asupra caruia s-a actionat este selectat
            if (checkBoxControl.Checked == true)
                utilitatiSelectate.Add(utilitateSelectata);
            else
                utilitatiSelectate.Remove(utilitateSelectata);
        }



        private void lbleroareSuprafata_Click(object sender, EventArgs e)
        {

        }

        private void lbleroareStrada_Click(object sender, EventArgs e)
        {

        }

        private void lbleroareTip_Click(object sender, EventArgs e)
        {

        }

        private void lbleroareBloc_Click(object sender, EventArgs e)
        {

        }

        private void lbleroareScara_Click(object sender, EventArgs e)
        {

        }

        private void lbleroareNrapartamnet_Click(object sender, EventArgs e)
        {

        }

        private void lbleroarePret_Click(object sender, EventArgs e)
        {

        }

        private void txtTip_TextChanged(object sender, EventArgs e)
        {
            validare = true;
            if (txtTip.Text == "")
            {
                lblTip.ForeColor = Color.Red;
                validare = false;
            }
            validare = true;
            if (validare == true)
            {
                lblTip.ForeColor = Color.Black;

            }
        }

        private void txtSuprafata_TextChanged(object sender, EventArgs e)
        {
            validare = true;
            lblSuprafata.ForeColor = Color.Black;
            if (txtSuprafata.Text == "")
            {
                lblSuprafata.ForeColor = Color.Red;
                validare = false;
            }
            else
            {

                string s = txtSuprafata.Text;
                for (int i = 0; i < s.Length; i++)
                    if (!char.IsDigit(s[i]))
                    {
                        lbleroareSuprafata.Text = "SE INTODUC DOAR CIFRE";
                        lbleroareSuprafata.Visible = true;
                        lbleroareSuprafata.ForeColor = Color.Red;
                        validare = false;


                    }


            }
            if (validare == true)
            {
                lblSuprafata.ForeColor = Color.Black;

                lbleroareSuprafata.Visible = false;
                lbleroareSuprafata.Text = "";
                lbleroareSuprafata.ForeColor = Color.Transparent;
                lblSuprafata.ForeColor = Color.Black;

            }
        }

        private void txtStrada_TextChanged(object sender, EventArgs e)
        {
            validare = true;
            if (txtStrada.Text == "")
            {
                lblStrada.ForeColor = Color.Red;
                validare = false;
            }
            validare = true;
            if (validare == true)
            {
                lblStrada.ForeColor = Color.Black;

            }
        }

        private void txtNr_TextChanged(object sender, EventArgs e)
        {
            validare = true;
            if (txtNr.Text == "")
            {
                lblNr.ForeColor = Color.Red;
                validare = false;
            }
            else
            {

                string s = txtNr.Text;
                for (int i = 0; i < s.Length; i++)
                    if (!char.IsDigit(s[i]))
                    {
                        lbleroareNr.Text = "SE INTODUC DOAR CIFRE";
                        lbleroareNr.Visible = true;
                        lbleroareNr.ForeColor = Color.Red;
                        validare = false;


                    }


            }
            if (validare == true)
            {


                lbleroareNr.Visible = false;
                lbleroareNr.Text = "";
                lbleroareNr.ForeColor = Color.Transparent;
                lblNr.ForeColor = Color.Black;

            }
        }

        private void txtBloc_TextChanged(object sender, EventArgs e)
        {
            validare = true;
            if (txtBloc.Text == "")
            {
                lblBloc.ForeColor = Color.Red;
                validare = false;
            }
            validare = true;
            if (validare == true)
            {
                lblBloc.ForeColor = Color.Black;

            }
        }

        private void txtScara_TextChanged(object sender, EventArgs e)
        {
            validare = true;
            if (txtScara.Text == "")
            {
                lblScara.ForeColor = Color.Red;
                validare = false;
            }
            validare = true;
            if (validare == true)
            {
                lblScara.ForeColor = Color.Black;

            }
        }

        private void txtNrapartament_TextChanged(object sender, EventArgs e)
        {
            validare = true;
            if (txtNrapartament.Text == "")
            {
                lblNrapartament.ForeColor = Color.Red;
                validare = false;
            }
            else
            {

                string s = txtNrapartament.Text;
                for (int i = 0; i < s.Length; i++)
                    if (!char.IsDigit(s[i]))
                    {
                        lbleroareNrapartament.Text = "SE INTODUC DOAR CIFRE";
                        lbleroareNrapartament.Visible = true;
                        lbleroareNrapartament.ForeColor = Color.Red;
                        validare = false;


                    }


            }

            if (validare == true)
            {
                lblNrapartament.ForeColor = Color.Black;

                lbleroareNrapartament.Visible = false;
                lbleroareNrapartament.Text = "";
                lbleroareNrapartament.ForeColor = Color.Transparent;
                lblNrapartament.ForeColor = Color.Black;

            }
        }

        private void txtPret_TextChanged(object sender, EventArgs e)
        {
            validare = true;
            if (txtPret.Text == "")
            {
                lblPret.ForeColor = Color.Red;
                validare = false;
            }
            else
            {

                string s = txtPret.Text;
                for (int i = 0; i < s.Length; i++)
                    if (!char.IsDigit(s[i]))
                    {
                        lbleroarePret.Text = "SE INTODUC DOAR CIFRE";
                        lbleroarePret.Visible = true;
                        lbleroarePret.ForeColor = Color.Red;
                        validare = false;


                    }


            }
            if (validare == true)
            {
                lblPret.ForeColor = Color.Black;

                lbleroarePret.Visible = false;
                lbleroarePret.Text = "";
                lbleroarePret.ForeColor = Color.Transparent;
                lblPret.ForeColor = Color.Black;

            }
        }

        private void butTrimite_Click(object sender, EventArgs e)
        {
            FormDestinatie f2 = new FormDestinatie();
            f2.ShowDialog();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblCompartimentare_Click(object sender, EventArgs e)
        {

        }

        private void cmbComp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblAnconstructie_Click(object sender, EventArgs e)
        {

        }

        private void DataConstructie_ValueChanged(object sender, EventArgs e)
        {

        }

        private void chblift_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void grbUtilitati_Enter(object sender, EventArgs e)
        {

        }

        private void lblUtilitati_Click(object sender, EventArgs e)
        {

        }

        private void dataGridImobiliare_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void butIntoarcere_Click(object sender, EventArgs e)
        {
            this.Hide();
            PrimaPagina f2 = new PrimaPagina();
            f2.ShowDialog();
        }
    }
}

