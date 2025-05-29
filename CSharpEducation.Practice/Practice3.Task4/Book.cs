namespace Practice3.Task4
{
    internal class Book
    {
        public string name { get; }
        public string author { get; }

        public Book(string name, string author)
        {
            this.name = name;
            this.author = author;
        }
        public Book()
        {
            this.name = "Программирование на С#";
            this.author = "Васильев А.В.";
        }
    }
}
