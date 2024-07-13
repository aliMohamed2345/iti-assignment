using System;

class Program {
  class Book{
    static int bookBought = 0 ; 
  private int Id ;
  private string name ; 
  private string Type ;
  private float Price ;
  private DateTime createdOn ;
  private bool IsDeleted ;
static  Book(){
  Console.WriteLine("Static Constructor");
}
    public Book(int id)
    {
        this.Id = id;
        this.createdOn = DateTime.Now;
     
    }

    public Book(int id, string name) : this(id)
    {
        this.name = name;
      this.createdOn = DateTime.Now;
      bookBought++;
      Console.WriteLine(bookBought);
    }

    public Book(int id, string name, string type) : this(id, name)
    {
      this.createdOn = DateTime.Now;
      this.Type = type;
      bookBought++;
      Console.WriteLine(bookBought);
    }

    public Book(int id, string name, string type, float price) : this(id, name, type)
    {
      this.createdOn = DateTime.Now;
        this.Price = price;
      bookBought++;
      Console.WriteLine(bookBought);
    }
  public string getBookData(){
    return $"the name of the book is {this.name},and it's id is {Id},and it's type is {Type},and it's price is {Price},and it's created on is {createdOn}";
  }
    public int NumberOfBoughtBooks(){
      return bookBought ;
    }
    public bool Delete(){
      Console.WriteLine(IsDeleted);
      return !IsDeleted; 
      Console.WriteLine(IsDeleted);
    }
  }
  
  public static void Main (string[] args) {
    Book book1 = new Book(1);
    Book book2 = new Book(2, "Book Name");
    Book book3 = new Book(3, "Book Name", "Fiction");
    Book book4 = new Book(4, "Book Name", "Fiction", 29.99f);

    Console.WriteLine(book4.getBookData());
    Console.WriteLine(book1.NumberOfBoughtBooks());
    Console.WriteLine(book1.Delete()); 
    }
  
}
