using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyManagement
{
    public abstract class Person
    {
        private string role;
        private string name;
        private string mobileNumber;
        private DateTime dob;
        private string email;
        private string username;
        private string password;

        public Person(string role, string name, string mobileNumber, DateTime dob, string email, string username, string password)
        {
            this.role = role;
            this.name = name;
            this.mobileNumber = mobileNumber;
            this.dob = dob;
            this.email = email;
            this.username = username;
            this.password = password;
        }

        public virtual bool SignIn(string enteredUsername, string enteredPassword)
        {
            if (username == enteredUsername && password == enteredPassword)
            {
                Console.WriteLine($"{role} signed in successfully.");
                return true;
            }
            else
            {
                Console.WriteLine("Invalid credentials.");
                return false;
            }
        }

        public string Role => role;
        public string Name => name;
        public string MobileNumber => mobileNumber;
        public DateTime DOB => dob;
        public string Email => email;
        public string Username => username;
    }

    public class Administrator : Person
    {
        public Administrator(string name, string mobileNumber, DateTime dob, string email, string username, string password)
            : base("Administrator", name, mobileNumber, dob, email, username, password)
        {
        }

        public void Dashboard()
        {
            Console.WriteLine("Administrator Dashboard");
        }

        public void AddUser(Person user)
        {
            Console.WriteLine($"User {user.Name} added successfully.");
        }

        public void ModifyUser(Person user)
        {
            Console.WriteLine($"User {user.Name} modified successfully.");
        }

        public void ViewUsers()
        {
            Console.WriteLine("Viewing all users...");
        }

        public void LogOut()
        {
            Console.WriteLine("Administrator logged out.");
        }

        public override bool SignIn(string enteredUsername, string enteredPassword)
        {
            return base.SignIn(enteredUsername, enteredPassword);
        }
    }

    public class Pharmacist : Person
    {
        public Pharmacist(string name, string mobileNumber, DateTime dob, string email, string username, string password)
            : base("Pharmacist", name, mobileNumber, dob, email, username, password)
        {
        }

        public void AddMedicine(string medicineName)
        {
            Console.WriteLine($"Medicine {medicineName} added successfully.");
        }

        public void ViewMedicine(string medicineName)
        {
            Console.WriteLine($"Viewing details for medicine: {medicineName}");
        }

        public void ModifyMedicine(string medicineName)
        {
            Console.WriteLine($"Medicine {medicineName} modified successfully.");
        }

        public void SellMedicine(string medicineName, int quantity)
        {
            Console.WriteLine($"Sold {quantity} units of {medicineName}.");
        }

        public void LogOut()
        {
            Console.WriteLine("Pharmacist logged out.");
        }

        public override bool SignIn(string enteredUsername, string enteredPassword)
        {
            return base.SignIn(enteredUsername, enteredPassword);
        }
    }

}
