namespace FolhaDePagamento
{
    

    class Terceirizados : Funcionarios
    {

        //cirando um contrutor personalizado herdando da classe 'Funcionários'
        public Terceirizados(string nome, int horasTrabalhadas, double valorPorHora) 
        : base(nome, horasTrabalhadas, valorPorHora)
        {
        }

        //método de pagamento usando override(herdando da classe 'Funcionários')
        public override double Pagamento()
        {            
             return (HorasTrabalhadas * ValorPorHora) * 1.10;
        }


       
    }
}
