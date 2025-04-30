using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DatabaseModel.Model
{

    [Table("Member")]
    public class Member
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid MB_ID { get; set; }
        public string MB_username { get; set; }

        public string MB_password { get; set; }
        public string MB_name {  get; set; }
        public string MB_fname { get; set; }
        public string MB_add { get; set; }
        public string MB_tel { get; set; }

    }
}
