using System;
using System.Collections.Generic;

namespace _2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = new string[3] {"Петя", "Женя", "Вася" };
            List<int> g = new List<int> { };//Список индексов
            Random ran = new Random();
            int size = 0;// Счетчик количества  элементов списка

            while(size < arr.Length)//До тех пор пока счетчик не будет равен количеству элементов массива
            {
                int count = 0;//Счетчик повторяющихся индексов

                int h = ran.Next(0, 3);//Генерация случайного числа от 0 до 2

                foreach(int el in g)//Если сгенерированное число встречается в списке, то счетчик coount увеличивается
                {
                    if(el == h)
                    {
                        count++;
                    }
                }
                if(count == 0)//Если же такого значения в списке нет, то оно добавляется в него, и счетчик size увеличиается
                {   
                  g.Add(h);
                    size++;
                }
            }

            foreach(int ele in g)
            {
                Console.WriteLine(arr[ele]);
            }
            Console.ReadLine();
        }

        
    }
}
