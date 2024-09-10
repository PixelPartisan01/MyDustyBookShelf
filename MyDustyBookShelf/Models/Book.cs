namespace MyDustyBookShelf.Models
{
    public class Book
    {
        public string Title      { get; set; }
        public int Id            { get; set; }
        public string Author     { get; set; }
        public string? Series    { get; set; }
        //public DateTime? Release { get; set; }
    }
}
