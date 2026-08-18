using System;
using System.Runtime.ConstrainedExecution;
namespace Main
{
    class MinimumCoinCalculator 
    {   
        public void CalculateCoins()
        {
            string? input = Console.ReadLine();
            bool isParsed = int.TryParse(input, out int pharseResult);
            Coin coin = new Coin();
            if(!int.TryParse(input, out _) || string.IsNullOrWhiteSpace("input"))
            {
                Console.WriteLine("숫자 입력.");
            }
            if(pharseResult % 10 != 0)
            {
                Console.WriteLine("10의 배수여야합니다.");
            }
            else
            {
                coin.fiveHunderedWonCount = pharseResult / Coin.fiveHunderedWon; //나누기 연산자로 500원 갯수 구하기 (나누었을때 몫이 0 이면 0개)
                pharseResult = pharseResult % Coin.fiveHunderedWon; // 500원 갯수 만큼 차감했을때 남은 거스름돈 

                // 100원의 갯수 구하기
                coin.onehundreredWonCount = pharseResult / Coin.oneHunderedWon;
                pharseResult = pharseResult % Coin.oneHunderedWon; // 100원 갯수 만큼 차감했을때 남은 거스름돈

                // 10원의 갯수 구하기
                coin.tenWonCount = pharseResult / Coin.tenWon;
                pharseResult = pharseResult % Coin.tenWon;  // 10원 주고 남은 돈 (0원이 됨)

                
                Console.WriteLine($"500원 동전: {coin.fiveHunderedWonCount}개");
                Console.WriteLine($"100원 동전: {coin.onehundreredWonCount}개");
                Console.WriteLine($"10원 동전: {coin.tenWonCount}개");
            }
            

        }
    }
}