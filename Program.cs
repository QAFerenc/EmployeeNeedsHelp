using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_B
{
    class Program
    {    
          
        static void Main(string[] args)
        {
            
            string inputData = Console.ReadLine();
            string [] inputDataArray = inputData.Split(" ");
            int number_of_necessary_questions = int.Parse(inputDataArray[0]);
            int number_of_coworkers = int.Parse(inputDataArray[1]);
           
            List<int> initialAngryness =  new List<int>();
            List<int> angrynessIncrease = new List<int>();
            List<int> actualAngriness = new List<int>();

            for(int i = 0; i < number_of_coworkers; i++)
            {
                inputData = Console.ReadLine();
                inputDataArray = inputData.Split(" ");

                initialAngryness.Add(int.Parse(inputDataArray[0]));
                angrynessIncrease.Add(int.Parse(inputDataArray[1]));
                actualAngriness.Add(0);
            }
                           
            int overallMinimumAngrinessOfAngriestCoWorker = 999999999;
                             
            var arr = new int[number_of_necessary_questions];
                
            while (true)
            {
                //Console.WriteLine($"({string.Join(", ", arr.Select(e => CoWorkerIndices[e]))})");
                
                int maximumAngrinessPerVariation = 0;

                for(int i=0; i < number_of_necessary_questions; i++)
                {
                    if(actualAngriness[arr[i]]==0)
                        actualAngriness[arr[i]]=initialAngryness[arr[i]] + angrynessIncrease[arr[i]];
                    else
                        actualAngriness[arr[i]]+=angrynessIncrease[arr[i]];                    
                }
                                
                for(int i=0; i < number_of_coworkers; i++)
                {
                    //Console.WriteLine(actualAngriness[i]);
                    
                    if( (actualAngriness[i] > maximumAngrinessPerVariation) && (actualAngriness[i]!=0) )
                    {
                        maximumAngrinessPerVariation = actualAngriness[i];                        
                    }
                    actualAngriness[i] = 0;
                }   
                
                //Console.WriteLine(maximumAngrinessPerVariation);
                
                if(maximumAngrinessPerVariation < overallMinimumAngrinessOfAngriestCoWorker)
                    overallMinimumAngrinessOfAngriestCoWorker = maximumAngrinessPerVariation;


                var index = number_of_necessary_questions - 1;
                
                while (index >= 0 && arr[index] == number_of_coworkers - 1)
                {
                    index--;
                }
    
                if (index < 0)
                {
                    break;
                }
    
                arr[index]++;
    
                for (int i = index + 1; i < number_of_necessary_questions; i++)
                {
                    arr[i] = 0;
                }

            }
            Console.WriteLine(overallMinimumAngrinessOfAngriestCoWorker);
        }

    }
}
