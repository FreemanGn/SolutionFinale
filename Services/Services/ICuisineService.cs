using Models;


namespace Services
{
    public interface ICuisineService
    {
        public List<CuisineModel> getAllCuisines();
        public CuisineModel getCuisineById(int id);

        public CuisineModel addCuisine(CuisineModel Cuisine);
        public CuisineModel deleteCuisine(CuisineModel Cuisine);
        public CuisineModel updateCuisine(CuisineModel Cuisine);
    }
}
