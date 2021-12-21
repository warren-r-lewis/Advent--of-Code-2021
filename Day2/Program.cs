using System;
using System.IO;

namespace Day2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string[] input= RetrieveInput();
            
            Console.WriteLine(CaluclateAimAndPosition(input));
        }
        public static string[] RetrieveInput(){
        string[] lines = File.ReadAllLines(@"/Users/alphadube/Documents/C#/Advent of Code/Day2/input.txt");
        return lines;
        }
        public static int PlotPosition(string[] data){
            int forward_heading = 0;
             int depth_heading = 0;
            foreach (string heading in data){
                if(heading.Contains("forward")){
                    int forward = int.Parse(heading.Substring(heading.Length -1)); 
                    forward_heading = forward_heading + forward;
                }else if(heading.Contains("down")){
                    int depth= int.Parse(heading.Substring(heading.Length -1)); 
                    depth_heading = depth_heading + depth;
                }else if(heading.Contains("up")){
                    int depth= int.Parse(heading.Substring(heading.Length -1)); 
                    depth_heading = depth_heading - depth;
                }
            }
            return forward_heading * depth_heading;
        }
        public static int CaluclateAimAndPosition(string[] data){
            int forward_heading = 0;
            int depth_heading = 0;
            int aim = 0;
            foreach (string heading in data){
                if(heading.Contains("forward")){
                    int forward = int.Parse(heading.Substring(heading.Length -1)); 
                    forward_heading = forward_heading + forward;
                    depth_heading = aim * forward;
                }else if(heading.Contains("down")){
                    int depth= int.Parse(heading.Substring(heading.Length -1)); 
                    depth_heading = depth_heading+depth;
                    aim = aim + depth;
                }else if(heading.Contains("up")){
                    int depth= int.Parse(heading.Substring(heading.Length -1)); 
                    depth_heading = depth_heading+depth;
                    aim = aim - depth;
                }
            }
            return forward_heading * depth_heading;
        }
    }
    
    
}
