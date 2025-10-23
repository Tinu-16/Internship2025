using DataAccess;
namespace BusinessLogic
{
    public class BusinessLogicImplementation
    {
        private readonly DatabaseConnection _db;
        public BusinessLogicImplementation() 
        {
            _db=new DatabaseConnection();
        }

        public void GetData()
        {
            var data = new DatabaseConnection();
            data.Database();
        }
    }
}
