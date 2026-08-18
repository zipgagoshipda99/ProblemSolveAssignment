using System;
namespace Main
{
    public struct Coin
    {
        public int tenWonCount= 0;
        public int onehundreredWonCount= 0; // C #10 이후부터 가능한거 (구조체에서도 필드 초기화 가능)
        public int fiveHunderedWonCount = 0;
        public const int tenWon = 10;
        public const int oneHunderedWon = 100;
        public const int fiveHunderedWon = 500;
        public Coin()
        {
            
        } //구조체는 자동 생성자를 안만들어줘서 구조체에서 필드의 값을 설정할려면 텅 빈 구조체라도 만들어야해서 추가.
        // 구조체에서 생성자 또는 필드 초기화자(field initializers) 가 없으면 new Coin() 으로 구조체 객체를 만들때 객체 안에 있는 모든 필드를 다 기본 값으로 시작하도록 보장되어 있다..
    }
}