using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyLuckyTicket.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Account { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
