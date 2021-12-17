string lastName = "";
string firstName = "";
System.Console.WriteLine("Bonjour, merci d'indiquer votre nom");
lastName = Console.ReadLine();
System.Console.WriteLine("Bonjour, merci d'indiquer votre prénom");
firstName = Console.ReadLine();


System.Console.WriteLine("Bonjour " + lastName + " " + firstName + " nous sommes le " + DateTime.Now.ToLongDateString() +", comment allez-vous ?");