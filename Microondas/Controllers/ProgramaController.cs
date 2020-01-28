using Microondas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        public void ValidarPrograma(Programa value)
        {
            if (String.IsNullOrEmpty(value.Nome))
                throw new Exception("Nome do programa é obrigatório");

            if (value.Tempo > 120 || value.Tempo == 0)
                throw new Exception("Tempo inválido");

            if (value.Potencia > 10 || value.Potencia == 0)
                throw new Exception("Potência inválida");

            if (string.IsNullOrEmpty(value.CaractereAquecimento))
                throw new Exception("Caractere de Aquecimento é obrigatório");

            Regex caractereAquecimento = new Regex(@"[a-zA-Z]");
            bool resultado = caractereAquecimento.IsMatch(value.CaractereAquecimento);

            if (!resultado)
                throw new Exception("Caractere de Aquecimento é inválido");

            if (string.IsNullOrEmpty(value.Instrucao))
                throw new Exception("Instrução é obrigatório");
        }

        #endregion Métodos publicos
    }
}