using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace PingPong
{
    public partial class Form1 : Form, IDialogViewDelegate
    {
        private Graphics    graphics;
        private int         puntos;
        private int         factor  = 0;
        private Dialog      dialog  = null;
        Tabla myTabla = new Tabla() 
        { 
            //Singleton Model Tabla
            x               = 100, 
            y               = 350, 
            tamano          = new Size (100,25), 
            direccion_X     = 1, 
            velocidad       = 10
        };
        Pelota myPelota = new Pelota()
        {
            //Singleton Model Tabla
            x               = 50, 
            y               = 50, 
            tamano          = new Size(25,25), 
            Direcccion_Y    = 1, 
            direccion_X     = 1, 
            velocidad       = 10
        };


        public Form1()
        {
            InitializeComponent();
            graphics            = CreateGraphics();
            sPausa.Visible      = false;
            sGameOver.Visible   = false;
            timer1.Enabled      = false;
            dialog              = new Dialog();
            dialog.ViewDelegate = this;
            dialog.Visible      = true;
        }

        public void movimiento_tabla()
        {
            if (myTabla.direccion_X == 1)
            {
                myTabla.x += myTabla.velocidad;
            }
            if (myTabla.direccion_X == 0)
            {
                myTabla.x -= myTabla.velocidad;
            }
        }

        public void movimiento_pelota()
        {
            if (myPelota.direccion_X == 1)
            {
                myPelota.x += myPelota.velocidad;
            }
            if (myPelota.direccion_X == 0)
            {
                myPelota.x -= myPelota.velocidad;
            }
            if (myPelota.Direcccion_Y == 1)
            {
                myPelota.y += myPelota.velocidad;
            }
            if (myPelota.Direcccion_Y == 0)
            {
                myPelota.y -= myPelota.velocidad;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            graphics            .FillRectangle(Brushes.White,       myTabla.Rectangulo);
            movimiento_tabla();
            graphics            .FillRectangle(Brushes.YellowGreen, myTabla.Rectangulo);
            graphics            .FillEllipse(Brushes.White,         myPelota.Rectangulo);
            movimiento_pelota();
            colicion_pelota();
            colicion_pelota_tabla();
            graphics            .FillEllipse(Brushes.Purple,        myPelota.Rectangulo);
        }

        public void colicion_pelota()
        {
            if (myPelota.x <=0)
            {
                myPelota.direccion_X = 1;
            }
            if (myPelota.x > Width - (tablero.Height))
            {
                myPelota.direccion_X = 0;
            }
            if (myPelota.y < 25)
            {
                myPelota.Direcccion_Y = 1;
            }
            if (myPelota.y > Height - (tablero.Height + 70))
            {
                myPelota.Direcccion_Y = 0;
                timer1.Enabled = false;
                this.sGameOver.Visible = true;

            }
            this.pOSXToolStripMenuItem.Text = "Posicion X: " + myPelota.x;
            this.pOSYToolStripMenuItem.Text = "Posicion Y: " + myPelota.y;
            this.wIToolStripMenuItem.Text   = "Ancho: " + Width;
            this.hEToolStripMenuItem.Text   = "Alto: " + Height;
        }

        public void colicion_pelota_tabla()
        {
            if (myTabla.Rectangulo.IntersectsWith(myPelota.Rectangulo))
            {
                if (myPelota.Direcccion_Y == 0)
                {
                    myPelota.Direcccion_Y = 1;
                }
                if (myPelota.Direcccion_Y == 1)
                {
                    myPelota.Direcccion_Y = 0;
                }
                puntos++;
                this.sPuntos.Text           = "" + (puntos * factor);
            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                myTabla.direccion_X = 1;
            }
            if (e.KeyCode == Keys.Left)
            {
                myTabla.direccion_X = 0;
            }
            if (e.KeyCode == Keys.Up)
            {
                myTabla.direccion_Y = 1;
            }
            if (e.KeyCode == Keys.Down)
            {
                myTabla.direccion_Y = 0;
            }
            if (e.KeyCode == Keys.P)
            {
                stop();
            }
        }

        private void stop()
        {
            timer1.Enabled = !timer1.Enabled;
            if (!timer1.Enabled)
            {
                this.sPausa.Visible = true;
            }
            else
            {
                this.sPausa.Visible = false;
            }
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void reset()
        {
            myPelota.x              = 50;
            myPelota.y              = 50;
            puntos                  = 0;
            sPuntos.Text            = "0";
            myPelota.Direcccion_Y   = 1;
            myPelota.direccion_X    = 1;
            timer1.Enabled          = true;
            sPausa.Visible          = false;
            sGameOver.Visible       = false;
        }

        private void nivel1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myPelota.velocidad = 1;
            factor             = 1;
            sNivel.Text = "Muy facil";
            reset();
        }

        private void nToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myPelota.velocidad = 4;
            factor             = 3;
            sNivel.Text = "Intermedio";
            reset();
        }

        private void nivel2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myPelota.velocidad = 2;
            factor             = 2;
            sNivel.Text = "Facil";
            reset();
        }

        private void nivel4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myPelota.velocidad = 8;
            factor             = 4;
            sNivel.Text = "Dificil";
            reset();
        }

        private void muyDificilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myPelota.velocidad = 16;
            factor             = 5;
            sNivel.Text = "Muy Dificil";
            reset();
        }

        public void usuarioSelecciono(Dialog.Tipo option)
        {
            switch (option)
            {
                case Dialog.Tipo.NIVEL_MUY_FACIL:
                    nivel1ToolStripMenuItem_Click(null, null);
                    break;
                case Dialog.Tipo.NIVEL_FACIL:
                    nivel2ToolStripMenuItem_Click(null, null);
                    break;
                case Dialog.Tipo.NIVEL_INTERMEDIO:
                    nToolStripMenuItem_Click(null, null);
                    break;
                case Dialog.Tipo.NIVEL_DIFICIL:
                    nivel4ToolStripMenuItem_Click(null, null);
                    break;
                case Dialog.Tipo.NIVEL_MUY_DIFICIL:
                    muyDificilToolStripMenuItem_Click(null, null);
                    break;
            }
        }
    }
}
