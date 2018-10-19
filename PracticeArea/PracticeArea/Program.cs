using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeArea
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine("Enter the number of values you want to put : ");
            int val = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[val];
            int[] tempArr = new int[val];
            for (int i = 0; i < val; i++)
            {
                Console.WriteLine("Enter value for arr[{0}] : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int tempArrCount = 0;
            bool isPresent = false;
            for (int i = 0; i < val; i++)
            {
                /*Take out values*/
                int value = arr[i]; //2

                /*Compare with all the values of the array*/
                for (int j = 0; j < val; j++)
                {
                    if (j != i)
                    {
                        if (value == arr[j])
                        {
                            foreach (int item in tempArr)
                            {
                                if (item == arr[j])
                                {
                                    isPresent = true;
                                    break;
                                }
                                else
                                {
                                    isPresent = false;
                                }
                            }
                            if (!isPresent)
                            {
                                count++;
                                tempArr[tempArrCount] = arr[j];
                                tempArrCount++;
                            }
                        }
                    }
                }
            }

            Console.WriteLine("Total Duplicate Values are {0}", count);
            Console.ReadKey();
            
        }
    }
}
