// See https://aka.ms/new-console-template for more information
using EFCoreMigrations.Model;

class Operations
{
    public static void List()
    {
        using var dbCtx = new ApplicationDbContext();
        foreach (var item in dbCtx.Blogs)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("--- finished ---");
    }
}