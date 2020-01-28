using System;
using System.Collections.Generic;

namespace Microondas.Models
{
    public class Programa
    {
        #region Locais

        private IList<Programa> _programas;

        #endregion Locais

        #region Propriedade

        public int ID { get; private set; }

        public string Nome { get; private set; }

        public int Tempo { get; private set; }

        public int Potencia { get; private set; }

        public string CaractereAquecimento { get; private set; }

        public string Instrucao { get; private set; }

        #endregion Propriedade

        #region Construtor

        public Programa(string nome, int tempo, int potencia, string caractereAquecimento, string instrucao)
        {
            ID = new Random().Next(1, 100);
            Nome = nome;
            Tempo = tempo;
            Potencia = potencia;
            CaractereAquecimento = caractereAquecimento;
            Instrucao = instrucao;
            _programas = new List<Programa>();
        }

        #endregion Construtor

        #region Métodos públicos

        public void AdicionarPrograma(Programa value)
        {
            _programas.Clear();
            _programas.Add(new Programa(value.Nome, value.Tempo, value.Potencia, value.CaractereAquecimento, value.Instrucao));
        }

        public IList<Programa> PopularPrograma()
        {
            var peixe = new Programa("Peixe", 58, 10, "P", "Tempo de preparo: 58s e potência: 10");
            var frango = new Programa("Frango", 51, 9, "F", "Tempo de preparo: 51s e potência: 9");
            var congelado = new Programa("Congelado", 46, 8, "C", "Tempo de preparo: 46s e potência: 8");
            var sopa = new Programa("Sopa", 35, 7, "S", "Tempo de preparo: 35s e potência: 7");
            var leite = new Programa("Leite", 22, 6, "L", "Tempo de preparo: 22s e potência: 6");

            _programas.Add(peixe);
            _programas.Add(frango);
            _programas.Add(congelado);
            _programas.Add(sopa);
            _programas.Add(leite);

            return _programas;
        }

        #endregion Métodos públicos
    }
}