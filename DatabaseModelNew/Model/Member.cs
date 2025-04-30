using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DatabaseModel.Model
{

    [Table("Admin")]
    public class Admin
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid A_ID { get; set; }
        public string A_name { get; set; }
        public string A_username { get; set; }
        public string A_password {  get; set; }
        public string A_status { get; set; }

    }
}
