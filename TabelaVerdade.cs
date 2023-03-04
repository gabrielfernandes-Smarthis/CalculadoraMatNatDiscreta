using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraMatNatDiscreta
{
    public partial class TabelaVerdade : Form
    {
        public override System.Drawing.Size MaximumSize { get; set; }
        public TabelaVerdade()
        {
            InitializeComponent();
            this.MaximumSize = new System.Drawing.Size(1368, 600);
        }

        public void GerarTabela(double linha, int colunas, List<List<bool>> ListaProp, List<bool> Resultado, List<Proposicao> proposicaos)
        {
            tabelaVerdadeG.Controls.Clear();

            tabelaVerdadeG.ColumnStyles.Clear();
            tabelaVerdadeG.RowStyles.Clear();

            tabelaVerdadeG.ColumnCount = colunas;
            tabelaVerdadeG.RowCount = (int)linha;

            tabelaVerdadeG.AutoScroll = true;
            //tabelaVerdadeG.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            int width = 0;
            int height = 0;
            float tamCol = 100 / colunas;
            float tamlinha = 100 / Convert.ToInt32(linha);
            for (int i = 0; i < colunas; i++)
            {
                width += 58;
                tabelaVerdadeG.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, tamCol));
            }
            for (int i = 0; i < linha; i++)
            {
                height += 64;
                tabelaVerdadeG.RowStyles.Add(new RowStyle(SizeType.Percent, tamlinha));
            }

            tabelaVerdadeG.Size = new Size(width, height);

            for (int i = 0; i < proposicaos.Count; i++)
            {
                tabelaVerdadeG.Controls.Add(new Label() { Text = proposicaos[i].getNome().ToString() }, i, 0);
            }

            tabelaVerdadeG.Controls.Add(new Label() { Text = "R" }, proposicaos.Count, 0);

            for (int i = 0; i < ListaProp.Count; i++)
            {
                for (int j = 0; j < ListaProp[i].Count; j++)
                {
                    string valor;
                    if (ListaProp[i][j]) { valor = "V"; }
                    else { valor = "F"; }
                    tabelaVerdadeG.Controls.Add(new Label() { Text = valor }, i + proposicaos.Count + 1, j);
                }
            }

            for (int i = 0; i < Resultado.Count; i++)
            {
                string valorR;
                if (Resultado[i]) { valorR = "V"; }
                else { valorR = "F"; }
                tabelaVerdadeG.Controls.Add(new Label() { Text = valorR }, Resultado.Count + 1, i);
            }
        }

        private void TabelaVerdade_Load_1(object sender, EventArgs e)
        {

        }
    }
}
