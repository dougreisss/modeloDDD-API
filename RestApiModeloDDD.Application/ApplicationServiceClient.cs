using RestApiModeloDDD.Application.Dtos;
using RestApiModeloDDD.Application.Interface;
using RestApiModeloDDD.Application.Interface.Mappers;
using RestApiModeloDDD.Domain.Core.Interfaces.Services;
using System.Collections.Generic;

namespace RestApiModeloDDD.Application
{
    public class ApplicationServiceClient : IApplicationServiceClient
    {
        private readonly IServiceClient serviceClient;
        private readonly IMapperClient mapperClient;

        public ApplicationServiceClient(IServiceClient serviceClient, IMapperClient mapperClient)
        {
            this.serviceClient = serviceClient;
            this.mapperClient = mapperClient;
        }

        public IEnumerable<ClientDto> GetAll()
        {
            var clients = serviceClient.GetAll();

            return mapperClient.MapperListClientDto(clients);
        }

        public ClientDto GetById(int id)
        {
            var client = serviceClient.GetById(id);

            return mapperClient.MapperEntityToDto(client);
        }

        public void Add(ClientDto clientDto)
        {
            var client = mapperClient.MapperDtoToEntity(clientDto);

            serviceClient.Add(client);
        }

        public void Remove(ClientDto clientDto)
        {
            var client = mapperClient.MapperDtoToEntity(clientDto);

            serviceClient.Remove(client);
        }

        public void Update(ClientDto clientDto)
        {
            var client = mapperClient.MapperDtoToEntity(clientDto);

            serviceClient.Update(client);
        }
    }
}