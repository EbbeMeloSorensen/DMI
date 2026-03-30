using System;
using System.Transactions;
using DMI.StatDB.Persistence.Npgsql.Repositories;
using DMI.StatDB.Persistence.Repositories;

namespace DMI.StatDB.Persistence.Npgsql
{
    public class UnitOfWork : IUnitOfWork
    {
        private TransactionScope _scope;

        public IStationRepository Stations { get; }
        public IPositionRepository Positions { get; }

        public UnitOfWork()
        {
            try
            {
                // This worked with the old setup, where the Repository wasn't asynchronous,
                // but with the new setup, where the Repository is asynchronous, we need to enable async flow in the TransactionScope.
                // The CoPilot extension in VS Code helped me with that!
                //_scope = new TransactionScope();
                
                _scope = new TransactionScope(
                    TransactionScopeOption.Required,
                    new TransactionOptions
                    { IsolationLevel = IsolationLevel.ReadCommitted },
                    TransactionScopeAsyncFlowOption.Enabled);                

                Stations = new StationRepository();
                Positions = new PositionRepository();
            }
            catch (Exception e)
            {
                _scope.Dispose();
                throw e;
            }
        }

        public void Dispose()
        {
            _scope.Dispose();
        }

        public int Complete()
        {
            _scope.Complete();
            return 0;
        }
    }
}
