namespace Aula7.Campeonato
{

    public class Lutador
    {
        private string name;
        private string nacionalidade;
        private int idade;
        private float altura;
        private float peso;
        private string categoria;
        private int vitorias;
        private int derrotas;
        private int empates;

        public Lutador(string n, string na, int i, float a, float p, int v, int d, int e)
        {
            this.name = n;
            this.nacionalidade = na;
            this.idade = i;
            this.altura = a;
            this.setPeso(p);
            this.vitorias = v;
            this.derrotas = d;
            this.empates = e;
        }

        public string getName()
        {
            return this.name;
        }
        private string getNacionalidade()
        {
            return this.nacionalidade;
        }
        private int getIdade()
        {
            return this.idade;
        }
        private float getAltura()
        {
            return this.altura;
        }
        private float getPeso()
        {
            return this.peso;
        }
        public string getCategoria()
        {
            return this.categoria;
        }
        private int getVitorias()
        {
            return this.vitorias;
        }
        private int getDerrotas()
        {
            return this.derrotas;
        }
        private int getEmpates()
        {
            return this.empates;
        }

        private void setName(string n)
        {
            this.name = n;
        }
        private void setNacionalidade(string na)
        {
            this.nacionalidade = na;
        }
        private void setIdade(int i)
        {
            this.idade = i;
        }
        private void setAltura(float a)
        {
            this.altura = a;
        }
        private void setPeso(float p)
        {
            this.peso = p;
            this.setCategoria();

        }
        private void setCategoria()
        {
            if (this.peso < 52.2)
            {
                this.categoria = "Inválido";
            }
            else if (this.peso <= 70.3)
            {
                this.categoria = "Leve";
            }
            else if (this.peso <= 83.9)
            {
                this.categoria = "Médio";
            }
            else if (this.peso <= 120.2)
            {
                this.categoria = "Pesado";
            }
            else
            {
                this.categoria = "Inválido";
            }
        }
        private void setVitoria(int v)
        {
            this.vitorias = v;
        }
        private void setDerrotas(int d)
        {
            this.derrotas = d;
        }
        private void setEmpates(int e)
        {
            this.empates = e;
        }



        public void apresentar()
        {
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Chegou a hora! Apresentamos o lutador: " + this.getName());
            Console.WriteLine("Diretamente de: " + this.getNacionalidade());
            Console.WriteLine("Com: " + this.getIdade() + "anos");
            Console.WriteLine("Pesando: " + this.getPeso() + "Kg");
            Console.WriteLine(this.getVitorias() + " Vitorias ");
            Console.WriteLine(this.getDerrotas() + " Derrotas ");
            Console.WriteLine(this.getEmpates() + " Empates ");
        }
        public void status()
        {
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine(getName());
            Console.WriteLine("É um peso " + this.getCategoria());
            Console.WriteLine("Ganhou" + this.getVitorias());
            Console.WriteLine("Perdeu" + this.getDerrotas());
            Console.WriteLine("Empatou" + this.getEmpates());
            Console.WriteLine("--------------------------------------------------------");
            
        }
        public void ganharLuta()
        {
            this.setVitoria(this.getVitorias() + 1);
        }
        public void perdeLuta()
        {
            this.setDerrotas(this.getDerrotas() + 1);
        }
        public void empatarLuta()
        {
            this.setEmpates(this.getEmpates() + 1);
        }

    }
}

