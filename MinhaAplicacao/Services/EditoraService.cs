using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR.Protocol;
using Microsoft.EntityFrameworkCore;
using MinhaAplicacao.Data;
using MinhaAplicacao.Data.Repositories;
using MinhaAplicacao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhaAplicacao.Services
{
    public class EditoraService : IEditoraService
    {
        private readonly IEditoraRepository _repo;

        public EditoraService(IEditoraRepository repo) => _repo = repo;

        public Task<Editora> EditoraById(int id) => _repo.EditoraById(id);

        public async Task<IEnumerable<Editora>> ListAsync() => await _repo.ListAsync();

        public Task<Editora> CreateEditora(Editora editora) => _repo.CreateEditora(editora);


    }
}
