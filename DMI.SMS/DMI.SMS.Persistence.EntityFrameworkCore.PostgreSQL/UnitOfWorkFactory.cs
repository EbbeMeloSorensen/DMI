using Craft.Logging;

namespace DMI.SMS.Persistence.EntityFrameworkCore.PostgreSQL
{
    public class UnitOfWorkFactory : UnitOfWorkFactoryBase
    {
        static UnitOfWorkFactory()
        {
            using var context = new SMSDbContext();
            context.Database.EnsureCreated();

            //if (context.StationInformations.Any()) return;

            //SeedDatabase(context);
        }

        public override void Initialize(ILogger logger)
        {
        }

        public override async Task<bool> CheckRepositoryConnection()
        {
            using var context = new SMSDbContext();
            return await context.Database.CanConnectAsync();
        }

        public override IUnitOfWork GenerateUnitOfWork()
        {
            return new UnitOfWork(new SMSDbContext());
        }
    }
}
