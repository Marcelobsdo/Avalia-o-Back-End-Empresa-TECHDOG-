using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TD_ApplicationCore.Entity;
using TD_ApplicationCore.Entity.ValueObjects;
using TD_ApplicationCore.Interfaces.Services;

namespace TechDog_evaluation_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EscolaController : ControllerBase
    {
        private readonly IEscolaService _escolaService;
        public EscolaController(IEscolaService escolaService)
        {
            _escolaService = escolaService;
        }

        [HttpGet("Listar")]
        public IEnumerable<Escola> Listar()
        {
            return _escolaService.Listar();
        }

        [HttpPost("Cadastrar")]
        public void Cadastrar(Escola escola)
        {
            _escolaService.Cadastrar(escola);
        }

        [HttpPut("Editar")]
        public void Editar(Escola escola)
        {
            _escolaService.Editar(escola);
        }

        [HttpDelete("Excluir/{id}")]
        public void Excluir(int id)
        {
            _escolaService.Excluir(id);
        }
    }
}