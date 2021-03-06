using System.Collections.Generic;
using System.Threading.Tasks;
using Services.DTO;

namespace Services.Interfaces
{
    //comunicação da API com o services
    //via DTO

    public interface IUserService
    {
        Task<UserDTO> Create(UserDTO userDTO);
        Task<UserDTO> Update(UserDTO userDTO);
        Task Remove(int id);
        Task<List<UserDTO>> Get(int id);
        Task<List<UserDTO>> SearchByUsuario(string usuario);
        Task<List<UserDTO>> SearchByNome(string nome);
        Task<UserDTO> GetByUsuario(string usuario);

    }
}
