using IteratorBooks.Elements;

var biblio = new Library();
var iterator = biblio.CreateIterator();

while (iterator.HasNext())
{
    var book = iterator.Next();
    Console.WriteLine($"Title:{book.Title} written by {book.Author}");
}