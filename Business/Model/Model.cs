using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Model
{
    public class Model
    {
        public long ID { get; set; }

        public string StrID
        {
            get { return ID.ToString(); }
            set { ID = string.IsNullOrEmpty(value) ? 0 : Convert.ToInt64(value); }
        }

        public DateTime CreateDateTime { get; set; }
    }
}
