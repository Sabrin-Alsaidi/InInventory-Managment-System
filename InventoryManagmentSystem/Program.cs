namespace InventoryManagmentSystem;
class Program
{
    static void Main(string[] args)
    {
        //string username = "admin";
        //string password = "adminpass";

        //Username & Password Entery
        Console.WriteLine("Please Enter your username : ");
        string username = Console.ReadLine();
        Console.WriteLine("Please Enter your password : ");
        string password = Console.ReadLine();

        //create array for options:
        string[] option = { "Add new product", "Update product quantity", "Display product list", "Record sale", "generate product report", "Generate sale report", "Exit" }; 


        //check username & password
        if (username == "admin" && password == "adminpass")
        {
            // if authentication true 
            Console.WriteLine($"Authentication successful! welcome, {username}!");
            Console.WriteLine("-----------------------------------------------");

            //show options
            Console.WriteLine("option : ");
            for (int i = 0; i < option.Length; i++)
            {
                Console.WriteLine($"{i+1}. {option[i]}");
            }

            //get the option number from the user
            Console.WriteLine("Select an operation (1-7): ");
            int optionNum = Convert.ToInt16(Console.ReadLine());

            switch (optionNum)
            {
                case 1:
                    //To add product
                    Console.WriteLine("Enter product name: ");
                    string ProductName = Console.ReadLine();
                    Console.WriteLine("Enter product price: ");
                    double ProductPrice = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter initial quantity: ");
                    int quantity = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Product added successfully!");
                    break;
                case 2:
                    //To update product


                    break;
                case 3:
                    //To display product


                    break;
                case 4:
                    //To record sales


                    break;
                case 5:
                    //To product report


                    break;
                case 6:
                    //To sale report


                    break;
                case 7:
                    //To Exit the system
                    Console.WriteLine("Thank you for using the Inventory Management System, admin!");

                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid operation.");
                    break;
            }










        }
        else
        {
            //if authentication false
            Console.WriteLine("Username or Password not valid!");
        }
       



    }
}

