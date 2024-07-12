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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.barrita1 = new System.Windows.Forms.Panel();
            this.botonproductos = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.hora = new System.Windows.Forms.Label();
            this.fecha = new System.Windows.Forms.Label();
            this.horafecha = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelmenu
            // 
            this.panelmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(220)))));
            this.panelmenu.Controls.Add(this.pictureBox2);
            this.panelmenu.Controls.Add(this.barrita1);
            this.panelmenu.Controls.Add(this.botonproductos);
            this.panelmenu.Controls.Add(this.pictureBox1);
            this.panelmenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelmenu.Location = new System.Drawing.Point(0, 0);
            this.panelmenu.Name = "panelmenu";
            this.panelmenu.Size = new System.Drawing.Size(274, 440);
            this.panelmenu.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::Mercado.Properties.Resources.icons8_apagar_30;
            this.pictureBox2.Location = new System.Drawing.Point(116, 404);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // barrita1
            // 
            this.barrita1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.barrita1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(220)))));
            this.barrita1.Location = new System.Drawing.Point(-5, 233);
            this.barrita1.Name = "barrita1";
            this.barrita1.Size = new System.Drawing.Size(10, 45);
            this.barrita1.TabIndex = 2;
            // 
            // botonproductos
            // 
            this.botonproductos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.botonproductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(220)))));
            this.botonproductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonproductos.FlatAppearance.BorderSize = 0;
            this.botonproductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.botonproductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonproductos.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonproductos.ForeColor = System.Drawing.Color.White;
            this.botonproductos.Image = global::Mercado.Properties.Resources.producto;
            this.botonproductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonproductos.Location = new System.Drawing.Point(11, 234);
            this.botonproductos.Name = "botonproductos";
            this.botonproductos.Size = new System.Drawing.Size(266, 44);
            this.botonproductos.TabIndex = 1;
            this.botonproductos.Text = "Productos";
            this.botonproductos.UseVisualStyleBackColor = false;
            this.botonproductos.Click += new System.EventHandler(this.botonproductos_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::Mercado.Properties.Resources.rm410_11a_fotor_bg_remover_20240704142643;
            this.pictureBox1.Location = new System.Drawing.Point(0, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(277, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // hora
            // 
            this.hora.AutoSize = true;
            this.hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(220)))));
            this.hora.Location = new System.Drawing.Point(83, 106);
            this.hora.Name = "hora";
            this.hora.Size = new System.Drawing.Size(152, 55);
            this.hora.TabIndex = 3;
            this.hora.Text = "label1";
            // 
            // fecha
            // 
            this.fecha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fecha.AutoSize = true;
            this.fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.fecha.Location = new System.Drawing.Point(87, 181);
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
            this.panel3.Location = new System.Drawing.Point(67, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(412, 5);
            this.panel3.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(220)))));
            this.panel4.Location = new System.Drawing.Point(67, 260);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(412, 5);
            this.panel4.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.hora);
            this.panel1.Controls.Add(this.fecha);
            this.panel1.Location = new System.Drawing.Point(400, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(541, 300);
            this.panel1.TabIndex = 7;
            // 
            // Formulario1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1068, 440);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelmenu);
            this.MinimumSize = new System.Drawing.Size(850, 364);
            this.Name = "Formulario1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.panelmenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelmenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button botonproductos;
        private System.Windows.Forms.Panel barrita1;
        private System.Windows.Forms.Label hora;
        private System.Windows.Forms.Label fecha;
        private System.Windows.Forms.Timer horafecha;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
    }
}

