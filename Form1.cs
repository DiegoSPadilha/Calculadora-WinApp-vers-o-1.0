namespace Calculadora_WinApp_versão_1._0
{
    public partial class Form1 : Form
    {
        public decimal Resultado { get; set; }

        public decimal Valor { get; set; }
        private Operacao OperacaoSelecionada { get; set; }
        private enum Operacao
        {
            Adicao,
            Subtracao,
            Multiplicacao,
            Divisao
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Multiplicacao;
            Valor = Convert.ToDecimal(TXTresultado.Text);
            TXTresultado.Text = "";
            LBLoperacao.Text = "*";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BTNzero_Click(object sender, EventArgs e)
        {
            TXTresultado.Text += "0";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TXTresultado.Text += "5";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            TXTresultado.Text += "7";
        }

        private void BTNvirgula_Click(object sender, EventArgs e)
        {
            if (TXTresultado.Text.Contains(",")) ;
            TXTresultado.Text += ",";
        }

        private void BTNigual_Click(object sender, EventArgs e)
        {
            switch (OperacaoSelecionada)
            {
                case Operacao.Adicao:
                    Resultado = Valor + Convert.ToDecimal(TXTresultado.Text);
                    break;
                case Operacao.Subtracao:
                    Resultado = Valor - Convert.ToDecimal(TXTresultado.Text);
                    break;
                case Operacao.Divisao:
                    Resultado = Valor / Convert.ToDecimal(TXTresultado.Text);
                    break;
                case Operacao.Multiplicacao:
                    Resultado = Valor * Convert.ToDecimal(TXTresultado.Text);
                    break;
            }
            TXTresultado.Text = Convert.ToString(Resultado);
            LBLoperacao.Text = "=";
        }

        private void BTNsoma_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Adicao;
            Valor = Convert.ToDecimal(TXTresultado.Text);
            TXTresultado.Text = "";
            LBLoperacao.Text = "+";

        }

        private void BTNsubtracao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Subtracao;
            Valor = Convert.ToDecimal(TXTresultado.Text);
            TXTresultado.Text = "";
            LBLoperacao.Text = "-";
        }

        private void BTNdivisao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Divisao;
            Valor = Convert.ToDecimal(TXTresultado.Text);
            TXTresultado.Text = "";
            LBLoperacao.Text = "/";
        }

        private void BTNlimpar_Click(object sender, EventArgs e)
        {
            TXTresultado.Text = "";
            LBLoperacao.Text = "";
        }

        private void BTNnove_Click(object sender, EventArgs e)
        {
            TXTresultado.Text += "9";
        }

        private void BTNoito_Click(object sender, EventArgs e)
        {
            TXTresultado.Text += "8";
        }

        private void BTNquatro_Click(object sender, EventArgs e)
        {
            TXTresultado.Text += "4";
        }

        private void BTNseis_Click(object sender, EventArgs e)
        {
            TXTresultado.Text += "6";
        }

        private void BTNum_Click(object sender, EventArgs e)
        {
            TXTresultado.Text += "1";
        }

        private void BTNdois_Click(object sender, EventArgs e)
        {
            TXTresultado.Text += "2";
        }

        private void BTNtres_Click(object sender, EventArgs e)
        {
            TXTresultado.Text += "3";
        }

        private void TXTresultado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}