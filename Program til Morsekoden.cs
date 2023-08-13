class Program
{
    static void Main(string[] args)
    {
        // Here are all the diffrent characters that can be inputed in the program
        Dictionary<char, string> morseAlphabet = new Dictionary<char, string>
        {
            {'A', ".-"},
            {'B', "-..."},
            {'C', "-.-."},
            {'D', "-.."},
            {'E', "."},
            {'F', "..-."},
            {'G', "--."},
            {'H', "...."},
            {'I', ".."},
            {'J', ".---"},
            {'K', "-.-"},
            {'L', ".-.."},
            {'M', "--"},
            {'N', "-."},
            {'O', "---"},
            {'P', ".--."},
            {'Q', "--.-"},
            {'R', ".-."},
            {'S', "..."},
            {'T', "-"},
            {'U', "..-"},
            {'V', "...-"},
            {'W', ".--"},
            {'X', "-..-"},
            {'Y', "-.--"},
            {'Z', "--.."},
            {'Æ', ".-.-"},
            {'Ø', "---."},
            {'Å', ".--.-"},
            {' ', "/" },
            {'1', ".----"},
            {'2', "..---"},
            {'3', "...--"},
            {'4', "....-"},
            {'5', "....."},
            {'6', "-...."},
            {'7', "--..."},
            {'8', "---.."},
            {'9', "----."},
            {'0', "-----"},
            {'.', ".-.-.-"}, 
            {',', "--..--"}, 
            {'?', "..--.."}  
        };

        // Here it asks you to type what you want translated into morse code
        Console.Write("Indtast en tekst: ");
        string input = Console.ReadLine().ToUpper();

        // And down here it shows the translation of the text that you inputed
        foreach (char character in input)
        {
            if (morseAlphabet.TryGetValue(character, out string morseCode))
            {
                Console.Write(morseCode + " ");
            }
        }
        
        Console.WriteLine();
    }
}