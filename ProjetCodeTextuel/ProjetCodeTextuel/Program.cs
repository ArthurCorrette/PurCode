using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetCodeTextuel
{

 public class Program

{
	private static Random random = new Random();
	
	static void Main(string[] args)
	{
			De1.LanceLeDe();
	}

	private static void Jeu1()
	{
		Joueur Kevin = new Joueur(150);
		int cptFacile = 0;
		int cptDifficile = 0;
		while (Kevin.EstVivant)
		{
			MonstreFacile1 monstre = FabriqueDeMonstre();
			while (monstre.EstVivant && Kevin.EstVivant)
			{
				Kevin.Attaque(monstre);
				if (monstre.EstVivant)
					monstre.Attaque(Kevin);
			}

			if (Kevin.EstVivant)
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

	private static MonstreFacile1 FabriqueDeMonstre()
	{
		if (random.Next(2) == 0)
			return new MonstreFacile1();
		else
			return new MonstreDifficile1();
	}
}
}