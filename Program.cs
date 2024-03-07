// See https://aka.ms/new-console-template for more information
using System;
using System.IO; // Permet d'utiliser les clas StreamWriter et StreamReader
using System.Collections.Generic;
using System.Text;

namespace DB_notes_cours
{
  class Program
  {
    static void Main(string[] args)
    {
      using (StreamWriter sw = new StreamWriter("f:\\WANG\\Informatique\\Skilleos\\Cours\\Développer des applications en C#\\test.txt"))// si l'on ne précise pas le chemin, cela va créer un fichier dans le dossier du projet
      {
        sw.WriteLine("Mon premier texte.");
      }
      Console.ReadKey();
    }
  }
}
