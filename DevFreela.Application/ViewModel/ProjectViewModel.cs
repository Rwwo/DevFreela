using System;

namespace DevFreela.Application.InputModel
{
    public class ProjectViewModel
    {
        public ProjectViewModel(int id, string title, DateTime createAt)
        {
            Id = id;
            Title = title;
            CreatedAt = createAt;
        }

        public int Id { get; private set; }
        public string Title { get; private set; }
        public DateTime CreatedAt { get; private set; }
    }
}
