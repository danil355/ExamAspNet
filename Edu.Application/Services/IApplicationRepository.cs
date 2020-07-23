using System;
using System.Collections.Generic;
using System.Text;

namespace Edu.Application.Services
{
    public interface IApplicationRepository
    {
        Domain.Model.Application GetById(int id);

        Domain.Model.Application Create(Domain.Model.Application app);

        Domain.Model.Application Update(int id, Domain.Model.Application app);

        Domain.Model.Application Delete(int id);
    }
}
