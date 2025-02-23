
using Newtonsoft.Json;
namespace Çalısma_Projeleri;
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter your customer type.");
            Console.WriteLine("Normal(N)\nStudent(S)\nVeteran(V)");
            var userInput = Console.ReadLine();
            userInput = userInput.ToUpper();
            Console.WriteLine("Which book do you want to view?");
            ;

            string filePath = "BooksInfo.json";
            //string filePath = Path.Combine(Directory.GetCurrentDirectory(), "BooksInfo.json");
            Console.WriteLine($"Current directory: {Directory.GetCurrentDirectory()}");
            List<Book> books = new List<Book>();
            if (File.Exists(filePath))
            {
                string jsonContent = File.ReadAllText(filePath);

                books = JsonConvert.DeserializeObject<List<Book>>(jsonContent);
            }
            if (File.Exists(filePath))
            {

                string jsonContent = File.ReadAllText(filePath);


                books = JsonConvert.DeserializeObject<List<Book>>(jsonContent);


                if (books != null)
                {
                    foreach (var book in books)
                    {
                        Console.WriteLine(book.Title);
                    }
                }
                else
                {
                    Console.WriteLine("No books found in the JSON.");
                }
            }
            else
            {
                Console.WriteLine("BooksInfo.json file does not exist.");
            }
            var userInput2 = Console.ReadLine();
            var selectedBook = books.Find(b => b.Title.Equals(userInput2, StringComparison.OrdinalIgnoreCase));
            if (selectedBook != null)
            {
                Console.WriteLine("\nDetails of the book which you choose");
                Console.WriteLine($"Title: {selectedBook.Title}");
                Console.WriteLine($"Author: {selectedBook.Author}");
                Console.WriteLine($"Year: {selectedBook.PublicationYear}");
                Console.WriteLine($"Type: {selectedBook.Type}");
                Console.WriteLine($"Page Count: {selectedBook.PageCount}");
                Console.WriteLine($"Cost: {selectedBook.Cost}$");
                Console.WriteLine($"Description: {selectedBook.Description}");
            }
            else
            {
                Console.WriteLine("The book which you choose does not exist.");
            }

            Console.WriteLine("Do you want to buy this book? If yes press (B), else press (X)");
            var userInput3 = Console.ReadLine();
            userInput3 = userInput3.ToUpper();
            if (userInput3 == "B")
            {
                if (userInput == "N")
                {
                    Console.WriteLine("If you have normal membership you have no discount");
                    var price = selectedBook.Cost;
                    Console.WriteLine("The price does not changed. Price is = {0:C}$", price);
                }
                else if (userInput == "S")
                {
                    Console.WriteLine("If you have student membership you have %20 discount");
                    var price = selectedBook.Cost * 80 / 100;
                    Console.WriteLine("The new price is {0:C}$", price);
                }
                else if (userInput == "V")
                {
                    Console.WriteLine("If you have veteran membership you have %10 discount");
                    var price = selectedBook.Cost * 90 / 100;
                    Console.WriteLine("The new price is {0:C}$", price);
                }
                else
                {
                    Console.WriteLine("The membership type does not exist.");
                }
            }
            else if (userInput3 == "X")
            {
                Console.WriteLine("Returning to menu.");

            }
            else
            {
                Console.WriteLine("You pressed an invalid key.");
            }
        }
    }


