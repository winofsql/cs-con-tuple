using System;

namespace cs_con_tuple
{
    class Program
    {
        static void Main(string[] args)
        {
            // 無名
            var unnamed = ("one", "two");
            Console.WriteLine($"1: {unnamed.Item1}, 2: {unnamed.Item2}");

            // 左辺でプロパティを定義
            (string Alpha, string Beta) namedLetters = ("one", "two");
            Console.WriteLine($"1: {namedLetters.Alpha}, 2: {namedLetters.Beta}");

            // 右辺でプロパティを定義
            var alphabetStart = (Alpha: "one", Beta: "two");
            Console.WriteLine($"1: {alphabetStart.Alpha}, 2: {alphabetStart.Beta}");

            // 変数でプロパティを定義
            var sum = 12.5;
            var count = 5;
            var accumulation = (count, sum);
            Console.WriteLine($"1: {accumulation.count}, 2: {accumulation.sum}");

            // タプルを戻す関数 ( 1 )
            Console.WriteLine($"1: {testFunc().Item1}, 2: {testFunc().Item2}, 3: {testFunc().Item3}");

            // タプルを戻す関数 ( 2 )
            Console.WriteLine($"1: {testFunc2().a}, 2: {testFunc2().b}, 3: {testFunc2().c}");

            Console.ReadLine();
        }

        // ***********************************
        // タプルを戻す関数 ( 1 )
        // ***********************************
        public static (string, int, double) testFunc()
        {
            return ("a", 1, 5.5);
        }

        // ***********************************
        // タプルを戻す関数 ( 2 )
        // ***********************************
        public static (string a, int b, double c) testFunc2()
        {
            return ("a", 1, 5.5);
        }
    }
}
