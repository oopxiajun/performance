using System;
using System.Collections.Generic;
using System.Text;

namespace oop_standard.string_class
{
    public class CompareReplaceSpeed
    {

        System.Diagnostics.Stopwatch watch = new System.Diagnostics.Stopwatch();

        private void Test()
        {
            string s1 = "我要学习{0}";
            string s2 = "C#";

            int max = 10000000;
            watch.Restart();
            for (int i = 0; i < max; i++)
            {
                string s3 = string.Format(s1, s2);
            }
            watch.Stop();
            Console.WriteLine($"string.Format：{watch.ElapsedMilliseconds}");



            watch.Restart();
            for (int i = 0; i < max; i++)
            {
                string s3 = s1.Replace("{0}", s2);
            }
            watch.Stop();
            Console.WriteLine($"string.Replace：{watch.ElapsedMilliseconds}");



            #region 比较结果 用Replace 替换比Format 要快

            /*
         
         string.Format：1347
string.Replace：688



string.Format：1197
string.Replace：683



string.Format：1023
string.Replace：628



string.Format：1007
string.Replace：638



string.Format：1037
string.Replace：616



string.Format：1047
string.Replace：593



string.Format：1020
string.Replace：606



string.Format：1059
string.Replace：626



string.Format：1059
string.Replace：604



string.Format：1053
string.Replace：621


        

         */

            #endregion
        }

        public void StringAdd()
        {
            string s1 = "我要学习{0}";
            string s2 = "C#";

            string s3 = "";
            StringBuilder sb1 = new StringBuilder();//"我要学习{0}";
            int max = 100000000;

            watch.Restart();
            for (int i = 0; i < max; i++)
            {
                s3 = s1 + s2;
            }
            watch.Stop();
            Console.WriteLine($"string.+：{watch.ElapsedMilliseconds}");

            watch.Restart();
            for (int i = 0; i < max; i++)
            {
                sb1.Append(s1);
                sb1.Append(s2);
            }
            s3 = sb1.ToString();
            watch.Stop();
            Console.WriteLine($"StringBuilder.Append：{watch.ElapsedMilliseconds}");



            watch.Restart();
            for (int i = 0; i < max; i++)
            {
                s3 = $"{s1}{ s2}";
            }
            watch.Stop();
            Console.WriteLine($"$：{watch.ElapsedMilliseconds}");

            #region  +和$ 链接字符串速度相当，StringBuilder.Append对大量数据拼接速度较快
            /*
             
             string.+：2841
StringBuilder.Append：3370
$：2524


string.+：2531
StringBuilder.Append：3933
$：2776


string.+：2757
StringBuilder.Append：3860
$：2547


string.+：2562
StringBuilder.Append：3955
$：2507


string.+：2486
StringBuilder.Append：3819
$：2540


string.+：2530
StringBuilder.Append：3880
$：2657


string.+：2482
StringBuilder.Append：3769
$：2613


string.+：2479
StringBuilder.Append：3896
$：2606


string.+：2587
StringBuilder.Append：3855
$：2564


string.+：2725
StringBuilder.Append：4104
$：2544



             */

            #endregion
        }



        public void Do(int times)
        {
            for (int i = 0; i < times; i++)
            {
                // Test();
                StringAdd();
                Console.WriteLine("\n");
            }
        }


    }
}
