using System;
using System.Collections.Generic;

#nullable disable

namespace JobRoom.Domain.Job
{
    public class JobCategory
    {
        public JobCategory()
        {

        }

        public JobCategory(string title, short? parentId, string slug, string picture, string pictureAlt, string pictureTitle, string description)
        {
            Title = title;
            ParentId = parentId;
            Slug = slug;
            Picture = picture;
            PictureAlt = pictureAlt;
            PictureTitle = pictureTitle;
            Description = description;
            CreationDate = DateTime.Now;
            InverseParent = new HashSet<JobCategory>();
            Jobs = new HashSet<Job>();
        }

        public short Id { get; private set; }
        /// <summary>
        /// عنوان دسته بندی شغلی
        /// </summary>
        public string Title { get; private set; }
        /// <summary>
        /// پدر این دسته بندی
        /// </summary>
        public short? ParentId { get; private set; }
        /// <summary>
        /// اسلاگ
        /// </summary>
        public string Slug { get; private set; }
        /// <summary>
        /// مسیر عکس این دسته بندی
        /// </summary>
        public string Picture { get; private set; }
        /// <summary>
        /// alt عکس این دسته بندی
        /// </summary>
        public string PictureAlt { get; private set; }
        /// <summary>
        /// title عکس این دسته بندی
        /// </summary>
        public string PictureTitle { get; private set; }
        /// <summary>
        /// توضیحات مربوط به دسته بندی شغلی
        /// </summary>
        public string Description { get; private set; }
        public DateTime CreationDate { get;private set; }

        public virtual JobCategory Parent { get; private set; }
        public virtual ICollection<JobCategory> InverseParent { get; private set; }
        public virtual ICollection<Job> Jobs { get; private set; }
    }
}
