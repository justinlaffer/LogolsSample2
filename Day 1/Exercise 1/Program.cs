﻿using System;

namespace Exercise_1
{
    class Program
    {
    static void Main(string[] args)
        {
            Console.WriteLine("A status report is needed of all government employees");
            
            int[] status = new int[] {1,2,3,4};
            for(int counter = 0; counter < status.Length;counter++)
             if (status == 1)
             {Console.WriteLine("Status:Alive"[counter]);
            } 
            else if(status == 2)
            {Console.WriteLine("Status:Zombie"); }
            else if(status == 3)
            {Console.WriteLine("Status:Dead");}
            else if(status == 4)
            {Console.WriteLine("Status:Unknown");}
            }
           /* int counter=0;
            while(counter<status.Length)
            {Console.WriteLine(status[counter]);
            }*/
            /* 
            switch (status)
            {
            case 1:
            Console.WriteLine("Alive");
            break;
            case 2:
            Console.WriteLine("Status:Zombie");
            break;
            case 3:
            Console.WriteLine("Dead");
            break;
            case 4:
            Console.WriteLine("Unknown");
            break;
            }
            */
        } 
    }    
