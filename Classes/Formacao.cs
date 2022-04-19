namespace exerciciobacharelado
{
    public class Formacao
    {
        private string Descricao {get; set;}
        private int Periodo {get; set;}
        private double Mensalidade {get; set;}
        private int Duracao {get; set;} 

        public Formacao(string descricao, int periodo){
            Descricao = descricao;
            Periodo = periodo;
        }
        public string GetDescricao(){
            return Descricao;
        }
        public void SetDescriacao(string descricao){

        }
    }
}