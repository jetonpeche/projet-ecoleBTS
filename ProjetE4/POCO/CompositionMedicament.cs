
namespace ProjetE4
{
    class CompositionMedicament
    {
        private string _id;
        private string _nomComposant;

        public string Id { get => _id; set => _id = value; }
        public string NomComposant { get => _nomComposant; set => _nomComposant = value; }

        public CompositionMedicament(string id, string nomComposant)
        {
            Id = id;
            NomComposant = nomComposant;
        }

        public string RecupereId()
        {
            return Id;
        }

        public override string ToString()
        {
            return NomComposant;
        }


    }
}
