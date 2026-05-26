using PRN232.LMS.Repositories.BusinessModels;
using PRN232.LMS.Repositories.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN232.LMS.Repositories.Interfaces
{
    public interface IEnrollmentRepository
    {
        Task<PagedResult<EnrollmentBusinessModel>> GetAllAsync(QueryParameters query);
        Task<EnrollmentBusinessModel?> GetByIdAsync(int id);
        Task<EnrollmentBusinessModel> CreateAsync(EnrollmentBusinessModel model);
        Task<bool> UpdateAsync(EnrollmentBusinessModel model);
        Task<bool> DeleteAsync(int id);
    }
}
