using System;

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
        List <string> product = new List<string>();
        List<double> price = new List<double>();
        List <int> quantity = new List<int>();
        List<int> sales = new List<int>();

        #region Add product 
        //add produect name value
        Console.WriteLine("Enter new product");
        string newProduct = Console.ReadLine();
        product.Add(newProduct);
        
        //add price value
        Console.WriteLine("Enter new price");
       double Pprice = Convert.ToDouble(Console.ReadLine());
        price.Add(Pprice);
       
        //add quantity value 
        Console.WriteLine("Enter new quantity");
        int quan = Convert.ToInt32(Console.ReadLine());
        quantity.Add(quan);
        #endregion

        #region display product 
        //Display List
        Console.WriteLine("Product List: ");
        productList(product, price, quantity);
        #endregion


        #region update product
        Console.WriteLine("Enter quantity : ");
        int newQ = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter new product");
        string pro = Console.ReadLine();
       // string pro ="";
        for (int i = 0; i <=product.Count; i++)
        {
            if (product[i] == pro)
            {
               int Q = Convert.ToInt32(quantity[i])+newQ;
                //Console.WriteLine(Q);
                quantity.Insert(quantity[i], Q);
                Console.WriteLine("Updated");
                Console.WriteLine(quantity[i]);
            }

        }

        //Console.WriteLine("update Q");
        //int newQ = Convert.ToInt32(Console.ReadLine());
        //int add = quan + newQ;
        //updateProduct(product, ref newQ);
        //Console.WriteLine("success " + add);



        #endregion





        


        /* addProduct(product, newProduct);
       for (int i = 0; i <= product.Length; i++)
       {
           Console.WriteLine(product[i]);
       }

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

               //To add product
               Console.WriteLine("Enter product name: ");
               string ProductName = Console.ReadLine();
               for(int x = 0; x <= product.Length; x++)
               {
                   product[x] = ProductName;
                   Console.WriteLine(product[x]);

               }
               product[product.Length + 1] = ProductName;
               Console.WriteLine(product);

               //  addProduct(productName);

               /* switch (optionNum)
                {
                    case 1:
                        //To add product
                        Console.WriteLine("Enter product name: ");
                        string ProductName = Console.ReadLine();
                        product[product.Length+1]= ProductName;
                        Console.WriteLine(product);



                        Console.WriteLine("Enter product price: ");
                        double ProductPrice = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter initial quantity: ");
                        int Pquantity = Convert.ToInt16(Console.ReadLine());
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
           }*/

    }
    //-----------------------------------------------------------------------
    //static string[] addProduct(string[] pname , string product)
    //{
    //    Array.Resize(ref pname, pname.Length + 1);
    //    pname[pname.Length - 1] = product;
    //    //int i = 0;
    //    //while (i <= pname.Length - 1)
    //    //    i++;
    //    return pname;

    //}
    //static void add(string[] pname, double[] price,int[] quantity)
    //{
    //    //Console.WriteLine("Enter product name: ");
    //    //Console.WriteLine("Enter product price: ");
    //    //Console.WriteLine("Enter initial quantity: ");
    //    pname = new string[10];
    //    price = new double[10];
    //    quantity = new int[10];

    //}

    #region update product function

    //static void updateProduct( List <string> product ,ref int quan)
    //{
    //    //List<int> quantity;
    //    string pro=" ";
    //    int newQ, Q=0;
    //    for (int i = 0; i < product.Count; i++)
    //    {
    //        if (product[i] == pro)
    //        {
    //            newQ = Q;
    //            //quantity.Insert(quantity[i], newQ);
    //        }
                
    //    }

    //}
    #endregion

    #region display product function
    static void productList(List<string>product,List<double>price, List<int> quantity) 
    {
        for (int i = 0; i < product.Count; i++)
        {
            Console.WriteLine($"{product[i]} - price : {price[i]} - quantity : {quantity[i]}");
        }
    }
    #endregion

}

