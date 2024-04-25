using Microsoft.AspNetCore.Mvc;

namespace AutomobileWebApp.Models
{
    public class Validation
    {
        public Validation() { }
        public Boolean Validate(int year) 
        {
            if (year > 1990 && year < DateTime.Now.Year + 1) return true;
            return false;
        }
    }
}
