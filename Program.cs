//Action #2 : Skapa en Action som skriver "Hej!" till konsolen och kör den.

Action sayHello = PrintWelcomeMessage;

static void PrintWelcomeMessage()
{
    Console.WriteLine("Hej!");
}

sayHello();

//Action #2 :skapa en Action som tar emot ett namn och skriver "Hej, [namn]!" till konsolen. Kör delegaten två gånger med två olika namn.

Action<string> messageWithName = n => Console.WriteLine("Hej " + n);

messageWithName("shahad");
messageWithName("Elin");

//Action #3 : Skapa en Action som tar två heltal som input, adderar dem och skriver ut resultatet. Testa med två olika par av tal.

Action<int, int> add = (x, y) => Console.WriteLine($"{x + y}");

add(10, 10);
add(5, 5);

//Func #1 :Skapa en Func som tar ett heltal och returnerar talet i kvadrat. Hint: tänk på att en Func alltid returnerar ett värde, och det är den första typen i generics-listan.

Func<int,int> Kvadrat = y => y * y ;

Console.WriteLine("Resultet är "+ Kvadrat(3));

//Func #2 : Skapa en Func som adderar två tal och returnerar summan. Skriv ut resultatet efter att du kört funcen.

Func<int,int,int> add1 = (x,y) => x + y ;
Console.WriteLine("Resultet är "+ add1(3,9));

//Func #3 - Villkor : Skapa en func som returnerar en bool och tar ett heltal som input. Funcen ska returnera true om talet är över 65 och false annars. Funcen kan ses som en definition av ett villkor, i detta fallet om en tenta är godkänd eller inte. Så döp gärna funcen till något som reflekterar detta, t.ex. IsPassed. Testa funcen med olika tal och skriv ut resultatet i konsolen.

Func<int,bool> IsPassed = (age) => age > 65 ;

Console.WriteLine(IsPassed(44));

Console.WriteLine(IsPassed(67));