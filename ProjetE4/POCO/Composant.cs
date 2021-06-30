
namespace ProjetE4
{
    class Composant
    {
        private string _id;
        private string _nomComposant;

        public string Id { get => _id; set => _id = value; }
        public string NomComposant { get => _nomComposant; set => _nomComposant = value; }

        public Composant(string id, string nom)
        {
            Id = id;
            NomComposant = nom;
        }

        public string RecupererId()
        {
            return Id;
        }

        public override string ToString()
        {
            return NomComposant;
        }
    }
}
