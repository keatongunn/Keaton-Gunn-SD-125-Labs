using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_Basic_OOP_Principles
{

    // Abstraction - This is used to hide things that dont need to be seen by the user, and only allow necessary properties and methods to be seen. One great example of this that I found was a laptop class. For the user, all they would need to know is how to turn it on using the power button, or use the keyboard and trackpad. All the other information could be made private, such as the innerworkings like the motherboard information, graphics card information etc. 
    // For the bank account example you'd only display necessary information, so you could have a class BankAccount, with properties such as CustomerName, AccountNumber, Balance, and methods like Withdraw, Deposit, CheckBalance. You would leave out things that werent necessary, such as their more in-depth personal information. 


    //Inheritance - The way I like to think about inheritance is to have one Super Class, or a Parent Class that holds the main properties and methods, and then all of the children classes would inherit these main methods and properties from the parent, on top of having their own methods and properties that make them individualistic. A very easy example of this is if you were to make Class Animal, with a name property and methods like eat and sleep, and having classes Dog and Cat inherit from Animal but adding methods called Bark to Dog, and Meow to Cat. 
    // The bank account example of this would be simple, you would have the SuperClass BankAccount that would hold properties that every account type would hold, like CustomerName, AccountNumber, Balance, AccountType and methods like Withdraw, Deposit, CheckBalance. The child classes would then get more specific, for example you could have class Checking, that would inherit all of the BankAccount methods and properties, but it would also add an OverDrawFee property, or a TFSA class, that would give you an InterestRate property. 

    //Encapsulation - This is a process in which a developer would build a class with everything necessary for it to function built within the class. A good example of this would be a class Car, that would hold properties like Model, Make, Color, Year. It would also have within it all of the methods used to make use of the car like Drive, Reverse, Brake, Speed.
    //Regarding the bank account example, you would build Class BankAccount and it would hold every property and method necessary to make sure the bank account functions properly without needing outside help. 

    //Polymorphism - This allows us to create an object, property or method that may take on many forms. Basic inheritance is a good example of this. There are two commonly reffered to typs of polymorphism, Dynamic and Static. You can use this to perform a single method in multiple different ways. 
    // A use of this in the bank account example would be a Withdraw method with an int Amount argument. If you used this method on the SavingsAccount class with an argument of 10, it would simply withdraw your money. But using this Withdraw method on the TFSA class, with the same int 10 argument, it could also have an additional fee implemented that charges you per withdrawal.  


    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
