namespace exerciciobacharelado
{
    public class Formacao
    {
        protected string Descricao {get; set;}
        protected int Periodo {get; set;}
        protected double Mensalidade {get; set;}
        protected int Duracao {get; set;} 

        public Formacao(string descricao, int periodo){
            Descricao = descricao;
            Periodo = periodo;
        }
        public string GetDescricao(){
            return Descricao;
        }
        public void SetDescriacao(string descricao){
            Descricao = descricao;
        }

        public int GetPeriodo(){
            return Periodo;
        }
        public void SetPeriodo(int periodo){
            Periodo = Periodo;
        }
        public double GetMensalidade(){
            return Mensalidade;
        }
        public void SetMensalidade(double mensalidade){
            Mensalidade = mensalidade;
        }
        public int GetDuracao(){
            return Duracao;
        }
        public void SetDuracacao(int duracao){
            Duracao = duracao;
        }

        
    }
}