using system;
namespace ResponsiPemograman
{

    internal class Program
    {

        public static void Main(string[] args)
        {
            Dosen dosen = new Dosen();

            dosen.attDosen("Mr. Bayu Enka", 999999999);
            dosen.addCourse("Pemograman");
            dosen.me();
        }
    }
}