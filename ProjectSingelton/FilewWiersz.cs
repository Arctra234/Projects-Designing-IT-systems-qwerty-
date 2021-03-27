using System;
using System.IO;


namespace ProjectSingleton
{
    // Klasa do pracy z tekstem.Zapisywanie zmian w pliku
    // jest wykonywane tylko przy zapytaniu Save.
    // Do tego czasu zmiany są przechowywane w stercie.
    public class FilewWiersz
    {

        //Ścieżka do pliku
        public string FilePath { get; }

        //Zawartość pliku
        public string Text { get; private set; }

        //Funkcja tworzy nowy plik do pracy z tekstem
       public FilewWiersz()
        {
            FilePath = "test.txt";
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
