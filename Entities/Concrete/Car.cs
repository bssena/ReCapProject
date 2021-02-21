﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Car:IEntity //diğer katmanların da ulaşması için public
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public string ModelYear { get; set; }
        public int MyProperty { get; set; }
        public decimal DailyPrice { get; set; }
        public string Description { get; set; }


    }
}