using System;


namespace Week10
{
    public abstract class FileWorker
    {
        public double maxSize = 128;
        public abstract string Extension { get; set; }

        public virtual void Read() 
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("I can read from ");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(Extension);

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" file with max storage ");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(maxSize);
            Console.ForegroundColor = ConsoleColor.White;
        }
        public virtual void Write() 
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("I can write to ");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(Extension);

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" file with max storage ");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(maxSize);
            Console.ForegroundColor = ConsoleColor.White;
        }
        public virtual void Edit() 
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("I can edit ");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(Extension);

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" file with max storage ");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(maxSize);
            Console.ForegroundColor = ConsoleColor.White;
        }
        public virtual void Delete() 
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("I can delete from ");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(Extension);

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" file with max storage ");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(maxSize);
            Console.ForegroundColor = ConsoleColor.White;
        }

    }
}
