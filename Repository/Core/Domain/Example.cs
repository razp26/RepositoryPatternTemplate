
using System.ComponentModel.DataAnnotations;

namespace Repository.Core.Domain
{
    public class Example
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
