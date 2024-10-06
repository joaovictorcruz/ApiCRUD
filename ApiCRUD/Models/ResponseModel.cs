namespace ApiCRUD.Models
{
    public class ResponseModel<T>  //T = Significa que é um tipo genérico.//
    {
        public T? Dados { get; set; }
        public string Mensagem { get; set; } = string.Empty;
        public bool Status { get; set; } = true;   
    }
}
