﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    public class ReverseaNumber
    {
        public void Reverse()
        {
            Console.WriteLine("Enter a Number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            int revNum = 0, rem;
            while (num > 0)
            {
                rem = num % 10;
                revNum = revNum * 10 + rem;
                num = num / 10;
            }
            Console.WriteLine("The Reversed num is : " + revNum);
        }
    }
}