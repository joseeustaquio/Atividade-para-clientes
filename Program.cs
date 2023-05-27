using System;

namespace ClientLab
{
    class Program
    {
        static void Main(string[] args)
        {
            float valorPago;
            Console.WriteLine("Informe o seu nome.");
            string varNome = Console.ReadLine();
            
             Console.WriteLine("Informe o seu endereço.");
             string varEndereco = Console.ReadLine();
            
            Console.WriteLine("Pessoa física(f) ou PessoaJurídica(j)");
            string varTipo = Console.ReadLine();

            if(varTipo == "f")
            {
                PessoaFisica pFisica = new PessoaFisica();
                pFisica.nome = varNome;
                pFisica.endereco = varEndereco;

               
               Console.WriteLine("Informe o seu Cpf:");
                pFisica.cpf = Console.ReadLine();

                Console.WriteLine("Informe o seu Rg:");
                pFisica.rg = Console.ReadLine();

                Console.WriteLine("Informe o valor da compra:");
                valorPago = float.Parse(Console.ReadLine());
               
                pFisica.pagarImposto(valorPago);
                Console.WriteLine("-----Pessoa Física-----");
                Console.WriteLine("Nome....."+pFisica.nome);
                Console.WriteLine("Endereço....."+pFisica.endereco);
                Console.WriteLine("CPF....."+pFisica.cpf);
                Console.WriteLine("RG....."+pFisica.rg);
                Console.WriteLine("Valor da compra....."+pFisica.valor.ToString("C"));
                Console.WriteLine("Valor do imposto....."+pFisica.valorImposto.ToString("C"));
                Console.WriteLine("Total a pagar....."+pFisica.total.ToString("C"));
                      


            }
        }
    }
}
