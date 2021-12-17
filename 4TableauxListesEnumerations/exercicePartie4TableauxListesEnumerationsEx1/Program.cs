/*Créer un tableau week contenant les jours
entrer les éléments "Lundi, Mardi, Mercredi, Jedi, Vendredi, Samedi"*/
string[] week = new string[] { "Lundi", "Mardi", "Mercredi", "Jedi", "Vendredi", "Samedi" };
//Afficher le contenue de l'indice 1
Console.WriteLine(week[1]);
//Afficher le contenue de l'indice 4
Console.WriteLine(week[4]);
//Afficher le contenue du 1er élément du tableau
Console.WriteLine(week[0]);
//Afficher le contenue du 4er élément du tableau
Console.WriteLine(week[3]);
//Corriger le 4ème jour.
week[3] = "Jeudi";
//Ajouter le 7ème jour.
Array.Resize(ref week, 7);
week[6] = "Dimanche";
//Afficher le tableau dans la console.
for (int i=0; i<week.Length;i++)
{
    Console.WriteLine(week[i]);
}