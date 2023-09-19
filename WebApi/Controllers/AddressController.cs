using Domain;
using Domain.DTOs.AddresDto;
using Infrastructure.Servises.AddressServise;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;
[ApiController]
[Route("[controller]")]
    public class AddressController:ControllerBase
    {
    private readonly IAddressServise _address;

    public AddressController(IAddressServise address)
    {
        _address = address;
    }
    [HttpGet("GetAddress")]
    public async Task<List<EmployeeAddress>> Get() =>await _address.Get();

    [HttpDelete("deleteaddress")]
    public async Task<bool> Delete(int id)=>await _address.Delete(id);
    [HttpPost("Address")]
    public async Task<string> Add(AddAddressEmployeeDto addAddressEmployeeDto)=>await _address.Add(addAddressEmployeeDto);
    [HttpPut("updata")]
    public Task<string> Updata(AddAddressEmployeeDto dto)=> _address.Updata(dto);
    [HttpGet("GetByIdAddress")]
    public   Task<EmployeeAddress> GetById(int id) => _address.GetById(id);
        
}

