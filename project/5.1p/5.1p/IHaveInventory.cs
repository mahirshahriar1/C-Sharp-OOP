using Project;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace Project
{
    public interface IHaveInventory
    {
        GameObject Locate(string id);
        string Name
        {
            get;
        }
    }
}

