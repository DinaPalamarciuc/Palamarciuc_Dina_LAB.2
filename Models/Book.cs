using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;

namespace Palamarciuc_Dina_LAB._2.Models
{
    public class Book
    {
        public int iD { get; set; }

        [Display(Name = "Book Title" )]
        public string Title { get; set; }
        public string Author{ get; set; }

        [Column(TypeName = "decimal(6, 2)")]
        public decimal Price { get; set; }


        [DataType(DataType.Date)]
        public DateTime PublishingDate { get; set; }

        public int? PublisherID { get;set }

        public Publisher? Publisher { get; set } //navigation property
    }
}
