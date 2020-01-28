using System;

namespace Microondas.Eventos
{
    public delegate void NotificarErroHandler(object sender, ErroEventArgs args);

    public class ErroEventArgs : EventArgs
    {
        #region Propriedade

        public string Erro { get; private set; }

        #endregion Propriedade

        #region Construtor

        public ErroEventArgs(string erro)
        {
            Erro = erro;
        }

        #endregion Construtor
    }
}