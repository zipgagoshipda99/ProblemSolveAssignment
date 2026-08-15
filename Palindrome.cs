using System;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
namespace PalindromeSolve
{
    class Palindrome
    {
        
        internal void PalindromeSolver()
        {
            string? parseableString = Console.ReadLine();
            int baseNumber;
            int nonReversedNumber;
            bool isParsed = int.TryParse(parseableString, out baseNumber);
            if(parseableString == null)
                throw new ArgumentNullException(parseableString);
            else if(baseNumber < 0) return;

            nonReversedNumber = baseNumber;
            int reversedNumber = 0;
            // while (nonReversedNumber > 0)
            // {
            //     int remainder = nonReversedNumber % 10;                          // 1. 마지막 자릿수 추출
            //     reversedNumber = (reversedNumber * 10) + remainder; // 2. 기존 숫자를 한 칸 밀고 더하기
            //     nonReversedNumber = nonReversedNumber / 10;                                   // 3. 마지막 자릿수 제거
            // }
            for (int rem = 0; nonReversedNumber>0; nonReversedNumber = nonReversedNumber / 10)
            {
                rem = nonReversedNumber % 10;
                reversedNumber = (reversedNumber * 10) + rem;
            }
            Console.WriteLine($"원본 솟자 : {baseNumber}");
            Console.WriteLine($"뒤집은 숫자: {reversedNumber}");

        // [조건] 문자열 비교 없이 오직 숫자 비교(==)만 사용
            if (baseNumber  == reversedNumber)
            {
                Console.WriteLine("팰린드롬 여부: YES");
            }
            else
            {
                Console.WriteLine("팰린드롬 여부: NO");
            }
        }
    }
}