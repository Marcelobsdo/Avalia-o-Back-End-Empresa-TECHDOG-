using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TD_ApplicationCore.Entity;
using TD_ApplicationCore.Interfaces.Services;

namespace TechDog_evaluation_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TurmaController : ControllerBase
    {
        private readonly ITurmaService _turmaService;
        public TurmaController(ITurmaService turmaService)
        {
            _turmaService = turmaService;
        }

        [HttpGet("Listar")]
        public IEnumerable<Turma> Listar()
        {
            return _turmaService.Listar();
        }

        [HttpPost("Cadastrar")]
        public void Cadastrar(Turma turma)
        {
            _turmaService.Cadastrar(turma);
        }

        [HttpPut("Editar")]
        public void Editar(Turma turma)
        {
            _turmaService.Editar(turma);
        }

        [HttpDelete("Excluir/{id}")]
        public void Excluir(int id)
        {
            _turmaService.Excluir(id);
        }
    }
}