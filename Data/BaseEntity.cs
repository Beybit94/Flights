using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    /// <summary>
    /// Base Entity
    /// </summary>
    public abstract class BaseEntity
    {
        /// <summary>
        /// Identificator
        /// </summary>
        public long ID { get; set; }

        /// <summary>
        /// Creation date-time
        /// </summary>
        public DateTime CreateDateTime { get; set; }
    }
}
