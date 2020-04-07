using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetCodeTextuel
{
		public class MonstreFacile1
		{
			private const int degats = 10;
			public bool EstVivant { get; private set; }
		
		

			public MonstreFacile1()
			{
				EstVivant = true;
			}

			public virtual void Attaque(Joueur joueur)
			{
				int lanceMonstre = LanceLeDe();
				int lanceJoueur = joueur.LanceLeDe();
				if (lanceMonstre > lanceJoueur)
					joueur.SubitDegats(degats);
			}

			public void SubitDegats()
			{
				EstVivant = false;
			}

			public int LanceLeDe()
			{
				return De1.LanceLeDe();
			}
		}
	
}
