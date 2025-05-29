namespace Practice3.Task4
{
    internal class Book
    {
        public string name { get; }
        public string author { get; }
        public string yearCreateBook { get; }

        public Book(string name)
        {
            this.name = name;
        }
        public Book(string name, string author)
        {
            this.name = name;
            this.author = author;
        }
        public Book(string name, string author, string year)
        {
            this.name = name;
            this.author = author;
            this.yearCreateBook = year;
        }

    }
}
