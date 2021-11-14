#region Configuration Variables

// Used to control the version number
const string version = "0.1";

#endregion

#region Variables

// Integers
int offset = -1;

// Strings
string encryptedMessage;
string decryptedMessage;

// Chars
char[] specialCharArray = { 
    '`',
    '~',
    '+',
    '='
};

// Dictionaries
Dictionary<int, char> alphabetIndexLetter = new Dictionary<int, char>()
{
    { 0, 'a' },
    { 1, 'b' },
    { 2, 'c' },
    { 3, 'd' },
    { 4, 'e' },
    { 5, 'f' },
    { 6, 'g' },
    { 7, 'h' },
    { 8, 'i' },
    { 9, 'j' },
    { 10, 'k' },
    { 11, 'l' },
    { 12, 'm' },
    { 13, 'n' },
    { 14, 'o' },
    { 15, 'p' },
    { 16, 'q' },
    { 17, 'r' },
    { 18, 's' },
    { 19, 't' },
    { 20, 'u' },
    { 21, 'v' },
    { 22, 'w' },
    { 23, 'x' },
    { 24, 'y' },
    { 25, 'z' },
    { 26, ',' },
    { 27, '.' },
    { 28, '<' },
    { 29, '>' },
    { 30, '?' },
    { 31, '/' },
    { 32, ':' },
    { 33, ';' },
    { 34, '"' },
    { 35, '\'' },
    { 36, '{' },
    { 37, '[' },
    { 38, '}' },
    { 39, ']' },
    { 40, '|' },
    { 41, '\\' },
    { 42, 'Z' },
    { 43, 'Y' },
    { 44, 'X' },
    { 45, 'W' },
    { 46, 'V' },
    { 47, 'U' },
    { 48, 'T' },
    { 49, 'S' },
    { 50, 'R' },
    { 51, 'Q' },
    { 52, 'P' },
    { 53, 'O' },
    { 54, 'N' },
    { 55, 'M' },
    { 56, 'L' },
    { 57, 'K' },
    { 58, 'J' },
    { 59, 'I' },
    { 60, 'H' },
    { 61, 'G' },
    { 62, 'F' },
    { 63, 'E' },
    { 64, 'D' },
    { 65, 'C' },
    { 66, 'B' },
    { 67, 'A' },
    { 68, '!' },
    { 69, '1' },
    { 70, '@' },
    { 71, '2' },
    { 72, '#' },
    { 73, '3' },
    { 74, '$' },
    { 75, '4' },
    { 76, '%' },
    { 77, '5' },
    { 78, '^' },
    { 79, '6' },
    { 80, '&' },
    { 81, '7' },
    { 82, '*' },
    { 83, '8' },
    { 84, '(' },
    { 85, '9' },
    { 86, ')' },
    { 87, '0' },
    { 88, '_' },
    { 89, '-' }
};

Dictionary<char, int> alphabetLetterIndex = new Dictionary<char, int>()
{
    { 'a', 0 },
    { 'b', 1 },
    { 'c', 2 },
    { 'd', 3 },
    { 'e', 4 },
    { 'f', 5 },
    { 'g', 6 },
    { 'h', 7 },
    { 'i', 8 },
    { 'j', 9 },
    { 'k', 10 },
    { 'l', 11 },
    { 'm', 12 },
    { 'n', 13 },
    { 'o', 14 },
    { 'p', 15 },
    { 'q', 16 },
    { 'r', 17 },
    { 's', 18 },
    { 't', 19 },
    { 'u', 20 },
    { 'v', 21 },
    { 'w', 22 },
    { 'x', 23 },
    { 'y', 24 },
    { 'z', 25 },
    { ',', 26 },
    { '.', 27 },
    { '<', 28 },
    { '>', 29 },
    { '?', 30 },
    { '/', 31 },
    { ':', 32 },
    { ';', 33 },
    { '"', 34 },
    { '\'', 35 },
    { '{', 36 },
    { '[', 37 },
    { '}', 38 },
    { ']', 39 },
    { '|', 40 },
    { '\\', 41 },
    { 'Z', 42 },
    { 'Y', 43 },
    { 'X', 44 },
    { 'W', 45 },
    { 'V', 46 },
    { 'U', 47 },
    { 'T', 48 },
    { 'S', 49 },
    { 'R', 50 },
    { 'Q', 51 },
    { 'P', 52 },
    { 'O', 53 },
    { 'N', 54 },
    { 'M', 55 },
    { 'L', 56 },
    { 'K', 57 },
    { 'J', 58 },
    { 'I', 59 },
    { 'H', 60 },
    { 'G', 61 },
    { 'F', 62 },
    { 'E', 63 },
    { 'D', 64 },
    { 'C', 65 },
    { 'B', 66 },
    { 'A', 67 },
    { '!', 68 },
    { '1', 69 },
    { '@', 70 },
    { '2', 71 },
    { '#', 72 },
    { '3', 73 },
    { '$', 74 },
    { '4', 75 },
    { '%', 76 },
    { '5', 77 },
    { '^', 78 },
    { '6', 79 },
    { '&', 80 },
    { '7', 81 },
    { '*', 82 },
    { '8', 83 },
    { '(', 84 },
    { '9', 85 },
    { ')', 86 },
    { '0', 87 },
    { '_', 88 },
    { '-', 89 }
};

#endregion

#region Main

MenuSelection();
//WriteLine("\u000a");
//WriteLine("\u000b");
//WriteLine("\u000c");
//WriteLine("\u000d");
//WriteLine("\u000e");
//WriteLine("\u000f");

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
                Clear();
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
       
        Write("Please enter a cypher offset (0 - 89) >> ");
        successfullyConverted = Int32.TryParse(ReadLine(), out offset);

        // If it is an integer ? continue : restart the while loop.
        if (successfullyConverted)
        {

            // Test to see if the integer is between 0 - 89 ? continue : restart the while loop.
            if (offset >= 0 && offset <= 89)
            {

                isNotAnInt = false;
                encryptedMessage = CreateEncryptedMessage(offset);
                DisplayMenuBanner();
                WriteLine("\nYour encrypted message:\n");
                WriteLine($"  {encryptedMessage}");
                Write("\nPress any key to continue...");
                ReadLine();
                MenuSelection();

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

        Write("Please enter a cypher offset (0 - 89) >> ");
        successfullyConverted = Int32.TryParse(ReadLine(), out offset);

        // If it is an integer ? continue : restart the while loop.
        if (successfullyConverted)
        {

            // Test to see if the integer is between 0 - 89 ? continue : restart the while loop.
            if (offset >= 0 && offset <= 89)
            {

                decryptedMessage = DecryptEncryptedMessage(offset);
                DisplayMenuBanner();
                WriteLine("\nYour decrypted message:\n");
                WriteLine($"  {decryptedMessage}");
                Write("\nPress any key to continue...");
                ReadLine();
                MenuSelection();

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
 * CreateEncryptedMessage(int userOffset)
 * 
 * This method is the method that creates an encrypted
 * Caesar Cipher message. Uses the alpabet and an offset
 * that is chosen by the user.
 * 
 */

string CreateEncryptedMessage(int userOffset)
{

    // Variables
    StringBuilder hashedString = new StringBuilder();
    string userPlaintextString = "";
    int tempIndex = 0;

    // Get the user's plaintext message
    DisplayMenuBanner();
    Write("\nPlease enter the message you want to encrypt >> ");
    userPlaintextString = ReadLine();

    // Iterate though the userPlaintextString and encrypt it.
    foreach (char userChar in userPlaintextString)
    {

        // Check for a space char
        if (userChar == ' ')
        {

            // Run GenerateSpaceChar() appened it to the stringbuilder
            hashedString.Append(GenerateSpaceChar(specialCharArray));

        }
        else
        {

            // Get the index from the user char
            tempIndex = alphabetLetterIndex[userChar];

            // Add the offset to the tempIndex
            tempIndex = tempIndex + userOffset;

            // If the tempIndex is greater than 89
            if (tempIndex > 89)
            {

                // Subtract 26 from tempIndex to loop back to the
                // beginning of the alphabet
                tempIndex = tempIndex - 90;

                // Get the letter that corresponds with the new index
                // and append it to the stringbuilder
                hashedString.Append(alphabetIndexLetter[tempIndex]);

            }
            else
            {

                // Get the letter that corresponds with the new index
                // and append it to the stringbuilder
                hashedString.Append(alphabetIndexLetter[tempIndex]);

            }

        }

    }

    return hashedString.ToString();

}

/*
 * 
 * DecryptEncryptedMessage(int userOffset)
 * 
 * This method decrypts an encrypted Caesar Cypher message. Method
 * takes a user offset and decrypts the encrypted message.
 * 
 */

string DecryptEncryptedMessage(int userOffset)
{

    // Variables
    StringBuilder plaintextString = new StringBuilder();
    string userEncryptedString = "";
    int tempIndex = 0;

    // Get the user's encrypted message
    DisplayMenuBanner();
    Write("\nPlease enter the message you want to decrypt >> ");
    userEncryptedString = ReadLine();

    // Iterate though the userEncryptedString and decrypt it.
    foreach (char userChar in userEncryptedString)
    {

        // Check for a special char
        if (specialCharArray.Contains(userChar))
        {

            // Append a space
            plaintextString.Append(' ');

        }
        else
        {

            // Get the index from the user char
            tempIndex = alphabetLetterIndex[userChar];

            // Subtract the offset from the tempIndex
            tempIndex = tempIndex - userOffset;

            // If the tempIndex is less than zero
            if (tempIndex < 0)
            {

                // Add 26 to tempIndex to loop back to the
                // end of the alphabet
                tempIndex = tempIndex + 90;

                // Get the letter that corresponds with the new index
                // and append it to the stringbuilder
                plaintextString.Append(alphabetIndexLetter[tempIndex]);

            }
            else
            {

                // Get the letter that corresponds with the new index
                // and append it to the stringbuilder
                plaintextString.Append(alphabetIndexLetter[tempIndex]);

            }

        }

    }

    return plaintextString.ToString();

}

/*
 * 
 * GenerateSpaceChar(char[] array)
 * 
 * Generates a random special character to take
 * place of a space in the user's plaintext
 * string.
 * 
 */

char GenerateSpaceChar(char[] array)
{

    // Variables
    Random random = new Random();

    return array[random.Next(array.Length)];

}

#endregion