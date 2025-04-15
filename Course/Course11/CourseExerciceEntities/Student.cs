using System;
namespace Course11.CourseExerciceEntities
{
	public class Student
	{
		public int StudentCode { get; set; }

        public override int GetHashCode()
        {
            return StudentCode.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if(!(obj is Student))
            {
                return false;
            }
            Student other = obj as Student;
            return StudentCode.Equals(other.StudentCode);
        }
    }
}

