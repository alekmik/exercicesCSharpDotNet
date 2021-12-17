//Le nombre défini au départ est aléatoire.
Random randomNumber = new Random();
//La valeur est entre 1 et 50 : < randomNumber.Next(1,50) >
 
int numberOneTooFifty = randomNumber.Next(1,51);
int numberOfUser;

do
{
    //demander à l'utilisateur un nombre entre 1 et 50
    Console.WriteLine("Devinez un nombre entre 1 et 50 :");
    numberOfUser = int.Parse(Console.ReadLine());

    if (numberOfUser == numberOneTooFifty)
    {
        //si l'utilisateur trouve la bonne réponse, afficher "Bravo vous avez trouvé !"
        Console.WriteLine("Trouvé ! GG");
    }

    else if (numberOfUser < numberOneTooFifty)
    {
        //afficher "plus grand"
        Console.WriteLine("plus grand");
    }

    else
    {
        //afficher "plus petit"
        Console.WriteLine("plus petit");
    }

} while (numberOfUser != numberOneTooFifty);