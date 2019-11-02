using App.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace App.Data.Mapping
{
    /// <summary>
    /// 评估主记录表
    /// </summary>
    public class DocRecordsEntityConfig : IEntityTypeConfiguration<DOC_RECORDS>
    {
        public void Configure(EntityTypeBuilder<DOC_RECORDS> builder)
        {
            builder.HasKey(t => t.ID).HasName("ID");
        }
    }
}
