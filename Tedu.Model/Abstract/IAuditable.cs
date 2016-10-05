using System;

namespace Tedu.Model.Abstract
{
    public class IAuditable
    {
        DateTime? CreadtedDate { set; get; }
        string CreatedBy { set; get; }
        DateTime? UpdatedDate { set; get; }
        string UpdatedBy { set; get; }

        string MetaKeyword { set; get; }
        string MetaDescription { set; get; }

        bool Status { get; set; }
    }
}