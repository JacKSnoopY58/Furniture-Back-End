using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DatabaseModel.Model
{

    [Table("Order")]
    public class Order
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid O_ID { get; set; }
        public DateTime O_date { get; set; }

        public string O_netprice { get; set; }
        public string O_status {  get; set; }
        public Guid MB_ID { get; set; }

    }
}
