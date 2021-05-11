using RestApiModeloDDD.Application.Dtos;
using RestApiModeloDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestApiModeloDDD.Application.Interfaces.Mappers
{
    public interface IMapperProduto
    {
        Produto MapperDtoToEntity(ProdutoDto produtoDto);

        IEnumerable<ProdutoDto> MapperListClientesDto(IEnumerable<Produto> produtos);

        ProdutoDto MapperEntityToDto(Produto produtos);
    }
}
