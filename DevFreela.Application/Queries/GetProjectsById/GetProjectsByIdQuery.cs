using DevFreela.Application.ViewModel;
using MediatR;
using System;

namespace DevFreela.Application.Queries.GetProjectsById
{
    public class GetProjectsByIdQuery : IRequest<ProjectDetailsViewModel>
    {
        public GetProjectsByIdQuery(int id)
        {
            Id = id;
        }
        public int Id { get; private set; }
    }
}
