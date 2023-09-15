using EmployeeOOP.Classes;
using EmployeeOPP.Classes;

try
{
    //Declaración de variables
    int day, month, year, hour;
    string firstName, lastName;
    decimal salary, sales;

    Console.WriteLine("OOP APPLICATION");
    Console.WriteLine("---------------");

    Console.Write("Ingresar el día: ");
    day = Convert.ToInt32(Console.ReadLine());

    Console.Write("Ingresar el mes: ");
    month = Convert.ToInt32(Console.ReadLine());

    Console.Write("Ingresar el año: ");
    year = Convert.ToInt32(Console.ReadLine());

    //Inicialización de la clase Date
    Date dateObject = new Date(day, month, year);
    Console.WriteLine("\n");
    Console.WriteLine(dateObject.ToString());

    

    Console.Write("Ingresar nombre completo: ");
    firstName = Console.ReadLine();

    Console.Write("Ingresar apellidos: ");
    lastName = Console.ReadLine();


    Console.Write("Ingresar Salario devengado: ");
    salary = Decimal.Parse(Console.ReadLine());

    SalaryEmployee salaryEmployee = new SalaryEmployee()
    {

        Salary = salary,

    };


    Console.Write("Ingresar horas trabajadas: ");
    hour = Convert.ToInt32(Console.ReadLine());

    HourlyEmployee hourlyEmployee = new HourlyEmployee()
    {
        
        Hour = hour,
        HourValue = 4833,
    };

    CommissionEmployee commissionEmployee = new CommissionEmployee()
    {
        Id = 123456,
        FirstName = firstName,
        LastName = lastName,
        BirthDate = dateObject,
        HiringDate = dateObject,
        IsActive = true,
        Commission = 0.03,
        ValCommission = 4500,
    };

    Console.WriteLine(hourlyEmployee);
    Console.WriteLine(salaryEmployee);
    Console.WriteLine(commissionEmployee);
}


catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}


