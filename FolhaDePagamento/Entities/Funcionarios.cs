using System.Globalization;

namespace FolhaDePagamento
{
      class Funcionarios
    {
        //criando as propriedades
        public string Nome { get; private set; }
        public int HorasTrabalhadas { get; private set; }
        public double ValorPorHora { get; private set; }

        //criando construtor vazio
        public Funcionarios()
        {
        }

        //criando construtor personalizado
        public Funcionarios(string nome, int horasTrabalhadas, double valorPorHora)
        {
            Nome = nome;
            HorasTrabalhadas = horasTrabalhadas;
            ValorPorHora = valorPorHora;
        }

        
        //criando método de pagamento virtual(para usar em outra classe que herde desta)
        virtual public double Pagamento()
        {
            return HorasTrabalhadas * ValorPorHora;
        }

        //conversão para string
        public override string ToString()
        {
            return "Nome:" + Nome + ", Pagamento:" + Pagamento().ToString("F2", CultureInfo.InvariantCulture) ;
        }
    }
}
