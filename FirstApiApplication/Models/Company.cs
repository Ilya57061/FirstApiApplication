using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstApiApplication.Models
{
    [Table ("Сompanies")]
    public class Company
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public List<User>? Users { get; set; }
    }
}
