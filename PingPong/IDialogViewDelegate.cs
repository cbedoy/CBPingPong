using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PingPong
{
    public interface IDialogViewDelegate
    {
        void usuarioSelecciono(Dialog.Tipo option);
    }
}
