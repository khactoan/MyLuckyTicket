using MyLuckyTicket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyLuckyTicket.ViewModels
{
    public class UserData
    {
        public User User { get; set; }
        public IEnumerable<Ticket> Tickets { get; set; }
    }
}
