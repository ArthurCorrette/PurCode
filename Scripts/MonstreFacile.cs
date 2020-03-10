public class MonstreFacile
{
    private const int degats = 10;
	protected De de;
	public bool EstVivant { get; private set; }

	public MonstreFacile()
	{
		de = new De();
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
		return de.LanceLeDe();
	}
}