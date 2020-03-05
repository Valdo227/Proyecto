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
    public partial class Ingresos : Form
    {
        public Ingresos()
        {
            InitializeComponent();
            inicio_temporal();
        }

        public void inicio_temporal()
        {
            //Cirulo de carga
            bunifuDataGridView1.Rows.Add("Sueldo de Trabajo", "Sueldo Base", "10,000,000");
            bunifuDataGridView1.Rows.Add("Sueldo de Trabajo", "Sueldo Base", "10,000,000");
            bunifuDataGridView1.Rows.Add("Sueldo de Trabajo", "Sueldo Base", "10,000,000");
            bunifuDataGridView1.Rows.Add("Sueldo de Trabajo", "Sueldo Base", "10,000,000");
            bunifuDataGridView1.Rows.Add("Sueldo de Trabajo", "Sueldo Base", "10,000,000");
            bunifuDataGridView1.Rows.Add("Sueldo de Trabajo", "Sueldo Base", "10,000,000");
            bunifuDataGridView1.Rows.Add("Sueldo de Trabajo", "Sueldo Base", "10,000,000");
            bunifuDataGridView1.Rows.Add("Sueldo de Trabajo", "Sueldo Base", "10,000,000");
            bunifuDataGridView1.Rows.Add("Sueldo de Trabajo", "Sueldo Base", "10,000,000");

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
    }
}
