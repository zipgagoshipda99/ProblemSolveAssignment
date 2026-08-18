namespace Main
{
    public class LongestConsecutiveWord 
    {
        public void GetLongestConsecutiveWord()
        {
            Console.WriteLine("배열 길이 입력: ");
            string? arraysize = Console.ReadLine();
            bool isParsed = int.TryParse(arraysize, out int output);
        

            Console.WriteLine("배열에 길이 만큼 정수를 공백으로 구분하여 입력.");
            string? inputs = Console.ReadLine();
            string[] inputsArr = inputs.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            if(!isParsed || string.IsNullOrWhiteSpace(inputs)){
                Console.WriteLine("숫자를 입력하시오.");
                return;
            }
            bool allNumbers = inputsArr.All(input => int.TryParse(input, out _));
            {
                if (!allNumbers)
                {
                    Console.WriteLine("숫자만 입력");
                    return;
                }
            }
            int[] intArr = inputsArr.Select(int.Parse).ToArray();
            
            int consecutiveCount = 1; 
            int maxCount = 1;
            if (output <= 0)
            {
                Console.WriteLine("0이하에 숫자는 입력 불가능합니다.");
                GetLongestConsecutiveWord();
                return;
            }
            
            if(intArr.Length == 0) return;

            if (output == intArr.Length)
            {
                Console.WriteLine($"{intArr.Length}");  
                
            }
            else
            {                
                Console.WriteLine("지정하신 배열길이와 값의 수가 일치하지 않습니다.");
                return;
            }
            for(int i = 1; i < intArr.Length; i++)
            {
                if (intArr[i] == intArr[i-1] + 1)
                {
                    consecutiveCount++;
                }
                else
                {
                    consecutiveCount = 1;
                }
                if(consecutiveCount> maxCount)
                {
                    maxCount = consecutiveCount;
                }
            }
            Console.WriteLine($"연속된 가장 긴 길이 : {maxCount}");
        }
    } 
}