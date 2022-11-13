namespace Palamarciuc_Dina_LAB._2.Models
{
    public class Publisher
    {
        public int ID { get; set; }

        public string PublisherName { get; set; }

        public ICollection<Book> {get; set;}  //navigation property
    }
}
