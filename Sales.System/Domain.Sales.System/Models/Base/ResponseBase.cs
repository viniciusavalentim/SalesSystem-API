namespace Domain.Sales.System.Models.Base
{
    public class ResponseBase<T>
    {
        public T? Data { get; set; } 
        public string Messages { get; set; } = string.Empty;
        public bool Status { get; set; } = true;
    }
}
