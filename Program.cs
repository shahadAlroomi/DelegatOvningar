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
