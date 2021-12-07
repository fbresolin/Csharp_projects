class Program
{
    static void Main(string[] args)
    {
        GuessGame("bola");
    }



    static void GuessGame(string SecretWord)
    {
        Console.WriteLine("The game will begin");
        string GuessString = "";
        for (int i = 0; i < SecretWord.Length; i++) { GuessString += '*'; }
        while (SecretWord != GuessString)
        {
            string GuessString_ = "";
            Console.Write("Please, input a character to find the secret word: ");
            char CharGuess = Convert.ToChar(Console.Read());
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
                }
            }
            Console.WriteLine("Characters discovered are: " + GuessString_);
            GuessString = GuessString_;
            FlushKeyboard();
        }
        Console.WriteLine("Congratulations, you discovered the secret word!");
    }

    private static void FlushKeyboard()
    {
        while (Console.In.Peek() != -1)
            Console.WriteLine(Console.In.Read());
    }

}