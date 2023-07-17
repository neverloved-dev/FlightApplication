using Microsoft.AspNetCore.Components.Web;

namespace FlightApplication.Models
{

    public enum GenderMarks
    {
        X,
        x,
        Y,
        y
    }
    public class User
    {
        private int _age;
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get { return _age; } 
            set 
            {
                if(value <1 && value >80)
                {
                    Console.WriteLine("Error! User age must be between one year and 80 years!");
                    return;
                }
                _age = value;
            } 
        }
        public GenderMarks Gender { get { return Gender; } 
            set 
            {
                if (Age < 12) 
                {
                    if (value == GenderMarks.X) 
                    {
                        Gender = GenderMarks.x;
                    }
                    Gender = GenderMarks.y;
                }
            } 
        }
    }
}
