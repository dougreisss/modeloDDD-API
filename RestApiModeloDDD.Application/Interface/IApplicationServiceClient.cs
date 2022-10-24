using RestApiModeloDDD.Application.Dtos;
using System.Collections.Generic;

namespace RestApiModeloDDD.Application.Interface
{
    public interface IApplicationServiceClient
    {
        void Add(ClientDto clientDto);

        void Update(ClientDto clientDto);

        void Remove(ClientDto clientDto);

        IEnumerable<ClientDto> GetAll();

        ClientDto GetById(int id);
    }
}