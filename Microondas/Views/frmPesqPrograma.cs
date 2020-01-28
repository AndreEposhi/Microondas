using Microondas.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Microondas.Views
{
    public partial class frmPesqPrograma : Form
    {
        #region Construtor

        public frmPesqPrograma()
        {
            InitializeComponent();
        }

        #endregion Construtor

        #region Métodos públicos

        public void PopularGrid(IList<Programa> values)
        {
            dataGridViewProg.Rows.Clear();

            foreach (var programa in values)
            {
                dataGridViewProg.Rows.Add(new object[]
                {
                    programa.Nome,
                    programa.Tempo,
                    programa.Potencia,
                    programa.CaractereAquecimento,
                    programa.Instrucao
                });
            }
        }

        #endregion Métodos públicos
    }
}