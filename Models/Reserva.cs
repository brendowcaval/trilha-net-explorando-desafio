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
            //  Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            
            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
                
                throw new ArgumentException("A capacidade é menor que o numero de hospedes!");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            
            int retornoHospedes = Hospedes.Count; 
            return retornoHospedes;
        }

        public decimal CalcularValorDiaria()
        {
        
            decimal valor = DiasReservados * Suite.ValorDiaria;

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%   
            if (DiasReservados >= 10)
            {
                decimal desconto = valor / 100;
                desconto = desconto * 10;


                valor = valor - desconto;
            }

            return valor;
        }
    }
}