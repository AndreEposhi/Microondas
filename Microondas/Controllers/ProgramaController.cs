using Microondas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microondas.Controllers
{
    public class ProgramaController
    {
        #region Locais

        private Programa _programa;

        #endregion Locais

        #region Construtor

        public ProgramaController()
        {
            _programa = new Programa("", 0, 0, "Z", "");
        }

        #endregion Construtor

        #region Métodos publicos

        public IList<Programa> PopularPrograma()
        {
            return _programa.PopularPrograma();
        }

        public void AdicionarPrograma(Programa value)
        {
            _programa.AdicionarPrograma(value);
        }

        #endregion Métodos publicos
    }
}