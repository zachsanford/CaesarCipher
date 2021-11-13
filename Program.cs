#region Configuration Variables

// Used to control the version number
const string version = "0.1";

#endregion

#region Variables

// Integers
int offset = -1;

// String Builders
StringBuilder hashedString = new StringBuilder();

// Dictionaries
Dictionary<int, (int position, char letter)> alphabet = new Dictionary<int, (int position, char letter)>()
{
    { 0, (0, 'a') },
    { 1, (1, 'b') },
    { 2, (2, 'c') },
    { 3, (3, 'd') },
    { 4, (4, 'e') },
    { 5, (5, 'f') },
    { 6, (6, 'g') },
    { 7, (7, 'h') },
    { 8, (8, 'i') },
    { 9, (9, 'j') },
    { 10, (10, 'k') },
    { 11, (11, 'l') },
    { 12, (12, 'm') },
    { 13, (13, 'n') },
    { 14, (14, 'o') },
    { 15, (15, 'p') },
    { 16, (16, 'q') },
    { 17, (17, 'r') },
    { 18, (18, 's') },
    { 19, (19, 't') },
    { 20, (20, 'u') },
    { 21, (21, 'v') },
    { 22, (22, 'w') },
    { 23, (23, 'x') },
    { 24, (24, 'y') },
    { 25, (25, 'z') }
};

#endregion

#region Main

MenuSelection();

#endregion

#region Methods

/*
 * 
 * DisplayMenuBanner()
 * 
 * Used to show the banner for the
 * main menu.
 * 
 */

void DisplayMenuBanner()
{

    Clear();
    WriteLine("");
    WriteLine("***********************************************");
    WriteLine("*                                             *");
    WriteLine("*                 _/_/_/   _/_/_/             *");
    WriteLine("*               _/       _/                   *");
    WriteLine("*              _/       _/                    *");
    WriteLine("*             _/       _/                     *");
    WriteLine("*              _/_/_/   _/_/_/                *");
    WriteLine("*                                             *");
    WriteLine("***********************************************");
    WriteLine("*                CAESAR CYPHER                *");
    WriteLine("***********************************************");
    WriteLine($"*                VERSION:  {version}                *");
    WriteLine("***********************************************");

}

/*
 * 
 * MenuSelection()
 * 
 * Displays the root menu selections and takes the
 * users input.
 * 
 */

void MenuSelection()
{

    // Variables
    string userSelection = "";
    string intermittentMessage = "";
    bool isIncorrectSelection = true;
    bool intermittentMessageExists = false;

    // User needs to make a correct selection, otherwise the application
    // reiterates through this while loop
    while (isIncorrectSelection)
    {

        // Display the menu options
        DisplayMenuBanner();

        // Display the intermittent message
        if (intermittentMessageExists)
        {
            WriteLine($"\n{userSelection} is not a correct choice!\n");
        }
        else
        {
            WriteLine("");
        }

        WriteLine("Please make a selection from one of the following options:\n");
        WriteLine("  1) Create a new message");
        WriteLine("  2) Decrypt an existing message");
        WriteLine("  3) Quit Caesar Cypher\n");
        Write("Your selection >> ");
        userSelection = ReadLine();

        // Switch through the selections and create a default selection
        switch (userSelection)
        {

            // 1: Create a new message
            case "1":
                isIncorrectSelection = false;
                CreateMessage();
                break;

            // 2: Decrypt a message
            case "2":
                isIncorrectSelection = false;
                DecryptMessage();
                break;

            // 3: Quit the app
            case "3":
                Environment.Exit(0);
                break;
            
            // Default: Incorrect Choice
            default:
                intermittentMessageExists = true;
                break;

        }

    }

}

/*
 * 
 * CreateMessage()
 * 
 * Begins the process of creating an encrypted message.
 * 
 */

void CreateMessage()
{

    // Variables
    bool isNotAnInt = true;
    bool successfullyConverted = false;
    bool intermittentMessageExists = false;

    // User needs to enter an offset (integer). If the user
    // input is not an integer, reiterate.
    while (isNotAnInt)
    {

        // Display the banner
        DisplayMenuBanner();

        // Display the intermittent message
        if (intermittentMessageExists)
        {
            WriteLine($"\nNot a correct offset!\n");
        }
        else
        {
            WriteLine("");
        }
       
        Write("Please enter a cypher offset (0 - 25) >> ");
        successfullyConverted = Int32.TryParse(ReadLine(), out offset);

        // If it is an integer ? continue : restart the while loop.
        if (successfullyConverted)
        {

            // Test to see if the integer is between 0 - 25 ? continue : restart the while loop.
            if (offset >= 0 && offset <= 25)
            {
                isNotAnInt = false;
                Exits(1);                
            }
            else
            {
                // Show the intermittent message
                intermittentMessageExists = true;
            }

        }
        else
        {
            // Show the intermittent message
            intermittentMessageExists = true;
        }

    }

}

/*
 * 
 * DecryptMessage()
 * 
 * Begins the process of decrypting an encrypted message.
 * 
 */

void DecryptMessage()
{

    // TESTING
    Exits(2);

}

/*
 * 
 * Exits(int exitRoute)
 * 
 * This method is for testing all of the menu routes.
 * Should not exist in a production environment.
 * 
 */

void Exits(int exitRoute)
{
    WriteLine(exitRoute.ToString());
}

#endregion