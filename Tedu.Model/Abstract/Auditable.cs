﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Tedu.Model.Abstract
{
    public abstract class Auditable : IAuditable
    {
        public DateTime? CreadtedDate { set; get; }

        [MaxLength(256)]
        public string CreatedBy { set; get; }

        public DateTime? UpdatedDate { set; get; }

        [MaxLength(256)]
        public string UpdatedBy { set; get; }

        [MaxLength(256)]
        public string MetaKeyword { set; get; }

        [MaxLength(256)]
        public string MetaDescription { set; get; }

        public bool Status { set; get; }
    }
}