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
    public partial class Resumen : Form
    {

        //variables

        public Resumen()
        {
            InitializeComponent();
            inicio_temporal();
            Calcular_Dia();
        }

        public void inicio_temporal()
        {
            //Cirulo de carga
            bunifuDataGridView1.Rows.Add("Pago1", "11/12/2020", "$1,000,000");
            bunifuDataGridView1.Rows.Add("Pago2", "12/10/2020", "$1,000,000");
            bunifuDataGridView1.Rows.Add("Pago3", "09/08/2020", "$1,000,000");
            bunifuDataGridView1.Rows.Add("Pago4", "11/05/2020", "$1,000,000");
            bunifuDataGridView1.Rows.Add("Pago5", "11/09/2020", "$1,000,000");
            bunifuDataGridView1.Rows.Add("Pago6", "12/12/2020", "$1,000,000");
            bunifuDataGridView1.Rows.Add("Pago7", "12/12/2020", "$1,000,000");
            bunifuDataGridView1.Rows.Add("Pago8", "12/12/2020", "$1,000,000");
            bunifuDataGridView1.Rows.Add("Pago9", "12/12/2020", "$1,000,000");
            bunifuDataGridView1.Rows.Add("Pago10", "12/12/2020", "$1,000,000");
            bunifuDataGridView1.Rows.Add("Pago11", "12/12/2020", "$1,000,000");
            
            //Gráfica
            Bunifu.DataViz.WinForms.Canvas canvas = new Bunifu.DataViz.WinForms.Canvas();
            Bunifu.DataViz.WinForms.DataPoint values = new Bunifu.DataViz.WinForms.DataPoint(Bunifu.DataViz.WinForms.BunifuDataViz._type.Bunifu_spline);
            Bunifu.DataViz.WinForms.DataPoint values2 = new Bunifu.DataViz.WinForms.DataPoint(Bunifu.DataViz.WinForms.BunifuDataViz._type.Bunifu_spline);


            //valores
            Random r = new Random();
            for(int i=0; i < 7; i++)
            {
                values.addLabely("", r.Next(0, 10000));
                values2.addLabely("" + "", r.Next(0, 10000));
            }
            canvas.addData(values);
            canvas.addData(values2);
            bunifuDataViz1.Render(canvas);
        }

        public void Calcular_Dia()
        {
            String[] Dias = new String[7];
            String[] DiasActualizados = new String[6];
            int cont = 0;
            Dias[0] = "Dom";
            Dias[1] = "Lun";
            Dias[2] = "Mar";
            Dias[3] = "Mie";
            Dias[4] = "Jue";
            Dias[5] = "Vie";
            Dias[6] = "Sab";
            DateTime dateValue = DateTime.Today;
            int hoy = (int)dateValue.DayOfWeek;
            for (int i=hoy-1;i!=hoy;i--)
            {
                if (i == -1) i = 6;
                DiasActualizados[cont]=Dias[i];
                cont++;
            }
            Dia1.Text = Dias[hoy];
            Dia2.Text = DiasActualizados[5];
            Dia3.Text = DiasActualizados[4];
            Dia4.Text = DiasActualizados[3];
            Dia5.Text = DiasActualizados[2];
            Dia6.Text = DiasActualizados[1];
            Dia7.Text = DiasActualizados[0];

        }

        private void bunifuButton13_Click(object sender, EventArgs e)
        {
            Nuevo_Ingreso_Variable ventana = new Nuevo_Ingreso_Variable();
            ventana.ShowDialog();
        }

        private void bunifuButton16_Click(object sender, EventArgs e)
        {
            Nuevo_Gasto_Variable ventana = new Nuevo_Gasto_Variable();
            ventana.ShowDialog();
        }

        private void bunifuButton14_Click(object sender, EventArgs e)
        {
            Nuevo_Ahorro ventana = new Nuevo_Ahorro("Nuevo Ahorro");
            ventana.ShowDialog();
        }

        private void bunifuButton15_Click(object sender, EventArgs e)
        {
            Nuevo_Crédito ventana = new Nuevo_Crédito();
            ventana.ShowDialog();
        }

    }
}
