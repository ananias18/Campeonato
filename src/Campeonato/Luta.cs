
namespace Aula7.Campeonato
{

    public class Luta
    {


        private Lutador desafiado;
        private Lutador desafiante;
        private int rounds;
        private bool aprovada;

        public void marcaLuta(Lutador l1, Lutador l2)
        {
            if ((l1.getCategoria().Equals(l2.getCategoria())) &&
            (l1 != l2))
            {
                this.aprovada = true;
                this.desafiado = l1;
                this.desafiante = l2;

            }
            else
            {
                this.aprovada = false;
                this.desafiado = null;
                this.desafiante = null;
            }
        }
        public void lutar()
        {
            if (this.aprovada)
            {
                Console.WriteLine("### Desafiado ###");
                this.desafiado.apresentar();

                Console.WriteLine("### Desafiante ###");
                this.desafiante.apresentar();

                Random aleatorio = new Random();
                int vencedor = aleatorio.Next(3);

                switch (vencedor)
                {
                    case 0:
                        Console.WriteLine("Empatou!");
                        this.desafiado.empatarLuta();
                        this.desafiante.empatarLuta();

                        break;
                    case 1:
                        Console.WriteLine("Vitoria do: " + this.desafiado.getName());
                        this.desafiado.ganharLuta();
                        this.desafiante.perdeLuta();

                        break;
                    case 2:
                        Console.WriteLine("Vitoria do: " + this.desafiante.getName());
                        this.desafiante.ganharLuta();
                        this.desafiado.perdeLuta();

                        break;
                }
            }
            else
            {
                Console.WriteLine("Luta não pode acontecer");
            }
        }
        public void setDesafiado(Lutador desafiado)
        {
            this.desafiado = desafiado;
        }
        public void setDesafiante(Lutador desafiante)
        {
            this.desafiante = desafiante;
        }
        public void setRounds(int rounds)
        {
            this.rounds = rounds;
        }
        public void setAprovada(bool aprovada)
        {
            this.aprovada = aprovada;
        }
        public Lutador getdesafiante()
        {
            return this.desafiante;
        }
        public Lutador getDesafiado()
        {
            return this.desafiado;
        }
        public int getRounds()
        {
            return this.rounds;
        }
        public bool getAprovada()
        {
            return this.aprovada;
        }

    }
}





