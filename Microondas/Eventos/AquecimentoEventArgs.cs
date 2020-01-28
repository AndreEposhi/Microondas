using System;

namespace Microondas.Eventos
{
    public delegate void NotificarAquecimentoHandler(object sender, AquecimentoEventArgs args);

    public class AquecimentoEventArgs : EventArgs
    {
        #region Propriedade

        public string Notificacao { get; private set; }

        #endregion Propriedade

        #region Construtor

        public AquecimentoEventArgs(string notificacao)
        {
            Notificacao = notificacao;
        }

        #endregion Construtor
    }
}