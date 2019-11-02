using App.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace App.Data.Mapping
{
    /// <summary>
    /// 护理记录表
    /// </summary>
    public class DocNursingRecordsConfig : IEntityTypeConfiguration<DOC_NURSING_RECORDS>
    {
        public void Configure(EntityTypeBuilder<DOC_NURSING_RECORDS> builder)
        {
            builder.HasKey(t => t.ID).HasName("ID");
        }
    }
}
