public class Joueur
{
    private De de;
	public int PtsDeVies { get; private set; }
	public bool EstVivant
	{
		get { return PtsDeVies > 0; }
	}

	public Joueur(int points)
	{
		PtsDeVies = points;
		de = new De();
	}

	public void Attaque(MonstreFacile monstre)
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