using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cadrastro_empresa.Classes;


namespace Cadrastro_empresa
{

    public partial class Cadrasto : Form
    {
        public List<listagemdados> listagem_dados;


        public Cadrasto()
        {
            InitializeComponent();
            listagem_dados = new List<listagemdados>();

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
                ValidarCPF vali = new ValidarCPF();
                bool cpfvalid = vali.ValidaCPF(cpfpro.Text);
                if (!cpfvalid)
                {
                    MessageBox.Show("CPF Inválido!!");
                    return;
                }
                if (string.IsNullOrWhiteSpace(CNPJ.Text) || string.IsNullOrWhiteSpace(rz.Text) || string.IsNullOrWhiteSpace(nomefantasi.Text) || string.IsNullOrWhiteSpace(nomepropris.Text)
                    || string.IsNullOrWhiteSpace(cpfpro.Text) || string.IsNullOrWhiteSpace(naturezaJ.Text) || string.IsNullOrWhiteSpace(enderecoC.Text) || string.IsNullOrWhiteSpace(CapitalS.Text)
                    || string.IsNullOrWhiteSpace(telefones.Text))
                {
                    MessageBox.Show("Necessário Preencher Tudo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
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
                empresa.nomeproprietario = nomepropris.Text;
                empresa.cpfpropri = cpfpro.Text;
                empresa.datainicio = dateTimePicker1.Value.ToString();



                if (radioButton4.Checked)
                {
                    empresa.tipo = "Matriz";
                }
                else if (radioButton5.Checked)
                {
                    empresa.tipo = "Filial";
                }

                if (radioButton1.Checked)
                {
                    empresa.Regimetributario = "Simples Nacional";
                }
                else if (radioButton2.Checked)
                {
                    empresa.Regimetributario = "Lucro Presumido";

                }
                else if (radioButton3.Checked)
                {
                    empresa.Regimetributario = " Lucro Real";
                }
                if (radioButton6.Checked)
                {
                    empresa.porte = "Pequeno";
                }
                else if (radioButton7.Checked)
                {
                    empresa.porte = "Médio";

                }
                else if (radioButton8.Checked)
                {
                    empresa.porte = "Grande";
                }

                listagem_dados.Add(empresa);

                teladadoscs a = new teladadoscs(listagem_dados);
                a.ShowDialog();


            }
            catch (Exception ex)
            {
                MessageBox.Show($"ocorreu um erro! {ex.Message}");
            }
        }

        private void situacao_SelectedIndexChanged(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            CNPJ.Clear();
            rz.Clear();
            nomefantasi.Clear();
            situacao.Items.RemoveAt(situacao.SelectedIndex);
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            CapitalS.Clear();
            enderecoC.Items.RemoveAt(situacao.SelectedIndex);
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            naturezaJ.Items.RemoveAt(situacao.SelectedIndex);
            nomepropris.Clear();
            telefones.Clear();
            cpfpro.Clear();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
