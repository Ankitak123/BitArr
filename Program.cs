﻿using System;
using System.Collections;
namespace BitArr
{
    class Program
    {
        static void Main(string[] args)
        {

            BitArray myBitArr = new BitArray(5);

            myBitArr[0] = true;
            myBitArr[1] = true;
            myBitArr[2] = false;
            myBitArr[3] = true;
            myBitArr[4] = false;

            // To get the value of index at index 2 
            Console.WriteLine(myBitArr.Get(2));

            // To get the value of index at index 3 
            Console.WriteLine(myBitArr.Get(3));
        }
		
    }
}
