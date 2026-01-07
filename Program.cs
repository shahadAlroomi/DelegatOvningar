// Skapa en Action som skriver "Hej!" till konsolen och kör den.
//Action sayHello = ???;
//sayHello();


Action sayHello = PrintWelcomeMessage ;

static void PrintWelcomeMessage()
{
    Console.WriteLine("Hej!");
}

sayHello();

//skapa en Action som tar emot ett namn och skriver "Hej, [namn]!" till konsolen. Kör delegaten två gånger med två olika namn.

Action<string> messageWithName = n => Console.WriteLine("Hej "+ n);

messageWithName ("shahad");
messageWithName("Elin");

//Skapa en Action som tar två heltal som input, adderar dem och skriver ut resultatet. Testa med två olika par av tal.

Action<int,int> add = (x,y) => Console.WriteLine($"{x+y}");

add(10,10);
add(5,5);
