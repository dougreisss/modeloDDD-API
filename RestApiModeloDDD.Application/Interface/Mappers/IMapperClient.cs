using RestApiModeloDDD.Application.Dtos;
using RestApiModeloDDD.Domain.Entitys;
using System.Collections.Generic;

namespace RestApiModeloDDD.Application.Interface.Mappers
{
    public interface IMapperClient
    {
        Client MapperDtoToEntity(ClientDto clientDto);

        IEnumerable<ClientDto> MapperListClientDto(IEnumerable<Client> clients);

        ClientDto MapperEntityToDto(Client client);
    }
}