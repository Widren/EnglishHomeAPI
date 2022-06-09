﻿using BaseAPI.Controllers.Resources;
using System;

namespace BaseAPI.Resources
{
    public class SiparisResource
    {
        public int SiparisId { get; set; }
        public DateTime SiparisTarihi { get; set; }
        public int Adet { get; set; }
        public int UserId { get; set; }
        public int ProductID { get; set; }
        public UserResource User { get; set; }
        public ProductResource Product { get; set; }
    }
}
