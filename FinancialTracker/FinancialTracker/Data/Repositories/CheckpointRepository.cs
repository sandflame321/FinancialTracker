using FinancialTracker.Models.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinancialTracker.Data.Repositories
{
    public class CheckpointRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<Checkpoint> _checkpoints;

        public CheckpointRepository(ApplicationDbContext context)
        {
            _context = context;
            _checkpoints = context.Checkpoints;
        }

        public IEnumerable<Checkpoint> GetAll()
        {
            return _checkpoints.ToList();
        }
        public Checkpoint GetBy(DateTime datum)
        {
            return _checkpoints.SingleOrDefault(c => c.Date == datum);
        }
        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
