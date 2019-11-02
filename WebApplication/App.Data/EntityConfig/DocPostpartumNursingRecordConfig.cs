using App.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace App.Data.Mapping
{
    /// <summary>
    /// 产后护理记录表
    /// </summary>
    public class DocPostpartumNursingRecordConfig : IEntityTypeConfiguration<DOC_POSTPARTUM_NURSING_RECORD>
    {
        public void Configure(EntityTypeBuilder<DOC_POSTPARTUM_NURSING_RECORD> builder)
        {
            builder.HasKey(t => t.ID).HasName("ID");
        }
    }
}
