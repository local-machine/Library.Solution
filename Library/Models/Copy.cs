namespace Library.Models
{
    public class Copy
    {
        public int CopyId {get; set;}
        public bool CheckOutStatus{get; set;}
        public virtual Book Book {get; set;}
    }
}