using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadrastro_empresa
{
    
    public partial class Cadrasto : Form
    {
        private List<listagemdados> listagem_dados;    

        public Cadrasto()
        {
            InitializeComponent();

        }

        private void Cadrasto_Load(object sender, EventArgs e)
        {

        }

        private void maskedTextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            try
            {
                listagemdados empresa = new listagemdados();
                empresa.cnpj = CNPJ.Text;
                empresa.razaoSocial = rz.Text;
                empresa.nomefantasia = nomefantasi.Text;
                empresa.situacaocadrastal = situacao.Text;
                empresa.Regimetributario = grupobox.Text;
                empresa.telefone = telefones.Text;
                empresa.capitalsocial = CapitalS.Text;
                empresa.enderecocompleto = enderecoC.Text;
                empresa.tipo = grupobox2.Text;
                empresa.porte = grupobox3.Text;
                empresa.naturezajuris = naturezaJ.Text;
                empresa.nomeproprietario = nomepropri.Text;
                empresa.cpfpropri = cpfpro.Text;
                empresa.datainicio = dateTimePicker1.Value.ToString();
                listagem_dados.Add(empresa);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"ocorreu um erro! {ex.Message}");

            }
         
        }

        private void situacao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void datainicio_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void grupobox_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void grupobox3_Enter(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }

}
