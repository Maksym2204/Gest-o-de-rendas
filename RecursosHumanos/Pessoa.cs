namespace RecursosHumanos
{
    public class Pessoa
    {
        private string nome;
        private string nif;
        private string telefone;
        private string email;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string NIF
        {
            get { return nif; }
            set { nif = value; }
        }
        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }   
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public Pessoa(string nome, string nif, string telefone, string email)
        {
            this.nome = nome;
            this.nif = nif;
            this.telefone = telefone;
            this.email = email;
        }
    }
}
