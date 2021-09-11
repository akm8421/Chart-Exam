using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            //1. Next()
            Console.WriteLine("1. Next()");
            for (int i = 0; i < 10; ++i)
            {
                int a = rand.Next();
                Console.WriteLine("Next() : " + a);
            }

            //2. Next(min, max)
            Console.WriteLine("\n2. Next(min, max)");
            for (int i = 0; i < 10; ++i)
            {
                int a = rand.Next(1, 5);
                Console.WriteLine("Next(1, 5) : " + a);
            }

            //3. Next(max)
            Console.WriteLine("\n3. Next(max)");
            for (int i = 0; i < 10; ++i)
            {
                int a = rand.Next(5);
                Console.WriteLine("Next(5) : " + a);
            }

            //4. 응용1 (배열안의 랜덤)
            Console.WriteLine("\n4. 문자열 배열의 랜덤 index를 가지고 오기");
            string[] str = { "BlockDMask", "Random", "C# example", "Blog", "Programmer" };
            for (int i = 0; i < 10; ++i)
            {
                //randomIndex는 str.Length 보다 작은 음이 아닌 정수를 반환하기 때문에,
                //랜덤값을 배열의 index로 바로 사용해도 상관없는 상황이 됩니다.
                int randomIndex = rand.Next(str.Length);    //Next(Max).
                Console.WriteLine("randomIndex = {0}, str[randomIndex] = {1}", randomIndex, str[randomIndex]);
            }

            //5. NextBytes(byte[] buffer)
            Console.WriteLine("\n5. NextBytes(byte[] buffer)");
            byte[] arrByte = new byte[5];
            rand.NextBytes(arrByte);        //한번 호출에 배열 모든 요소 랜덤값 세팅

            for (int i = 0; i < arrByte.Length; ++i)
            {
                Console.WriteLine("arrByte[{0}] : {1}", i, arrByte[i]);
            }

            //6. NextDouble()
            Console.WriteLine("\n6. NextDouble()");

            for (int i = 0; i < 10; ++i)
            {
                double d = rand.NextDouble();
                Console.WriteLine("NextDouble() : " + d);
            }

            Console.ReadLine();
        }
    }
}
