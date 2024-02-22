using Cadrastro_empresa.Classes;
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
    public partial class teladadoscs : Form
    {
        public List<listagemdados> listagem_dados;

        public teladadoscs(List<listagemdados> listagem_dados)
        {
            InitializeComponent();
            this.listagem_dados = listagem_dados;

            // Defina a fonte de dados do DataGridView com a lista de dados
            dataGridView1.Refresh();
            dataGridView1.DataSource = listagem_dados;
            dataGridView1.AutoGenerateColumns = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
