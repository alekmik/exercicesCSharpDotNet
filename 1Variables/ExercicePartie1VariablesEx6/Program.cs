string nom = "";
string prenom = "";
int anneeDeNaissance;
//Demande à l’utilisateur de renseigner son nom, son prénom et son année de naissance
Console.WriteLine("Veuillez taper votre nom");
nom = Console.ReadLine();
Console.WriteLine("Veuillez taper votre prénom");
prenom = Console.ReadLine();
Console.WriteLine("Veuillez taper votre année de naissance");
anneeDeNaissance = int.Parse( Console.ReadLine());
int age = DateTime.Now.Year - anneeDeNaissance;
Console.WriteLine("Votre fiche :");
Console.WriteLine("Nom : " + nom + "\n" + "Prénom : " + prenom + "\n" + "Age : " + age);