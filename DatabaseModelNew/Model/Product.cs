using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DatabaseModel.Model
{

    [Table("Product")]
    public class Product
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid PD_ID { get; set; }
        public string PD_name { get; set; }

        public decimal PD_price { get; set; }
        public string PD_detail {  get; set; }
        public string PD_img { get; set; }
        public Guid PT_ID { get; set; }


    }
}
