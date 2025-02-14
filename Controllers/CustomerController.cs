using BookStore.DTOs.Customer;
using BookStore.DTOs.CustomerDTO;
using BookStore.Models;
using BookStore.Repository;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        UnitOfWork _unitOfWork;
        UserManager<IdentityUser> _userManager;
        RoleManager<IdentityRole> _roleManager;
        public CustomerController(UnitOfWork unitOfWork, UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _unitOfWork = unitOfWork;
            _userManager = userManager;
            _roleManager = roleManager;
        }


        [HttpGet]
        public async Task<IActionResult> GetCustomers()
        {
            var customers = await _unitOfWork.CustomerRepo.GetAllAsync();
            return Ok(customers);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCustomer(string id)
        {
            var customer = await _unitOfWork.CustomerRepo.GetByIdAsync(id);
            if (customer == null) return NotFound();
            return Ok(customer);
        }

        [HttpPost]
        public async Task<IActionResult> AddCustomer(AddCustomerDTO customerDto)
        {
            var newCustomer = new Customer
            {
                Name = customerDto.Name,
                Email = customerDto.Email,
                PhoneNumber = customerDto.Phone,
                Address = customerDto.Address,
                UserName = customerDto.UserName
            };

            var result = await _userManager.CreateAsync(newCustomer, customerDto.Password); // ✅ Use `await` properly

            if (!result.Succeeded)
                return BadRequest(result.Errors);

            var roleStatus = await _roleManager.FindByNameAsync("Customer");
            await _userManager.AddToRoleAsync(newCustomer, "Customer"); // ✅ Use `await`

            return StatusCode(StatusCodes.Status201Created);
        }


        [HttpPut]
        public async Task<IActionResult> UpdateCustomer(EditCustomerDTO customerDTO)
        {
            if (ModelState.IsValid)
            {
                var customer = await _unitOfWork.CustomerRepo.GetByIdAsync(customerDTO.Id);
                if (customer == null) return NotFound();
                customer.Name = customerDTO.Name;
                customer.Email = customerDTO.Email;
                customer.PhoneNumber = customerDTO.Phone;
                customer.Address = customerDTO.Address;
                customer.UserName = customerDTO.UserName;

                _unitOfWork.CustomerRepo.Update(customer);
                await _unitOfWork.SaveAsync();
                return Ok();
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCustomer(string id)
        {
            var customer = await _unitOfWork.CustomerRepo.GetByIdAsync(id);
            if (customer == null) return NotFound();
            _unitOfWork.CustomerRepo.Delete(customer);
            await _unitOfWork.SaveAsync();
            return Ok();
        }

    }
}
