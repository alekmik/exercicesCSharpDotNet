int result =1;
//Stocker dans une liste
List<string> listToBeAdd = new List<string>();
//Demander à l’utilisateur les nombres qu'il souhaite multiplier
Console.WriteLine("Veuillez entrer les nombres à multiplier :");
while (true)
{
    listToBeAdd.Add(Console.ReadLine());
    if (listToBeAdd.Count == 6)
        break;
}
//Calculer le résultat de la multiplication
Console.WriteLine("\nLe résultat de la multiplication est de :");
for (int i = 0; i < listToBeAdd.Count; i++)
{
    result*= int.Parse(listToBeAdd[i]);
}
Console.WriteLine(result);

//L’afficher en rappelant tous les nombres
Console.WriteLine("\nCi-dessous la liste des nombres :");

for (int i = 0; i < listToBeAdd.Count; i++)
{
    Console.WriteLine(listToBeAdd[i]);
}