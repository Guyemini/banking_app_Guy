using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banking_app
{
    public class Customer
    {
        private int id;
        private string name;
        private int phoneNumber;

        public Customer(int id, string name, int phoneNumber)
        {
            this.id = id;
            this.name = name;
            this.phoneNumber = phoneNumber;
        }

        // Getter for id
        public int GetId()
        {
            return this.id;
        }

        // Setter for id
        public void SetId(int id)
        {
            this.id = id;
        }

        // Getter for name
        public string GetName()
        {
            return this.name;
        }

        // Setter for name
        public void SetName(string name)
        {
            this.name = name;
        }

        // Getter for phoneNumber
        public int GetPhoneNumber()
        {
            return this.phoneNumber;
        }

        // Setter for phoneNumber
        public void SetPhoneNumber(int phoneNumber)
        {
            this.phoneNumber = phoneNumber;
        }

        public void PrintDetails()
        {
            Console.WriteLine($"id = {this.id}, name = {this.name}, phone-number = {this.phoneNumber}");
        }
    }
}
