using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_Prototype
{
	//CONCREATE PROTOTYPE 1
	public class Turntable : DjEquipment
	{

		public string VynilToPlay {  get; set; }

		public Turntable(string model, string vynilToPlay) : base(model)
		{
			VynilToPlay = vynilToPlay;
		}

		public override DjEquipment Clone()
		{
			return (DjEquipment)MemberwiseClone();
		}
	}
}
