using Core;

namespace BusinessLayer
{
    public class MyLogic
    {
        private readonly IRepository _repository;

        public MyLogic(IRepository repository)
        {
            _repository = repository;
        }

        public void SaveData()
        {
            _repository.Save();
        }
    }
}
