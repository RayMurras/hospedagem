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
          
            if (hospedes.Count >= Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new ArgumentException("Capacidade da suíte ultrapassada");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            int TotalHospedes = Hospedes.Count();
            return TotalHospedes ;
        }

        public decimal CalcularValorDiaria()
        {
         
            Suite.ValorDiaria = 50M;
            DiasReservados = 10;
            decimal valor = DiasReservados * Suite.ValorDiaria;

           
            if (DiasReservados >= 10)
            {
                valor = valor - (valor/10);
            }

            return valor;
        }
    }
}