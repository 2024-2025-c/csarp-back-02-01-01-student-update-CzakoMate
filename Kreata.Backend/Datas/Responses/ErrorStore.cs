namespace Kreata.Backend.Datas.Responses
{
    public class ErrorStore
    {
        public ErrorStore()
        {
            Error=string.Empty;
        }
        public string Error {  get; set; }=string.Empty;
        public bool HasError=>!string.IsNullOrEmpty(Error);
    }
    
}
