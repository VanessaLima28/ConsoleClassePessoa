using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClassePessoa
{
    class Pessoa
    {
        //atributos
        public string nome;
        public int idade;
        //só será int quando precisar de calculos matemáticos
        public string rg;
        public string cpf;

        //adicionando os gets e sets (encapsulamento)
        //os gets e sets atruibuem movimento e comportamento para os atributos

        //funçao dentro da classe
        public void Acenar(Pessoa pessoa)
        {
            // o this pega o nome da pessoa que está acenando
            //método
            //pessoa=pessoaSilva, é uma cópia e o this é a pessoa a ser digitada
            Console.WriteLine("{0} acenou para {1}", this.nome, pessoa.nome);
        }

        public void PerguntaIdade(Pessoa pessoa)
        {
            //pergunta para a pessoa silvia
            Console.WriteLine("{0} quantos anos você tem?", pessoa.nome);
            pessoa.RespostaIdade();
        }

        public void RespostaIdade()
        {
            Console.WriteLine("Eu tenho {0} anos", this.idade);
        }
    }
}
