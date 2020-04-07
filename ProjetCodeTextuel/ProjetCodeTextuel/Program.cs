using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program

{
	private static Random random = new Random();
	
	static void Main(string[] args)
	{
		Jeu1();
	}

	private static void Jeu1()
	{
		Joueur nicolas = new Joueur(150);
		int cptFacile = 0;
		int cptDifficile = 0;
		while (nicolas.EstVivant)
		{
			MonstreFacile1 monstre = FabriqueDeMonstre();
			while (monstre.EstVivant && nicolas.EstVivant)
			{
				nicolas.Attaque(monstre);
				if (monstre.EstVivant)
					monstre.Attaque(nicolas);
			}

			if (nicolas.EstVivant)
			{
				if (monstre is MonstreDifficile1)
					cptDifficile++;
				else
					cptFacile++;
			}
			else
			{
				
				break;
			}
		}
		Console.WriteLine("Bravo !!! Vous avez tué {0} monstres faciles et {1} monstres difficiles. Vous avez {2} points.", cptFacile, cptDifficile, cptFacile + cptDifficile * 2);
	}

	private static MonstreFacile FabriqueDeMonstre()
	{
		if (random.Next(2) == 0)
			return new MonstreFacile();
		else
			return new MonstreDifficile();
	}
}