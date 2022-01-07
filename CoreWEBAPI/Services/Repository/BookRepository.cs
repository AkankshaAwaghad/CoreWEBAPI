using CoreWEBAPI.Models;
using CoreWEBAPI.Services.IRepository;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace CoreWEBAPI.Services.Repository
{
    public class BookRepository : IBookRepository
    {
        private readonly esankal1_finacctaxContext _esankal1_finacctaxContext;
        public BookRepository(esankal1_finacctaxContext esankal1_finacctaxContext)
        {
            _esankal1_finacctaxContext= esankal1_finacctaxContext;
        }

        public async Task<TblBookConsultation>AddBookConsultation(TblBookConsultation TblBookConsultation)
        {
            _esankal1_finacctaxContext.TblBookConsultations.Add(TblBookConsultation);
            await _esankal1_finacctaxContext.SaveChangesAsync();
            return TblBookConsultation;
        }

        public async Task<TblBookConsultation> DeleteBookConsultation(int ID)
        {
            var result =await _esankal1_finacctaxContext.TblBookConsultations.FirstOrDefaultAsync (x => x.Id==ID);
            if (result==null)
            {
                return null;
            }
            _esankal1_finacctaxContext.TblBookConsultations.Remove(result);
            _esankal1_finacctaxContext.SaveChangesAsync();
            return result;
        }

        public async Task<IEnumerable<TblBookConsultation>> GetBookConsultation()
        {
            var BookList=await _esankal1_finacctaxContext.TblBookConsultations.ToListAsync();
            return BookList;
        }

        public async Task<TblBookConsultation> GetBookConsultation(int ID)
        {
            var result= await _esankal1_finacctaxContext.TblBookConsultations.FirstOrDefaultAsync(x => x.Id==ID);
            if (result==null) 
            {
                return null;
            }
            return result;
        }

        public async Task<TblBookConsultation> UpdateBookConsultation(TblBookConsultation TblBookConsultation)
        {
            _esankal1_finacctaxContext.TblBookConsultations.Update(TblBookConsultation);
            await _esankal1_finacctaxContext.SaveChangesAsync();
            return TblBookConsultation;
        }
    }
}
