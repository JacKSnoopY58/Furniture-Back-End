using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace DatabaseModel.Model
{

    [Table("Payment")]
    public class Payment
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid P_ID { get; set; }
        public DateTime P_date { get; set; }

        public DateTime P_time { get; set; }
        public string P_netprice {  get; set; }
        public string P_img { get; set; }
        public string P_add { get; set; }
        public Guid O_ID { get; set; }
        public Guid MB_ID { get; set; }
        public bool Is_Payment {  get; set; }

    }
}
