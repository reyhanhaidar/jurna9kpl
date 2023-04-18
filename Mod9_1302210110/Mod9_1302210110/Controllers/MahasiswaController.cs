using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Mod9_1302210110.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaController : ControllerBase
    {

        public static int Year = 2019;

        public MahasiswaController() { }

        static List<string> Course = new List<string>()
        {
            new string("pbo"),
            new string("basdar"),
            new string("kpl")
        };

        static List<Mahasiswa> list = new List<Mahasiswa>
        {

            new Mahasiswa("Reyhan",  1302210110, Year, Course),
            new Mahasiswa("Yosua",  1302210126, Year, Course),
            new Mahasiswa("Andry", 1302213005, Year, Course),
            new Mahasiswa("Rafa",  1302210123, Year, Course)
        };



        [HttpGet]
        public IEnumerable<string> Get()
        {
            return (IEnumerable<string>)list;
        }
        [HttpGet("id")]
        public IEnumerable<string> Get(int id)
        {
            return (IEnumerable<string>)list[id];
        }

        [HttpPost]
        public void Post(Mahasiswa lt)
        {
          list.Add(lt);
        }
        [HttpDelete("id")]
        public void Delete(int id)
        {
            list.RemoveAt(id);
        }

    }
}
