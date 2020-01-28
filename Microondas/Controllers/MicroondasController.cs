using Microondas.Models;
using System;
using System.Collections.Generic;

namespace Microondas.Controllers
{
    public class MicroondasController
    {
        #region Locais

        private Models.Microondas _microondas;

        #endregion Locais

        #region Construtor

        public MicroondasController()
        {
            _microondas = new Models.Microondas();
        }

        #endregion Construtor

        #region Métodos públicos

        public IList<Programa> PopularPrograma()
        {
            return _microondas.RecuperarProgramas();
        }

        public void ValidarTempo(int totalMinutos, int totalSegundos, int potencia = 0)
        {
            if (totalSegundos == 0 && totalMinutos == 0)
                throw new Exception("Tempo inválido");

            if (totalSegundos > 60)
                throw new Exception("Segundos inválidos");

            if ((totalMinutos + totalSegundos) > 120)
                throw new Exception("Tempo inválido, só é permitido um tempo menor do que 2 minutos");

            if (potencia > 10 || potencia == 0)
                throw new Exception("Potência inválida");
        }

        #endregion Métodos públicos
    }
}