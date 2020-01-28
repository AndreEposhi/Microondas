using System.Collections.Generic;

namespace Microondas.Models
{
    public class Microondas
    {
        #region Locais

        private Programa _programa;

        #endregion Locais

        #region Construtor

        public Microondas()
        {
            _programa = new Programa("", 0, 0, "", "");
        }

        #endregion Construtor

        #region Métodos públicos

        public IList<Programa> RecuperarProgramas()
        {
            return _programa.PopularPrograma();
        }

        #endregion Métodos públicos
    }
}