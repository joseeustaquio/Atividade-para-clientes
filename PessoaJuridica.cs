namespace ClientLab
{
    class PessoaJuridica : Pessoa
    {
        public string cnpj {get; set;}
        public string inscEstadual {get;set;}

        public virtual  void pagarImpostos(float v)
        {
            
        }
    }
}