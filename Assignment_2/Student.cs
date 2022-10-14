using System;
using System.Text.RegularExpressions;

//Name: Sanskar Parihar
//Student Id: 200489011
/*
Creating a C# console application and creating a Class called Student with the following fields.
1.First name
2. Last name
3. Student ID
4. Email address
5. Date of birth
*/
public class Student
{
    //Initializing variables
    string firstName;
    string lastName;
    int studentID;
    string emailID;
    string dateOfBirth;

    // integer variables
    int year;
    int month;
    int day;
    int ageYear;
    int ageMonth;
    int ageDay;

    //Creating getDetail() method in Student class.
    public void getDetails()
    {
        Console.Write("Enter your first name : ");
        firstName = Console.ReadLine();

        Console.Write("Enter your last name : ");
        lastName = Console.ReadLine();

        Console.Write("Enter your student ID : ");
        studentID = int.Parse(Console.ReadLine());

        Console.Write("Enter your email ID : ");
        emailID = Console.ReadLine();

        Console.Write("Enter the year of your born : ");
        year = int.Parse(Console.ReadLine());

        Console.Write("Enter the month of your born : ");
        month = int.Parse(Console.ReadLine());

        Console.Write("Enter the day of your born : ");
        day = int.Parse(Console.ReadLine());
    }

    //Create a method to Calculate the age of the user.
    public void findAge()
    {
        DateTime now = DateTime.Now;
        ageYear = now.Year - year;

        if (year <= 0 && month <= 0 && day <= 0)
        {
            Console.WriteLine("Error!! \n Plese enter the valid digits");
        }
        else
        {
            if (ageYear > 120)
            {
                Console.WriteLine("Error!! /n The age 120 years old is not possible !!!");
            }
            else
            {
                if (month > now.Month)
                {
                    ageMonth = 12 - (month - now.Month);
                    ageYear = ageYear - 1;
                }
                else
                {
                    if (day > now.Day)
                    {
                        ageMonth = now.Month - month - 1;
                    }
                    else
                    {
                        ageMonth = now.Month - month;
                    }
                }
            }
            if (day > now.Day)
            {
                ageDay = 30 - (day - now.Day);
            }
            else
            {
                ageDay = now.Day - day;
            }
            if (now.Month == month && now.Day == day && ageYear < 135)
            {
                Console.WriteLine($" ** Happy Birthday {firstName} ** ");
                Console.WriteLine("Your are " + ageYear + " years " + ageMonth + " months " + ageDay + " days old.");
            }
            else
            {
                Console.WriteLine("Your are " + ageYear + " years " + ageMonth + " months " + ageDay + " days old.");
            }
        }
    }

    //Creating a method for validating email.
    public void validateEmail()
    {
        Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

        //checking if email matches the pattern in regex
        bool isValidEmail = regex.IsMatch(emailID);

        if (!isValidEmail)
        {
            Console.WriteLine($" {emailID} is an invalid email address");
        }

        else
        {
            Console.WriteLine($"{emailID} is a valid email address");
        }
    }

    //Creating a method to Display to Output user information to the Console
    public void display()
    {
        Console.Write("\n Name : " + firstName + lastName);
        Console.Write("\n Student ID : " + studentID);
        Console.Write("\n Email address : " + emailID);
        Console.Write("\n Your are " + ageYear + " years " + ageMonth + " months " + ageDay + " days old.\n");
    }
}

