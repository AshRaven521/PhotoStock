using Microsoft.AspNetCore.Mvc;
using PhotoStock.Models;
using PhotoStock.Models.UpdatedModels;
using PhotoStock.Services;
using System.Threading.Tasks;

namespace PhotoStock.Controllers
{
    [Route("api/photo")]
    [ApiController]
    public class PhotoController : ControllerBase
    {
        private IPhotoService photoService;


        public PhotoController(IPhotoService photoService)
        {
            this.photoService = photoService;
        }

        [HttpGet("photo-list")]
        public async Task<IActionResult> GetAll()
        {
            var photos = await photoService.GetPhotosAsync();

            return Ok(photos);
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Photo>> GetPhoto(int id)
        {
            var photo = await photoService.GetPhotoByIdAsync(id);
            return Ok(photo);
        }
        [HttpPut("edit-photo")]
        public IActionResult EditPhoto(PhotoUpdatedModel photo)
        {

            if (photo is null)
            {
                return BadRequest();
            }

            photoService.UpdatePhotoAsync(photo);

            return Ok();
        }
    }
}
