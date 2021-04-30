using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO {
    class Heranca {

        public class Carro {
            protected readonly int VelocidadeMaxima;
            int VelocidadeAtual;

            public Carro(int velocidadeMaxima) {
                VelocidadeMaxima = velocidadeMaxima;
            }

            protected int AlterarVelocidade(int delta) {
                int novaVelocidade = VelocidadeAtual + delta;

                if(novaVelocidade < 0) {
                    VelocidadeAtual = 0;
                } else if (novaVelocidade > VelocidadeMaxima) {
                    VelocidadeAtual = VelocidadeMaxima;
                } else {
                    VelocidadeAtual = novaVelocidade;
                }

                return VelocidadeAtual;
            }

            public int Acelerar() {
                return AlterarVelocidade(5);
            }

            public int Frear() {
                return AlterarVelocidade(-5);
            }
        }

        public class Uno : Carro {
            public Uno() : base(200) {

            }
        }

        public static void Executar() {
            Console.WriteLine("Uno...");
            Uno c1 = new Uno();
            Console.WriteLine(c1.Acelerar());
            Console.WriteLine(c1.Acelerar());
            Console.WriteLine(c1.Frear());
            Console.WriteLine(c1.Frear());
        }
    }
}
