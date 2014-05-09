namespace PingPong
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nivelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nivel1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nivel2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nivel4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.muyDificilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.sPuntos = new System.Windows.Forms.Label();
            this.sPausa = new System.Windows.Forms.Label();
            this.nivel = new System.Windows.Forms.Label();
            this.sNivel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nivelToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(657, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nivelToolStripMenuItem
            // 
            this.nivelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nivel1ToolStripMenuItem,
            this.nivel2ToolStripMenuItem,
            this.nToolStripMenuItem,
            this.nivel4ToolStripMenuItem,
            this.muyDificilToolStripMenuItem});
            this.nivelToolStripMenuItem.Name = "nivelToolStripMenuItem";
            this.nivelToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.nivelToolStripMenuItem.Text = "Nivel";
            // 
            // nivel1ToolStripMenuItem
            // 
            this.nivel1ToolStripMenuItem.Name = "nivel1ToolStripMenuItem";
            this.nivel1ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nivel1ToolStripMenuItem.Text = "Muy facil";
            this.nivel1ToolStripMenuItem.Click += new System.EventHandler(this.nivel1ToolStripMenuItem_Click);
            // 
            // nivel2ToolStripMenuItem
            // 
            this.nivel2ToolStripMenuItem.Name = "nivel2ToolStripMenuItem";
            this.nivel2ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nivel2ToolStripMenuItem.Text = "Facil";
            this.nivel2ToolStripMenuItem.Click += new System.EventHandler(this.nivel2ToolStripMenuItem_Click);
            // 
            // nToolStripMenuItem
            // 
            this.nToolStripMenuItem.Name = "nToolStripMenuItem";
            this.nToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nToolStripMenuItem.Text = "Medio";
            this.nToolStripMenuItem.Click += new System.EventHandler(this.nToolStripMenuItem_Click);
            // 
            // nivel4ToolStripMenuItem
            // 
            this.nivel4ToolStripMenuItem.Name = "nivel4ToolStripMenuItem";
            this.nivel4ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nivel4ToolStripMenuItem.Text = "Dificil";
            this.nivel4ToolStripMenuItem.Click += new System.EventHandler(this.nivel4ToolStripMenuItem_Click);
            // 
            // muyDificilToolStripMenuItem
            // 
            this.muyDificilToolStripMenuItem.Name = "muyDificilToolStripMenuItem";
            this.muyDificilToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.muyDificilToolStripMenuItem.Text = "Muy dificil";
            this.muyDificilToolStripMenuItem.Click += new System.EventHandler(this.muyDificilToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(450, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Puntos";
            // 
            // sPuntos
            // 
            this.sPuntos.AutoSize = true;
            this.sPuntos.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.sPuntos.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sPuntos.ForeColor = System.Drawing.Color.SlateGray;
            this.sPuntos.Location = new System.Drawing.Point(603, 8);
            this.sPuntos.Name = "sPuntos";
            this.sPuntos.Size = new System.Drawing.Size(25, 29);
            this.sPuntos.TabIndex = 2;
            this.sPuntos.Text = "0";
            // 
            // sPausa
            // 
            this.sPausa.AutoSize = true;
            this.sPausa.BackColor = System.Drawing.Color.Transparent;
            this.sPausa.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sPausa.Location = new System.Drawing.Point(147, 178);
            this.sPausa.Name = "sPausa";
            this.sPausa.Size = new System.Drawing.Size(386, 73);
            this.sPausa.TabIndex = 3;
            this.sPausa.Text = "P  A  U  S  A";
            // 
            // nivel
            // 
            this.nivel.AutoSize = true;
            this.nivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nivel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.nivel.Location = new System.Drawing.Point(12, 9);
            this.nivel.Name = "nivel";
            this.nivel.Size = new System.Drawing.Size(68, 29);
            this.nivel.TabIndex = 4;
            this.nivel.Text = "Nivel";
            // 
            // sNivel
            // 
            this.sNivel.AutoSize = true;
            this.sNivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sNivel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.sNivel.Location = new System.Drawing.Point(97, 9);
            this.sNivel.Name = "sNivel";
            this.sNivel.Size = new System.Drawing.Size(137, 29);
            this.sNivel.TabIndex = 5;
            this.sNivel.Text = "Nivel actual";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.nivel);
            this.panel1.Controls.Add(this.sNivel);
            this.panel1.Controls.Add(this.sPuntos);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 388);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(657, 47);
            this.panel1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(657, 435);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sPausa);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Juego Actual";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nivelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nivel1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nivel2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nivel4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem muyDificilToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label sPuntos;
        private System.Windows.Forms.Label sPausa;
        private System.Windows.Forms.Label nivel;
        private System.Windows.Forms.Label sNivel;
        private System.Windows.Forms.Panel panel1;
    }
}

