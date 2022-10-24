using RestApiModeloDDD.Application.Dtos;
using RestApiModeloDDD.Application.Interface;
using RestApiModeloDDD.Application.Interface.Mappers;
using RestApiModeloDDD.Domain.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestApiModeloDDD.Application
{
    public class ApplicationServiceProduct : IApplicationServiceProduct
    {
        private readonly IServiceProduct serviceProduct;
        private readonly IMapperProduct MapperProduct;

        public ApplicationServiceProduct(IServiceProduct serviceProduct, IMapperProduct MapperProduct)
        {
            this.serviceProduct = serviceProduct;
            this.MapperProduct = MapperProduct;
        }

        public IEnumerable<ProductDto> GetAll()
        {
            var products = serviceProduct.GetAll();

            return MapperProduct.MapperListProductDto(products);
        }

        public ProductDto GetById(int id)
        {
            var product = serviceProduct.GetById(id);

            return MapperProduct.MapperEntityToDto(product);
        }

        public void Add(ProductDto productDto)
        {
            var product = MapperProduct.MapperDtoToEntity(productDto);

            serviceProduct.Add(product);
        }

        public void Remove(ProductDto productDto)
        {
            var product = MapperProduct.MapperDtoToEntity(productDto);

            serviceProduct.Remove(product);
        }

        public void Update(ProductDto productDto)
        {
            var product = MapperProduct.MapperDtoToEntity(productDto);

            serviceProduct.Update(product);
        }
    }
}
