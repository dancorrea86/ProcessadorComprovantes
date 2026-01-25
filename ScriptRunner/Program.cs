using ProcessadorComprovantes.Application.MoveFiles;

class Program 
{     
    static void Main(string[] args)
    {
        try
        {
            string[] dirs = Directory.GetFiles(@"C:\Users\Daniel\Desktop", "*.pdf");
            Console.WriteLine("The number of files starting with c is {0}.", dirs.Length);
            foreach (string dir in dirs)
            {

                MoveFileUseCase.Renomear(dir);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("The process failed: {0}", e.ToString());
        }

        
    }
}