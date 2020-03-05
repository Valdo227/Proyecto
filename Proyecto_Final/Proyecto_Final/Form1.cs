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
    public partial class Form1 : Form
    {
        //Variables
        int posX = 0, posY = 0; //X y Y para el movimiento de la ventana
        bool MenuDesplegado = false; //Para saber si el menu esta desplegado o no

        public Form1()
        {
            InitializeComponent();
            Controlador_Forms(new Resumen());
        }

        //Control de forms
        public void mover_Ventana(MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                posX = e.X;
                posY = e.Y;
            }
            else
            {
                Left = Left + (e.X - posX);
                Top = Top + (e.Y - posY);
            }
        }
        public void Controlador_Forms(Form form)
        {
            if (Contenedor.Controls.Count > 0) Contenedor.Controls.RemoveAt(0);
            form.FormBorderStyle = FormBorderStyle.None;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;

            Contenedor.Controls.Add(form);
            Contenedor.Tag = form;
            form.Show();

            label1.Text = form.Name;
        }

        //Botones del menu
        private void Bt_Resumen_Click(object sender, EventArgs e)
        {
            Controlador_Forms(new Resumen());
        }
        private void Bt_Ingresos_Click(object sender, EventArgs e)
        {
            Controlador_Forms(new Ingresos());
        }
        private void Bt_Ahorro_Click(object sender, EventArgs e)
        {
            Controlador_Forms(new Ahorros());
        }
        private void Bt_Predicciones_Click(object sender, EventArgs e)
        {
            Controlador_Forms(new Historial());
        }
        private void Bt_Aprender_Click(object sender, EventArgs e)
        {
            Controlador_Forms(new Créditos());
        }
        private void Bt_Configuraciones_Click(object sender, EventArgs e)
        {
            Controlador_Forms(new Configuraciones());
        }
        private void Bt_Gastos_Click(object sender, EventArgs e)
        {
            Controlador_Forms(new Gastos());
        }

        //Control del menu
        private void MouseDetect_Tick(object sender, EventArgs e)
        {
            if (!BunifuTransition1.IsCompleted) return;
            else if (panel_Color1.ClientRectangle.Contains(PointToClient(Control.MousePosition)))
            {
                if (!MenuDesplegado)
                {
                    MenuDesplegado = true;
                    panel_Color1.Visible = false;
                    panel_Color1.Width = 187;
                    BunifuTransition1.Show(panel_Color1);
                }
            }
            else
            {
                if (MenuDesplegado)
                {
                    MenuDesplegado = false;
                    panel_Color1.Visible = false;
                    panel_Color1.Width = 41;
                    panel_Color1.Visible = true;
                }
            }
        }

        //Control de la ventana
        private void Bt_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Bt_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void Bt_MaxNorm_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)   this.WindowState = FormWindowState.Normal;
            else   this.WindowState = FormWindowState.Maximized;
        }

        //Mover Ventana
        private void bunifuLabel1_MouseMove(object sender, MouseEventArgs e)
        {
            mover_Ventana(e);
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void Mover_Ventana(object sender, MouseEventArgs e)
        {
            mover_Ventana(e);

        }

    }
}
