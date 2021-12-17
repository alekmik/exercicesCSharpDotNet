//créer une variable < result >
int userInput;
int result = 0;
string addNumberYesOrNo;


do 
{
    //Demander à l'utilisateur un nombre à additionner
    Console.WriteLine("Taper un nombre à additionner ");
    userInput = int.Parse(Console.ReadLine());
    result += userInput;
    
    Console.WriteLine("Le solde de votre compte est de : "+result);
    //Demander si l'utilisateur souhaite ajouter un nombre
    Console.WriteLine("Souhaitez vous ajouter un nombre ? Tapez \"oui\" ou \"non\"");
    addNumberYesOrNo = Console.ReadLine();

} while (addNumberYesOrNo == "oui");