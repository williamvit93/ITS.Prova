using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using ITS.Prova.Domain.Funcionario;
using ITSProva.Data.Context;
using ITSProva.Data.Interfaces;

namespace ITSProva.Data.Repository
{
    public class FuncionarioRepository : IFuncionarioRepository, IDisposable
    {
        private readonly ProvaContext _context;

        public FuncionarioRepository(ProvaContext context)
        {
            _context = context;
        }
        
        public void Add(Funcionario funcionario)
        {
            _context.Funcionario.Add(funcionario);
        }

        public void Update(Funcionario funcionario)
        {
            _context.Funcionario.AddOrUpdate(funcionario);
        }

        public void Delete(Funcionario funcionario)
        {
            _context.Funcionario.Remove(funcionario);
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public Funcionario GetById(int funcionarioId)
        {
            return _context.Funcionario.FirstOrDefault(x => x.Id == funcionarioId);
        }

        public IEnumerable<Funcionario> GetAll()
        {
            return _context.Funcionario.ToList();
        }

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
