using M3UF5PR1_EspanaJan.Models.DTOs;

namespace M3UF5PR1_EspanaJan.Persistence.DAOs
{
    internal interface IRescueDAO
    {
        public void InsertRescue(RescueDTO rescue);
        public List<RescueDTO> GetAllRescue();
        public RescueDTO GetRescueById(int id);
        public List<int> GetAllIds();
    }
}
