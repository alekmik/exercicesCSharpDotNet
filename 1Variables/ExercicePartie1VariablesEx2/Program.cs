//1. Créer trois variables et leur attribuer des nombres au choix.
int NumberOfStudents = 14;
int NumberOfScreens = 28;
int NumberOfFingers = 140;

//3. Additionner les 2 premiers nombres p
int SumOfTwoFirstNumbers = NumberOfStudents + NumberOfScreens;
int SumOfMultiplicationWithTheLastNumber = SumOfTwoFirstNumbers * NumberOfFingers;

//2. Afficher les valeurs de ces nombres dans la console dans une phrase.
Console.WriteLine("Aujourd'hui LA MANU acceuille " + NumberOfStudents + 
" nouveaux étudiants. Ils ont à leur disposition " + NumberOfScreens +
"écrans. Cela fait un total de " + NumberOfFingers + " doigts près à pianoter.");

Console.WriteLine("La somme des deux premiers nombres est "+ SumOfTwoFirstNumbers +
". Multiplier par 140, cela donne " + SumOfMultiplicationWithTheLastNumber +".");