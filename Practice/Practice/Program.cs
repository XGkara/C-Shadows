//prototype of Casting Shadows
//Working on dice rolls and action economy managment 


//dice roll here (Blue Orb, Red Orb, Purple Orb, Red Crystal, Blue Crystal, Purple Crystal, Curse, Shadow Fragment
// a total of five dice with six side 
// all 5 dice have 2 constact resources which is the curse and the shadow fragment
// 2 of the dice have a 2 red orbs and 2 red crystals and 2 of the dice have 2 blue crystal and 2 blue orbs 1 of the dice has 2 purple orbs and 2 purple crystals.




using System.Collections;

List<string> dice = new List<string> { "Blue Orb", "Red Orb", "Purple Orb", "Red Crystal", "Blue Crystal", "Purple Crystal", "Curse", "Shadow Fragment" };

Console.WriteLine("Welcome to Casting Shadows");
Console.WriteLine("Press Enter to roll the dice");
Console.ReadLine();

if (Console.ReadKey().Key == ConsoleKey.Enter) {
    RandomRoll();
}



void RandomRoll() {

    Random random = new Random(); // Random number generator
    for (int i = 0; i < 5; i++) {
        int roll = random.Next(0, dice.Count);

            //change color of dice to match the resource
            if (dice[roll] == "Blue Orb" || dice[roll] == "Blue Crystal") {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            else if (dice[roll] == "Red Orb" || dice[roll] == "Red Crystal") {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else if (dice[roll] == "Purple Orb" || dice[roll] == "Purple Crystal") {
                Console.ForegroundColor = ConsoleColor.Magenta;
            }
            else if (dice[roll] == "Curse") {
                Console.ForegroundColor = ConsoleColor.DarkGray;
            }
            else if (dice[roll] == "Shadow Fragment") {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
            }

        Console.WriteLine("You rolled: ");
        Console.WriteLine(dice[roll]);
        
    }
    
}




