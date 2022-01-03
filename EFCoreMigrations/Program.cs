// See https://aka.ms/new-console-template for more information
using EFCoreMigrations.Model;

Console.WriteLine("Executing!");

var cmdline = Environment.CommandLine;

if (cmdline.Contains("list", StringComparison.OrdinalIgnoreCase))
{
    using var dbCtx = new ApplicationDbContext();
    foreach (var item in dbCtx.Blogs)
    {
        Console.WriteLine(item);
    }

    if (!dbCtx.Blogs.Any())
    {
        Console.WriteLine("no blogs found!");
    }
} 
else if (cmdline.Contains("insert", StringComparison.OrdinalIgnoreCase))
{
    using var dbCtx = new ApplicationDbContext();

    var b = new Blog() { Rating = 4, Url = $"dummy url {DateTime.Now.TimeOfDay}" };
    dbCtx.Blogs.Add(b);

    dbCtx.SaveChanges();
}

Console.WriteLine("--- finished ---");