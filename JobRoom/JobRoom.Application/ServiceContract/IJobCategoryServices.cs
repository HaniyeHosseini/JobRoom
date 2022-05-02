using JobRoom.Application.ViewModels.JobCategory;
using JobRoom.Common.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobRoom.Application.ServiceContract
{
    public interface IJobCategoryServices
    {
        OperationResult Create(CreateJobCategoryViewModel entiti);
        OperationResult Edit(EditJobCategoryViewModel entiti);
        EditJobCategoryViewModel GetDeatails(short id);
        List<JobCategoryViewModel> GetJobCategories(JobCategorySearchModel model);

    }
}
