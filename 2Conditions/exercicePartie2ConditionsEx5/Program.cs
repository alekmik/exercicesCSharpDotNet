string mois = "";
//Demander à l'utilisateur de renseigner un mois dans la console
Console.WriteLine("Renseigner un mois parmis les 12 disponibles :");
mois = Console.ReadLine();

if (mois == "décembre" || mois == "janvier" || mois == "février")
{
    Console.WriteLine("La saison du mois saisi est le HIVER.");
}

else if (mois == "mars" || mois == "avril" || mois == "mai")
{
    Console.WriteLine("La saison du mois saisi est le PRINTEMPS.");
}

else if (mois == "juin" || mois == "juillet" || mois == "août")
{
    Console.WriteLine("La saison du mois saisi est l'ÉTÉ.");
}

else if(mois == "septembre" || mois == "octobre" || mois == "novembre")
{
    Console.WriteLine("La saison du mois saisi est l'AUTOMNE.");
}

else ()
{
    Console.WriteLine("Erreur, merci de réésayer");
}