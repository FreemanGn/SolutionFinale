using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface ICuisineRepository
    {
        List<CuisineModel> GetAll();

        CuisineModel GetById(int Id);
        CuisineModel Add(CuisineModel model);
        CuisineModel Delete(CuisineModel model);

        CuisineModel Update(CuisineModel model);
    }
}
