using Hospital.DAL.Data.Models;
using Hospital.DAL.Repositories.Generic;

namespace Hospital.DAL.Repositories.Issues
{
    public interface IIssuesRepo : IGenericRepo<Issue>
    {
        Issue? GetIssueByName(string name);
    }
}
