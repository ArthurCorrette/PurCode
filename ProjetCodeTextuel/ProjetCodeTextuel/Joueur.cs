using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Joueur
{
	// ça marche pour pitot
    private De1 de;
	public int PtsDeVies { get; private set; }
	public bool EstVivant
	{
		get { return PtsDeVies > 0; }
	}

	public Joueur(int points)
	{
		PtsDeVies = points;
		de = new De1();
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
		return de.LanceLeDe();
	}

	public void SubitDegats(int degats)
	{
		if (!BouclierFonctionne())
			PtsDeVies -= degats;
	}

	private bool BouclierFonctionne()
	{
		return de.LanceLeDe() <= 2;
	}
}