namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            // *IMPLEMENTE AQUI*

            int qtdHospedes = hospedes.Count;
            int capacidadeSuite = Suite.Capacidade;

            if (qtdHospedes<= capacidadeSuite)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception("A capacidade da suíte é menor que o número de hóspedes recebido");
                // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
                // *IMPLEMENTE AQUI*
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
            // *IMPLEMENTE AQUI*
            int qtdHospedes = Hospedes.Count;
            return qtdHospedes;
        }

        public decimal CalcularValorDiaria()
        {
            // TODO: Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria
            // *IMPLEMENTE AQUI*
            decimal valor = 0;

            if (DiasReservados >= 10)
            {
                valor = DiasReservados * Suite.ValorDiaria * (decimal)0.9;
                return valor;
            }

            valor = DiasReservados * Suite.ValorDiaria;
            return valor;
            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            // *IMPLEMENTE AQUI*
            
        }
    }
}