using Estudo_1___Web_API.Domain.DTOs;

namespace Estudo_1___Web_API.Domain.Models
{
    public interface IEmployeeRepository
    {
        void Add(Employee employee);

        List<EmployeeDTO> Get(int pageNumber, int pageQuantity);

        Employee? Get(int id);
    }
}
