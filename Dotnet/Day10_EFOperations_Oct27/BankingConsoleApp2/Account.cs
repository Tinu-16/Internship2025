using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingConsoleApp2
{
    public class Account
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string AccountNumber { get; set; }
        public double Balance { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
