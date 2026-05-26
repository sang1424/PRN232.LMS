using PRN232.LMS.Repositories.BusinessModels;
using PRN232.LMS.Repositories.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN232.LMS.Repositories.Interfaces
{
    public interface ICourseRepository
    {
        Task<PagedResult<CourseBusinessModel>> GetAllAsync(QueryParameters query);
        Task<CourseBusinessModel?> GetByIdAsync(int id);
        Task<CourseBusinessModel> CreateAsync(CourseBusinessModel model);
        Task<bool> UpdateAsync(CourseBusinessModel model);
        Task<bool> DeleteAsync(int id);
    }
}
