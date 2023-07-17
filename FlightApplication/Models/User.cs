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
        private GenderMarks _gender;
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
        public GenderMarks Gender { get { return _gender; } 
            set 
            {
                if (Age < 12) 
                {
                    if (value == GenderMarks.X) 
                    {
                        _gender = GenderMarks.x;
                    }
                    _gender = GenderMarks.y;
                }
            } 
        }
        public int? FlightTicketId { get; set; }
    }
}
