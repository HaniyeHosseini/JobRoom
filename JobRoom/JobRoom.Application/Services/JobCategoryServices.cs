using JobRoom.Application.RepositoryContract;
using JobRoom.Application.ServiceContract;
using JobRoom.Application.ViewModels.JobCategory;
using JobRoom.Common.Application;
using JobRoom.Domain.Job;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobRoom.Application.Services
{
    public class JobCategoryServices : IJobCategoryServices
    {
        private readonly IJobCategoryRepository _repository;

        public JobCategoryServices(IJobCategoryRepository repository)
        {
            _repository = repository;
        }

        public OperationResult Create(CreateJobCategoryViewModel entiti)
        {
            var operation = new OperationResult();
            if (_repository.Exist(x => x.Title == entiti.Title))
              return  operation.Failed(ApplicationMessages.DuplicatedRecord);

            var category = new JobCategory(entiti.Title, entiti.ParentId, entiti.Slug, entiti.Picture, entiti.PictureAlt,
                               entiti.PictureTitle, entiti.Description);
            _repository.Create(category);
            return operation.Succedded();
        }

        public OperationResult Edit(EditJobCategoryViewModel entiti)
        {
            var operation = new OperationResult();
         

            return operation.Succedded();

        }

        public EditJobCategoryViewModel GetDeatails(short id)
        {
            throw new NotImplementedException();
        }

        public List<JobCategoryViewModel> GetJobCategories(JobCategorySearchModel model)
        {
            throw new NotImplementedException();
        }
    }
}
