﻿using System;

namespace VatanBilgisayarMobil.Models
{
    public class Siparis
    {
        public DateTime SiparisTarihi { get; set; }
        public int Adet { get; set; }
        public int UserId { get; set; }
        public int ProductID { get; set; }
        public User User { get; set; }
        public Product Product { get; set; }
    }
}