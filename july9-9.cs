using System;
 using System.IO;

namespace july9
{
    
            class WordSearch
{
    public static void Main()
    {
        
        FileStream inFile = new FileStream(@"C:\Users\dpladmin\Documents\Document1.txt", FileMode.Open, FileAccess.Read);
        StreamReader reader = new StreamReader(inFile);
        string record;
        string input;
        Console.Write("Enter the word to search in the file :\n");
        input = Console.ReadLine();
        try
        {

            record = reader.ReadLine();
            while (record != null)
            {
                
                if (record.Contains(input))
                {
                    Console.WriteLine(record);
                }

                record = reader.ReadLine();

            }
        }
        finally
        {
            
            reader.Close();
            inFile.Close();
        }


        Console.ReadLine();
    }
} 

        }
        
    

