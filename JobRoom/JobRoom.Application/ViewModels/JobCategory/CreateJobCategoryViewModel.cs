using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobRoom.Application.ViewModels.JobCategory
{
    public class CreateJobCategoryViewModel
    {
        /// <summary>
        /// عنوان دسته بندی شغلی
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// پدر این دسته بندی
        /// </summary>
        public short? ParentId { get; set; }
        /// <summary>
        /// اسلاگ
        /// </summary>
        public string Slug { get; set; }
        /// <summary>
        /// مسیر عکس این دسته بندی
        /// </summary>
        public string Picture { get; set; }
        /// <summary>
        /// alt عکس این دسته بندی
        /// </summary>
        public string PictureAlt { get; set; }
        /// <summary>
        /// title عکس این دسته بندی
        /// </summary>
        public string PictureTitle { get; set; }
        /// <summary>
        /// توضیحات مربوط به دسته بندی شغلی
        /// </summary>
        public string Description { get; set; }
    }
}
