using System.ComponentModel.DataAnnotations.Schema;

namespace Als_Net_Core_2.Models
{
    public class League
    {
        public int ID { get; set; }

        public string Name { get; set; }

        [Column("is_active")]
        public bool IsActive { get; set; }
    }
}
