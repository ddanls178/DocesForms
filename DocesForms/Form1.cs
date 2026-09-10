namespace DocesForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                //instância(Criação de objeto na memória)
                Pedido pedido = new Pedido();

                //propriedade(atribuição de dados)
                //aqui pegamos os textos das caixas(TextBox) e convertemos
                pedido.NomeDoce = txtNomeDoce.Text;
                pedido.PrecoUnitario = Convert.ToDouble(txtPrecoUnitario.Text);
                pedido.Quantidade = int.Parse(txtQuantidade.Text);
                pedido.IdadeCliente = int.Parse(txtIdadeCliente.Text);

                //utilização do objeto
                //chamamos os métodos da classe e exibimos nas Labels
                double desconto = pedido.CalcularDesconto();
                double valorFinal = pedido.CalcularValorFinal();
                double parcela = pedido.CalcularParcela();
                bool brindeAprovado = pedido.ValidarBrinde();

                //exibindo os dados formatados na tela
                lblNome.Text = $"{pedido.NomeDoce.ToUpper()}";
                lblDesconto.Text = $"Desconto: R$ {desconto:N2}";
                lblValorFinal.Text = $"Valor Final: R$ {valorFinal:N2}";
                lblParcela.Text = $"Parcela: 3x de R$ {parcela:N2}";

                if (brindeAprovado)
                {
                    lblStatus.Text = "PARABÉNS!\n Você ganhou um \nbrinde surpresa!";
                    lblStatus.ForeColor = Color.Green;
                }
                else
                {
                    lblStatus.Text = "Compra padrão \nrealizada com sucesso!";
                    lblStatus.ForeColor = Color.Blue;
                }
            }
            catch (FormatException)
            {
                //tratamento de erros simples caso o usuário digite texto onde deve ser número
                MessageBox.Show("Preencha os campos numéricos corretamente!",
                    "Erro de Digitação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }


        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //Limpando campos
            txtNomeDoce.Clear();
            txtPrecoUnitario.Clear();
            txtQuantidade.Clear();
            txtIdadeCliente.Clear();
            //retornando nome dos elementos
            lblNome.Text = "Nome:";
            lblDesconto.Text = "Desconto:";
            lblValorFinal.Text = "Valor Final";
            lblParcela.Text = "Parcela:";
            lblStatus.Text = "Status";
            //retornando cor original do status
            lblStatus.ForeColor= Color.Gold;
        }

        private void txtPrecoUnitario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
