namespace VideoClub
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conectarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desconectarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alquilarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devolverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.logueado = new System.Windows.Forms.Label();
            this.cant = new System.Windows.Forms.TextBox();
            this.titulo = new System.Windows.Forms.TextBox();
            this.director = new System.Windows.Forms.TextBox();
            this.estreno = new System.Windows.Forms.TextBox();
            this.genero = new System.Windows.Forms.TextBox();
            this.precio = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.TextBox();
            this.sinopsis = new System.Windows.Forms.TextBox();
            this.portada = new System.Windows.Forms.PictureBox();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.portada)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.BackgroundImage = global::VideoClub.Properties.Resources.Base_VC_Sin_Logo_V2;
            this.menuStrip1.Font = new System.Drawing.Font("Comic Sans MS", 18.25F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.buscarToolStripMenuItem,
            this.alquilarToolStripMenuItem,
            this.devolverToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 6, 0, 6);
            this.menuStrip1.Size = new System.Drawing.Size(848, 46);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conectarToolStripMenuItem,
            this.desconectarToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.loginToolStripMenuItem.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.loginToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(75, 34);
            this.loginToolStripMenuItem.Text = "Login";
            // 
            // conectarToolStripMenuItem
            // 
            this.conectarToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.conectarToolStripMenuItem.BackgroundImage = global::VideoClub.Properties.Resources.Base_VC;
            this.conectarToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.conectarToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.conectarToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.conectarToolStripMenuItem.Name = "conectarToolStripMenuItem";
            this.conectarToolStripMenuItem.Size = new System.Drawing.Size(211, 34);
            this.conectarToolStripMenuItem.Text = "Conectar";
            this.conectarToolStripMenuItem.Click += new System.EventHandler(this.conectarToolStripMenuItem_Click);
            // 
            // desconectarToolStripMenuItem
            // 
            this.desconectarToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.desconectarToolStripMenuItem.BackgroundImage = global::VideoClub.Properties.Resources.Base_VC;
            this.desconectarToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.desconectarToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.desconectarToolStripMenuItem.Name = "desconectarToolStripMenuItem";
            this.desconectarToolStripMenuItem.Size = new System.Drawing.Size(211, 34);
            this.desconectarToolStripMenuItem.Text = "Desconectar";
            this.desconectarToolStripMenuItem.Click += new System.EventHandler(this.desconectarToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.salirToolStripMenuItem.BackgroundImage = global::VideoClub.Properties.Resources.Base_VC;
            this.salirToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.salirToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(211, 34);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F);
            this.buscarToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(88, 34);
            this.buscarToolStripMenuItem.Text = "Buscar";
            this.buscarToolStripMenuItem.Click += new System.EventHandler(this.buscarToolStripMenuItem_Click);
            // 
            // alquilarToolStripMenuItem
            // 
            this.alquilarToolStripMenuItem.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F);
            this.alquilarToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.alquilarToolStripMenuItem.Name = "alquilarToolStripMenuItem";
            this.alquilarToolStripMenuItem.Size = new System.Drawing.Size(94, 34);
            this.alquilarToolStripMenuItem.Text = "Alquilar";
            this.alquilarToolStripMenuItem.Click += new System.EventHandler(this.alquilarToolStripMenuItem_Click);
            // 
            // devolverToolStripMenuItem
            // 
            this.devolverToolStripMenuItem.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F);
            this.devolverToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.devolverToolStripMenuItem.Name = "devolverToolStripMenuItem";
            this.devolverToolStripMenuItem.Size = new System.Drawing.Size(103, 34);
            this.devolverToolStripMenuItem.Text = "Devolver";
            this.devolverToolStripMenuItem.Click += new System.EventHandler(this.devolverToolStripMenuItem_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.WindowText;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(16, 105);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(275, 234);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selecciona el nombre de la película:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(315, 139);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 9F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(315, 166);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Titulo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 9F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(315, 193);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Director:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 9F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(315, 223);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Estreno:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 9F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(315, 251);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "Género:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 9F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(548, 247);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Sinopsis:";
            this.label7.Click += new System.EventHandler(this.Label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Bahnschrift", 9F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(315, 279);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 18);
            this.label8.TabIndex = 9;
            this.label8.Text = "Cantidad:";
            this.label8.Click += new System.EventHandler(this.Label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Bahnschrift", 9F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(315, 306);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 18);
            this.label9.TabIndex = 10;
            this.label9.Text = "Precio:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Image = global::VideoClub.Properties.Resources.Base;
            this.label10.Location = new System.Drawing.Point(606, 19);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 17);
            this.label10.TabIndex = 11;
            this.label10.Text = "Estado:";
            // 
            // logueado
            // 
            this.logueado.AutoSize = true;
            this.logueado.BackColor = System.Drawing.Color.Transparent;
            this.logueado.Font = new System.Drawing.Font("Bahnschrift", 9F);
            this.logueado.ForeColor = System.Drawing.Color.White;
            this.logueado.Image = global::VideoClub.Properties.Resources.Base;
            this.logueado.Location = new System.Drawing.Point(689, 19);
            this.logueado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.logueado.Name = "logueado";
            this.logueado.Size = new System.Drawing.Size(0, 18);
            this.logueado.TabIndex = 12;
            // 
            // cant
            // 
            this.cant.Location = new System.Drawing.Point(392, 276);
            this.cant.Margin = new System.Windows.Forms.Padding(4);
            this.cant.Name = "cant";
            this.cant.Size = new System.Drawing.Size(132, 24);
            this.cant.TabIndex = 13;
            // 
            // titulo
            // 
            this.titulo.Location = new System.Drawing.Point(392, 162);
            this.titulo.Margin = new System.Windows.Forms.Padding(4);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(132, 24);
            this.titulo.TabIndex = 14;
            // 
            // director
            // 
            this.director.Location = new System.Drawing.Point(392, 190);
            this.director.Margin = new System.Windows.Forms.Padding(4);
            this.director.Name = "director";
            this.director.Size = new System.Drawing.Size(132, 24);
            this.director.TabIndex = 15;
            // 
            // estreno
            // 
            this.estreno.Location = new System.Drawing.Point(392, 219);
            this.estreno.Margin = new System.Windows.Forms.Padding(4);
            this.estreno.Name = "estreno";
            this.estreno.Size = new System.Drawing.Size(132, 24);
            this.estreno.TabIndex = 17;
            // 
            // genero
            // 
            this.genero.Location = new System.Drawing.Point(392, 247);
            this.genero.Margin = new System.Windows.Forms.Padding(4);
            this.genero.Name = "genero";
            this.genero.Size = new System.Drawing.Size(132, 24);
            this.genero.TabIndex = 18;
            // 
            // precio
            // 
            this.precio.Location = new System.Drawing.Point(392, 303);
            this.precio.Margin = new System.Windows.Forms.Padding(4);
            this.precio.Name = "precio";
            this.precio.Size = new System.Drawing.Size(132, 24);
            this.precio.TabIndex = 19;
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(392, 135);
            this.id.Margin = new System.Windows.Forms.Padding(4);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(132, 24);
            this.id.TabIndex = 20;
            // 
            // sinopsis
            // 
            this.sinopsis.BackColor = System.Drawing.SystemColors.WindowText;
            this.sinopsis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sinopsis.ForeColor = System.Drawing.Color.White;
            this.sinopsis.Location = new System.Drawing.Point(552, 276);
            this.sinopsis.Margin = new System.Windows.Forms.Padding(4);
            this.sinopsis.Multiline = true;
            this.sinopsis.Name = "sinopsis";
            this.sinopsis.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.sinopsis.Size = new System.Drawing.Size(265, 90);
            this.sinopsis.TabIndex = 21;
            this.sinopsis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // portada
            // 
            this.portada.BackColor = System.Drawing.Color.Black;
            this.portada.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.portada.Location = new System.Drawing.Point(617, 67);
            this.portada.Name = "portada";
            this.portada.Size = new System.Drawing.Size(115, 167);
            this.portada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.portada.TabIndex = 22;
            this.portada.TabStop = false;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F);
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(145, 34);
            this.toolStripMenuItem1.Text = "Alta Peliculas";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.ToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::VideoClub.Properties.Resources.Base_VC_Logo_V3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(848, 381);
            this.Controls.Add(this.portada);
            this.Controls.Add(this.sinopsis);
            this.Controls.Add(this.id);
            this.Controls.Add(this.precio);
            this.Controls.Add(this.genero);
            this.Controls.Add(this.estreno);
            this.Controls.Add(this.director);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.cant);
            this.Controls.Add(this.logueado);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "VideoClub";
            this.VisibleChanged += new System.EventHandler(this.Loguer);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.portada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conectarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desconectarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alquilarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devolverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label logueado;
        private System.Windows.Forms.TextBox cant;
        private System.Windows.Forms.TextBox titulo;
        private System.Windows.Forms.TextBox director;
        private System.Windows.Forms.TextBox estreno;
        private System.Windows.Forms.TextBox genero;
        private System.Windows.Forms.TextBox precio;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox sinopsis;
        private System.Windows.Forms.PictureBox portada;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}

