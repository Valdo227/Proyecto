using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final
{
    public partial class Historial : Form
    {
        public Historial()
        {
            InitializeComponent();
            inicio_temporal();
        }

        public void inicio_temporal()
        {
            //Cirulo de carga
            bunifuDataGridView1.Rows.Add("Ingreso1", "Ingreso", "12/02/2020", "$1,000,000", "Si");
            bunifuDataGridView1.Rows.Add("Ingreso2", "Ingreso", "12/02/2020", "$1,000,000", "Si");
            bunifuDataGridView1.Rows.Add("Ingreso3", "Ingreso", "12/02/2020", "$1,000,000", "Si");
            bunifuDataGridView1.Rows.Add("Ingreso4", "Ingreso", "12/02/2020", "$1,000,000", "Si");
            bunifuDataGridView1.Rows.Add("Ingreso5", "Ingreso", "12/02/2020", "$1,000,000", "Si");
            bunifuDataGridView1.Rows.Add("Ingreso6", "Ingreso", "12/02/2020", "$1,000,000", "Si");
            bunifuDataGridView1.Rows.Add("Ingreso7", "Ingreso", "12/02/2020", "$1,000,000", "Si");
            bunifuDataGridView1.Rows.Add("Ingreso8", "Ingreso", "12/02/2020", "$1,000,000", "Si");
            bunifuDataGridView1.Rows.Add("Ingreso9", "Ingreso", "12/02/2020", "$1,000,000", "Si");
            bunifuDataGridView1.Rows.Add("Ingreso10", "Ingreso", "12/02/2020", "$1,000,000", "Si");
            bunifuDataGridView1.Rows.Add("Ingreso11", "Ingreso", "12/02/2020", "$1,000,000", "Si");
            bunifuDataGridView1.Rows.Add("Ingreso12", "Ingreso", "12/02/2020", "$1,000,000", "Si");
            bunifuDataGridView1.Rows.Add("Ingreso13", "Ingreso", "12/02/2020", "$1,000,000", "Si");
        }

        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
