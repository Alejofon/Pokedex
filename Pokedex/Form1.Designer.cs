namespace Pokedex
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.ImagenPokemon = new System.Windows.Forms.PictureBox();
            this.textNumero = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textVelocidad = new System.Windows.Forms.TextBox();
            this.textVida = new System.Windows.Forms.TextBox();
            this.textDefensa = new System.Windows.Forms.TextBox();
            this.textAtaque = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textMov4 = new System.Windows.Forms.TextBox();
            this.textMov3 = new System.Windows.Forms.TextBox();
            this.textMov2 = new System.Windows.Forms.TextBox();
            this.textMov1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textTipo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.Buscar = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse4 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.labelCerrar = new System.Windows.Forms.Label();
            this.bunifuElipse5 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenPokemon)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1176, 568);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.pictureBox1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // ImagenPokemon
            // 
            this.ImagenPokemon.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ImagenPokemon.Location = new System.Drawing.Point(277, 178);
            this.ImagenPokemon.Name = "ImagenPokemon";
            this.ImagenPokemon.Size = new System.Drawing.Size(269, 174);
            this.ImagenPokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImagenPokemon.TabIndex = 1;
            this.ImagenPokemon.TabStop = false;
            // 
            // textNumero
            // 
            this.textNumero.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.textNumero.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textNumero.Font = new System.Drawing.Font("Orbitron", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textNumero.ForeColor = System.Drawing.Color.Lime;
            this.textNumero.Location = new System.Drawing.Point(4, 34);
            this.textNumero.Name = "textNumero";
            this.textNumero.Size = new System.Drawing.Size(159, 42);
            this.textNumero.TabIndex = 3;
            this.textNumero.Text = "\r\n\r\n0000\r\n";
            this.textNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.groupBox1.Controls.Add(this.textNumero);
            this.groupBox1.Font = new System.Drawing.Font("Orbitron", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.Lime;
            this.groupBox1.Location = new System.Drawing.Point(293, 467);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(169, 82);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Introduce un numero";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.groupBox2.Controls.Add(this.textVelocidad);
            this.groupBox2.Controls.Add(this.textVida);
            this.groupBox2.Controls.Add(this.textDefensa);
            this.groupBox2.Controls.Add(this.textAtaque);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textMov4);
            this.groupBox2.Controls.Add(this.textMov3);
            this.groupBox2.Controls.Add(this.textMov2);
            this.groupBox2.Controls.Add(this.textMov1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textTipo);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textNumber);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textNombre);
            this.groupBox2.Font = new System.Drawing.Font("Orbitron", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.Color.Lime;
            this.groupBox2.Location = new System.Drawing.Point(671, 190);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 280);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informacion";
            // 
            // textVelocidad
            // 
            this.textVelocidad.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.textVelocidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textVelocidad.Enabled = false;
            this.textVelocidad.ForeColor = System.Drawing.Color.Lime;
            this.textVelocidad.Location = new System.Drawing.Point(194, 224);
            this.textVelocidad.Name = "textVelocidad";
            this.textVelocidad.Size = new System.Drawing.Size(80, 16);
            this.textVelocidad.TabIndex = 18;
            this.textVelocidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textVida
            // 
            this.textVida.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.textVida.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textVida.Enabled = false;
            this.textVida.ForeColor = System.Drawing.Color.Lime;
            this.textVida.Location = new System.Drawing.Point(147, 224);
            this.textVida.Name = "textVida";
            this.textVida.Size = new System.Drawing.Size(41, 16);
            this.textVida.TabIndex = 17;
            this.textVida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textDefensa
            // 
            this.textDefensa.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.textDefensa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textDefensa.Enabled = false;
            this.textDefensa.ForeColor = System.Drawing.Color.Lime;
            this.textDefensa.Location = new System.Drawing.Point(76, 224);
            this.textDefensa.Name = "textDefensa";
            this.textDefensa.Size = new System.Drawing.Size(65, 16);
            this.textDefensa.TabIndex = 16;
            this.textDefensa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textAtaque
            // 
            this.textAtaque.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.textAtaque.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textAtaque.Enabled = false;
            this.textAtaque.ForeColor = System.Drawing.Color.Lime;
            this.textAtaque.Location = new System.Drawing.Point(6, 224);
            this.textAtaque.Name = "textAtaque";
            this.textAtaque.Size = new System.Drawing.Size(64, 16);
            this.textAtaque.TabIndex = 15;
            this.textAtaque.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(194, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Velocidad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(147, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Vida";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Defensa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ataque";
            // 
            // textMov4
            // 
            this.textMov4.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.textMov4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textMov4.Enabled = false;
            this.textMov4.ForeColor = System.Drawing.Color.Lime;
            this.textMov4.Location = new System.Drawing.Point(16, 168);
            this.textMov4.Name = "textMov4";
            this.textMov4.Size = new System.Drawing.Size(146, 16);
            this.textMov4.TabIndex = 10;
            // 
            // textMov3
            // 
            this.textMov3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.textMov3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textMov3.Enabled = false;
            this.textMov3.ForeColor = System.Drawing.Color.Lime;
            this.textMov3.Location = new System.Drawing.Point(16, 146);
            this.textMov3.Name = "textMov3";
            this.textMov3.Size = new System.Drawing.Size(146, 16);
            this.textMov3.TabIndex = 9;
            // 
            // textMov2
            // 
            this.textMov2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.textMov2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textMov2.Enabled = false;
            this.textMov2.ForeColor = System.Drawing.Color.Lime;
            this.textMov2.Location = new System.Drawing.Point(16, 124);
            this.textMov2.Name = "textMov2";
            this.textMov2.Size = new System.Drawing.Size(146, 16);
            this.textMov2.TabIndex = 8;
            // 
            // textMov1
            // 
            this.textMov1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.textMov1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textMov1.Enabled = false;
            this.textMov1.ForeColor = System.Drawing.Color.Lime;
            this.textMov1.Location = new System.Drawing.Point(16, 102);
            this.textMov1.Name = "textMov1";
            this.textMov1.Size = new System.Drawing.Size(146, 16);
            this.textMov1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Movimientos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tipo";
            // 
            // textTipo
            // 
            this.textTipo.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.textTipo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textTipo.Enabled = false;
            this.textTipo.ForeColor = System.Drawing.Color.Lime;
            this.textTipo.Location = new System.Drawing.Point(76, 54);
            this.textTipo.Name = "textTipo";
            this.textTipo.Size = new System.Drawing.Size(146, 16);
            this.textTipo.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Numero";
            // 
            // textNumber
            // 
            this.textNumber.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.textNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textNumber.Enabled = false;
            this.textNumber.ForeColor = System.Drawing.Color.Lime;
            this.textNumber.Location = new System.Drawing.Point(76, 38);
            this.textNumber.Name = "textNumber";
            this.textNumber.Size = new System.Drawing.Size(146, 16);
            this.textNumber.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // textNombre
            // 
            this.textNombre.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.textNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textNombre.Enabled = false;
            this.textNombre.ForeColor = System.Drawing.Color.Lime;
            this.textNombre.Location = new System.Drawing.Point(76, 19);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(146, 16);
            this.textNombre.TabIndex = 0;
            // 
            // Buscar
            // 
            this.Buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Buscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Buscar.Font = new System.Drawing.Font("Orbitron", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Buscar.ForeColor = System.Drawing.Color.Silver;
            this.Buscar.Location = new System.Drawing.Point(671, 476);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(276, 67);
            this.Buscar.TabIndex = 6;
            this.Buscar.Text = "Buscar Pokemon";
            this.Buscar.UseVisualStyleBackColor = false;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this.groupBox2;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 15;
            this.bunifuElipse2.TargetControl = this.groupBox1;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 15;
            this.bunifuElipse3.TargetControl = this.ImagenPokemon;
            // 
            // bunifuElipse4
            // 
            this.bunifuElipse4.ElipseRadius = 15;
            this.bunifuElipse4.TargetControl = this.Buscar;
            // 
            // labelCerrar
            // 
            this.labelCerrar.AutoSize = true;
            this.labelCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelCerrar.Font = new System.Drawing.Font("Orbitron", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCerrar.ForeColor = System.Drawing.Color.Maroon;
            this.labelCerrar.Location = new System.Drawing.Point(332, 23);
            this.labelCerrar.Name = "labelCerrar";
            this.labelCerrar.Size = new System.Drawing.Size(25, 22);
            this.labelCerrar.TabIndex = 7;
            this.labelCerrar.Text = "X";
            this.labelCerrar.Click += new System.EventHandler(this.labelCerrar_Click);
            // 
            // bunifuElipse5
            // 
            this.bunifuElipse5.ElipseRadius = 100;
            this.bunifuElipse5.TargetControl = this.labelCerrar;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1200, 592);
            this.Controls.Add(this.labelCerrar);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ImagenPokemon);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Black;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenPokemon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private PictureBox ImagenPokemon;
        private TextBox textNumero;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox textNombre;
        private Button Buscar;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse4;
        private Label label1;
        private TextBox textVelocidad;
        private TextBox textVida;
        private TextBox textDefensa;
        private TextBox textAtaque;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox textMov4;
        private TextBox textMov3;
        private TextBox textMov2;
        private TextBox textMov1;
        private Label label4;
        private Label label3;
        private TextBox textTipo;
        private Label label2;
        private TextBox textNumber;
        private Label labelCerrar;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse5;
    }
}