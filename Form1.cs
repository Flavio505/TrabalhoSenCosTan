using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabalho_seno_cosseno_e_tangente.SenoCosTang.Modelo;

namespace Trabalho_seno_cosseno_e_tangente
{
    public partial class Form1 : Form
    {
        Controle controle;

        public Form1()
        {
            InitializeComponent();
        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            controle = new Controle(txbAngulo.Text.ToString());
            if(controle.Resposta != "numero incorreto")
            {
                lblCosseno.Text = "Cosseno = "+ controle.cosseno.ToString();
                lblSeno.Text = "Seno = " + controle.seno.ToString();
                lblTangente.Text = "Tangente = " + controle.tangente.ToString();
            }
            else
            {
                lblCosseno.Text = "ERRO";
                lblSeno.Text = "ERRO";
                lblTangente.Text = "ERRO";
            }
        }

        
    }
}
