namespace Mod9_1302210110
{
    public class Mahasiswa
    {

        public String nama { get; set; }



        public int nim { get; set; }



        public List<String> Course { get; set; }



        public int Year { get; set; }



        public Mahasiswa(string v, int nim, int Year, List<string> Course) { 
            this.nama = v;
            this.nim = nim;
            this.Course = Course;
            this.Year = Year;   
        }

        

     
    }
}
