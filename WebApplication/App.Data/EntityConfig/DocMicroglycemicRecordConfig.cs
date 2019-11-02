using App.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace App.Data.Mapping
{
    /// <summary>
    /// 微量血糖监测表
    /// </summary>
    public class DocMicroglycemicRecordConfig : IEntityTypeConfiguration<DOC_MICROGLYCEMIC_RECORD>
    {
        public void Configure(EntityTypeBuilder<DOC_MICROGLYCEMIC_RECORD> builder)
        {
            builder.HasKey(t => t.ID).HasName("ID");
        }
    }
}
