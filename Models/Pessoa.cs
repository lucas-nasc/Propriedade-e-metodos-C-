using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace metodos_construtores.Models
{
    public class Pessoa
    {
        public Pessoa()
        {
            
        }
        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;

        }


        private string _nome;
        private int _idade;

        
        public string Nome { 
            get => _nome.ToUpper(); // quando o codigo é apenas uma linha poder usar o sinal de =>

             set
             {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }
                _nome=value;
             }
              }
              public string Sobrenome { get; set; }

              public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();// juntando duas propriedades em uma unica get


        public int Idade { 
            get => _idade;

            set{
                if (value <0)
                {
                    throw new ArgumentException("a idade não pode ser menor que 0");
                }
                _idade = value;
            }
            
            }


        public void Apresentar()
        {
            Console.WriteLine($"Olá, {NomeCompleto} sua idade é de {Idade}");
        }
    }
}