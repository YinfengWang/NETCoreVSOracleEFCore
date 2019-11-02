using App.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Data.EntityConfig
{
    /// <summary>
    /// 发送报告的中间表
    /// </summary>
    public class ReportDataEntityConfig : IEntityTypeConfiguration<MNIS_T_REPORT_DATA>
    {
        public void Configure(EntityTypeBuilder<MNIS_T_REPORT_DATA> builder)
        {
            builder.HasKey(t => t.ID).HasName("ID");
        }
    }
}
