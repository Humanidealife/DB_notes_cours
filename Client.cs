using System;
using System.Collections.Generic;
using System.Text;

namespace DB_notes_cours
{
  class Client // Création de l'Objet Client
  {
    // deux attributs de l'Objet Client
    private string _nom;
    private string _prenom;

    // deux Propriétés de l'Objet Client accessibles en lecture getteur et en écriture setteur
    public string Nom
    {
      get { return _nom; }
      set { _nom = value; }
    }


    public string Prenom
    {
      get { return _prenom;}
      set { _prenom = value;}
    }

    // Un Consctructeur qui permet de créer les Propriétés nom et prenom à l'instanciation de l'Objet Client
    public Client(string nom, string prenom)
    {
      this._nom = nom;
      this._prenom = prenom;
    }

    // un Constructeur par défaut qui ne possède rien pour instancier un Objet sans valeur
    public Client() {}

    // une simple Méthode public information qui présente une information sur l'Objet Client
    public void Information()
    {
      Console.WriteLine("Bonjour je m'appelle : " + _nom + " " + _prenom);
    }
  }
}
