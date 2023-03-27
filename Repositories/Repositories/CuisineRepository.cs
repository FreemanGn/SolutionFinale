using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    internal class CuisineRepository : ICuisineRepository
    {
        private readonly FormationDbContext _formationDbContext;

        public CuisineRepository(FormationDbContext formationDbContext)
        {
            _formationDbContext = formationDbContext;
        }
        public CuisineModel Add(CuisineModel model)
        {
             _formationDbContext.Cuisines.Add(model);
            _formationDbContext.SaveChanges();
            return model;
        }

        public CuisineModel Delete(CuisineModel model)
        {
            
            _formationDbContext.Cuisines.Remove(model);
            _formationDbContext.SaveChanges();
            return model;
        }

        public List<CuisineModel> GetAll()
        {
            return _formationDbContext.Cuisines.ToList();
        }

        public CuisineModel GetById(int Id)
        {
            return _formationDbContext?.Cuisines.FirstOrDefault(c=>c.Id==Id);
        }

        public CuisineModel Update(CuisineModel model)
        {
            _formationDbContext.Cuisines.Update(model);
            _formationDbContext.SaveChanges();
            return model;
        }
    }
}
