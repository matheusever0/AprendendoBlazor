using Blazor4.Data;
using Blazor4.Model;
using Microsoft.EntityFrameworkCore;
#nullable disable
namespace Blazor4.Repository
{
    public class PessoaRepository
    {
        private SystemContext _context;

        public PessoaRepository()
        {
            _context = new SystemContext();
        }

        public async Task<List<Pessoa>> List()
        {
            return await _context.Pessoa.ToListAsync();
        }

        public async Task Create(Pessoa pessoa)
        {
            await _context.Pessoa.AddAsync(pessoa);
            await _context.SaveChangesAsync();
        }

        public async Task Edit(Pessoa pessoa)
        {
            _context.Entry(pessoa).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }


        public async Task Delete(int id)
        {
            var pessoa = await _context.Pessoa.FirstOrDefaultAsync(x=> x.Id == id);

            if(pessoa != null)
            {
                _context.Pessoa.Remove(pessoa);
                await _context.SaveChangesAsync();
            }
        
        }

        public async Task<Pessoa> Get(int id)
        {
            var pessoa = await _context.Pessoa.FirstOrDefaultAsync(x => x.Id == id);

            return pessoa;
        }

    }
}
