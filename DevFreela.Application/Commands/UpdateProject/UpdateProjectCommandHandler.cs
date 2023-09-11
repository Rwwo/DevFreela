using DevFreela.Core.Repositories;
using DevFreela.Infrastructure.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace DevFreela.Application.Commands.UpdateProject
{
    public class UpdateProjectCommandHandler : IRequestHandler<UpdateProjectCommand, Unit>
    {
        //DevFreelaDbContext _dbContext;
        //public UpdateProjectCommandHandler(DevFreelaDbContext dbContext)
        //{
        //    _dbContext = dbContext;
        //}

        private readonly IProjectRepository _projectRepository;
        public UpdateProjectCommandHandler(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }

        public async Task<Unit> Handle(UpdateProjectCommand request, CancellationToken cancellationToken)
        {
            //var project = await _dbContext.Projects.SingleOrDefaultAsync(p => p.Id == request.Id);
            //project.Update(request.Title, request.Description, request.TotalCost);
            //await _dbContext.SaveChangesAsync();
            //return Unit.Value;

            var project = await _projectRepository.GetByIdAsync(request.Id);
            
            project.Update(request.Title, request.Description, request.TotalCost);

            await _projectRepository.SaveChangesAsync();
            
            return Unit.Value;

        }
    }
}
