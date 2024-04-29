using Microsoft.AspNetCore.Mvc;

namespace modul9_1302220002.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MahasiswaController : ControllerBase
    {
        private static List<String> CourseList = new List<String> {
            "KPL", "PBO", "BASDAT"
        };
        private static List<Mahasiswa> mahasiswaList = new List<Mahasiswa> {
            new Mahasiswa("Fionadhilla Gustriani", "1302220002", CourseList, 2023),
            new Mahasiswa("Asy-Syifa Ekhar Nanda Kautsar", "1302223029", CourseList, 2023),
            new Mahasiswa("Febry Twenido Firmanio", "1302220084", CourseList, 2023),
            new Mahasiswa("Henri Silas Samban", "1302220087", CourseList, 2023),
            new Mahasiswa("Indra Mahesa", "1302220067", CourseList, 2023)
        };


        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return mahasiswaList;
        }


        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return mahasiswaList[id];
        }

        [HttpPost]
        public ActionResult Post([FromBody] Mahasiswa mahasiswa)
        {
            mahasiswaList.Add(mahasiswa);
            return CreatedAtAction(nameof(Get), new { id = mahasiswaList.IndexOf(mahasiswa) }, mahasiswa);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            mahasiswaList.RemoveAt(id);
            return NoContent();
        }
    }
}
