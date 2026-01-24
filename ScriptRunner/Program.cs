using FileProcessor;
using System;



class Program 
{     
    static void Main(string[] args)
    {
        try
        {
            // Only get files that begin with the letter "c".
            string[] dirs = Directory.GetFiles(@"C:\Users\Daniel\OneDrive\Desktop", "*.pdf");
            Console.WriteLine("The number of files starting with c is {0}.", dirs.Length);
            foreach (string dir in dirs)
            {

                FileProcessor.GerenciadorDeArquivos.ConcatenarData(dir);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("The process failed: {0}", e.ToString());
        }

        
    }
}