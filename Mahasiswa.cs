namespace modul9_1302220002
{
    public class Mahasiswa
    {
        public string Nama { get; set; }
        public string Nim { get; set; }
        public List<String> Course { get; set; }
        public int Year { get; set; }

        public Mahasiswa(String nama, String Nim, List<String> course, int year)
        {
            this.Nama = nama;
            this.Nim = Nim;
            this.Course = course;
            this.Year = year;
        }
    }
}
