using Domain.DataAccess;
using Domain.Model;
using Edu.Application.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Edu.Application.Implementations
{
    public class ApplicationRepository : IApplicationRepository
    {
        private readonly ApplicationDbContext _context;

        public ApplicationRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Domain.Model.Application Create(Domain.Model.Application app)
        {
            var createdApplication = _context.Applications.Add(app);
            _context.SaveChanges();

            return createdApplication.Entity;
        }

        public Domain.Model.Application Delete(int id)
        {
            var appToDelete = GetById(id);

            if (appToDelete == null) return null;

            _context.Applications.Remove(appToDelete);
            _context.SaveChanges();

            return appToDelete;
        }

        public Domain.Model.Application GetById(int id)
        {
            return _context.Applications.Find(id);
        }

        public Domain.Model.Application Update(int id, Domain.Model.Application app)
        {
            var appToUpdate = GetById(id);
            if (appToUpdate == null) return null;

            appToUpdate = app;

            _context.Applications.Update(app);


            _context.SaveChanges();

            return appToUpdate;
        }
    }
}
