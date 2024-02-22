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
    public partial class Tela_menu : Form
    {
        public Tela_menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cadrasto menu = new Cadrasto();
            menu.ShowDialog();
        }
    }
}
