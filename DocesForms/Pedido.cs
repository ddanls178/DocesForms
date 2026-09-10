namespace DocesForms
{
    class Pedido
    {
        //Propriedades (atributos)

        public string? NomeDoce {  get; set; }
        public double PrecoUnitario { get; set; }
        public int Quantidade { get; set; }
        public int IdadeCliente {  get; set; }

        //Métodos (ações)

        public double CalcularDesconto() //calcular desconto
        {
            double valorTotal = PrecoUnitario * Quantidade;
            
            if(Quantidade >= 10)
            {
                return valorTotal * 0.10; //10%
            }
            return 0.0;
        }


        //método para calcular o valor final com o desconto aplicado
        public double CalcularValorFinal()
        {
            double valorTotalBruto = PrecoUnitario * Quantidade;
            double desconto = CalcularDesconto();
            return valorTotalBruto - desconto;
        }

        //método para calcular o parcelamento em 3x sem juros (se o valor for válido)
        public double CalcularParcela()
        {
            return CalcularValorFinal() / 3.0;
        }

        //método para validar se o cliente tem direito a um brinde especial (ex:maiores de 18 anos
        //ou compra grande)
        
        public bool ValidarBrinde()
        {
            return (IdadeCliente >= 18 && Quantidade >= 5) || CalcularValorFinal() > 100.00;
        }
    }
}
