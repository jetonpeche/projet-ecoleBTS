using System;


namespace ProjetE4
{
    public class Famille
    {
        private string _id;
        private string _lib_famille;

        public string Id { get => _id; set => _id = value; }
        public string Lib_famille { get => _lib_famille; set => _lib_famille = value; }

        public Famille(string id, string nom)
        {
            Id = id;
            Lib_famille = nom;
        }

        public string RecupererId()
        {
            
            return Id;
        }

        public override string ToString()
        {
            return Lib_famille;
        }
    }
}
