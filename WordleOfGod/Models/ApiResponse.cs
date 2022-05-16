namespace WordleOfGod.Models;

public class ApiResponse
{
	//public Informations? Informations { get; set; }
	public Lectures? Lectures { get; set; }
}

//public class Informations
//{
//	public string? Date { get; set; }
//	public string? Zone { get; set; }
//	public string? Couleur { get; set; }
//	public string? Annee { get; set; }
//	public string? Temps_liturgique { get; set; }
//	public string? Semaine { get; set; }
//	public string? Jour { get; set; }
//	public string? Jour_liturgique_nom { get; set; }
//	public string? Fete { get; set; }
//	public string? Degre { get; set; }
//	public string? Ligne1 { get; set; }
//	public string? Ligne2 { get; set; }
//	public string? Ligne3 { get; set; }
//	public object? Couleur2 { get; set; }
//	public object? Couleur3 { get; set; }
//}

public class Lectures
{
	//public string? Introduction { get; set; }
	//public Hymne?  Hymne { get; set; }
	//public string? Antienne_1 { get; set; }
	//public Psaume? Psaume_1 { get; set; }
	//public string? Antienne_2 { get; set; }
	//public Psaume? Psaume_2 { get; set; }
	//public string? Antienne_3 { get; set; }
	//public Psaume? Psaume_3 { get; set; }
	//public string? Verset_psaume { get; set; }
	public Parole? Lecture { get; set; }
	//public string? Repons_lecture { get; set; }
	//public string? Titre_patristique { get; set; }
	//public string? Texte_patristique { get; set; }
	//public string? Repons_patristique { get; set; }
	//public object[]? Te_deum { get; set; }
	//public string? Oraison { get; set; }
}

//public class Hymne
//{
//	public string? Auteur { get; set; }
//	public string? Editeur { get; set; }
//	public string? Titre { get; set; }
//	public string? Texte { get; set; }
//}

public class Lecture
{
	public string? Reference { get; set; }
	public string? Texte { get; set; }
}

//public class Psaume : Lecture { }

public class Parole : Lecture
{
	public string? Titre { get; set; }
}