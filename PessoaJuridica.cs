namespace ClientLab
{
    class PessoaJuridica : Pessoa
    {
        public string cnpj {get; set;}
        public string inscEstadual {get;set;}

        public virtual void pagarImpostos(float v)
        {
           this.valor = v;
            this.valorImposto = this.valor * 20/100;
            this.total = this.valor + this.valorImposto;
        }
    }
}