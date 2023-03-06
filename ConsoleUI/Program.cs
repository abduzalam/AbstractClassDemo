using DemoLibrary;

public class Program
{
    private static void Main(string[] args)
    {
        List<IDataAccess> databases = new List<IDataAccess>()
        {
            new SqlDataAccess(),
            new SqliteDataAccess()
        };

        foreach(var db in databases)
        {
            db.LoadConnectionString("demo");
            db.LoadData("Select * from table");
            db.SaveData("insert into table");
        }
        Console.ReadLine();
    }
}