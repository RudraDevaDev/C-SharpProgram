//Jagged Array
class Program
{
static void Main(string[] args)
{
Console.WriteLine("-- Jagged array --");
Console.WriteLine("");
int[][] lists = new int[3][];
lists[0] = new int[ 3 ] { 1, 2, 3 };
lists[1] = new int[ 2 ] { 4, 5 };
lists[2] = new int[ 5 ] { 6, 7, 8, 9, 10 };
for(int i=0; i < lists.Length; i++)
{
Console.WriteLine("Items in list - " + i);
Console.WriteLine("-----------------------------------");
for(int j=0; j < lists[i].Length; j++)
{
Console.Write(lists[ i ][ j ] + "\t");
}
Console.WriteLine("");
Console.WriteLine("");
}
Console.Write("Press any key to continue...");
Console.ReadKey(true);
}
}
