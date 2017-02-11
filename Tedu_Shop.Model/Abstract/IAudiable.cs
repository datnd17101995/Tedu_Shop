using System;

namespace Tedu_Shop.Model.Abstract
{
    public interface IAudiable
    {
        string MetaKeyword { set; get; }
        string MetaDescription { set; get; }
        DateTime? CreatedDate { set; get; }
        string CreatedBy { set; get; }
        DateTime? UpdatedDate { set; get; }
        string UpdatedBy { set; get; }

        bool Status { set; get; }
    }
}