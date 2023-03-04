namespace CalculadoraMatNatDiscreta
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnOu = new Button();
            btnE = new Button();
            btnSe = new Button();
            btnSeSomenteSe = new Button();
            EntradaA = new Button();
            EntradaB = new Button();
            EntradaC = new Button();
            EntradaD = new Button();
            EntradaE = new Button();
            EntradaF = new Button();
            VisualizarFormula = new TextBox();
            btnResultado = new Button();
            ValorA = new ComboBox();
            ValorB = new ComboBox();
            ValorC = new ComboBox();
            ValorD = new ComboBox();
            ValorE = new ComboBox();
            ValorF = new ComboBox();
            btnAbrirParenteses = new Button();
            btnFecharParenteses = new Button();
            btlLimpar = new Button();
            btnNegacao = new Button();
            SuspendLayout();
            // 
            // btnOu
            // 
            btnOu.BackColor = Color.DimGray;
            btnOu.Font = new Font("JetBrainsMono Nerd Font", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnOu.ForeColor = Color.White;
            btnOu.Location = new Point(528, 282);
            btnOu.Margin = new Padding(4, 3, 4, 3);
            btnOu.Name = "btnOu";
            btnOu.Size = new Size(72, 60);
            btnOu.TabIndex = 2;
            btnOu.Text = "^";
            btnOu.UseVisualStyleBackColor = false;
            btnOu.Click += btnOu_Click;
            // 
            // btnE
            // 
            btnE.BackColor = Color.DimGray;
            btnE.Font = new Font("JetBrainsMono Nerd Font", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnE.ForeColor = Color.White;
            btnE.Location = new Point(528, 348);
            btnE.Margin = new Padding(4, 3, 4, 3);
            btnE.Name = "btnE";
            btnE.Size = new Size(72, 60);
            btnE.TabIndex = 3;
            btnE.Text = "v";
            btnE.UseVisualStyleBackColor = false;
            btnE.Click += btnE_Click;
            // 
            // btnSe
            // 
            btnSe.BackColor = Color.DimGray;
            btnSe.Font = new Font("JetBrainsMono Nerd Font", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSe.ForeColor = Color.White;
            btnSe.Location = new Point(528, 148);
            btnSe.Margin = new Padding(4, 3, 4, 3);
            btnSe.Name = "btnSe";
            btnSe.Size = new Size(72, 60);
            btnSe.TabIndex = 4;
            btnSe.Text = "→";
            btnSe.UseVisualStyleBackColor = false;
            btnSe.Click += btnSe_Click;
            // 
            // btnSeSomenteSe
            // 
            btnSeSomenteSe.BackColor = Color.DimGray;
            btnSeSomenteSe.Font = new Font("JetBrainsMono Nerd Font", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSeSomenteSe.ForeColor = Color.White;
            btnSeSomenteSe.Location = new Point(528, 215);
            btnSeSomenteSe.Margin = new Padding(4, 3, 4, 3);
            btnSeSomenteSe.Name = "btnSeSomenteSe";
            btnSeSomenteSe.Size = new Size(72, 60);
            btnSeSomenteSe.TabIndex = 5;
            btnSeSomenteSe.Text = "↔";
            btnSeSomenteSe.UseVisualStyleBackColor = false;
            btnSeSomenteSe.Click += btnSeSomenteSe_Click;
            // 
            // EntradaA
            // 
            EntradaA.BackColor = Color.White;
            EntradaA.Font = new Font("JetBrainsMono Nerd Font", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            EntradaA.Location = new Point(16, 148);
            EntradaA.Margin = new Padding(4, 3, 4, 3);
            EntradaA.Name = "EntradaA";
            EntradaA.Size = new Size(72, 60);
            EntradaA.TabIndex = 6;
            EntradaA.Text = "A";
            EntradaA.UseVisualStyleBackColor = false;
            EntradaA.Click += EntradaA_Click;
            // 
            // EntradaB
            // 
            EntradaB.BackColor = Color.White;
            EntradaB.Font = new Font("JetBrainsMono Nerd Font", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            EntradaB.Location = new Point(16, 215);
            EntradaB.Margin = new Padding(4, 3, 4, 3);
            EntradaB.Name = "EntradaB";
            EntradaB.Size = new Size(72, 60);
            EntradaB.TabIndex = 7;
            EntradaB.Text = "B";
            EntradaB.UseVisualStyleBackColor = false;
            EntradaB.Click += EntradaB_Click;
            // 
            // EntradaC
            // 
            EntradaC.BackColor = Color.White;
            EntradaC.Font = new Font("JetBrainsMono Nerd Font", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            EntradaC.Location = new Point(16, 282);
            EntradaC.Margin = new Padding(4, 3, 4, 3);
            EntradaC.Name = "EntradaC";
            EntradaC.Size = new Size(72, 60);
            EntradaC.TabIndex = 8;
            EntradaC.Text = "C";
            EntradaC.UseVisualStyleBackColor = false;
            EntradaC.Click += EntradaC_Click;
            // 
            // EntradaD
            // 
            EntradaD.BackColor = Color.White;
            EntradaD.Font = new Font("JetBrainsMono Nerd Font", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            EntradaD.Location = new Point(16, 348);
            EntradaD.Margin = new Padding(4, 3, 4, 3);
            EntradaD.Name = "EntradaD";
            EntradaD.Size = new Size(72, 60);
            EntradaD.TabIndex = 9;
            EntradaD.Text = "D";
            EntradaD.UseVisualStyleBackColor = false;
            EntradaD.Click += EntradaD_Click;
            // 
            // EntradaE
            // 
            EntradaE.BackColor = Color.White;
            EntradaE.Font = new Font("JetBrainsMono Nerd Font", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            EntradaE.Location = new Point(16, 415);
            EntradaE.Margin = new Padding(4, 3, 4, 3);
            EntradaE.Name = "EntradaE";
            EntradaE.Size = new Size(72, 60);
            EntradaE.TabIndex = 10;
            EntradaE.Text = "E";
            EntradaE.UseVisualStyleBackColor = false;
            EntradaE.Click += EntradaE_Click;
            // 
            // EntradaF
            // 
            EntradaF.BackColor = Color.White;
            EntradaF.Font = new Font("JetBrainsMono Nerd Font", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            EntradaF.Location = new Point(16, 482);
            EntradaF.Margin = new Padding(4, 3, 4, 3);
            EntradaF.Name = "EntradaF";
            EntradaF.Size = new Size(72, 60);
            EntradaF.TabIndex = 11;
            EntradaF.Text = "F";
            EntradaF.UseVisualStyleBackColor = false;
            EntradaF.Click += EntradaF_Click;
            // 
            // VisualizarFormula
            // 
            VisualizarFormula.BackColor = Color.White;
            VisualizarFormula.Font = new Font("JetBrainsMono Nerd Font", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            VisualizarFormula.Location = new Point(16, 37);
            VisualizarFormula.Margin = new Padding(4, 3, 4, 3);
            VisualizarFormula.Multiline = true;
            VisualizarFormula.Name = "VisualizarFormula";
            VisualizarFormula.ReadOnly = true;
            VisualizarFormula.Size = new Size(584, 87);
            VisualizarFormula.TabIndex = 12;
            // 
            // btnResultado
            // 
            btnResultado.BackColor = Color.DimGray;
            btnResultado.Font = new Font("JetBrainsMono Nerd Font", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnResultado.ForeColor = Color.White;
            btnResultado.Location = new Point(528, 415);
            btnResultado.Margin = new Padding(4, 3, 4, 3);
            btnResultado.Name = "btnResultado";
            btnResultado.Size = new Size(72, 126);
            btnResultado.TabIndex = 13;
            btnResultado.Text = "=";
            btnResultado.UseVisualStyleBackColor = false;
            btnResultado.Click += btnResultado_Click;
            // 
            // ValorA
            // 
            ValorA.Font = new Font("JetBrainsMono Nerd Font", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            ValorA.FormattingEnabled = true;
            ValorA.Items.AddRange(new object[] { "true", "false" });
            ValorA.Location = new Point(108, 164);
            ValorA.Margin = new Padding(4, 3, 4, 3);
            ValorA.Name = "ValorA";
            ValorA.Size = new Size(140, 33);
            ValorA.TabIndex = 14;
            // 
            // ValorB
            // 
            ValorB.Font = new Font("JetBrainsMono Nerd Font", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            ValorB.FormattingEnabled = true;
            ValorB.Items.AddRange(new object[] { "true", "false" });
            ValorB.Location = new Point(108, 231);
            ValorB.Margin = new Padding(4, 3, 4, 3);
            ValorB.Name = "ValorB";
            ValorB.Size = new Size(140, 33);
            ValorB.TabIndex = 15;
            // 
            // ValorC
            // 
            ValorC.Font = new Font("JetBrainsMono Nerd Font", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            ValorC.FormattingEnabled = true;
            ValorC.Items.AddRange(new object[] { "true", "false" });
            ValorC.Location = new Point(108, 298);
            ValorC.Margin = new Padding(4, 3, 4, 3);
            ValorC.Name = "ValorC";
            ValorC.Size = new Size(140, 33);
            ValorC.TabIndex = 16;
            // 
            // ValorD
            // 
            ValorD.Font = new Font("JetBrainsMono Nerd Font", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            ValorD.FormattingEnabled = true;
            ValorD.Items.AddRange(new object[] { "true", "false" });
            ValorD.Location = new Point(108, 365);
            ValorD.Margin = new Padding(4, 3, 4, 3);
            ValorD.Name = "ValorD";
            ValorD.Size = new Size(140, 33);
            ValorD.TabIndex = 17;
            // 
            // ValorE
            // 
            ValorE.Font = new Font("JetBrainsMono Nerd Font", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            ValorE.FormattingEnabled = true;
            ValorE.Items.AddRange(new object[] { "true", "false" });
            ValorE.Location = new Point(108, 432);
            ValorE.Margin = new Padding(4, 3, 4, 3);
            ValorE.Name = "ValorE";
            ValorE.Size = new Size(140, 33);
            ValorE.TabIndex = 18;
            // 
            // ValorF
            // 
            ValorF.Font = new Font("JetBrainsMono Nerd Font", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            ValorF.FormattingEnabled = true;
            ValorF.Items.AddRange(new object[] { "true", "false" });
            ValorF.Location = new Point(108, 498);
            ValorF.Margin = new Padding(4, 3, 4, 3);
            ValorF.Name = "ValorF";
            ValorF.Size = new Size(140, 33);
            ValorF.TabIndex = 19;
            // 
            // btnAbrirParenteses
            // 
            btnAbrirParenteses.BackColor = Color.DimGray;
            btnAbrirParenteses.Font = new Font("JetBrainsMono Nerd Font", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAbrirParenteses.ForeColor = Color.White;
            btnAbrirParenteses.Location = new Point(449, 215);
            btnAbrirParenteses.Margin = new Padding(4, 3, 4, 3);
            btnAbrirParenteses.Name = "btnAbrirParenteses";
            btnAbrirParenteses.Size = new Size(72, 60);
            btnAbrirParenteses.TabIndex = 20;
            btnAbrirParenteses.Text = "(";
            btnAbrirParenteses.UseVisualStyleBackColor = false;
            btnAbrirParenteses.Click += btnAbrirParenteses_Click;
            // 
            // btnFecharParenteses
            // 
            btnFecharParenteses.BackColor = Color.DimGray;
            btnFecharParenteses.Font = new Font("JetBrainsMono Nerd Font", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnFecharParenteses.ForeColor = Color.White;
            btnFecharParenteses.Location = new Point(449, 282);
            btnFecharParenteses.Margin = new Padding(4, 3, 4, 3);
            btnFecharParenteses.Name = "btnFecharParenteses";
            btnFecharParenteses.Size = new Size(72, 60);
            btnFecharParenteses.TabIndex = 21;
            btnFecharParenteses.Text = ")";
            btnFecharParenteses.UseVisualStyleBackColor = false;
            btnFecharParenteses.Click += btnFecharParenteses_Click;
            // 
            // btlLimpar
            // 
            btlLimpar.BackColor = Color.DimGray;
            btlLimpar.Font = new Font("JetBrainsMono Nerd Font", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btlLimpar.ForeColor = Color.White;
            btlLimpar.Location = new Point(449, 148);
            btlLimpar.Margin = new Padding(4, 3, 4, 3);
            btlLimpar.Name = "btlLimpar";
            btlLimpar.Size = new Size(72, 60);
            btlLimpar.TabIndex = 22;
            btlLimpar.Text = "CE";
            btlLimpar.UseVisualStyleBackColor = false;
            btlLimpar.Click += btlLimpar_Click;
            // 
            // btnNegacao
            // 
            btnNegacao.BackColor = Color.DimGray;
            btnNegacao.Font = new Font("JetBrainsMono Nerd Font", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnNegacao.ForeColor = Color.White;
            btnNegacao.Location = new Point(449, 348);
            btnNegacao.Margin = new Padding(4, 3, 4, 3);
            btnNegacao.Name = "btnNegacao";
            btnNegacao.Size = new Size(72, 60);
            btnNegacao.TabIndex = 23;
            btnNegacao.Text = "~";
            btnNegacao.UseVisualStyleBackColor = false;
            btnNegacao.Click += btnNegacao_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(615, 555);
            Controls.Add(btnNegacao);
            Controls.Add(btlLimpar);
            Controls.Add(btnFecharParenteses);
            Controls.Add(btnAbrirParenteses);
            Controls.Add(ValorF);
            Controls.Add(ValorE);
            Controls.Add(ValorD);
            Controls.Add(ValorC);
            Controls.Add(ValorB);
            Controls.Add(ValorA);
            Controls.Add(btnResultado);
            Controls.Add(VisualizarFormula);
            Controls.Add(EntradaF);
            Controls.Add(EntradaE);
            Controls.Add(EntradaD);
            Controls.Add(EntradaC);
            Controls.Add(EntradaB);
            Controls.Add(EntradaA);
            Controls.Add(btnSeSomenteSe);
            Controls.Add(btnSe);
            Controls.Add(btnE);
            Controls.Add(btnOu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button btnOu;
        private System.Windows.Forms.Button btnE;
        private System.Windows.Forms.Button btnSe;
        private System.Windows.Forms.Button btnSeSomenteSe;
        private System.Windows.Forms.Button EntradaA;
        private System.Windows.Forms.Button EntradaB;
        private System.Windows.Forms.Button EntradaC;
        private System.Windows.Forms.Button EntradaD;
        private System.Windows.Forms.Button EntradaE;
        private System.Windows.Forms.Button EntradaF;
        private System.Windows.Forms.TextBox VisualizarFormula;
        private System.Windows.Forms.Button btnResultado;
        private System.Windows.Forms.ComboBox ValorA;
        private System.Windows.Forms.ComboBox ValorB;
        private System.Windows.Forms.ComboBox ValorC;
        private System.Windows.Forms.ComboBox ValorD;
        private System.Windows.Forms.ComboBox ValorE;
        private System.Windows.Forms.ComboBox ValorF;
        private System.Windows.Forms.Button btnAbrirParenteses;
        private System.Windows.Forms.Button btnFecharParenteses;
        private System.Windows.Forms.Button btlLimpar;
        private System.Windows.Forms.Button btnNegacao;
    }
}