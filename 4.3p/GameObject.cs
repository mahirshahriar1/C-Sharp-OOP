using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class GameObject : IdentifiableObject
    {
        private string _description, _name;

        public GameObject(string[] ids, string name, string description) : base(ids)
        {
            _description = description; 
            _name = name;
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public virtual string FullDescription
        {
            get
            {
                return _description;
            }
        }

        public string ShortDescription
        {
            get
            {
               // return $"{_name} ({FirstID})";
                return (_name+" ("+base.FirstID+')');
            }
        }



    }
}
