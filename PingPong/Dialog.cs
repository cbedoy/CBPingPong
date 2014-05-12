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
    public partial class Dialog : Form
    {
        public enum Tipo
        {
            NIVEL_MUY_FACIL,
            NIVEL_FACIL,
            NIVEL_INTERMEDIO,
            NIVEL_DIFICIL,
            NIVEL_MUY_DIFICIL
        }


        private IDialogViewDelegate viewDelegate;
        public Dialog()
        {
            InitializeComponent();
        }

        private void Dialog_Load(object sender, EventArgs e)
        {

        }

        public IDialogViewDelegate ViewDelegate
        {
            set { this.viewDelegate = value; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            viewDelegate.usuarioSelecciono(Dialog.Tipo.NIVEL_MUY_FACIL);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            viewDelegate.usuarioSelecciono(Dialog.Tipo.NIVEL_FACIL);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            viewDelegate.usuarioSelecciono(Dialog.Tipo.NIVEL_INTERMEDIO);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            viewDelegate.usuarioSelecciono(Dialog.Tipo.NIVEL_DIFICIL);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            viewDelegate.usuarioSelecciono(Dialog.Tipo.NIVEL_MUY_DIFICIL);
        }
    }
}
