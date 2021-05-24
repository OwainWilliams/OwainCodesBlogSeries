namespace ConsoleApp
{
    class Program
    {
        public static string text = "The last time you had a cheeseburger was too long ago. Try not to drool when you think about the slightly charred, " +
            "medium-rare meat nestled between soft brioche, cradled in crisp iceberg lettuce and flavour amplifying condiments. Why are you still reading this- go get a cheeseburger.";

        public static void Main()
        {
            string path = @"D:\Development\OwainCodes_Blogs\testFile.txt";
            var output = new OutputFile(path, text);

        }
      
    }
}