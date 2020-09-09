using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Receiver161
{
    [Table("Messages")]
    public class Message
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public int IsRequest { get; set; }
    }
}