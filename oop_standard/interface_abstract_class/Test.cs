using System;
using System.Collections.Generic;
using System.Text;

namespace oop_standard.interface_abstract_class
{
    public class Test
    {
        Interface_Test inter = new InterFace_Imp();
        Abstract_Test abs = new Abstract_Imp();
        Father son = new Son();
        System.Diagnostics.Stopwatch watch = new System.Diagnostics.Stopwatch();
        private void test()
        { 
            watch.Restart();
            for (int i = 0; i < int.MaxValue; i++)
            {
                inter.Do();
            }
            watch.Stop();

            Console.WriteLine($"接口共执行：{watch.ElapsedMilliseconds}");


            watch.Restart();
            for (int i = 0; i < int.MaxValue; i++)
            {
                abs.Do();
            }
            watch.Stop();

            Console.WriteLine($"抽象共执行：{watch.ElapsedMilliseconds}");




            watch.Restart();
            for (int i = 0; i < int.MaxValue; i++)
            {
                son.Do();
            }
            watch.Stop();

            Console.WriteLine($"继承共执行：{watch.ElapsedMilliseconds}");
        }

        public void Do(int times)
        {
            for (int i = 0; i < times; i++)
            {
                test();
                Console.WriteLine("\n\n");
            }
        }
    }
}
