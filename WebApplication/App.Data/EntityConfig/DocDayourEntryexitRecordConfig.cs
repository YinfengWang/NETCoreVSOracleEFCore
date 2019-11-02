using App.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace App.Data.Mapping
{
    /// <summary>
    /// 24小时出入量记录表
    /// </summary>
    public class DocDayourEntryexitRecordConfig : IEntityTypeConfiguration<DOC_DAYOUR_ENTRYEXIT_RECORD>
    {
        public void Configure(EntityTypeBuilder<DOC_DAYOUR_ENTRYEXIT_RECORD> builder)
        {
            builder.HasKey(t => t.ID).HasName("ID");
        }
    }
}
