using BaseAPI.Core.Models;
using System;

namespace BaseAPI.Domain.Models
{
    public class Siparis
    {
        public int SiparisId { get; set; }
        public DateTime SiparisTarihi { get; set; }
        public int Adet { get; set; }
        public int UserId { get; set; }
        public int ProductID { get; set; }

    }
}
