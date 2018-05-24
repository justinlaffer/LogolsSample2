using System;

namespace Exercise_1
{
    class Program
    {
    static void Main(string[] args)
    {
        /*A status report is needed of all government employees")*/
          int[] status = {1,2,3,4};
            
            for(int count = 0; count < status.Length;count++)
              if (status == 1)
             {Console.WriteLine("Status:Alive") ;}
            else if(status == 2)
            {Console.WriteLine("Status:Zombie"); }
            else if(status == 3)
            {Console.WriteLine("Status:Dead");}
            else if(status == 4)
            {Console.WriteLine("Status:Unknown");}
            
           /* int[] status = new int[] {1,2,3,4};
            int count = 0;
            while(count<status.Length)
            {Console.WriteLine(status[count].ToString());counter++;
            }*/
                       
            switch (status)
            {
            case 1:
            Console.WriteLine("Alive");
            break;
            case 2:
            Console.WriteLine("Zombie");
            break;
            case 3:
            Console.WriteLine("Dead");
            break;
            case 4:
            Console.WriteLine("Unknown");
            break;
            }            
        } 
    }   

} 
