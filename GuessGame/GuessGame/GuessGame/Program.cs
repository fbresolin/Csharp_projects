class Program
{
    static void Main(string[] args)
    {
        GuessGame("bola", 10);
    }



    static void GuessGame(string SecretWord, int tryCount)
    {
        string GuessString = "";
        int GuessCount = 1;
        Console.WriteLine($"The guess game will begin, you can have a maximum of {tryCount} mistakes");
        for (int i = 0; i < SecretWord.Length; i++) { GuessString += '*'; }
        while (SecretWord != GuessString && GuessCount < tryCount)
        {
            string GuessString_ = "";
            Console.Write($"Guess number {GuessCount}. Please, input a character to find the secret word: ");
            char CharGuess = Convert.ToChar(Console.Read());FlushKeyboard();
            GuessCount++;
            for (int i = 0; i < SecretWord.Length; i++)
            {
                if (GuessString[i] != '*')
                {
                    GuessString_ += GuessString[i];
                }
                else if (SecretWord[i] != CharGuess)
                {
                    GuessString_ += '*';
                }
                else
                {
                    GuessString_ += CharGuess;
                    GuessCount--;
                }
            }
            Console.WriteLine("Characters discovered are: " + GuessString_);
            GuessString = GuessString_;
        }
        if (SecretWord == GuessString)
        {
            Console.WriteLine("Congratulations, you discovered the secret word!");
        }else
        {
            Console.WriteLine($"Sorry, you were unable to discover the secret word.");
        }
    }

    private static void FlushKeyboard()
    {
        while (Console.In.Peek() != -1)
            Console.In.Read();
    }

}