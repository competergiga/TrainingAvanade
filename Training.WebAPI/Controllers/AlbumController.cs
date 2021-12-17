using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Training.Application.Albums;

namespace Training.WebAPI.Controllers
{


    [ApiController]
 
    [Route("api/[controller]")]
    public class AlbumController : Controller
    {


        private readonly IAlbumService _albumService;


        public AlbumController(IAlbumService bookService)
        {
            _albumService = bookService;
        }


        [HttpGet]
        public IActionResult Get()
        {
            var albums = _albumService.Get();

            return Ok(albums);
        }

        [HttpPost]
        public IActionResult Post(AlbumDto album)
        {
            _albumService.Create(album);

            return Ok();
        }
    }
}
