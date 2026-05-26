using PRN232.LMS.Repositories.BusinessModels;
using PRN232.LMS.Repositories.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN232.LMS.Repositories.Interfaces
{
    public interface ISubjectRepository
    {
        Task<PagedResult<SubjectBusinessModel>> GetAllAsync(QueryParameters query);
        Task<SubjectBusinessModel?> GetByIdAsync(int id);
        Task<SubjectBusinessModel> CreateAsync(SubjectBusinessModel model);
        Task<bool> UpdateAsync(SubjectBusinessModel model);
        Task<bool> DeleteAsync(int id);
    }
}
