using System;
using System.Collections.Generic;
using System.Linq;
using App.BusinessService.IService;
using App.Core;
using App.Data.Entity;

namespace App.BusinessService.Service
{
    public class AssessDocService : IAssessDocService
    {
        private IRepository<DOC_RECORDS> docRecordsRepository;
        private IRepository<MNIS_T_REPORT_DATA> reportDataRepository;
        public AssessDocService(IRepository<DOC_RECORDS> docRecordsRepository)
        {
            this.docRecordsRepository = docRecordsRepository;
        }


        public void Delete(DOC_RECORDS entity)
        {
            this.docRecordsRepository.Delete(entity);
        }

        public IQueryable<DOC_RECORDS> Get()
        {
            return docRecordsRepository.Table;
        }

        public DOC_RECORDS GetById(string id)
        {
            return docRecordsRepository.GetById(id);

        }

        public void Insert(DOC_RECORDS entity)
        {
            docRecordsRepository.Insert(entity);
        }

        public object ProductPDF(string recID)
        {
            return new {Name= "11312",Sex="1221" };
        }

        public void Update(DOC_RECORDS entity)
        {
            docRecordsRepository.Update(entity);
        }


    }
}
