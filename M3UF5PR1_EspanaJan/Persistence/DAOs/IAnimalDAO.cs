using M3UF5PR1_EspanaJan.Models.DTOs;

namespace M3UF5PR1_EspanaJan.Persistence.DAOs
{
    public interface IAnimalDAO
    {
        void InsertAnimal(AnimalDTO animal);
        void UpdateAnimal(AnimalDTO animal);
        void DeleteAnimalById(int id);
        AnimalDTO PickRandomAnimal();
        AnimalDTO SelectById(int id);
        int NextId();
        List<int> GetAllIds();
    }
}
