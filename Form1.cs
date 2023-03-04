namespace CalculadoraMatNatDiscreta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            removerBordas();
        }

        string FormulaVisualisa;
        List<string> Formula = new List<string>();

        private void EntradaA_Click(object sender, EventArgs e)
        {
            ValorA.Enabled = false;
            FormulaVisualisa = FormulaVisualisa + "A";
            Formula.Add("A");
            VisualizarFormula.Clear();
            VisualizarFormula.Text = VisualizarFormula.Text + FormulaVisualisa;
        }

        private void EntradaB_Click(object sender, EventArgs e)
        {
            ValorB.Enabled = false;
            FormulaVisualisa = FormulaVisualisa + "B";
            Formula.Add("B");
            VisualizarFormula.Clear();
            VisualizarFormula.Text = VisualizarFormula.Text + FormulaVisualisa;
        }

        private void EntradaC_Click(object sender, EventArgs e)
        {
            ValorC.Enabled = false;
            FormulaVisualisa = FormulaVisualisa + "C";
            Formula.Add("C");
            VisualizarFormula.Clear();
            VisualizarFormula.Text = VisualizarFormula.Text + FormulaVisualisa;
        }

        private void EntradaD_Click(object sender, EventArgs e)
        {
            ValorD.Enabled = false;
            FormulaVisualisa = FormulaVisualisa + "D";
            Formula.Add("D");
            VisualizarFormula.Clear();
            VisualizarFormula.Text = VisualizarFormula.Text + FormulaVisualisa;
        }

        private void EntradaE_Click(object sender, EventArgs e)
        {
            ValorE.Enabled = false;
            FormulaVisualisa = FormulaVisualisa + "E";
            Formula.Add("D");
            VisualizarFormula.Clear();
            VisualizarFormula.Text = VisualizarFormula.Text + FormulaVisualisa;
        }

        private void EntradaF_Click(object sender, EventArgs e)
        {
            ValorF.Enabled = false;
            FormulaVisualisa = FormulaVisualisa + "F";
            Formula.Add("F");
            VisualizarFormula.Clear();
            VisualizarFormula.Text = VisualizarFormula.Text + FormulaVisualisa;
        }

        private void btnSe_Click(object sender, EventArgs e)
        {
            FormulaVisualisa = FormulaVisualisa + "→";
            Formula.Add("→");
            VisualizarFormula.Clear();
            VisualizarFormula.Text = VisualizarFormula.Text + FormulaVisualisa;
        }

        private void btnSeSomenteSe_Click(object sender, EventArgs e)
        {
            FormulaVisualisa = FormulaVisualisa + "↔";
            Formula.Add("↔");
            VisualizarFormula.Clear();
            VisualizarFormula.Text = VisualizarFormula.Text + FormulaVisualisa;
        }

        private void btnOu_Click(object sender, EventArgs e)
        {
            FormulaVisualisa = FormulaVisualisa + "^";
            Formula.Add("^");
            VisualizarFormula.Clear();
            VisualizarFormula.Text = VisualizarFormula.Text + FormulaVisualisa;
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            FormulaVisualisa = FormulaVisualisa + "v";
            Formula.Add("∨");
            VisualizarFormula.Clear();
            VisualizarFormula.Text = VisualizarFormula.Text + FormulaVisualisa;
        }

        private void btnNegacao_Click(object sender, EventArgs e)
        {
            FormulaVisualisa = FormulaVisualisa + "~";
            Formula.Add("~");
            VisualizarFormula.Clear();
            VisualizarFormula.Text = VisualizarFormula.Text + FormulaVisualisa;
        }

        private void btnAbrirParenteses_Click(object sender, EventArgs e)
        {
            FormulaVisualisa = FormulaVisualisa + "(";
            Formula.Add("(");
            VisualizarFormula.Clear();
            VisualizarFormula.Text = VisualizarFormula.Text + FormulaVisualisa;
        }

        private void btnFecharParenteses_Click(object sender, EventArgs e)
        {
            FormulaVisualisa = FormulaVisualisa + ")";
            Formula.Add(")");
            VisualizarFormula.Clear();
            VisualizarFormula.Text = VisualizarFormula.Text + FormulaVisualisa;
        }

        private void btlLimpar_Click(object sender, EventArgs e)
        {
            VisualizarFormula.Clear();
            Formula.Clear();
            FormulaVisualisa = "";
            ValorA.Enabled = true;
            ValorA.SelectedIndex = -1;

            ValorB.Enabled = true;
            ValorB.SelectedIndex = -1;

            ValorC.Enabled = true;
            ValorC.SelectedIndex = -1;

            ValorD.Enabled = true;
            ValorD.SelectedIndex = -1;

            ValorE.Enabled = true;
            ValorE.SelectedIndex = -1;

            ValorF.Enabled = true;
            ValorF.SelectedIndex = -1;
        }

        private List<bool> transformarBool(List<string> valores)
        {
            List<bool> valoresPreposicoesBool = new List<bool>();
            foreach (var i in valores)
            {
                if (i != "")
                {
                    valoresPreposicoesBool.Add(bool.Parse(i));
                }
            }
            return valoresPreposicoesBool;
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            List<string> valoresPreposicoes = new List<string>
            {
                ValorA.Text,
                ValorB.Text,
                ValorC.Text,
                ValorD.Text,
                ValorE.Text,
                ValorF.Text,
            };
            List<bool> valoresBool = transformarBool(valoresPreposicoes);
            Calculadora calculadora = new Calculadora(Formula, valoresBool);
        }

        public void Resultado(string mensagem)
        {
            MessageBox.Show(mensagem);
        }

        private void removerBordas()
        {
            btnAbrirParenteses.FlatStyle = FlatStyle.Flat;
            btnAbrirParenteses.FlatAppearance.BorderSize = 0;
            btnE.FlatStyle = FlatStyle.Flat;
            btnE.FlatAppearance.BorderSize = 0;
            btnFecharParenteses.FlatStyle = FlatStyle.Flat;
            btnFecharParenteses.FlatAppearance.BorderSize = 0;
            btnNegacao.FlatStyle = FlatStyle.Flat;
            btnNegacao.FlatAppearance.BorderSize = 0;
            btnOu.FlatStyle = FlatStyle.Flat;
            btnOu.FlatAppearance.BorderSize = 0;
            btnResultado.FlatStyle = FlatStyle.Flat;
            btnResultado.FlatAppearance.BorderSize = 0;
            btnSe.FlatStyle = FlatStyle.Flat;
            btnSe.FlatAppearance.BorderSize = 0;
            btnSeSomenteSe.FlatStyle = FlatStyle.Flat;
            btnSeSomenteSe.FlatAppearance.BorderSize = 0;
            btlLimpar.FlatStyle = FlatStyle.Flat;
            btlLimpar.FlatAppearance.BorderSize = 0;

            EntradaA.FlatStyle = FlatStyle.Flat;
            EntradaA.FlatAppearance.BorderSize = 0;
            EntradaB.FlatStyle = FlatStyle.Flat;
            EntradaB.FlatAppearance.BorderSize = 0;
            EntradaC.FlatStyle = FlatStyle.Flat;
            EntradaC.FlatAppearance.BorderSize = 0;
            EntradaD.FlatStyle = FlatStyle.Flat;
            EntradaD.FlatAppearance.BorderSize = 0;
            EntradaE.FlatStyle = FlatStyle.Flat;
            EntradaE.FlatAppearance.BorderSize = 0;
            EntradaF.FlatStyle = FlatStyle.Flat;
            EntradaF.FlatAppearance.BorderSize = 0;
        }
    }
}