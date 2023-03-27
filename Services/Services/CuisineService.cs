using Models;
using Repositories;


namespace Services
{
    public class CuisineService : ICuisineService
    {
        private readonly ICuisineRepository _cuisineRepository;

        public CuisineService(ICuisineRepository cuisineRepository)
        {
            _cuisineRepository = cuisineRepository;
        }

       

        public List<CuisineModel> getAllCuisines()
        {
            return _cuisineRepository.GetAll();
        }

        public CuisineModel getCuisineById(int id)
        {
            return _cuisineRepository.GetById(id);
        }

        public CuisineModel addCuisine(CuisineModel Cuisine)
        {
           return _cuisineRepository.Add(Cuisine);
        }

        public CuisineModel deleteCuisine(CuisineModel Cuisine)
        {
            return _cuisineRepository.Delete(Cuisine);
        }

       

     

        public CuisineModel updateCuisine(CuisineModel Cuisine)
        {
            return _cuisineRepository.Update(Cuisine);
        }
    }
}
