using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OnlineEventManagementSystem.Entity
{

    public  class UserManager
    {
        public string UserID { get; set; }
        //Validation for mail id
        [Required(ErrorMessage ="Please enter your email address")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address")]
        [MaxLength(64)]
        public string UserMailId { get; set; }
        //validation for password
        [Required(ErrorMessage ="Please enter your password")]
        [RegularExpression("((?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%]).{6,15})", ErrorMessage = "Password must be at least 8 characters long, contain at least one number and have a mixture of uppercase and lowercase letters.")]
        [MaxLength(15)]
        [MinLength(6)]
        [DataType(DataType.Password)]
        public string UserPassword { get; set; }
        //validation for confirming password
        [Required(ErrorMessage = "Please Re-enter your password")]
        [Compare("UserPassword", ErrorMessage = "Those password didn't match, Try again ")]
        public string ReenteredPassword { get; set; }
        //Validation for first name
        [Required(ErrorMessage = "Please enter your first name")]
        [MaxLength(35)]
        [RegularExpression("[A-Z][a-z][^(@#&<>~;$^%{}?][^0-9]{0,35}", ErrorMessage ="Please enter a valid name")]
        public string UserFirstName { get; set; }
        //Validation for last name
        [Required(ErrorMessage = "Please enter your last name")]
        [MaxLength(35)]
        [RegularExpression("[A-Z][a-z][^(@#&<>~;$^%{}?][^0-9]{0,35}", ErrorMessage = "Please enter a valid name")]
        public string UserLastName { get; set; }
        //Validation for mobile number
        [Required(ErrorMessage = "Please enter your mobile number")]
        [RegularExpression("^[6-9][0-9]{9}$",ErrorMessage ="Please enter a valid mobile number")]
        [MaxLength(10)]
        [DataType(DataType.PhoneNumber,ErrorMessage = "Please enter a valid mobile number")]
        public long UserMobileNumber { get; set; }
        //Validation for date of birth
        [Required(ErrorMessage = "Please enter your DOB")]
        [DataType(DataType.Date)]
        public DateTime UserDOB { get; set; }
        //Validation for gender
        [Required(ErrorMessage ="Please select your gender")]
        public string UserGender { get; set; }

        public void Signup()
        {


        }
        public void Login(string mailId, string password)
        {

        }
        //public bool VerifyMailId(string mailId)
        //{
        //    bool isExist = true;
        //    foreach (var user in userDatabase)
        //    {
        //        if (user.userMailId.Equals(mailId))
        //        {
        //            return false;
        //        }
        //    }
        //    return isExist;
        //}
        //public bool ValidateAccount(string mailId, string password)
        //{
        //    bool isMatched = false;
        //    foreach (var user in userDatabase)
        //    {
        //        if (user.userMailId.Equals(mailId) && user.userPassword.Equals(password))
        //        {
        //            isMatched = true;
        //            break;
        //        }
        //    }
        //    return isMatched;
        //}
        public string GenerateUserID(string name, long mobileNumber)
        {
            string userId = "C" + name.Substring(0, 3).ToUpper() + mobileNumber.ToString().Substring(0, 4);
            return userId;
        }
    }

}
