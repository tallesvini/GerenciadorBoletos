using BoletoProject.Application.DTOs;
using BoletoProject.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BoletoProject.WebApi.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class BoletoController : ControllerBase
	{
		private readonly IBoletoService _boletoService;

		public BoletoController(IBoletoService boletoService)
		{
			_boletoService = boletoService;
		}

		[HttpGet("{id:int}")]
		public async Task<IActionResult> GetById(int id)
		{
			if (id == 0) throw new Exception("The field could not be empty.");

			BoletoDTO list = await _boletoService.GetByIdAsync(id);

			if(list == null) return NotFound();

			return Ok(list);
		}

		[HttpPost]
		public async Task<IActionResult> PostBoleto(BoletoCreatedDTO entity)
		{
			try
			{
				await _boletoService.AddEntityAsync(entity);
				return Ok();
			}
			catch (Exception ex)
			{
				throw new Exception("Error: " + ex.Message);
			}
		}

	}
}
