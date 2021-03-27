using System;
using System.IO;


namespace ProjectSingleton
{
    // Klasa do pracy z tekstem.Zapisywanie zmian w pliku
    // jest wykonywane tylko przy zapytaniu Save.
    // Do tego czasu zmiany są przechowywane w stercie.
    public sealed class FileWierszSingleton
    {

        // Prywatne pole statyczne klasy, które przechowuje pojedynczą instancję
        // klasy singleton. Inicjalizacja instancji odbywa się leniwie(lazy) - to znaczy
        // zostanie wykonane tylko przy pierwszym wywołaniu.
        // Również ta konstrukcja gwarantuje, że przy dostępie z wielu wątków będzie
        // tworzona tylko jedna instancja klasy.

        private static readonly Lazy<FileWierszSingleton> instance =
            new Lazy<FileWierszSingleton>(() => new FileWierszSingleton());

        // Właściwość publiczna umożliwiająca dostęp do instancji klasy Singleton
        public static FileWierszSingleton Instance { get { return instance.Value; } }
        //Ścieżka do pliku
        public string FilePath { get; }

        //Zawartość pliku
        public string Text { get; private set; }

        //Funkcja tworzy nowy plik do pracy z tekstem
       private FileWierszSingleton()
        {
            FilePath = "test2.txt";
            ReadTextFromFile();
        }

        
        //Funkcja dodania tekstu do pliku
        
        public void WriteText(string text)
        {
            Text += text;
        }
        //Funkcja zapisywania tekstu do pliku
        public void Save()
        {
            using (var writer = new StreamWriter(FilePath, false))
            {
                writer.WriteLine(Text);
            }
        }

        //Odczytywanie danych z pliku
        private void ReadTextFromFile()
        {
            if (!File.Exists(FilePath))
            {
                Text = "";
            }
            else
            {
                using (var reader = new StreamReader(FilePath))
                {
                    Text = reader.ReadToEnd();
                }
            }
        }
    }
}
