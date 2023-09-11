using DevFreela.Application.ViewModel;
using DevFreela.Core.Repositories;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace DevFreela.Application.Queries.GetProjectsById
{
    public class GetProjectByIdQueryHandler : IRequestHandler<GetProjectsByIdQuery, ProjectDetailsViewModel>
    {
        //private readonly DevFreelaDbContext _dbContext;
        private readonly IProjectRepository _projectRepository;

        //public GetProjectByIdQueryHandler(DevFreelaDbContext dbContext)
        public GetProjectByIdQueryHandler(IProjectRepository projectRepository)
        {
            //_dbContext = dbContext;
            _projectRepository = projectRepository;
        }
        public async Task<ProjectDetailsViewModel> Handle(GetProjectsByIdQuery request, CancellationToken cancellationToken)
        {

            var project = _projectRepository.GetByIdAsync(request.Id);

            if (project == null) return null;

            var projectViewModel = new ProjectDetailsViewModel(
                project.Result.Id,
                project.Result.Title,
                project.Result.Description,
                project.Result.TotalCost,
                project.Result.CreateAt,
                project.Result.FinishAt,
                project.Result.Client.FullName,
                project.Result.Freelancer.FullName
                );

            return projectViewModel;

        }
    }
}
