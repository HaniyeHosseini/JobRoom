using System;
using System.Collections.Generic;

#nullable disable

namespace JobRoom.Domain.Job
{
    public  class Job
    {
        public long Id { get; set; }
        public short CategoryId { get; set; }
        public long CompanyId { get; set; }
        public string Title { get; set; }
        public byte Type { get; set; }
        public DateTime CreationDateTime { get; set; }
        public DateTime ConfirmDateTime { get; set; }
        public int LocationStateId { get; set; }
        public int LocationCityId { get; set; }
        public byte? Salary { get; set; }
        public byte? Exprience { get; set; }
        public string Description { get; set; }
        public string Slug { get; set; }

        public virtual JobCategory Category { get; set; }
    }
}
