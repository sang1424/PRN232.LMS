using PRN232.LMS.Repositories.Helpers;
using PRN232.LMS.Services.Models.Requests;
using PRN232.LMS.Services.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN232.LMS.Services.Interfaces
{
    public interface ISubjectService
    {
        Task<PagedResult<SubjectResponse>> GetAllAsync(QueryParameters query);
        Task<SubjectResponse?> GetByIdAsync(int id);
        Task<SubjectResponse> CreateAsync(CreateSubjectRequest request);
        Task<bool> UpdateAsync(int id, UpdateSubjectRequest request);
        Task<bool> DeleteAsync(int id);
    }
}
