﻿using Project;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Project
{
    public class Item : GameObject
    {
        public Item(string[] idents, string name, string desc) :
            base(idents, name, desc)
        {
        }
    }
}

