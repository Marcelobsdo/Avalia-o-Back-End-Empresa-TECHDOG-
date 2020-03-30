using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TD_ApplicationCore.Entity;
using TD_ApplicationCore.Interfaces.Services;

namespace TechDog_evaluation_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        private readonly IAlunoService _alunoService;
        public AlunoController(IAlunoService alunoService)
        {
            _alunoService = alunoService;
        }

        [HttpGet("Listar")]
        public IEnumerable<Aluno> Listar()
        {
            return _alunoService.Listar();
        }

        [HttpPost("Cadastrar")]
        public void Cadastrar(Aluno aluno)
        {
            _alunoService.Cadastrar(aluno);
        }

        [HttpPut("Editar")]
        public void Editar(Aluno aluno)
        {
            _alunoService.Editar(aluno);
        }

        [HttpDelete("Excluir/{id}")]
        public void Excluir(int id)
        {
            _alunoService.Excluir(id);
        }
    }
}