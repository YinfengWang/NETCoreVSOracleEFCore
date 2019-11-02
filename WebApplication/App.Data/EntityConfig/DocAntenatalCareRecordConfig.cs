using App.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace App.Data.Mapping
{
    /// <summary>
    /// 产前护理记录表
    /// </summary>
    public class DocAntenatalCareRecordConfig : IEntityTypeConfiguration<DOC_ANTENATAL_CARE_RECORD>
    {
        public void Configure(EntityTypeBuilder<DOC_ANTENATAL_CARE_RECORD> builder)
        {
            builder.HasKey(t => t.ID).HasName("ID");
        }
    }
}
