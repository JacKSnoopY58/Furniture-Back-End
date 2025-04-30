using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DatabaseModel.Model
{

    [Table("OrderDetail")]
    public class OrderDetail
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid O_ID { get; set; }
        public Guid PD_ID { get; set; }

        public decimal OD_price { get; set; }
        public int OD_num {  get; set; }
        public decimal OD_totel { get; set; }

    }
}
