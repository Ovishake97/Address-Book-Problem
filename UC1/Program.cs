using System;
using System.Collections.Generic;

namespace AddressBook
{
    public class Program
    {
        //Printing the address from an addressbook
        static void Main(string[] args)
        {
            AddressCheck addressCheck= new AddressCheck();
            addressCheck.AddToAddressBook("Nayan", "Dey", "Kolkata", "WB", 690123, 9976543760, "nayandey@gmail.com");
            addressCheck.AddToAddressBook("Rahul", "Das", "Gurgaon", "Haryana", 768643, 6754678560, "rdg@gmail.com");
            string temp = addressCheck.GetFirstName("Nayan");
            Console.WriteLine("Employee details are:");
            addressCheck.PrintAddress(temp);
            Console.ReadKey();
        }
    }

    public class AddressBookMain {
       public String firstName;
        public String lastName;
        public String address;
        public String state;
        public int zip;
        public double phoneNo;
        public string emailId;


        public AddressBookMain(string firstName, string lastName, string address, string state, int zip, double phoneNo, string emailId)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.state = state;
            this.zip = zip;
            this.phoneNo = phoneNo;
            this.emailId = emailId; 
        }
        
    }

    //Creating a dictionary to store the address book
    public class AddressCheck {
        
        private Dictionary<string, AddressBookMain> addresssBookMap;
        public AddressCheck() {
            
            this.addresssBookMap = new Dictionary<string,AddressBookMain>();
            
        }

        //Adding the values to the dictionary
        public void AddToAddressBook(string firstName, string lastName, string address, string state, int zip, double phoneNo, string emailId) {
            AddressBookMain addressBookMain = new AddressBookMain( firstName,  lastName,  address, state, zip, phoneNo, emailId);
            
            this.addresssBookMap.Add(firstName, addressBookMain);

            }
        public string GetFirstName(string firstName)
        {
            return this.addresssBookMap[firstName].firstName;
        }
        //Printing the values from the dictionary
        public void PrintAddress(String key) {
            
            foreach (KeyValuePair<string,AddressBookMain> items in this.addresssBookMap) {
                
                
                    AddressBookMain adBook = items.Value;
                if (adBook.firstName.Equals(key)) { 
                    Console.WriteLine(adBook.firstName);
                    Console.WriteLine(adBook.lastName);
                    Console.WriteLine(adBook.address);
                    Console.WriteLine(adBook.state);
                    Console.WriteLine(adBook.zip);
                    Console.WriteLine(adBook.phoneNo);
                    Console.WriteLine(adBook.emailId);
                }
            }
        }
        
    }
}
