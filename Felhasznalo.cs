using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
	public class Felhasznalo

	{

		public string Nev { get; }

		public int Egyenleg { get; private set; }

		public List<Jatek> Konyvtar { get; }

		public Felhasznalo(string nev, int egyenleg)

		{

			Nev = nev;

			Egyenleg = egyenleg;

			Konyvtar = new List<Jatek>();

		}

		public bool Vasarlas(Jatek jatek)

		{

			if (Konyvtar.Contains(jatek))

			{

				Console.WriteLine($"A(z) {jatek.Cim} játék már a könyvtárban van!");

				return false;

			}

			if (Egyenleg >= jatek.Ar)

			{

				Egyenleg -= jatek.Ar;

				Konyvtar.Add(jatek);

				Console.WriteLine($"{jatek.Cim} sikeresen megvásárolva!");

				return true;

			}

			else

			{

				Console.WriteLine($"Nincs elég egyenleg a(z) {jatek.Cim} megvásárlásához!");

				return false;

			}

		}

		public void KonyvtarMegtekintes()

		{

			Console.WriteLine($"Megvásárolt játékok ({Nev} könyvtárában):");

			if (Konyvtar.Count == 0)

			{

				Console.WriteLine("- Nincs megvásárolt játék.");

				return;

			}

			foreach (var jatek in Konyvtar)

			{

				Console.WriteLine($"- {jatek.Cim}");

			}

		}

		public void Feltoltes(int osszeg)

		{

			Egyenleg += osszeg;

			Console.WriteLine($"Egyenleg feltöltve: +{osszeg} Ft. Jelenlegi egyenleg: {Egyenleg} Ft");

		}

	}

}
	

