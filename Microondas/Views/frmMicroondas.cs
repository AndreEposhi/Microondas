using Microondas.Controllers;
using Microondas.Eventos;
using Microondas.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Microondas.Views
{
    public partial class frmMicroondas : Form
    {
        #region Locais

        private bool _primeiroDigitoPreenchido;

        private bool _segundoDigitoPreenchido;

        private bool _terceiroDigitoPreenchido;

        private string _primeiroDigito = "";

        private string _segundoDigito = "";

        private string _terceiroDigito = "";

        private int _totalMinutos = 0;

        private int _totalSegundos = 0;

        private int _totalTempoSegundos = 0;

        private int _potenciaValor = 10;

        private MicroondasController _microondasController;

        private IList<Programa> _programas;

        #endregion Locais

        #region Eventos

        public event NotificarAquecimentoHandler OnNotificarAquecimento;

        public event NotificarErroHandler OnNotificarErro;

        #endregion Eventos

        #region Construtor

        public frmMicroondas()
        {
            InitializeComponent();
            lblCaracProg.Text = "";
            _programas = new List<Programa>();
            _microondasController = new MicroondasController();
            BuscarTempo();
            PopularPrograma(_microondasController.PopularPrograma());
        }

        #endregion Construtor

        #region Métodos privados

        private void PopularPrograma(IList<Programa> values)
        {
            var programas = new List<Programa>();
            programas.Add(new Programa("Selecione", 0, 0, "X", ""));

            foreach (var programa in values)
                programas.Add(new Programa(programa.Nome, programa.Tempo, programa.Potencia, programa.CaractereAquecimento, programa.Instrucao));

            comboBoxProg.DataSource = programas;
            comboBoxProg.DisplayMember = "Nome";
            comboBoxProg.ValueMember = "ID";
            _programas = programas;
        }

        private void BuscarTempo()
        {
            _primeiroDigito = lblTempo.Text.Substring(4, 1);
            _segundoDigito = lblTempo.Text.Substring(3, 1);
            _terceiroDigito = lblTempo.Text.Substring(1, 1);
        }

        private void ProgramarTempo(string tempo = "0")
        {
            if (!_terceiroDigitoPreenchido)
            {
                _terceiroDigitoPreenchido = true;
                _terceiroDigito = tempo;
                lblTempo.Text = $"0{_terceiroDigito}:{_segundoDigito}{_primeiroDigito}";
            }
            else if (!_segundoDigitoPreenchido)
            {
                _segundoDigitoPreenchido = true;
                _segundoDigito = tempo;
                lblTempo.Text = $"0{_terceiroDigito}:{_segundoDigito}{_primeiroDigito}";
            }
            else if (!_primeiroDigitoPreenchido)
            {
                _primeiroDigitoPreenchido = true;
                _primeiroDigito = tempo;
                lblTempo.Text = $"0{_terceiroDigito}:{_segundoDigito}{_primeiroDigito}";
            }
        }

        private void ResetarTempo()
        {
            _terceiroDigitoPreenchido = false;
            _segundoDigitoPreenchido = false;
            _primeiroDigitoPreenchido = false;
            _primeiroDigito = "0";
            _segundoDigito = "0";
            _terceiroDigito = "0";
            lblCaracProg.Text = "";
            lblTempo.Text = "00:00";
            lblTempo.Refresh();
        }

        private bool ValidarTempo()
        {
            try
            {
                _totalMinutos = Convert.ToInt32(_terceiroDigito) * 60;
                _totalSegundos = (Convert.ToInt32(_segundoDigito) * 10) + Convert.ToInt32(_primeiroDigito);
                _potenciaValor = Convert.ToInt32(lblPotValor.Text);

                _microondasController.ValidarTempo(_totalMinutos, _totalSegundos, _potenciaValor);
            }
            catch (Exception ex)
            {
                if (OnNotificarErro != null)
                    OnNotificarErro(this, new ErroEventArgs(ex.Message));

                MessageBox.Show(ex.Message, "Alerta");
                ResetarTempo();
                return false;
            }

            _totalTempoSegundos = _totalMinutos + _totalSegundos;

            return true;
        }

        private void Iniciar(int terceiroDigito, int totalTempoSegundos, int totalSegundos, bool rapido = false)
        {
            for (int j = 0; j <= terceiroDigito; j++)
            {
                if (j == 2)
                    break;

                var segundos = totalSegundos == 0 ? 60 : totalSegundos;
                decimal minuto = terceiroDigito == 0 ? 0 : terceiroDigito;

                if (totalTempoSegundos == 120 || totalTempoSegundos == 60)
                {
                    minuto = totalTempoSegundos / 60;
                    minuto = Math.Round(minuto - 1);

                    if (minuto < 0)
                        minuto = 0;

                    if (!rapido)
                        segundos = 60;
                }

                for (int k = segundos; k <= segundos; k--)
                {
                    segundos = --segundos;
                    lblTempo.Text = $"0{minuto}:{segundos.ToString().PadLeft(2, '0')}";
                    lblTempo.Refresh();
                    --totalTempoSegundos;
                    System.Threading.Thread.Sleep(1000);

                    if (segundos == 0)
                        break;
                }
            }

            if (OnNotificarAquecimento != null)
                OnNotificarAquecimento(this, new AquecimentoEventArgs("Aquecido"));

            MessageBox.Show("Aquecido", "Aviso");
            ResetarTempo();
        }

        private void ConfigurarPotencia(int potencia)
        {
            try
            {
                ValidarTempo();

                lblPotLeg.Text = "";

                for (int i = 0; i < potencia; i++)
                {
                    lblPotLeg.Text = lblPotLeg.Text + ".";
                    lblPotLeg.Refresh();
                }
                lblPotValor.Text = potencia.ToString();
                lblPotValor.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta");
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ProgramarTempo("1");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            ProgramarTempo("2");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            ProgramarTempo("3");
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            ProgramarTempo("4");
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            ProgramarTempo("5");
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            ProgramarTempo("6");
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            ProgramarTempo("7");
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            ProgramarTempo("8");
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            ProgramarTempo("9");
        }

        private void Button0_Click(object sender, EventArgs e)
        {
            ProgramarTempo();
        }

        private void ButtonInic_Click(object sender, EventArgs e)
        {
            if (!ValidarTempo())
                return;

            Iniciar(Convert.ToInt32(_terceiroDigito), _totalTempoSegundos, _totalSegundos);
        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            ResetarTempo();
        }

        private void ButtonPot_Click(object sender, EventArgs e)
        {
            _potenciaValor = Convert.ToInt32(lblPotValor.Text);

            if (_potenciaValor == 10 || _potenciaValor >= 2)
            {
                --_potenciaValor;
                lblPotValor.Text = _potenciaValor.ToString();
                lblPotLeg.Text = lblPotLeg.Text.Substring(0, _potenciaValor);
                lblPotLeg.Refresh();
            }
        }

        private void ButtonPotMais_Click(object sender, EventArgs e)
        {
            _potenciaValor = Convert.ToInt32(lblPotValor.Text);

            if (_potenciaValor == 1 || _potenciaValor <= 9)
            {
                ++_potenciaValor;
                lblPotValor.Text = _potenciaValor.ToString();
                lblPotLeg.Text = lblPotLeg.Text + ".";
                lblPotLeg.Refresh();
            }
        }

        private void ButtonRapido_Click(object sender, EventArgs e)
        {
            lblTempo.Text = "00:30";
            lblPotValor.Text = "8";
            lblPotLeg.Text = "........";
            lblTempo.Refresh();
            lblPotValor.Refresh();
            lblPotLeg.Refresh();

            Iniciar(0, 30, 30, true);
        }

        private void ComboBoxProg_SelectedValueChanged(object sender, EventArgs e)
        {
            var combo = (ComboBox)sender;

            if (combo != null && combo.SelectedIndex > 0)
            {
                ResetarTempo();
                var minuto = ((Programa)combo.SelectedItem)?.Tempo == 120 ? 2 : ((Programa)combo.SelectedItem)?.Tempo > 60 ? 1 : 0;
                var totalsegundos = ((Programa)combo.SelectedItem).Tempo;
                var potencia = ((Programa)combo.SelectedItem).Potencia;
                var caractereAquecimento = ((Programa)combo.SelectedItem).CaractereAquecimento;

                if (totalsegundos > 60)
                    totalsegundos = totalsegundos - 60;

                lblTempo.Text = $"0{minuto}:{totalsegundos.ToString().PadLeft(2, '0')}";
                lblTempo.Refresh();
                lblCaracProg.Text = caractereAquecimento.ToString();

                _terceiroDigito = minuto.ToString();
                _totalTempoSegundos = totalsegundos;
                _totalSegundos = totalsegundos;
                BuscarTempo();

                ConfigurarPotencia(potencia);
            }
            else
                ResetarTempo();
        }

        private void ButtonAdcProg_Click(object sender, EventArgs e)
        {
            frmPrograma frmPrograma = new frmPrograma();
            frmPrograma.ShowDialog();
            PopularPrograma(frmPrograma.Programas);
        }

        private void ButtonPesq_Click(object sender, EventArgs e)
        {
            var frmPesqPrograma = new frmPesqPrograma();
            _programas.RemoveAt(0);
            frmPesqPrograma.PopularGrid(_programas);
            frmPesqPrograma.ShowDialog();
        }

        #endregion Métodos privados
    }
}