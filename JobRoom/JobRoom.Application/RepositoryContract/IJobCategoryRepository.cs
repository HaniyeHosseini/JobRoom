using JobRoom.Application.ViewModels.JobCategory;
using JobRoom.Domain;
using JobRoom.Domain.Job;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobRoom.Application.RepositoryContract
{
    public interface IJobCategoryRepository : IRepositoryBase<short, JobCategory>
    {
        EditJobCategoryViewModel GetDeatails(short id);
        List<JobCategoryViewModel> GetJobCategories(JobCategorySearchModel model);
    }
}
