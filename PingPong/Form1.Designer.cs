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
            this.pOSXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pOSYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.sPuntos = new System.Windows.Forms.Label();
            this.sPausa = new System.Windows.Forms.Label();
            this.nivel = new System.Windows.Forms.Label();
            this.sNivel = new System.Windows.Forms.Label();
            this.tablero = new System.Windows.Forms.Panel();
            this.sGameOver = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tablero.SuspendLayout();
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
            this.menuStrip1.BackColor = System.Drawing.Color.Crimson;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nivelToolStripMenuItem,
            this.pOSXToolStripMenuItem,
            this.pOSYToolStripMenuItem,
            this.wIToolStripMenuItem,
            this.hEToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(768, 25);
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
            this.nivelToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nivelToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.nivelToolStripMenuItem.Name = "nivelToolStripMenuItem";
            this.nivelToolStripMenuItem.Size = new System.Drawing.Size(52, 21);
            this.nivelToolStripMenuItem.Text = "Nivel";
            // 
            // nivel1ToolStripMenuItem
            // 
            this.nivel1ToolStripMenuItem.BackColor = System.Drawing.Color.DodgerBlue;
            this.nivel1ToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nivel1ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.nivel1ToolStripMenuItem.Name = "nivel1ToolStripMenuItem";
            this.nivel1ToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.nivel1ToolStripMenuItem.Text = "Muy facil";
            this.nivel1ToolStripMenuItem.Click += new System.EventHandler(this.nivel1ToolStripMenuItem_Click);
            // 
            // nivel2ToolStripMenuItem
            // 
            this.nivel2ToolStripMenuItem.BackColor = System.Drawing.Color.DodgerBlue;
            this.nivel2ToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nivel2ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.nivel2ToolStripMenuItem.Name = "nivel2ToolStripMenuItem";
            this.nivel2ToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.nivel2ToolStripMenuItem.Text = "Facil";
            this.nivel2ToolStripMenuItem.Click += new System.EventHandler(this.nivel2ToolStripMenuItem_Click);
            // 
            // nToolStripMenuItem
            // 
            this.nToolStripMenuItem.BackColor = System.Drawing.Color.DodgerBlue;
            this.nToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.nToolStripMenuItem.Name = "nToolStripMenuItem";
            this.nToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.nToolStripMenuItem.Text = "Medio";
            this.nToolStripMenuItem.Click += new System.EventHandler(this.nToolStripMenuItem_Click);
            // 
            // nivel4ToolStripMenuItem
            // 
            this.nivel4ToolStripMenuItem.BackColor = System.Drawing.Color.DodgerBlue;
            this.nivel4ToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nivel4ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.nivel4ToolStripMenuItem.Name = "nivel4ToolStripMenuItem";
            this.nivel4ToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.nivel4ToolStripMenuItem.Text = "Dificil";
            this.nivel4ToolStripMenuItem.Click += new System.EventHandler(this.nivel4ToolStripMenuItem_Click);
            // 
            // muyDificilToolStripMenuItem
            // 
            this.muyDificilToolStripMenuItem.BackColor = System.Drawing.Color.DodgerBlue;
            this.muyDificilToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.muyDificilToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.muyDificilToolStripMenuItem.Name = "muyDificilToolStripMenuItem";
            this.muyDificilToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.muyDificilToolStripMenuItem.Text = "Muy dificil";
            this.muyDificilToolStripMenuItem.Click += new System.EventHandler(this.muyDificilToolStripMenuItem_Click);
            // 
            // pOSXToolStripMenuItem
            // 
            this.pOSXToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pOSXToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.pOSXToolStripMenuItem.Name = "pOSXToolStripMenuItem";
            this.pOSXToolStripMenuItem.Size = new System.Drawing.Size(89, 21);
            this.pOSXToolStripMenuItem.Text = "Posicion X:";
            // 
            // pOSYToolStripMenuItem
            // 
            this.pOSYToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pOSYToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.pOSYToolStripMenuItem.Name = "pOSYToolStripMenuItem";
            this.pOSYToolStripMenuItem.Size = new System.Drawing.Size(88, 21);
            this.pOSYToolStripMenuItem.Text = "Posicion Y:";
            // 
            // wIToolStripMenuItem
            // 
            this.wIToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wIToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.wIToolStripMenuItem.Name = "wIToolStripMenuItem";
            this.wIToolStripMenuItem.Size = new System.Drawing.Size(63, 21);
            this.wIToolStripMenuItem.Text = "Ancho:";
            // 
            // hEToolStripMenuItem
            // 
            this.hEToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hEToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.hEToolStripMenuItem.Name = "hEToolStripMenuItem";
            this.hEToolStripMenuItem.Size = new System.Drawing.Size(54, 21);
            this.hEToolStripMenuItem.Text = "Alto: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DodgerBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(613, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Puntos";
            // 
            // sPuntos
            // 
            this.sPuntos.AutoSize = true;
            this.sPuntos.BackColor = System.Drawing.Color.DodgerBlue;
            this.sPuntos.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sPuntos.ForeColor = System.Drawing.Color.Gainsboro;
            this.sPuntos.Location = new System.Drawing.Point(730, 9);
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
            this.sPausa.Location = new System.Drawing.Point(188, 162);
            this.sPausa.Name = "sPausa";
            this.sPausa.Size = new System.Drawing.Size(386, 73);
            this.sPausa.TabIndex = 3;
            this.sPausa.Text = "P  A  U  S  A";
            // 
            // nivel
            // 
            this.nivel.AutoSize = true;
            this.nivel.BackColor = System.Drawing.Color.DodgerBlue;
            this.nivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nivel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.nivel.Location = new System.Drawing.Point(12, 9);
            this.nivel.Name = "nivel";
            this.nivel.Size = new System.Drawing.Size(68, 29);
            this.nivel.TabIndex = 4;
            this.nivel.Text = "Nivel";
            // 
            // sNivel
            // 
            this.sNivel.AutoSize = true;
            this.sNivel.BackColor = System.Drawing.Color.DodgerBlue;
            this.sNivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sNivel.ForeColor = System.Drawing.Color.Gainsboro;
            this.sNivel.Location = new System.Drawing.Point(97, 9);
            this.sNivel.Name = "sNivel";
            this.sNivel.Size = new System.Drawing.Size(137, 29);
            this.sNivel.TabIndex = 5;
            this.sNivel.Text = "Nivel actual";
            // 
            // tablero
            // 
            this.tablero.BackColor = System.Drawing.Color.DodgerBlue;
            this.tablero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tablero.Controls.Add(this.nivel);
            this.tablero.Controls.Add(this.sNivel);
            this.tablero.Controls.Add(this.sPuntos);
            this.tablero.Controls.Add(this.label1);
            this.tablero.Location = new System.Drawing.Point(0, 376);
            this.tablero.Name = "tablero";
            this.tablero.Size = new System.Drawing.Size(768, 47);
            this.tablero.TabIndex = 6;
            // 
            // sGameOver
            // 
            this.sGameOver.AutoSize = true;
            this.sGameOver.BackColor = System.Drawing.Color.Transparent;
            this.sGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sGameOver.Location = new System.Drawing.Point(12, 162);
            this.sGameOver.Name = "sGameOver";
            this.sGameOver.Size = new System.Drawing.Size(732, 73);
            this.sGameOver.TabIndex = 7;
            this.sGameOver.Text = "G A M E    O V E R    </3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(768, 421);
            this.Controls.Add(this.sGameOver);
            this.Controls.Add(this.tablero);
            this.Controls.Add(this.sPausa);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Juego Actual";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tablero.ResumeLayout(false);
            this.tablero.PerformLayout();
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
        private System.Windows.Forms.Panel tablero;
        private System.Windows.Forms.ToolStripMenuItem pOSXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pOSYToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hEToolStripMenuItem;
        private System.Windows.Forms.Label sGameOver;
    }
}

