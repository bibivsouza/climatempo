using ClimaTempo.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ClimaTempo.Context
{
    public class dbContext
    {

            readonly SQLiteAsyncConnection _dbContext;

            public dbContext(string dbPath)
            {
            _dbContext = new SQLiteAsyncConnection(dbPath);
            _dbContext.CreateTableAsync<Cidade>().Wait();
            }

            public Task<List<Cidade>> GetCidadesAsync()
            {
                return _dbContext.Table<Cidade>().ToListAsync();
            }

            public Task<int> SaveCidadesAsync(Cidade cidade)
            {
                return _dbContext.InsertAsync(cidade);
            }

            public Task<int> DeleteCidadesAsync(Cidade cidade)
            {
                return _dbContext.InsertAsync(cidade);
            }
        
    }
}
