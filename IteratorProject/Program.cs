using System;

namespace IteratorProject
{
    class Program
    {
        static void Main(string[] args)
        {
            ///jest klasa czytelników, którzy chcą uzyskać informacje o książkach znajdujących się w bibliotece. 
            ///W tym celu musimy iterować po obiektach za pomocą iteratora
            Library library = new Library();
            Reader reader = new Reader();
            reader.SeeBooks(library);

            Console.Read();
        }
    }

    class Reader
    {
        public void SeeBooks(Library library)
        {
            IBookIterator iterator = library.CreateNumerator();
            while (iterator.HasNext())
            {
                Book book = iterator.Next();
                Console.WriteLine(book.Name);
            }
        }
    }
    /// <summary>
    /// Interfejs IBookIterator reprezentuje iterator. 
    /// Rola interfejsu agregatu złożonego jest reprezentowana przez typ IBookNumerable. 
    /// Klientem jest tutaj klasa Reader, która używa iteratora do przechodzenia przez obiekt biblioteki.
    /// </summary>
    interface IBookIterator
    {
        bool HasNext();
        Book Next();
    }
    interface IBookNumerable
    {
        IBookIterator CreateNumerator();
        int Count { get; }
        Book this[int index] { get; }
    }
    class Book
    {
        public string Name { get; set; }
    }

    class Library : IBookNumerable
    {
        private Book[] books;
        public Library()
        {
            books = new Book[]
            {
            new Book{Name="Wojna i pokój"},
            new Book {Name="Trzy Siostry"},
            new Book {Name="Zbrodnia i kara"}
            };
        }
        public int Count
        {
            get { return books.Length; }
        }

        public Book this[int index]
        {
            get { return books[index]; }
        }
        public IBookIterator CreateNumerator()
        {
            return new LibraryNumerator(this);
        }
    }
    class LibraryNumerator : IBookIterator
    {
        IBookNumerable aggregate;
        int index = 0;
        public LibraryNumerator(IBookNumerable a)
        {
            aggregate = a;
        }
        public bool HasNext()
        {
            return index < aggregate.Count;
        }

        public Book Next()
        {
            return aggregate[index++];
        }
    }
}
