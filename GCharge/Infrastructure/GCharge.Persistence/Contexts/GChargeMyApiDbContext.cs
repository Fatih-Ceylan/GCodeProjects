using GCharge.Domain.Entities.Definitions;
using GCharge.Domain.Entities.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Utilities.Core.UtilityDomain.Entities;

namespace GCharge.Persistence.Contexts
{
    public class GChargeMyApiDbContext: IdentityDbContext<AppUser, AppRole, string>
    {
        readonly IHttpContextAccessor _httpContextAccessor;

        public GChargeMyApiDbContext(DbContextOptions<GChargeMyApiDbContext> options, IHttpContextAccessor httpContextAccessor) : base(options)
        {
            _httpContextAccessor = httpContextAccessor;
        }


        public virtual DbSet<ChargePoint> ChargePoints { get; set; }
        public virtual DbSet<ChargeTag> ChargeTags { get; set; }
        public virtual DbSet<ConnectorStatus> ConnectorStatuses { get; set; }
        public virtual DbSet<ConnectorStatusView> ConnectorStatusViews { get; set; }
        public virtual DbSet<MessageLog> MessageLogs { get; set; }
        public virtual DbSet<Transaction> Transactions { get; set; }


        public async Task<string> GetCurrentUserNameAsync()
        {
            return ""; //return _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Name);
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Configuration.GChargeConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChargePoint>(entity =>
            {
                entity.ToTable("ChargePoint");

                entity.HasIndex(e => e.ChargePointId, "ChargePoint_Identifier")
                    .IsUnique();

                entity.Property(e => e.ChargePointId).HasMaxLength(100);

                entity.Property(e => e.Comment).HasMaxLength(200);

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.Username).HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.ClientCertThumb).HasMaxLength(100);
            });

            modelBuilder.Entity<ChargeTag>(entity =>
            {
                entity.HasKey(e => e.TagId)
                    .HasName("PK_ChargeKeys");

                entity.Property(e => e.TagId).HasMaxLength(50);

                entity.Property(e => e.ParentTagId).HasMaxLength(50);

                entity.Property(e => e.TagName).HasMaxLength(200);
            });

            modelBuilder.Entity<ConnectorStatus>(entity =>
            {
                entity.HasKey(e => new { e.ChargePointId, e.ConnectorId });

                entity.ToTable("ConnectorStatus");

                entity.Property(e => e.ChargePointId).HasMaxLength(100);

                entity.Property(e => e.ConnectorName).HasMaxLength(100);

                entity.Property(e => e.LastStatus).HasMaxLength(100);
            });

            modelBuilder.Entity<ConnectorStatusView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ConnectorStatusView");

                entity.Property(e => e.ChargePointId)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ConnectorName).HasMaxLength(100);

                entity.Property(e => e.LastStatus).HasMaxLength(100);

                entity.Property(e => e.StartResult).HasMaxLength(100);

                entity.Property(e => e.StartTagId).HasMaxLength(50);

                entity.Property(e => e.StopReason).HasMaxLength(100);

                entity.Property(e => e.StopTagId).HasMaxLength(50);
            });

            modelBuilder.Entity<MessageLog>(entity =>
            {
                entity.HasKey(e => e.LogId);

                entity.ToTable("MessageLog");

                entity.HasIndex(e => e.LogTime, "IX_MessageLog_ChargePointId");

                entity.Property(e => e.ChargePointId)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ErrorCode).HasMaxLength(100);

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Transaction>(entity =>
            {
                entity.Property(e => e.Uid).HasMaxLength(50);

                entity.Property(e => e.ChargePointId)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.StartResult).HasMaxLength(100);

                entity.Property(e => e.StartTagId).HasMaxLength(50);

                entity.Property(e => e.StopReason).HasMaxLength(100);

                entity.Property(e => e.StopTagId).HasMaxLength(50);

                entity.HasOne(d => d.ChargePoint)
                    .WithMany(p => p.Transactions)
                    .HasForeignKey(d => d.ChargePointId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Transactions_ChargePoint");
            });

            base.OnModelCreating(modelBuilder);
        }


        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            #region Tüm entitylerde ortak değişiklikler
            //ChangeTracker entitiy üzerinde yapılan değişiklikleri yakalar.


            var datas = ChangeTracker.Entries<BaseEntity>(); //tip base entitiy olarak giren tüm modelleri yakala


            foreach (var data in datas)
            {
                switch (data.State)
                {
                    case EntityState.Detached:
                        break;
                    case EntityState.Unchanged:
                        break;
                    case EntityState.Deleted:
                        break;
                    case EntityState.Modified:
                        if (data.Entity.IsDeleted)
                        {
                            data.Entity.DeletedBy = await GetCurrentUserNameAsync();
                            data.Entity.DeletedDate = DateTime.Now;
                        }
                        else
                        {
                            data.Entity.UpdatedBy = await GetCurrentUserNameAsync();
                            data.Entity.UpdatedDate = DateTime.Now;
                        }
                        break;
                    case EntityState.Added:
                        data.Entity.CreatedBy = await GetCurrentUserNameAsync() ?? "user none";
                        data.Entity.CreatedDate = DateTime.Now;
                        break;
                    default:
                        break;
                }
            }
            #endregion

            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}
