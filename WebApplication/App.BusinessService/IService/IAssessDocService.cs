
using App.Data.Entity;
using System;
using System.Linq;

namespace App.BusinessService.IService
{
    public interface IAssessDocService
    {
        IQueryable<DOC_RECORDS> Get();
        DOC_RECORDS GetById(String id);
        void Insert(DOC_RECORDS entity);
        void Update(DOC_RECORDS entity);
        void Delete(DOC_RECORDS entity);
        object ProductPDF(string recID);
    }
}
