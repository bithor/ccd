namespace ccd {

    public class Inventory {

        public Item[] Items;
        public int Storlek;

        public Inventory(int storlek) {
            Storlek = storlek;
            Items = new Item[Storlek];
        }

        public override string ToString(){
            return $"Namn: {Items[0].Namn}, Besk: {Items[0].Besk}";
        }
    }
}