namespace OrçamentoMensalWF
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            OrcamentoInicial = new TextBox();
            DespesasFixas = new TextBox();
            BotaoAvancar = new Button();
            TextoMensalmente = new Label();
            label2 = new Label();
            label3 = new Label();
            AlimentacaoText = new TextBox();
            label4 = new Label();
            LazerText = new TextBox();
            label5 = new Label();
            label6 = new Label();
            InvesteText = new TextBox();
            label1 = new Label();
            SalarioMensalLabel = new Label();
            GastosFixosLB = new Label();
            AlimentacaoLB = new Label();
            LazerLB = new Label();
            InvestLabel = new Label();
            RespostaSim = new Label();
            ValorRespostaSim = new TextBox();
            BotaoExportar = new Button();
            SuspendLayout();
            // 
            // OrcamentoInicial
            // 
            OrcamentoInicial.Location = new Point(34, 59);
            OrcamentoInicial.Name = "OrcamentoInicial";
            OrcamentoInicial.Size = new Size(196, 23);
            OrcamentoInicial.TabIndex = 0;
            OrcamentoInicial.TextChanged += OrcamentoInicial_TextChanged;
            // 
            // DespesasFixas
            // 
            DespesasFixas.Location = new Point(34, 103);
            DespesasFixas.Name = "DespesasFixas";
            DespesasFixas.Size = new Size(196, 23);
            DespesasFixas.TabIndex = 1;
            DespesasFixas.TextChanged += DespesasFixas_TextChanged;
            // 
            // BotaoAvancar
            // 
            BotaoAvancar.Location = new Point(34, 342);
            BotaoAvancar.Name = "BotaoAvancar";
            BotaoAvancar.Size = new Size(196, 62);
            BotaoAvancar.TabIndex = 3;
            BotaoAvancar.Text = "Avançar";
            BotaoAvancar.UseVisualStyleBackColor = true;
            BotaoAvancar.Click += button1_Click;
            // 
            // TextoMensalmente
            // 
            TextoMensalmente.AutoSize = true;
            TextoMensalmente.Location = new Point(34, 41);
            TextoMensalmente.Name = "TextoMensalmente";
            TextoMensalmente.Size = new Size(196, 15);
            TextoMensalmente.TabIndex = 4;
            TextoMensalmente.Text = "Quanto você recebe mensalmente ?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 85);
            label2.Name = "label2";
            label2.Size = new Size(212, 15);
            label2.TabIndex = 5;
            label2.Text = "Qual é o valor das suas despesas fixas ?";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 129);
            label3.Name = "label3";
            label3.Size = new Size(302, 15);
            label3.TabIndex = 6;
            label3.Text = "Quanto você gasta aproximadamente em alimentação ?";
            // 
            // AlimentacaoText
            // 
            AlimentacaoText.Location = new Point(34, 147);
            AlimentacaoText.Name = "AlimentacaoText";
            AlimentacaoText.Size = new Size(196, 23);
            AlimentacaoText.TabIndex = 7;
            AlimentacaoText.TextChanged += AlimentacaoText_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 173);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 8;
            label4.Text = "E em lazer ?";
            // 
            // LazerText
            // 
            LazerText.Location = new Point(34, 191);
            LazerText.Name = "LazerText";
            LazerText.Size = new Size(196, 23);
            LazerText.TabIndex = 9;
            LazerText.TextChanged += LazerText_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 217);
            label5.Name = "label5";
            label5.Size = new Size(385, 15);
            label5.TabIndex = 10;
            label5.Text = "Você investe o seu dinheiro em alguma coisa  ? (Renda fixa, fundos, etc)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(34, 232);
            label6.Name = "label6";
            label6.Size = new Size(77, 15);
            label6.TabIndex = 11;
            label6.Text = "(Sim ou Não)";
            // 
            // InvesteText
            // 
            InvesteText.Location = new Point(34, 250);
            InvesteText.Name = "InvesteText";
            InvesteText.Size = new Size(196, 23);
            InvesteText.TabIndex = 12;
            InvesteText.TextChanged += InvesteText_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(502, 41);
            label1.Name = "label1";
            label1.Size = new Size(136, 15);
            label1.TabIndex = 13;
            label1.Text = "Dados e recomendações";
            label1.Click += label1_Click;
            // 
            // SalarioMensalLabel
            // 
            SalarioMensalLabel.AutoSize = true;
            SalarioMensalLabel.Location = new Point(502, 62);
            SalarioMensalLabel.Name = "SalarioMensalLabel";
            SalarioMensalLabel.Size = new Size(0, 15);
            SalarioMensalLabel.TabIndex = 14;
            // 
            // GastosFixosLB
            // 
            GastosFixosLB.AutoSize = true;
            GastosFixosLB.Location = new Point(502, 85);
            GastosFixosLB.Name = "GastosFixosLB";
            GastosFixosLB.Size = new Size(0, 15);
            GastosFixosLB.TabIndex = 15;
            // 
            // AlimentacaoLB
            // 
            AlimentacaoLB.AutoSize = true;
            AlimentacaoLB.Location = new Point(502, 106);
            AlimentacaoLB.Name = "AlimentacaoLB";
            AlimentacaoLB.Size = new Size(0, 15);
            AlimentacaoLB.TabIndex = 16;
            AlimentacaoLB.Click += label9_Click;
            // 
            // LazerLB
            // 
            LazerLB.AutoSize = true;
            LazerLB.Location = new Point(502, 129);
            LazerLB.Name = "LazerLB";
            LazerLB.Size = new Size(0, 15);
            LazerLB.TabIndex = 17;
            LazerLB.Click += LazerLB_Click;
            // 
            // InvestLabel
            // 
            InvestLabel.AutoSize = true;
            InvestLabel.Location = new Point(502, 150);
            InvestLabel.Name = "InvestLabel";
            InvestLabel.Size = new Size(0, 15);
            InvestLabel.TabIndex = 18;
            // 
            // RespostaSim
            // 
            RespostaSim.AutoSize = true;
            RespostaSim.Location = new Point(34, 276);
            RespostaSim.Name = "RespostaSim";
            RespostaSim.Size = new Size(55, 15);
            RespostaSim.TabIndex = 19;
            RespostaSim.Text = "Quanto ?";
            RespostaSim.Click += RespostaSim_Click;
            // 
            // ValorRespostaSim
            // 
            ValorRespostaSim.Location = new Point(34, 294);
            ValorRespostaSim.Name = "ValorRespostaSim";
            ValorRespostaSim.Size = new Size(196, 23);
            ValorRespostaSim.TabIndex = 20;
            ValorRespostaSim.TextChanged += ValorRespostaSim_TextChanged;
            // 
            // BotaoExportar
            // 
            BotaoExportar.Location = new Point(502, 342);
            BotaoExportar.Name = "BotaoExportar";
            BotaoExportar.Size = new Size(196, 62);
            BotaoExportar.TabIndex = 21;
            BotaoExportar.Text = "Exportar para txt";
            BotaoExportar.UseVisualStyleBackColor = true;
            BotaoExportar.Click += BotaoExportar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(800, 450);
            Controls.Add(BotaoExportar);
            Controls.Add(ValorRespostaSim);
            Controls.Add(RespostaSim);
            Controls.Add(InvestLabel);
            Controls.Add(LazerLB);
            Controls.Add(AlimentacaoLB);
            Controls.Add(GastosFixosLB);
            Controls.Add(SalarioMensalLabel);
            Controls.Add(label1);
            Controls.Add(InvesteText);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(LazerText);
            Controls.Add(label4);
            Controls.Add(AlimentacaoText);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(TextoMensalmente);
            Controls.Add(BotaoAvancar);
            Controls.Add(DespesasFixas);
            Controls.Add(OrcamentoInicial);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox OrcamentoInicial;
        private TextBox DespesasFixas;
        
        private Button BotaoAvancar;
        private Label TextoMensalmente;
        private Label label2;
        private Label label3;
        private TextBox AlimentacaoText;
        private Label label4;
        private TextBox LazerText;
        private Label label5;
        private Label label6;
        private TextBox InvesteText;
        private Label label1;
        private Label SalarioMensalLabel;
        private Label GastosFixosLB;
        private Label AlimentacaoLB;
        private Label LazerLB;
        private Label InvestLabel;
        private Label RespostaSim;
        private TextBox ValorRespostaSim;
        private Button BotaoExportar;
    }
}
