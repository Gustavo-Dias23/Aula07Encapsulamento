using System;

namespace Aula07Encapsulamento
{
    public class MasterCard : Cartao
    {
        public int parcelas { get; set; }         
        public void ComprarComDescontoMaster(float desconto){
            cvc = 456;
            Console.WriteLine($"Aplicado desconto de {desconto}%, no total de {parcelas} parcelas.");
        }
    }
}