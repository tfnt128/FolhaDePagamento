namespace FolhaDePagamento
{
    

    class Terceirizados : Funcionarios
    {
       //criando a propriedade adicional para os funcionários terceirizados
        public double Adicional { get; private set; }

        //cirando um contrutor personalizado herdando da classe 'Funcionários'
        public Terceirizados(string nome, int horasTrabalhadas, double valorPorHora, double adicional) 
        : base(nome, horasTrabalhadas, valorPorHora)
        {
            Adicional = adicional;
        }

        //método de pagamento usando override(herdando da classe 'Funcionários')
        public override double Pagamento()
        {            
             return ((HorasTrabalhadas * ValorPorHora) + Adicional) + (Adicional * 0.10);
        }


       
    }
}
