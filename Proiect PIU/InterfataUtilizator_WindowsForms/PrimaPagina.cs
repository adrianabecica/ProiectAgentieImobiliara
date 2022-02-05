using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibrarieAgentie;
using System.Windows.Forms;

namespace InterfataUtilizator_WindowsForms
{
    public partial class PrimaPagina : Form
    {
        

        public PrimaPagina()
        {
            InitializeComponent();
        }

        private void butManager_Click(object sender, EventArgs e)
        {
            this.Hide();
            PaginaLogare f2 = new PaginaLogare();
           f2.ShowDialog();
            
        }

        private void butClient_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormBeneficiar f2 = new FormBeneficiar();
            f2.ShowDialog();
        }
    }
}
