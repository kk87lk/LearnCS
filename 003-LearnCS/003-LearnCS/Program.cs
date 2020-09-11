using System;
using System.Collections.Generic;

namespace _003_LearnCS
{
    class ClassA<T>
    {
        private T a;
        public ClassA(T a)
        {
            this.a = a;
        }
        public void getA()
        {
            Console.WriteLine(a);
            return;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var scoreList = new List<int>();
            scoreList.Add(11);
            scoreList.Add(121);
            scoreList.Add(15);
            scoreList.Add(123);
            scoreList.Add(52);
            foreach(var i in scoreList){
                Console.WriteLine(i);
            }
            var o1 = new ClassA<int>(12);
            o1.getA();
        }
    }
}
