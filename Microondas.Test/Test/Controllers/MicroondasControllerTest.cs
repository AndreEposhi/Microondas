using System;
using Microondas.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Microondas.Test.Test.Controllers
{
    [TestClass]
    public class MicroondasControllerTest
    {
        #region Métodos públicos

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TempoInvalidoTest()
        {
            var totalMinutos = 0;
            var totalSegundos = 0;

            var microondas = new MicroondasController();
            microondas.ValidarTempo(totalMinutos, totalSegundos);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void SegundosInvalidoTest()
        {
            var totalMinutos = 1;
            var totalSegundos = 65;

            var microondas = new MicroondasController();
            microondas.ValidarTempo(totalMinutos, totalSegundos);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TempoMaiorDoisMinutosTest()
        {
            var totalMinutos = 2 * 60;
            var totalSegundos = 10;

            var microondas = new MicroondasController();
            microondas.ValidarTempo(totalMinutos, totalSegundos);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void PotenciaInvalidaTest()
        {
            var totalMinutos = 1;
            var totalSegundos = 10;
            var potencia = 11;

            var microondas = new MicroondasController();
            microondas.ValidarTempo(totalMinutos, totalSegundos, potencia);
        }

        #endregion Métodos públicos
    }
}