namespace JobRoom.Application.ViewModels.JobCategory
{
    public class JobCategoryViewModel
    {
        public short Id { get; set; }
        /// <summary>
        /// عنوان دسته بندی شغلی
        /// </summary>
        public string Title { get; set; }
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
        /// <summary>
        /// تعداد شغل های این دسته بندی
        /// </summary>
        public long CountJobs { get; set; }
        public short ParentId { get; set; }
        public string CreationDate { get; set; }
    }
}
