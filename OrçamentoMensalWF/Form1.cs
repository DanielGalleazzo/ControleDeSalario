namespace OrçamentoMensalWF
{
    public partial class Form1 : Form
    {
        private string SalarioInicial;
        private string GastosFixos;
        private string Alimentacao;
        private string Lazer;
        private string Investe;

        public Form1()
        {
            InitializeComponent();
        }

        private void OrcamentoInicial_TextChanged(object sender, EventArgs e)
        {
            SalarioInicial = OrcamentoInicial.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RespostaSim.Visible = false;
            ValorRespostaSim.Visible = false;
            InvestLabel.Visible = false;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            SalarioMensalLabel.Text = "O seu salário mensal é de R$: " + SalarioInicial;

            int salario, gastos, alimentacao, lazer;

            bool salarioValido = int.TryParse(SalarioInicial, out salario);
            bool gastosValidos = int.TryParse(GastosFixos, out gastos);
            bool alimentacaoValido = int.TryParse(Alimentacao, out alimentacao);
            bool lazerValido = int.TryParse(Lazer, out lazer);

            if (salarioValido && gastosValidos && alimentacaoValido && lazerValido)
            {
                int GastoMensal = salario - gastos;

                GastosFixosLB.Text = "O seu gasto fixo mensal é de R$: " + GastoMensal;
                AlimentacaoLB.Text = "Você gasta aproximadamente com alimentação R$: " + alimentacao;
                LazerLB.Text = "Você gasta aproximadamente com lazer R$: " + lazer;
            }


            if (InvesteText.Text.Equals("Sim", StringComparison.OrdinalIgnoreCase))
            {
                RespostaSim.Visible = true;
                ValorRespostaSim.Visible = true;

                if (int.TryParse(ValorRespostaSim.Text, out int valorInvestimento))
                {
                    InvestLabel.Visible = true;
                    InvestLabel.Text = "O seu investimento mensal é de R$: " + valorInvestimento;
                }
                else
                {
                    InvestLabel.Visible = true;
                    InvestLabel.Text = "Digite um valor numérico válido para investimento.";
                }
            }
            if (InvesteText.Text.Equals("Não", StringComparison.OrdinalIgnoreCase))
            {
                InvestLabel.Visible = true;
                InvestLabel.Text = "Sugestão de investimento R$:" + salario * 0.20;
            }
            else
            {
                RespostaSim.Visible = false;
                ValorRespostaSim.Visible = false;
                InvestLabel.Visible = false;
            }
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DespesasFixas_TextChanged(object sender, EventArgs e)
        {
            GastosFixos = DespesasFixas.Text;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AlimentacaoText_TextChanged(object sender, EventArgs e)
        {
            Alimentacao = AlimentacaoText.Text;
        }

        private void LazerText_TextChanged(object sender, EventArgs e)
        {
            Lazer = LazerText.Text;
        }

        private void InvesteText_TextChanged(object sender, EventArgs e)
        {
            string resposta = InvesteText.Text;

            if (resposta.Equals("Sim", StringComparison.OrdinalIgnoreCase))
            {
                RespostaSim.Visible = true;
                ValorRespostaSim.Visible = true;
            }
            else
            {
                RespostaSim.Visible = false;
                ValorRespostaSim.Visible = false;
                InvestLabel.Text = "";
            }
        }


        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void LazerLB_Click(object sender, EventArgs e)
        {

        }

        private void RespostaSim_Click(object sender, EventArgs e)
        {

        }

        private void ValorRespostaSim_TextChanged(object sender, EventArgs e)
        {
            string valorDigitado = ValorRespostaSim.Text;

            if (int.TryParse(valorDigitado, out int valorInvestimento))
            {
                InvestLabel.Text = "O seu investimento mensal é de R$: " + valorInvestimento.ToString();
            }
            else
            {
                InvestLabel.Text = "Digite um valor numérico válido para investimento.";
            }
        }

        private void BotaoExportar_Click(object sender, EventArgs e)
        {

            string conteudo = "Relatório Financeiro";
            conteudo += "Salário Inicial R$: " + SalarioInicial;
            conteudo += " Gastos Fixos R$: " + GastosFixos;
            conteudo += " Alimentação R$: "+ Alimentacao;
            conteudo += " Lazer R$: " + Lazer;

            if (InvesteText.Text.Equals("Sim", StringComparison.OrdinalIgnoreCase))
            {
                conteudo += " Investimento Mensal R$:" + ValorRespostaSim.Text;
            }
            else if (InvesteText.Text.Equals("Não", StringComparison.OrdinalIgnoreCase))
            {
                if (int.TryParse(SalarioInicial, out int salario))
                {
                    conteudo += " Sugestão de Investimento  R$: "+ salario * 0.20;
                }
            }

            SaveFileDialog salvarDialogo = new SaveFileDialog();
            salvarDialogo.Filter = "Arquivo de Texto (*.txt)|*.txt";
            salvarDialogo.Title = "Salvar Relatório Financeiro";
            salvarDialogo.FileName = "relatorio_financeiro.txt";

            if (salvarDialogo.ShowDialog() == DialogResult.OK)
            {
                    File.WriteAllText(salvarDialogo.FileName, conteudo);
                    MessageBox.Show("Relatório exportado com sucesso!", "Exportação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
