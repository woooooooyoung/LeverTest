namespace LeverTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 문자열 속 문자 찾기
            Console.WriteLine("문장과 문자를 입력하세요.");    // 문장과 문자를 입력하세요. 출력
            string str = Console.ReadLine();                   // 입력한 문장을 str에 저장
            string str1 = Console.ReadLine();                  // 입력한 문자를 str1에 저장
            Console.WriteLine(str.IndexOf(str1, 0, str.Length)); // str에 저장된 문장중 str1의 처음 문자를 찾을 수 있음

            //문자열을 입력받으면 단어의 갯수를 출력하기
            Console.WriteLine("단어의 갯수를 알고 싶으면 문장을 입력하세요."); // 단어의 갯수를 알고 싶으면 문장을 입력하세요. 출력 (목적을 알기위함)
            string str2 = Console.ReadLine();                                  // 입력한 문장을 str2에 저장
            Console.WriteLine(str2.Length);                                    // str2에 입력된 단어의 갯수를 출력(띄어쓰기 포함)

            Console.Write("최대 9자리의 숫자를 입력하세요 : ");               // 최대 입력할 수 있는 숫자의 갯수를 알려주기 위한 출력
            SumOfDigits(1);                                                   
        }
        static int SumOfDigits(int num)
        {
            int sum = int.Parse(Console.ReadLine());

            int a = sum % 10;               // 위에서 입력한 값의 마지막 자리의 숫자를 남겨둠
            int q = sum / 10;               // int sum 에서 입력한 값의 마지막 두 번 째 숫자까지 남겨둠
            int w1 = q / 10;                // q값의 마지막 두 번 째 숫자까지 남겨둠 q ~ w8 까지 반복
            int w2 = w1 / 10;                
            int w3 = w2 / 10;               
            int w4 = w3 / 10;               
            int w5 = w4 / 10;               
            int w6 = w5 / 10;               
            int w7 = w6 / 10;               
            int w8 = w7 / 10;               
                                            
            int e1 = q % 10;                // q값의 10%를 남김 e1 ~ e9까지 반복
            int e2 = w1 % 10;               
            int e3 = w2 % 10;               
            int e4 = w3 % 10;               
            int e5 = w4 % 10;               
            int e6 = w5 % 10;               
            int e7 = w6 % 10;               
            int e8 = w7 % 10;               
            int e9 = w8 % 10;               
            
            
            int t1 = a + e1 + e2 + e3 + e4 + e5 + e6 + e7 + e8 + e9;
            // 각 나온 값을 더해줌
            if (e9 == 0)
            {
                Console.WriteLine("개별 숫자의 값은 {0}입니다", t1);
                // 나온값을 메세지와 함께 알려줌
            }
            else
            {
                Console.WriteLine("10자리 이상의 숫자는 입력할 수 없습니다.");
                // 입력한 숫자가 9자리를 넘어가면 출력함 
            }

            return 0;
        }
    }
}
