internal class Program
{
    private static void Main(string[] args)
    {
        string[] one = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
        //1~9
        string[] ten = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
        //10이 없는 경우, 10배수
        string[] hundred = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
        //100이 없는 경우, 100배수
        string[] thousand = { "", "M", "MM", "MMM" };
        //1000이 없는 경우, 1000배수

        int one_index;
        int ten_index;
        int hundred_index;
        int thousand_index;
        //로마자를 담아둔 인덱스를 불러올 변수

        string result;
        //결과

        while (true)
        {
            Console.Write("1~3999의 정수를 입력해주세요. : ");
            string num = Console.ReadLine();

            try
            {
                int num_2 = int.Parse(num);
                if (num_2 < 1 || num_2 > 3999)
                {
                    Console.WriteLine("잘못 입력되었습니다.");
                    Console.Write("\n");
                    continue;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("잘못 입력되었습니다.");
                Console.Write("\n");
                continue;
            }

            int count = int.Parse(num);

            one_index = count % 10;
            ten_index = (count / 10) % 10;
            hundred_index = (count / 100) % 10;
            thousand_index = (count / 1000) % 10;

            result = thousand[thousand_index] + hundred[hundred_index] + ten[ten_index] + one[one_index];

            Console.Write("입력된 수 " + count + "을 로마자로 변환한 결과 값은 : ");
            Console.WriteLine("[" + result + "] 입니다.\n");
            break;
        }
    }
}