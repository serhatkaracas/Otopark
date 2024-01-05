namespace Siniflar
{
    public class ParkYeri : TemelSinif
    {
        public int park_yeri_no { get; set; }
        public string otopark_no { get; set; }
        public string Doluluk { get; set; }
        public string kullanici { get; set; }
        public override void Tanit()
        {
            Console.WriteLine($"Park Yeri No: {park_yeri_no}");
        }
    }

}
