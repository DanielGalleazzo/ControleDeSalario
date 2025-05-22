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

        }



        private void button1_Click(object sender, EventArgs e)
        {

            SalarioMensalLabel.Text = "O seu salário mensal é de R$: " + SalarioInicial;

            int salario, gastos, alimentacao, lazer, investe;
            bool salarioValido = int.TryParse(SalarioInicial, out salario);
            bool gastosValidos = int.TryParse(GastosFixos, out gastos);
            bool alimentacaoValido = int.TryParse(Alimentacao, out alimentacao);
            bool lazerValido = int.TryParse(Lazer, out lazer);


            if (salarioValido && gastosValidos)
            {
                int GastoMensal = salario - gastos;
                int GastoAli = salario - alimentacao;
                int GastoLazer = salario - lazer;
                GastosFixosLB.Text = "O seu gasto fixo mensal é de R$: " + GastoMensal.ToString();
                AlimentacaoLB.Text = "Você gasta mensalmente com alimentação R$:" + GastoAli.ToString();
                LazerLB.Text = "Você gasta mensalmente com lazer R$: " + GastoLazer.ToString();

            }
            else
            {
                GastosFixosLB.Text = "Só é aceito números";
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
            Investe = InvesteText.Text;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void LazerLB_Click(object sender, EventArgs e)
        {

        }
    }
}
