using System;
using System.IO;
using System.Collections.Generic;

namespace Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines(@"/Users/alphadube/Documents/C#/Advent of Code/Day3/input.txt");
            List<int[]>  list = new List<int[]>();
            foreach (string line in lines)
            {
             int[] value = new int[12];
             int arrayPosition = 0;
             foreach(Char c in line ){
                int binaryValue = c - '0';
                value[arrayPosition]=binaryValue;
                arrayPosition++;
                }
             list.Add(value);
            }
            int[] gamma = new int[] {0,0,0,0,0,0,0,0,0,0,0,0};
            int[] epsilon = new int[] {0,0,0,0,0,0,0,0,0,0,0,0};
            int[] onesCount = new int[]{0,0,0,0,0,0,0,0,0,0,0,0};
            int[] zeroCount = new int[]{0,0,0,0,0,0,0,0,0,0,0,0};
            foreach(int[] array in list){
                int arrayIndex = 0;
                foreach(int i in array){
                    if(i == 0){
                        zeroCount[arrayIndex]++;
                        arrayIndex++;
                    }
                    else if(i==1){
                        onesCount[arrayIndex]++;
                        arrayIndex++;
                    }
                }
            }
            for(int i = 0; i < 12; i++){
                if(onesCount[i] > zeroCount[i]){
                    gamma[i] = 1;
                    epsilon[i] =0;
                }
                else if(onesCount[i] < zeroCount[i]){
                    gamma[i] = 0;
                    epsilon[i] = 1;
                }
            }
            Console.WriteLine();
            int BinaryConversion(int[] array){
            int result =0;
            int binaryPosition = 1;
            for(int i = array.Length; i-- >0; ){
              if(array[i] == 1){
                  result = result + binaryPosition;
                  binaryPosition = binaryPosition * 2;
              }
              else{
                  binaryPosition = binaryPosition * 2;
              }
            }   
            return result;
            }

            Console.WriteLine(BinaryConversion(gamma)*BinaryConversion(epsilon));
        }
    }
}
