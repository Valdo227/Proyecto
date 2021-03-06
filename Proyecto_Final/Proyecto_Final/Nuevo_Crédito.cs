﻿using System;
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
    public partial class Nuevo_Crédito : Form
    {
        public Nuevo_Crédito()
        {
            InitializeComponent();
        }

        int posX = 0, posY = 0; //X y Y para el movimiento de la ventana
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
        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            mover_Ventana(e);
        }
        private void bunifuGradientPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            mover_Ventana(e);
        }
        private void Close_Click(object sender, EventArgs e)
        {
            DialogResult resultado;
            resultado = MessageBox.Show("¿Desea cancelar el formulario?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
