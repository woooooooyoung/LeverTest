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
        }
    }
}