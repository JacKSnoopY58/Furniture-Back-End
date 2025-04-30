using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseModel.Model
{

    [Table("ProductType")]
    public class ProductType
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid PT_ID { get; set; }
        public string PT_name { get; set; }
        
    }
}
