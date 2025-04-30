using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DatabaseModel.Model
{

    [Table("Cancel")]
    public class Cancel
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid CC_ID { get; set; }
        public DateTime CC_date { get; set; }
        public Guid O_ID { get; set; }

    }
}
