public class Book
{
    // veri tabanı tablosu yerine geçecek tip!!
    public int Id { get; set; }
    public string Name { get; set; }
    public int Price { get; set; }

    public int Stock { get; set; }

    // dotnet ef migrations add InitialCreate       


    / 
    // dotnet tool install --global dotnet-ef --version 9.*
}