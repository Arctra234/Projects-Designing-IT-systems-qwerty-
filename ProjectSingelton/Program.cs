using System;

namespace ProjectSingleton
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sprawdzanie standardowej implementacje.
            // Możena stworzyć wiele instancji klasy
            // które będą mędzy sobą konfliktować.

            var text1 = new FilewWiersz();
            var text2 = new FilewWiersz();

            text1.WriteText("Ala ma kota, a kot ma Alę");
            text2.WriteText("i żyć bez siebie nie mogą wcale");

            text1.Save();
            text2.Save();

            var singleton1 = FileWierszSingleton.Instance;
            var singleton2 = FileWierszSingleton.Instance;

            // var singleton = new FileWierszSingleton(); // Nie można stworzyć nowej instancji Singleton 

            singleton1.WriteText("Ala ma kota, a kot ma Alę");
            singleton2.WriteText("i żyć bez siebie nie mogą wcale");

            singleton1.Save();
            singleton2.Save();
        }
    }
}
