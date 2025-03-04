namespace ConsoleApp4
{

	

namespace JatekBoltApp

	{

	
		class Program

		{

			static void Main(string[] args)

			{

				JatekBolt jatekBolt = new JatekBolt();

				

				jatekBolt.JatekHozzaadas(new Jatek("The Witcher 3", "RPG", 12000));

				jatekBolt.JatekHozzaadas(new Jatek("FIFA 23", "Sport", 18000));

				jatekBolt.JatekHozzaadas(new Jatek("Cyberpunk 2077", "RPG", 15000));

				while (true)

				{

					Console.WriteLine("\n--- Menü ---");

					Console.WriteLine("1. Új felhasználó regisztrálása");

					Console.WriteLine("2. Játék vásárlása");

					Console.WriteLine("3. Egyenleg feltöltése");

					Console.WriteLine("4. Játékkönyvtár megtekintése");

					Console.WriteLine("5. Új játék hozzáadása a bolt kínálatához");

					Console.WriteLine("6. Elérhető játékok megtekintése");

					Console.WriteLine("7. Felhasználók listájának megtekintése");

					Console.WriteLine("0. Kilépés");

					Console.Write("Válassz egy opciót: ");

					string valasztas = Console.ReadLine();

					switch (valasztas)

					{

						case "1":

							Console.Write("Add meg a felhasználó nevét: ");

							string nev = Console.ReadLine();

							Console.Write("Add meg a kezdő egyenleget (Ft): ");

							int egyenleg = int.Parse(Console.ReadLine());

							jatekBolt.FelhasznaloHozzaadas(new Felhasznalo(nev, egyenleg));

							break;

						case "2":

							Console.Write("Add meg a felhasználó nevét: ");

							nev = Console.ReadLine();

							Felhasznalo felhasznalo = jatekBolt.KeresFelhasznalo(nev);

							if (felhasznalo != null)

							{

								Console.Write("Add meg a megvásárolni kívánt játék címét: ");

								string jatekCim = Console.ReadLine();

								Jatek jatek = jatekBolt.KeresJatek(jatekCim);

								if (jatek != null)

								{

									felhasznalo.Vasarlas(jatek);

								}

							}

							break;

						case "4":

							Console.Write("Add meg a felhasználó nevét: ");

							nev = Console.ReadLine();

							felhasznalo = jatekBolt.KeresFelhasznalo(nev);

							if (felhasznalo != null)

							{

								felhasznalo.KonyvtarMegtekintes();

							}

							break;

						case "5":

							Console.Write("Játék címe: ");

							string cim = Console.ReadLine();

							Console.Write("Kategória: ");

							string kategoria = Console.ReadLine();

							Console.Write("Ár (Ft): ");

							int ar = int.Parse(Console.ReadLine());

							jatekBolt.JatekHozzaadas(new Jatek(cim, kategoria, ar));

							break;

						case "6":

							jatekBolt.JatekokListazasa();

							break;

						case "7":

							jatekBolt.FelhasznalokListazasa();

							break;

						case "0":

							Console.WriteLine("Kilépés...");

							return;

						default:

							Console.WriteLine("Érvénytelen opció! Próbáld újra.");

							break;

					}

				}

			}

		}

	}

}
