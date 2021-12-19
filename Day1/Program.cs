
string[] lines = File.ReadAllLines(@"C:\C# Projects\ASP.Net\AdventOfCode\Day1Solution\Day1\SonarInput\input.txt");
List<int>  list = new List<int>();
foreach (string line in lines)
{
    var value = int.Parse(line);
    list.Add(value);
    
}
Console.WriteLine(FindLargers(list));
Console.WriteLine(FindSums(list));
int FindLargers(List<int> list)
{
    int LargerCount = 0;
    int listSpot = 1;
    foreach(int n in list)
    {
       if (n > list[listSpot - 1])
        {
            LargerCount++;
            listSpot++;
            Console.WriteLine("larger");
        }
       else if (n < list[listSpot - 1])
        {
            listSpot++;
            Console.WriteLine("Smaller");
        }

    }
    return LargerCount;
}

List<int[]> CreateArrayBlocks(List<int> list)
{
    int listSpot = 1;
    List<int[]> windowList = new List<int[]>();
    {
        foreach (int n in list)
        {
            if(list.IndexOf(n) < 1998)
            {
                int[] arrayBlock = new int[3];
                arrayBlock[0] = n;
                arrayBlock[1] = list[listSpot];
                arrayBlock[2] = list[listSpot + 1];
                windowList.Add(arrayBlock);
                listSpot++;
                
            }
        
        }
    }

    return windowList;
}
int FindSums(List<int> list)
{
    int LargerCount = 0;
    int listSpot = 0;
    List<int[]>arrayList = CreateArrayBlocks(list);

    foreach(int[] n in arrayList)
    {
        if(listSpot -1 < 0)
        {
            listSpot++;
        }
        else if (n.Sum() > arrayList[listSpot -1].Sum())
        {
            LargerCount++;
            listSpot++;
            Console.WriteLine("larger");
        } 
       else if (n.Sum() <= arrayList[listSpot - 1].Sum())
        {
            listSpot++;
            Console.WriteLine("Smaller");
      
        }  
    }
    return LargerCount;
}
