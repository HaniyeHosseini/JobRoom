using JobRoom.Application.RepositoryContract;
using JobRoom.Application.ViewModels.JobCategory;
using JobRoom.Domain.Job;
using System;
using System.Collections.Generic;
using System.Linq;
using JobRoom.Common.Tools;
using System.Text;
using System.Threading.Tasks;

namespace JobRoom.Persistance.Repository
{
    public class JobCategoryRepository : RepositoryBase<short, JobCategory>, IJobCategoryRepository
    {
        private readonly JobRoomContext _context;

        public JobCategoryRepository(JobRoomContext context) : base(context)
        {
            _context = context;
        }


        public EditJobCategoryViewModel GetDeatails(short id)
        {
            return _context.JobCategories.Select(x => new EditJobCategoryViewModel()
            {
                Id = x.Id,
                Title = x.Title,
                Picture = x.Picture,
                PictureAlt = x.PictureAlt,
                PictureTitle = x.PictureTitle,
                ParentId = x.ParentId,
                Slug = x.Slug,
                Description = x.Description

            }).FirstOrDefault(x => x.Id == id);

        }

        public List<JobCategoryViewModel> GetJobCategories(JobCategorySearchModel model)
        {
            var query = _context.JobCategories.Select(x => new JobCategoryViewModel()
            {
                Id = x.Id,
                Title = x.Title,
                Picture = x.Picture,
                PictureAlt = x.PictureAlt,
                PictureTitle = x.PictureTitle,
                CreationDate = x.CreationDate.ToFarsi(),
                Description = x.Description
            }).ToList();
            if (string.IsNullOrWhiteSpace(model.Title))
                query.Where(x => x.Title.Contains(model.Title));
            if (model.ParentId != 0)
                query.Where(x => x.ParentId == model.ParentId);
            return query.OrderByDescending(x => x.CreationDate).ToList();
        }
    }
}
