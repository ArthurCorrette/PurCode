using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetCodeTextuel
{
	public class Joueur
	{
		// ça marche pour pitot

		public int PtsDeVies { get; private set; }
		public bool EstVivant
		{
			get { return PtsDeVies > 0; }
		}

		public Joueur(int points)
		{
			PtsDeVies = points;
		}

		public void Attaque(MonstreFacile1 monstre)
		{
			int lanceJoueur = LanceLeDe();
			int lanceMonstre = monstre.LanceLeDe();
			if (lanceJoueur >= lanceMonstre)
				monstre.SubitDegats();
		}

		public int LanceLeDe()
		{
			return De1.LanceLeDe();
		}

		public void SubitDegats(int degats)
		{
			if (!BouclierFonctionne())
				PtsDeVies -= degats;
		}

		private bool BouclierFonctionne()
		{
			return De1.LanceLeDe() <= 2;
		}
	}
}