using Microsoft.AspNetCore.Mvc;
using tpmodul10_103022300094.Models;
using System.Collections.Generic;

namespace tpmodul10_103022300094.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MahasiswaController : ControllerBase
    {
        private static List<Mahasiswa> ListMahasiswa = new List<Mahasiswa>
        {
            new Mahasiswa { Nama = "Syarif", Nim = "103022300094" },
            new Mahasiswa { Nama = " M. Hafizh Al Kautsar", Nim = "103022300069 " },
            new Mahasiswa { Nama = " Bintang Anugrah Pratama", Nim = "103022300058 " },
            new Mahasiswa { Nama = " Hizkia Nicander Budiyanto", Nim = "103022300127 " },
            new Mahasiswa { Nama = " Albert Febrian", Nim = "103022300003 " }
        };

        [HttpGet]
        public ActionResult<IEnumerable<Mahasiswa>> Get()
        {
            return ListMahasiswa;
        }

        [HttpGet("{index}")]
        public ActionResult<Mahasiswa> Get(int index)
        {
            if (index < 0 || index >= ListMahasiswa.Count)
                return NotFound();
            return ListMahasiswa[index];
        }

        [HttpPost]
        public ActionResult Post([FromBody] Mahasiswa mhs)
        {
            ListMahasiswa.Add(mhs);
            return Ok();
        }

        [HttpDelete("{index}")]
        public ActionResult Delete(int index)
        {
            if (index < 0 || index >= ListMahasiswa.Count)
                return NotFound();
            ListMahasiswa.RemoveAt(index);
            return Ok();
        }
    }
}