using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DatabaseModel.Model
{

    [Table("Delivery")]
    public class Delivery
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid D_ID { get; set; }
        public DateTime D_date { get; set; }

        public Guid D_parcelnum { get; set; }
        public Guid A_ID {  get; set; }
        public Guid P_ID { get; set; }
        public Guid O_ID { get; set; }

    }
}
