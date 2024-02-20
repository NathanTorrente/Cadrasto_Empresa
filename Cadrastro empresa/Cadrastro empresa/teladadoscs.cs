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
    private List<listagemdados> veiculosList;
    public partial class teladadoscs : Form
    {


        public teladadoscs()
        {
            InitializeComponent();
        }
        public teladadoscs(List<listagemdados> listagem_Dados)
        {
            InitializeComponent();
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            dataGridView1.DataSource = listagem_Dados;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void teladadoscs_Load(object sender, EventArgs e)
        {
            List<listagemdados> listagem_Dados;
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = listagem_Dados;
        }
    }
}
