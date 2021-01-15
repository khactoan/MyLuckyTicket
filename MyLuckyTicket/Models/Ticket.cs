using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyLuckyTicket.Models
{
    public class Ticket
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public int Number { get; set; }
        public virtual User User { get; set; }
    }
}
