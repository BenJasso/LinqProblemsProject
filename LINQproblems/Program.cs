using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQproblems
{
    class Program
    {
        static void Main(string[] args)
        {
            //member variables

            List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics"};
            string test = "th";
            List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };
            List<string> classGrades = new List<string>()
            {
                "80,100,92,89,65",
                "93,81,78,84,69",
                "73,88,83,99,64",
                "98,100,66,74,55"
            };




            //member methods

            //problem1
            //var listOfTHwords = words.Where(w => w.Contains(test));
            //foreach(var n in listOfTHwords)
            //{
            //    Console.WriteLine(n);
            //}
            //Console.ReadLine();


            //***************************************************************************************************************************


            //problem2
            //var listNoDups = names.Distinct();
            //foreach(var n in listNoDups)
            //{
            //    Console.WriteLine(n);
            //}
            //Console.ReadLine();


            //***************************************************************************************************************************


            //problem3
            List<double> gradeHolder = new List<double>();
            List<double> groupOfaverages = new List<double>();
            for (int i = 0; i < classGrades.Count; i++)
            {
                string numberHolder = null;
                

                Char[] array = classGrades[i].ToCharArray();
                
                for (int j = 0; j < classGrades[i].Length; j++)
                {
                    if(array[j] != ',')
                    {
                        if(j == array.Length - 1)
                        {
                            double grade = Convert.ToDouble(numberHolder);
                            gradeHolder.Add(grade);
                            numberHolder = null;
                        }
                        numberHolder = string.Concat(numberHolder, Convert.ToString(array[j]));
                    }
                  
                    else if(array[j] == ',' )
                    {
                        double grade = Convert.ToDouble(numberHolder);
                        gradeHolder.Add(grade);
                        numberHolder = null;
                    }
                    
                }

                gradeHolder.Sort();
                gradeHolder.RemoveAt(0);
                groupOfaverages.Add(gradeHolder.Average());
                
                gradeHolder.Clear();
            }

            double averageOfAverages = groupOfaverages.Average();
            Console.WriteLine(averageOfAverages);
            Console.ReadLine();


        }
    }
}
