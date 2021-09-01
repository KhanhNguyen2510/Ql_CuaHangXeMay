using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Neo4j.Driver;


namespace DoAN
{
    class Connection:IDisposable
    {
        private IDriver _drvier;
        IAsyncSession session;

        public Connection()
        {

        }
        public Connection(string user, string password)
        {
             _drvier = GraphDatabase.Driver("bolt://localhost:11003", AuthTokens.Basic(user, password));
            session = _drvier.AsyncSession();
        }
        public void Open(string user, string password)
        {
            _drvier = GraphDatabase.Driver("bolt://localhost:11003", AuthTokens.Basic(user, password));
             session = _drvier.AsyncSession();
        }

        public void Excutequery(string query, object obj)

        {

            var movies = session.WriteTransactionAsync(async tx =>
            {
                var result = await tx.RunAsync(query, obj);

            });
        }
        
        public async Task<string> SingleRecorAsync(string query, object temp)
        {
            var recods = session.WriteTransactionAsync(async tx =>
            {
                var result = await tx.RunAsync(query, temp);
                return (await result.SingleAsync())[0].As<string>();
            });
            await session.CloseAsync();
            return recods.Result.ToString();

        }

        public async Task<List<IRecord>> ListRecordAsync(string query)
        {

            var records = await session.ReadTransactionAsync(async tx =>
            {
                var result = await tx.RunAsync(query);
                return await result.ToListAsync();
            }
           ).ConfigureAwait(false);
                return records;
        }
        public async Task<List<IRecord>> ListRecordAsynctim(string query,object obj)
        {

            var records = await session.ReadTransactionAsync(async tx =>
            {
                var result = await tx.RunAsync(query,obj);
                return await result.ToListAsync();
            }
           ).ConfigureAwait(false);
            return records;
        }
        public void CloseAsync()
        {
            this.session.CloseAsync();
        }
        public void Dispose()
        {
            _drvier?.Dispose();
        }
    }
}

