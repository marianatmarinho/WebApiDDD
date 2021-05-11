using RestApiModeloDDD.Application.Dtos;
using RestApiModeloDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestApiModeloDDD.Application.Interfaces.Mappers
{
    public interface IMapperCliente
    {
        Cliente MapperDtoToEntity(ClienteDto clienteDto);

        IEnumerable<ClienteDto> MapperListClientesDto(IEnumerable<Cliente> clientes);

        ClienteDto MapperEntityToDto(Cliente cliente);
    }
}
