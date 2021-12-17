/*créer 2 variables : login et password et leur attribuer une valeur.
< const > = variable qui ne change pas*/
string login ="alek";
string password = "azerty1234";
//À l’aide de la console, inviter l’utilisateur à renseigner un identifiant 
Console.WriteLine("Votre identifiant :");
login = Console.ReadLine();
//inviter l’utilisateur à renseigner un mot de passe
Console.WriteLine("Votre mot de passe :");
password = Console.ReadLine();
if (login=="alek" && password=="azerty1234")
{
    Console.WriteLine("Bienvenue à la Manu.");
}
else
{
    Console.WriteLine("Mauvais identifiant ou mauvais mot de passe.");
    //Pour la sécurité de l'utilisateur, ne pas spécifier l'origine de l'erreur (email ou MDP)
}