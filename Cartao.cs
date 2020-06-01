namespace Aula07Encapsulamento
{
    public class Cartao
    {
        public string numero { get; set; }
        public string bandeira { get; set; }
        private string token { get;set; }
        protected int cvc { get;set; }
        

        public string AprovarCompra(){
            return "Compra aprovada";
        }
        private bool ValidarCompra(string tokenValidacao){
            if(tokenValidacao !=null && tokenValidacao !=""){
                return true;
            }
            return false;
        }
        protected bool ValidarCompra(){
            return true;
        }
    }   
}