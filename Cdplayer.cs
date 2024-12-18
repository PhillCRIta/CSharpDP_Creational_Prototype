using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_Prototype
{
	internal class Cdplayer : DjEquipment
	{
		public Turntable Turntable { get; set; }

		public Cdplayer(string model, Turntable turntable) : base(model)
		{
			Turntable = turntable;
		}

		public override DjEquipment Clone()
		{
			//DEEP COPY
			Cdplayer cdpClone = (Cdplayer)MemberwiseClone();
			cdpClone.Turntable = new Turntable(this.Turntable.Model, this.Turntable.VynilToPlay);
			//return (DjEquipment)MemberwiseClone();
			return cdpClone;
		}
	}
}
