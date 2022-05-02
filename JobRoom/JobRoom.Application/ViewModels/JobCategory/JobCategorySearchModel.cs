namespace JobRoom.Application.ViewModels.JobCategory
{
    public class JobCategorySearchModel
    {
        /// <summary>
        /// عنوان دسته بندی شغلی
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// پدر این دسته بندی
        /// </summary>
        public short? ParentId { get; set; }
    }
}
