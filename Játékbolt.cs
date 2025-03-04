using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
	public class JatekBolt

	{

		public List<Jatek> Jatekok { get; }

		public List<Felhasznalo> Felhasznalok { get; }

		public JatekBolt()

		{

			Jatekok = new List<Jatek>();

			Felhasznalok = new List<Felhasznalo>();

		}

		public void JatekHozzaadas(Jatek jatek)

		{

			Jatekok.Add(jatek);

			Console.WriteLine($"Új játék hozzáadva: {jatek.Cim} ({jatek.Kategoria}, {jatek.Ar} Ft)");

		}

		public void FelhasznaloHozzaadas(Felhasznalo felhasznalo)

		{

			Felhasznalok.Add(felhasznalo);

			Console.WriteLine($"Új felhasználó regisztrálva: {felhasznalo.Nev}");

		}

		public Jatek KeresJatek(string cim)

		{

			return Jatekok.FirstOrDefault(j => j.Cim.Equals(cim, StringComparison.OrdinalIgnoreCase));

		}

		public Felhasznalo KeresFelhasznalo(string nev)

		{

			return Felhasznalok.FirstOrDefault(f => f.Nev.Equals(nev, StringComparison.OrdinalIgnoreCase));

		}

		public void JatekokListazasa()

		{

			Console.WriteLine("Elérhető játékok a boltban:");

			foreach (var jatek in Jatekok)

			{

				Console.WriteLine($"- {jatek.Cim} ({jatek.Kategoria}) - {jatek.Ar} Ft");

			}

		}

		public void FelhasznalokListazasa()

		{

			Console.WriteLine("Regisztrált felhasználók:");

			foreach (var felhasznalo in Felhasznalok)

			{

				Console.WriteLine($"- {felhasznalo.Nev}");

			}

		}

	}
}
