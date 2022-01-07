using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using CoreWEBAPI.Services.IRepository;
using CoreWEBAPI.Models;

namespace CoreWEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookAPIController : ControllerBase
    {
        private readonly IBookRepository _BookRepository;
        public BookAPIController(IBookRepository BookRepository)
        {
            _BookRepository=BookRepository;
        }
        [HttpGet]
        public async Task<IActionResult>GetBookConsultation()
        {
            var result = await _BookRepository.GetBookConsultation();
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> AddBookConsultation(TblBookConsultation TblBookConsultation)
        {
            
              var result =await _BookRepository.AddBookConsultation(TblBookConsultation);
                return Ok(result);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateBookConsultation(TblBookConsultation TblBookConsultation)
        {
           var result= await _BookRepository.UpdateBookConsultation(TblBookConsultation);
            return Ok(result);
            }
         
        [HttpDelete]
         public async Task<IActionResult> DeleteBookConsultation(int ID)
         { 
            var result = await _BookRepository.DeleteBookConsultation(ID);
               return Ok(result);
          }
    }
}
