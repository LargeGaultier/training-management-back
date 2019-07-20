namespace TrainingManagement.RestApi.Domain
{ 
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Office365Id { get; set; }
        public int FkClassId { get; set; }
        public string Mail { get; set; }

        public SchoolClass SchoolClass { get; set; }
    }
}
