//Créer une liste languages
List<string> languages = new List<string>() { "HTML", "CSS", "Javacrit", "jQuery", "PHP", "Bootstrap", "Java" };
//Afficher toute la liste.
for (int i = 0; i < languages.Count; i++)
{ 
    Console.WriteLine(languages[i]);
}
//Afficher le 4ème élément de la liste.
Console.WriteLine(languages[3]);
//Afficher l’élément à l’index 4 de la liste.
Console.WriteLine(languages[4]);
//Supprimer Bootstrap de la liste.
languages.Remove("Bootstrap");
//Modifier Javacrit en Javascript.
languages[languages.IndexOf("Javacrit")]="Javascript";
//Ajouter C dans la liste.
languages.Add("C");
//Afficher la liste.
for (int i = 0;i < languages.Count;i++)
{
    Console.WriteLine(languages[i]);
}