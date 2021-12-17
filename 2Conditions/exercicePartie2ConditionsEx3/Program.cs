int age;
string sex;
//À l’aide de la console, inviter l’utilisateur à renseigner son âge.
Console.WriteLine("Quel est votre âge ?");
age = int.Parse(Console.ReadLine());
// Inviter l’utilisateur à renseigner son sexe.
Console.WriteLine("Êtes vous un homme ? Oui ou non");
sex = Console.ReadLine();
//Majeur & homme
if (age >= 18 && sex == "oui")
{
    Console.WriteLine("Vous êtes un homme et vous êtes majeur.");
}
//Majeur & femme
else if (age >= 18 && sex == "non")
{
    Console.WriteLine("Vous êtes une femme et vous êtes majeure.");
}
//Mineur & homme
else if (age < 18 && sex == "oui")
{
    Console.WriteLine("Vous êtes un homme et vous êtes mineur.");
}
//Mineur & femme
else if (age < 18 && sex == "non")
{
    Console.WriteLine("Vous êtes une femme et vous êtes majeure.");
}
//Réésayer
else
{
    Console.WriteLine("Erreur. Merci de réésayer");
}