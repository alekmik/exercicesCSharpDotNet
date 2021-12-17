Console.OutputEncoding = System.Text.Encoding.UTF8;
int firstNumber;
int secondNumber;
// Demander à l'utilisateur le premier nombre
Console.WriteLine("Quel est le premier nombre?");
firstNumber = int.Parse(Console.ReadLine());
// Demander à l'utilisateur le second nombre
Console.WriteLine("Quel est le second nombre?");
string secondNumberString = Console.ReadLine();
secondNumber = int.Parse(secondNumberString);
// Rajouter 33 au premier nombre et incrémenter 1 au second nombre
firstNumber += 33;
secondNumber++;
float quotient = (float)firstNumber / (float)secondNumber;
Console.WriteLine("Résultat de la division : " + quotient);
