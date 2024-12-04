using Microsoft.EntityFrameworkCore;


// Database'i oluşturalım


// BookDbContext bizim databasimizdir!!

// bir sınıfın databaee olması için, DbContext isimli sınıftan kalıtım alması gerekmektedir.
public class BooksDbContext : DbContext
{

    // book isimli sınıfı tablo olarak şekilde verelim!!
    public DbSet<Book> Books { get; set; }

    
    // Parametre olarak alacağı connection stringm bilgisini, base sınıfa iletmesi için base ctor'u çağırdık!!
    public BooksDbContext(DbContextOptions<BooksDbContext> options) : base(options)
    {

    }

}