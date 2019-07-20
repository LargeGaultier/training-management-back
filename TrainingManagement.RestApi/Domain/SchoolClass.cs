using System.Collections.Generic;

namespace TrainingManagement.RestApi.Domain
{
    public class SchoolClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Student> Students { get; set; }

    }
}
