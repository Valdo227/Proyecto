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
    public partial class Ahorros : Form
    {
        public Ahorros()
        {
            InitializeComponent();
            inicio_temporal();
        }

        public void inicio_temporal()
        {
            //Cirulo de carga
            bunifuDataGridView1.Rows.Add("100%", "Citibanamex1", "Aqui irá la descripcion de la tarjeta", "$1,000,000");
            bunifuDataGridView1.Rows.Add("100%", "Citibanamex2", "Aqui irá la descripcion de la tarjeta", "$1,000,000");
            bunifuDataGridView1.Rows.Add("100%", "Citibanamex3", "Aqui irá la descripcion de la tarjeta", "$1,000,000");
            bunifuDataGridView1.Rows.Add("100%", "Citibanamex4", "Aqui irá la descripcion de la tarjeta", "$1,000,000");
            bunifuDataGridView1.Rows.Add("100%", "Citibanamex5", "Aqui irá la descripcion de la tarjeta", "$1,000,000");

            //Gráfica
            Bunifu.DataViz.WinForms.Canvas canvas = new Bunifu.DataViz.WinForms.Canvas();
            Bunifu.DataViz.WinForms.DataPoint values = new Bunifu.DataViz.WinForms.DataPoint(Bunifu.DataViz.WinForms.BunifuDataViz._type.Bunifu_splineArea);

            //valores
            Random r = new Random();
            for (int i = 0; i < 7; i++)
            {
                values.addLabely("", r.Next(0, 10000));
            }
            canvas.addData(values);
            bunifuDataViz1.Render(canvas);
        }

        private void bunifuButton13_Click(object sender, EventArgs e)
        {
            Nuevo_Ahorro ventana = new Nuevo_Ahorro("Nuevo Ahorro");
            ventana.ShowDialog();
        }

        private void bunifuButton16_Click(object sender, EventArgs e)
        {
            if (bunifuDataGridView1.Rows.Count > 0)
            {
                int i = bunifuDataGridView1.CurrentRow.Index;
                DialogResult r;
                r = MessageBox.Show("Desea eliminar " + bunifuDataGridView1.Rows[i].Cells[1].Value.ToString(), "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes) bunifuDataGridView1.Rows.Remove(bunifuDataGridView1.CurrentRow);
            }
            else
                MessageBox.Show("No cuenta con ahorros disponibles", "Ahorros Vacios",MessageBoxButtons.OK ,MessageBoxIcon.Exclamation);

        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            Nuevo_Ahorro ventana = new Nuevo_Ahorro("Editar Ahorro");
            ventana.ShowDialog();
        }
    }
}
