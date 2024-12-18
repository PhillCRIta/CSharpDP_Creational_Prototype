using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_Prototype
{
	//PROTOTYPE
	public abstract class DjEquipment
	{

        public string Model { get; set; }

        protected DjEquipment(string model)
        {
            Model = model;   
        }

        public abstract DjEquipment Clone();
	}
}
