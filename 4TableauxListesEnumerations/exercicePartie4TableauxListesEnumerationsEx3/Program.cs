int result = 0;
//Créer une liste numbers et la remplir de nombres au choix.
List<int> listOfNumbers = new List<int>() { 23, 455, 6, 45, 30, 0, 9 };
//À l’aide d’une boucle, calculer la somme de tous les nombres de la liste.
for (int i = 0; i < listOfNumbers.Count; i++)
{
    result += listOfNumbers[i];
}

Console.WriteLine("Le résultat de l'opération " + String.Join(" + ", listOfNumbers) + " = " + result);