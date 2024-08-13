/*
TASK:
- WRITE PROGRAM THAT WILL RECOGNIZE INVALID INPUTS WHEN USER REQUESTS INFORMATION

BUILD SPECS:
✔ 1. CREATE 3 ARRAYS: NAME[], HOMETOWN[], FAV FOOD[]
✔ 2. PROMPT USER TO ASK ABOUT A STUDENT BY NUMBER
    ✔ - CONVERT INPUT -> INT
        ✔ - INT = INDEX FOR ARRAYS 
        ✔ - PRINT STUDENT'S NAME 
✔ 3. ASK USER WHICH CATEGORY TO DISPLAY: HOMETOWN OR FAV FOOD 
    ✔ - USE (.Contains) TO ALLOW FOR PARTIAL WORDS
✔ 4. ASK USER IF THEY WOULD TO LEARN ABOUT ANOTHER STUDENT 
✔ 5. USE IF STATEMENT TO CHECK IF INPUT IS WITHIN RANGE 
✔ 6. USE IF STATEMENT TO CHECK THAT THEY ENTERED CATEGORY NAME CORRECTLY 
7. USE FIRST ARRAY'S LENGTH IN CODE (name.Length)
✔ 8. PROVIDE OPTION WHERE USER CAN SEE LIST OF STUDENT 
9. ALLOW USER TO SEARCH BY STUDENT NAME 
*/

int[] arrSize = new int[11];
string[] name = {"Justin Jones", "DeAngelo Robinson", "Martina Basquez", "Alain Rene", "David Goodwin", "Joey Molinski", "Wren Grasley", "Brady Hartman", "David Brameijer", "Afseen Salam", "Ethan Thomas"};
string[] hometown = {"Westerville", "Detroit", "Edinburg", "Homestead", "Jersey City", "Toledo", "Richmond", "Saranac", "Grand Rapids", "India", "Bolivar"};
string[] favoriteFood = {"Baja Blast", "Pizza", "Leftovers", "Chicken Wings", "Sushi", "Dill Pickles", "Pizza", "Chicken Wings", "Tacos", "Shawarma", "Grapes"};

bool runProgram = true;
while (runProgram) 
{
    arrSize[0] = 1;
    Console.WriteLine("Please choose a student you would like to get to know and type the number corresponding to their name.");
    foreach (string n in name) // list out students numerically 
    { 
        Console.WriteLine($"{arrSize[0]++}. {n}");
    }
    int friends = 0; // accounting for robot math 
    while (true)
    {
        friends = int.Parse(Console.ReadLine()); // user input to choose student 
        friends -= 1;
        if (friends > name.Length)
        {
            Console.WriteLine($"Invalid entry. Please choose between 1 - {name.Length}.");
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine($"Awesome! You chose {name[friends]}. Would you like to know their favorite food or their hometown?");
            break;
        }
    }
    while (true) 
    {
        string homeOrFood = Console.ReadLine().ToLower();
        if (homeOrFood.Contains("food"))
        {
            Console.WriteLine();
            Console.WriteLine($"{name[friends]}'s favorite food is {favoriteFood[friends]}.");
            break;
        }
        else if (homeOrFood.Contains("home"))
        {
            Console.WriteLine();
            Console.WriteLine($"{name[friends]} is from {hometown[friends]}.");
            break;
        }
        else
        {
            Console.WriteLine("Invalid entry. Please try again.");
        }
    }
    while (true)
    {
        Console.WriteLine();
        Console.WriteLine("Would you like to get to know someone else? (y/n)");
            string userChoice = Console.ReadLine().ToLower();
            if (userChoice == "y")
            {
                Console.WriteLine();
                break;
            }
            else if (userChoice == "n")
            {
                runProgram = !true;
            }
            else
            {
                Console.WriteLine("Invalid entry. Please choose between (y/n).");
            }
    }
}

