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
    public partial class FormDestinatie : Form
    {
        IStocareData adminImobiliare = StocareFactory.GetAdministratorStocare();
        List<string> utilitatiSelectate = new List<string>();
        public FormDestinatie()
        {
            InitializeComponent();
        }

        private void FormDestinatie_Load(object sender, EventArgs e)
        {

        }

        private void butAfisareOferta_Click(object sender, EventArgs e)
        {
            lstImobiliare.Items.Clear();
            var antetTabel = String.Format("{0,-10}\t{1,0}\t{2,15}\t{3,5}\t{4,5}\t{5,5}\t{6,5}\t{7,5}\t{8,5}\n", "Tip", "Suprafata", "Strada", "Nr", "Bloc", "Scara", "Numar apartament", "Pret", "Grad");
            lstImobiliare.Items.Add(antetTabel);




            List<Imobiliar> imobiliare = adminImobiliare.GetImobiliare();

           // dataGridImobiliare.DataSource = null;
          //  dataGridImobiliare.DataSource = imobiliare;
            foreach (Imobiliar i in imobiliare)
            {

                var linieTabel = String.Format("{0,-10}\t{1,7}\t\t{2,-3}\t{3,5}\t{4,5}\t{5,5}\t{6,15}\t{7,5}\t{8,5}\n\n", i.Tip, i.Suprafata, i.Strada, i.Nr, i.Bloc, i.Scara, i.Nr_apartament, i.Pret, i.Grad.ToString());
                lstImobiliare.Items.Add(linieTabel);
            }
        }
    }
}
