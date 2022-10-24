using RestApiModeloDDD.Application.Dtos;
using RestApiModeloDDD.Application.Interface.Mappers;
using RestApiModeloDDD.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestApiModeloDDD.Application.Mappers
{
    public class MapperProduct : IMapperProduct
    {
        public Product MapperDtoToEntity(ProductDto productDto)
        {
            var product = new Product()
            {
                Id = productDto.Id,
                Name = productDto.Name,
                Value = productDto.Value
            };

            return product;
        }

        public ProductDto MapperEntityToDto(Product product)
        {
            var productDto = new ProductDto()
            {
                Id = product.Id,
                Name = product.Name,
                Value = product.Value
            };

            return productDto;
        }

        public IEnumerable<ProductDto> MapperListProductDto(IEnumerable<Product> products)
        {
            var dto = products.Select(c => new ProductDto { Id = c.Id, Name = c.Name, Value = c.Value });

            return dto;
        }
    }
}
