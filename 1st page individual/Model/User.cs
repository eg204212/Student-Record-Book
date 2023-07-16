using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace _1st_page_individual.Model
{
    public class User
    {
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public BitmapImage Image { get; set; }

        public string DateOfBirth { get; set; }
        public Double GPA { get; set; }

        public String ImagePath
        {
            get { return $"/Model/Images/{Image}"; }
        }

        public User(int age, string firstName, string lastName, string dateOfBirth, BitmapImage image,double gpa)
        {
            Age = age;
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Image = image;
            GPA = gpa;
        }

        public User()
        {

        }
    }
}

