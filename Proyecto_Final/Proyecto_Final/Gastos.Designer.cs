namespace Proyecto_Final
{
    partial class Gastos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gastos));
            this.panel_Color1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.SuspendLayout();
            // 
            // panel_Color1
            // 
            this.panel_Color1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_Color1.BackgroundImage")));
            this.panel_Color1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_Color1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Color1.ForeColor = System.Drawing.Color.Coral;
            this.panel_Color1.GradientBottomLeft = System.Drawing.Color.Empty;
            this.panel_Color1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(17)))), ((int)(((byte)(56)))));
            this.panel_Color1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(33)))), ((int)(((byte)(111)))));
            this.panel_Color1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(33)))), ((int)(((byte)(111)))));
            this.panel_Color1.Location = new System.Drawing.Point(0, 0);
            this.panel_Color1.Name = "panel_Color1";
            this.panel_Color1.Quality = 10;
            this.panel_Color1.Size = new System.Drawing.Size(41, 506);
            this.panel_Color1.TabIndex = 48;
            // 
            // Gastos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(861, 506);
            this.Controls.Add(this.panel_Color1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Gastos";
            this.Text = "Gastos";
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel panel_Color1;
    }
}