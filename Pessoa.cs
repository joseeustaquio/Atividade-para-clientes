namespace ClientLab
{
    class Pessoa
    {
          public string nome{get; set;}
          public string endereco { get; set;}
          public float valor { get; set;}
          public float valorImposto{get; set;}
          public float total{get;set;}

          public void pagarImposto(float v)
          {
            this.valor = v;
            this.valorImposto = this.valor * 10/100;
            this.total = this.valor + this.valorImposto;

          }

    }
  
}