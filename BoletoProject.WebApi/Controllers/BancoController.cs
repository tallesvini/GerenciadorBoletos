using BoletoProject.Application.DTOs;
using BoletoProject.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BoletoProject.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class BancoController : ControllerBase
	{
		private readonly IBancoService _bancoService;

		public BancoController(IBancoService bancoService)
		{
			_bancoService = bancoService;
		}

		[HttpGet]
		public async Task<IActionResult> GetAll()
		{
			var listBancos = await _bancoService.GetAllAsync();

			if (!listBancos.Any()) return NotFound();

			return Ok(listBancos);
		}

		[HttpGet("{codigoBanco:int}")]
		public async Task<IActionResult> GetByCodigoBanco(int codigoBanco)
		{
			if (codigoBanco == 0) throw new Exception("The field could not be empty.");

			var banco = await _bancoService.GetByCodigoBancoAsync(codigoBanco);

			if (banco == null) return NotFound();

			return Ok(banco);
		}

		[HttpPost]
		public async Task<IActionResult> PostBanco(BancoCreatedDTO banco)
		{
			try
			{
				if (banco == null) throw new Exception("The entity could not be empty.");

				await _bancoService.AddEntityAsync(banco);
				return Ok();
			}
			catch (Exception ex)
			{
				throw new Exception("Error: " + ex.Message);
			}
		}
	}
}
