using System;

namespace ConsoleClassePessoa
{
    class Program
    {
        static void Main(string[] args)
        {
            //faz a referencia da classe Pessoa, pega todos os atributos da mesma
            //Tipo da classe= Pessoa nome da variavel=pessoa novo objeto=new Pessoa();
            //=new Pessoa-copia todos os atributos da classse Pessoa 
            Pessoa pessoa = new Pessoa();

            Console.WriteLine("Digite o nome");
            //atribuindo valor aos atributos
            pessoa.nome = Console.ReadLine();

            Console.WriteLine("Digite a idade");
            Console.Read();
            pessoa.idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o rg");
            Console.Read();

            Console.WriteLine("Digite o cpf");
            Console.Read();
            pessoa.rg = Console.ReadLine();
            pessoa.cpf = Console.ReadLine();

            //acessando os atributos
            Console.WriteLine("Nome: {0} ", pessoa.nome);
            Console.WriteLine("Idade{0} ", pessoa.idade);
            Console.WriteLine("RG: {0} ", pessoa.rg);
            Console.WriteLine("CPF: {0} ", pessoa.cpf);

            //armezena apenas somente uma pessoa
            Pessoa pessoaSilva = new Pessoa();
            //atribuindo valor aos atributos
            pessoaSilva.nome = "Silvia Mendes";
            pessoaSilva.idade = 52;
            pessoaSilva.rg = "00.000.000-0";
            pessoaSilva.cpf = "000.000.000-00";

            //acessando os atributos
            Console.WriteLine("Nome: {0} ", pessoaSilva.nome);
            Console.WriteLine("Idade{0} ", pessoaSilva.idade);
            Console.WriteLine("RG: {0} ", pessoaSilva.rg);
            Console.WriteLine("CPF: {0} ", pessoaSilva.cpf);

            //pessoa=pessoa que será digitada
            pessoa.Acenar(pessoaSilva);
            pessoa.PerguntaIdade(pessoaSilva);

        }
    }
}
