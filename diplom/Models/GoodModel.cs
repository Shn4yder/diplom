﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diplom.Models
{
    internal class GoodModel
    {
        public int IdGood { get; set; }
        public string Img { get; set; }
        public string Name {  get; set; }
        public double Cost { get; set; }
        
        public GoodModel() { }

        public GoodModel(int idGood, string img, string name, double cost)
        {
            IdGood = idGood;
            Name = name;
            Cost = cost;
            Img = img;
        }    
    }
}