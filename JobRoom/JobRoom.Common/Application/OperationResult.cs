using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobRoom.Common.Application
{
    public class OperationResult
    {
        /// <summary>
        /// ایا عملیات انجام شد؟
        /// </summary>
        private bool IsSuccedded { get; set; }
        /// <summary>
        /// پیغام این عملیات
        /// </summary>
        private string Message { get; set; }

        public OperationResult()
        {
            IsSuccedded = false;
        }
        /// <summary>
        /// عملیات انجام شد
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public OperationResult Succedded(string message = "عملیات با موفقیت انجام شد")
        {
            IsSuccedded = true;
            Message = message;
            return this;
        }
        /// <summary>
        /// عملیات شکست خورد
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public OperationResult Failed(string message)
        {
            IsSuccedded = false;
            Message = message;
            return this;
        }
       
    }
}
