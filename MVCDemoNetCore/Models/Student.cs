namespace MVCDemoNetCore.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public string FirstName { get; set;}
        public string LastName { get; set;}

        //Agregando propiedades
        //Esto hace que se agregue una llave foranea a la tabla Students

        public int GradeID { get; set; }

        public Grade Grade { get; set; }

    }
}
