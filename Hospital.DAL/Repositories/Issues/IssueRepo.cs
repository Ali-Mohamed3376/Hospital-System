using Hospital.DAL.Data.Context;
using Hospital.DAL.Data.Models;
using Hospital.DAL.Repositories.Generic;

namespace Hospital.DAL.Repositories.Issues
{
    public class IssueRepo : GenericRepo<Issue>, IIssuesRepo
    {
        private readonly HospitalContext context;

        public IssueRepo(HospitalContext context) : base(context)
        {
            this.context = context;
        }

        public Issue? GetIssueByName(string name)
        {
            return context.Set<Issue>().FirstOrDefault(i => i.Name == name);
        }
    }
}
