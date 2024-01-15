using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public class DbOrder
    {
        [Key]
        public Guid id { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string senderCity { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string senderAddress { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string customerCity { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string customerAddress { get; set; }

        public double packageWeight { get; set; }

        public DateTime deliveryDate { get; set; }
    }
}
