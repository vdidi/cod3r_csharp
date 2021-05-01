
using System;
using System.Collections.Generic;

using CursoCSharp.OO;
using CursoCSharp.MetodosEFuncoes;


namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                // OO
                { "Herança - OO", Heranca.Executar},
                // Métodos e funções
                { "Exemplo Lambda - Métodos e funções", ExemploLambda.Executar},
                { "Lambdas com Delegates - Métodos e funções", LambdaDelegate.Executar}
            });

            central.SelecionarEExecutar();
        }
    }
}