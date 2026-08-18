using Main;

Console.WriteLine("Hello, World!");
ConsoleKeyInfo consoleKeyInfo;
Palindrome palindrome = new Palindrome();
LongestConsecutiveWord longestConsecutiveWord = new LongestConsecutiveWord();
MinimumCoinCalculator minimumCoinCalculator = new MinimumCoinCalculator();
while (true)
{
    Console.WriteLine("무슨 과제를 먼저 볼지 선택: ");
    consoleKeyInfo = Console.ReadKey();
    Console.WriteLine("\n");
    switch (consoleKeyInfo.KeyChar)
    {
        case '1':
            palindrome.PalindromeSolver();
            break;
        case '2':
            longestConsecutiveWord.GetLongestConsecutiveWord();
            break;
        case '3':
            minimumCoinCalculator.CalculateCoins();
            break;
        default:
        
        break;
    }
    break;
}