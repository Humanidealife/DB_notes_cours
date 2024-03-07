// See https://aka.ms/new-console-template for more information
using System;
using System.IO; // Permet d'utiliser les class StreamWriter et StreamReader
using System.Collections.Generic;
using System.Text;
using System.Text.Json; // cet espace de nom Permet de sérialiser et désérialiser des objets au format text dans un fichier JSON

namespace DB_notes_cours
{
  class Program
  {
    static void Main(string[] args)
    {
      // using (StreamWriter sw = new StreamWriter("test.txt"))// si l'on ne précise pas le chemin, cela va créer un fichier dans le dossier du projet
      // {
      //   sw.WriteLine("Mon texte.");
      // }

      // using (StreamWriter sw = File.AppendText("test.txt")) // Permet d'ajouter du texte à la fin du fichier
      // {
      //   sw.WriteLine("Ligne ajoutée");
      // }

      // Lecture ligne par ligne
      using (StreamReader sr = new StreamReader("test.txt"))
      {
        string Line = null;
        Line = sr.ReadLine();

        while (Line != null)
        {
          Console.WriteLine(Line);
          Line = sr.ReadLine();
        }
      }

      // Lecture de tpout le fichier en une seule fois
      using (StreamReader sr2 = new StreamReader("test.txt"))
      {
        string File = sr2.ReadToEnd();
        Console.WriteLine(File);
      }
      Console.ReadKey();
    }
  }
}
