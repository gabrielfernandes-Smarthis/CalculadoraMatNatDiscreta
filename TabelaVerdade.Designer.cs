namespace CalculadoraMatNatDiscreta
{
    partial class TabelaVerdade
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TabelaVerdade));
            tabelaVerdadeG = new TableLayoutPanel();
            SuspendLayout();
            // 
            // tabelaVerdadeG
            // 
            tabelaVerdadeG.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tabelaVerdadeG.ColumnCount = 1;
            tabelaVerdadeG.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tabelaVerdadeG.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 23F));
            tabelaVerdadeG.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 23F));
            tabelaVerdadeG.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 23F));
            tabelaVerdadeG.Font = new Font("JetBrainsMono Nerd Font", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            tabelaVerdadeG.Location = new Point(14, 14);
            tabelaVerdadeG.Margin = new Padding(4, 3, 4, 3);
            tabelaVerdadeG.Name = "tabelaVerdadeG";
            tabelaVerdadeG.RowCount = 1;
            tabelaVerdadeG.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tabelaVerdadeG.Size = new Size(136, 223);
            tabelaVerdadeG.TabIndex = 0;
            // 
            // TabelaVerdade
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            ClientSize = new Size(806, 516);
            Controls.Add(tabelaVerdadeG);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "TabelaVerdade";
            Text = "TabelaVerdade";
            Load += TabelaVerdade_Load_1;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tabelaVerdadeG;
    }
}