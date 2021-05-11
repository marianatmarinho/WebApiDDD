using RestApiModeloDDD.Application.Dtos;
using RestApiModeloDDD.Application.Interfaces.Mappers;
using RestApiModeloDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestApiModeloDDD.Application.Mappers
{
    public class MapperProduto : IMapperProduto
    {

        public Produto MapperDtoToEntity(ProdutoDto produtoDto)
        {
            var produto = new Produto()
            {
                Id = produtoDto.Id,
                Nome = produtoDto.Nome,
                Valor = produtoDto.Valor
            };

            return produto;
        }

        public IEnumerable<ProdutoDto> MapperListClientesDto(IEnumerable<Produto> produtos)
        {
            var dto = produtos.Select(p => new ProdutoDto
            {
                Id = p.Id,
                Nome = p.Nome,
                Valor = p.Valor
            });
            return dto;

        }

        public ProdutoDto MapperEntityToDto(Produto produtos)
        {
            var produtoDto = new ProdutoDto()
            {
                Id = produtos.Id,
                Nome = produtos.Nome,
                Valor = produtos.Valor
            };

            return produtoDto;
        }

    }
}
