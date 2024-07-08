namespace Mercado
{
    partial class Formulario1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelmenu = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.botonmarca = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.botoncategoria = new System.Windows.Forms.Button();
            this.barrita1 = new System.Windows.Forms.Panel();
            this.botonproductos = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelarriba = new System.Windows.Forms.Panel();
            this.botonminimizar = new System.Windows.Forms.PictureBox();
            this.botoncerrar = new System.Windows.Forms.PictureBox();
            this.hora = new System.Windows.Forms.Label();
            this.fecha = new System.Windows.Forms.Label();
            this.horafecha = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelarriba.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.botonminimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botoncerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelmenu
            // 
            this.panelmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(220)))));
            this.panelmenu.Controls.Add(this.panel2);
            this.panelmenu.Controls.Add(this.botonmarca);
            this.panelmenu.Controls.Add(this.panel1);
            this.panelmenu.Controls.Add(this.botoncategoria);
            this.panelmenu.Controls.Add(this.barrita1);
            this.panelmenu.Controls.Add(this.botonproductos);
            this.panelmenu.Controls.Add(this.pictureBox1);
            this.panelmenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelmenu.Location = new System.Drawing.Point(0, 0);
            this.panelmenu.Name = "panelmenu";
            this.panelmenu.Size = new System.Drawing.Size(280, 577);
            this.panelmenu.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(220)))));
            this.panel2.Location = new System.Drawing.Point(0, 288);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 32);
            this.panel2.TabIndex = 6;
            // 
            // botonmarca
            // 
            this.botonmarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(220)))));
            this.botonmarca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonmarca.FlatAppearance.BorderSize = 0;
            this.botonmarca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.botonmarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonmarca.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonmarca.ForeColor = System.Drawing.Color.White;
            this.botonmarca.Image = global::Mercado.Properties.Resources.icons8_billete_combinado_30;
            this.botonmarca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonmarca.Location = new System.Drawing.Point(11, 288);
            this.botonmarca.Name = "botonmarca";
            this.botonmarca.Size = new System.Drawing.Size(266, 32);
            this.botonmarca.TabIndex = 5;
            this.botonmarca.Text = "Marca";
            this.botonmarca.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(220)))));
            this.panel1.Location = new System.Drawing.Point(0, 335);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 32);
            this.panel1.TabIndex = 4;
            // 
            // botoncategoria
            // 
            this.botoncategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(220)))));
            this.botoncategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botoncategoria.FlatAppearance.BorderSize = 0;
            this.botoncategoria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.botoncategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botoncategoria.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botoncategoria.ForeColor = System.Drawing.Color.White;
            this.botoncategoria.Image = global::Mercado.Properties.Resources.icons8_formularios_de_google_30__3_;
            this.botoncategoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botoncategoria.Location = new System.Drawing.Point(11, 335);
            this.botoncategoria.Name = "botoncategoria";
            this.botoncategoria.Size = new System.Drawing.Size(266, 32);
            this.botoncategoria.TabIndex = 3;
            this.botoncategoria.Text = "Categoria";
            this.botoncategoria.UseVisualStyleBackColor = false;
            // 
            // barrita1
            // 
            this.barrita1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(220)))));
            this.barrita1.Location = new System.Drawing.Point(0, 240);
            this.barrita1.Name = "barrita1";
            this.barrita1.Size = new System.Drawing.Size(5, 32);
            this.barrita1.TabIndex = 2;
            // 
            // botonproductos
            // 
            this.botonproductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(220)))));
            this.botonproductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonproductos.FlatAppearance.BorderSize = 0;
            this.botonproductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.botonproductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonproductos.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonproductos.ForeColor = System.Drawing.Color.White;
            this.botonproductos.Image = global::Mercado.Properties.Resources.producto;
            this.botonproductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonproductos.Location = new System.Drawing.Point(11, 240);
            this.botonproductos.Name = "botonproductos";
            this.botonproductos.Size = new System.Drawing.Size(266, 32);
            this.botonproductos.TabIndex = 1;
            this.botonproductos.Text = "Productos";
            this.botonproductos.UseVisualStyleBackColor = false;
            this.botonproductos.Click += new System.EventHandler(this.botonproductos_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Mercado.Properties.Resources.rm410_11a_fotor_bg_remover_20240704142643;
            this.pictureBox1.Location = new System.Drawing.Point(0, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(277, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelarriba
            // 
            this.panelarriba.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelarriba.Controls.Add(this.botonminimizar);
            this.panelarriba.Controls.Add(this.botoncerrar);
            this.panelarriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelarriba.Location = new System.Drawing.Point(280, 0);
            this.panelarriba.Name = "panelarriba";
            this.panelarriba.Size = new System.Drawing.Size(984, 40);
            this.panelarriba.TabIndex = 2;
            // 
            // botonminimizar
            // 
            this.botonminimizar.BackColor = System.Drawing.Color.Transparent;
            this.botonminimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonminimizar.Image = global::Mercado.Properties.Resources.icons8_menos_30;
            this.botonminimizar.Location = new System.Drawing.Point(914, 6);
            this.botonminimizar.Name = "botonminimizar";
            this.botonminimizar.Size = new System.Drawing.Size(25, 25);
            this.botonminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.botonminimizar.TabIndex = 1;
            this.botonminimizar.TabStop = false;
            this.botonminimizar.Click += new System.EventHandler(this.botonminimizar_Click);
            // 
            // botoncerrar
            // 
            this.botoncerrar.BackColor = System.Drawing.Color.Transparent;
            this.botoncerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botoncerrar.Image = global::Mercado.Properties.Resources.icons8_multiplicar_30;
            this.botoncerrar.Location = new System.Drawing.Point(947, 6);
            this.botoncerrar.Name = "botoncerrar";
            this.botoncerrar.Size = new System.Drawing.Size(25, 25);
            this.botoncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.botoncerrar.TabIndex = 0;
            this.botoncerrar.TabStop = false;
            this.botoncerrar.Click += new System.EventHandler(this.botoncerrar_Click);
            // 
            // hora
            // 
            this.hora.AutoSize = true;
            this.hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(220)))));
            this.hora.Location = new System.Drawing.Point(612, 218);
            this.hora.Name = "hora";
            this.hora.Size = new System.Drawing.Size(249, 91);
            this.hora.TabIndex = 3;
            this.hora.Text = "label1";
            // 
            // fecha
            // 
            this.fecha.AutoSize = true;
            this.fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.fecha.Location = new System.Drawing.Point(622, 309);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(93, 33);
            this.fecha.TabIndex = 4;
            this.fecha.Text = "label2";
            // 
            // horafecha
            // 
            this.horafecha.Enabled = true;
            this.horafecha.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(220)))));
            this.panel3.Location = new System.Drawing.Point(480, 171);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(600, 5);
            this.panel3.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(220)))));
            this.panel4.Location = new System.Drawing.Point(480, 391);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(600, 5);
            this.panel4.TabIndex = 6;
            // 
            // Formulario1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 577);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.hora);
            this.Controls.Add(this.panelarriba);
            this.Controls.Add(this.panelmenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Formulario1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelmenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelarriba.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.botonminimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botoncerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelmenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button botonproductos;
        private System.Windows.Forms.Panel barrita1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button botoncategoria;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button botonmarca;
        private System.Windows.Forms.Panel panelarriba;
        private System.Windows.Forms.PictureBox botonminimizar;
        private System.Windows.Forms.PictureBox botoncerrar;
        private System.Windows.Forms.Label hora;
        private System.Windows.Forms.Label fecha;
        private System.Windows.Forms.Timer horafecha;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}

