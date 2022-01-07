using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreWEBAPI.Models;
namespace CoreWEBAPI.Services.IRepository
{
    public interface IBookRepository
    {
        Task<IEnumerable<TblBookConsultation>>GetBookConsultation();
        Task<TblBookConsultation> GetBookConsultation(int ID);
        Task<TblBookConsultation> AddBookConsultation(TblBookConsultation TblBookConsultation);
        Task<TblBookConsultation> UpdateBookConsultation(TblBookConsultation TblBookConsultation);
        Task<TblBookConsultation> DeleteBookConsultation(int ID);
    }
}
