namespace Creational_Prototype
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Create a prototypical instance of kind of object and creates new object using this prototype.
			//Generates a photocopy of another object, instead create new form scratch.
			//Usefull for complicated constructor phase or resource intensive construction.
			//You can use Clone() method instead of another NEW instantiation.

			Turntable turnTab = new Turntable("Technichs MK2 - 1200", "Usura - datura");
			Turntable turnTabClone = (Turntable)turnTab.Clone();
			Console.WriteLine($"Equipment was cloned {turnTabClone.Model} that playing {turnTabClone.VynilToPlay}");

			Cdplayer cdp = new Cdplayer("CDJ-100", turnTabClone);
			Cdplayer cdpClone = (Cdplayer)cdp.Clone();
            Console.WriteLine($"Cd player was cloned: {cdpClone.Model} it will be mixed with {cdpClone.Turntable.Model} equipment");

            Console.WriteLine("Change the model of the cloned turntable");
			turnTabClone.Model = "Piooner-X";
			/*The shallow copy copy the value of primitive variables, for reference type, shallow copy copies only a reference, not a value.
			 * For copy a value of reference you must use deep copy, copy manualy every reference type in a new reeference type.
			 */
			Console.WriteLine($"Cd player was cloned: {cdpClone.Model} it will be mixed with {cdpClone.Turntable.Model} equipment");
		}
	}
}
