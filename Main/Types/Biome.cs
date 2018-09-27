namespace SharpenedMinecraft.Types
{
    public class Biome
    {
        public static Biome Void = new Biome(127);

        public int Id { get; set; }

        public Biome(int id)
        {
            this.Id = id;
        }
    }
}