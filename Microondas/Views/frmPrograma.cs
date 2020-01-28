using Microondas.Controllers;
using Microondas.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Microondas.Views
{
    public partial class frmPrograma : Form
    {
        #region Locais

        private ProgramaController _programaController;

        #endregion Locais

        #region Propriedade

        public IList<Programa> Programas { get; private set; }

        #endregion Propriedade

        #region Construtor

        public frmPrograma()
        {
            InitializeComponent();
            _programaController = new ProgramaController();
            Programas = new List<Programa>();
        }

        #endregion Construtor

        #region Métodos públicos

        private void ButtonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                var programa = new Programa(
                textBoxNome.Text,
                string.IsNullOrEmpty(textBoxTempo.Text) ? 0 : Convert.ToInt32(textBoxTempo.Text),
                string.IsNullOrEmpty(textBoxPot.Text) ? 0 : Convert.ToInt32(textBoxPot.Text),
                textBoxCarAquec.Text,
                textBoxInstr.Text
                );

                _programaController.ValidarPrograma(programa);
                _programaController.AdicionarPrograma(programa);
                Programas = _programaController.PopularPrograma();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta");
            }
        }

        #endregion Métodos públicos
    }
}