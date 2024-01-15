using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class Order
    {
        [Key]
        public Guid id { get; set; }
        [StringLength(100)]
        public string senderCity { get; set; }
        [StringLength(100)]
        public string senderAddress { get; set; }
        [StringLength(100)]
        public string customerCity { get; set; }
        [StringLength(100)]
        public string customerAddress { get; set; }
        public double packageWeight { get; set; }
        public DateTime deliveryDate { get; set; }    
    }
}
