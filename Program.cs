
Dictionary<string, decimal> menu = new Dictionary<string, decimal>();
menu.Add("espresso", 3.00m);
menu.Add("cappuccino", 5.00m);
menu.Add("latte",5.50m);
menu.Add("tea", 4.50m);
menu.Add("smoothie", 7.00m);
menu.Add("milkshake", 8.00m);
menu.Add("muffin",4.50m);
menu.Add("sandwich", 6.50m);

List<string> cart = new List<string>();
bool isAMatch = false;

while (isAMatch == false)
{
    Console.WriteLine("Welcome to Veecafe!");
    Console.WriteLine(""); //for spacing

    Console.WriteLine($"{"Item",-10}{"Price",10}"); 
    Console.WriteLine("=====================");
    foreach (KeyValuePair<string, decimal> item in menu)
    { 
        Console.WriteLine("{0,-10}{1, 9}", item.Key,item.Value); // menu system display
    }
    Console.WriteLine(""); // for spacing
    
    Console.Write("Please enter an item to buy: ");
    string order = Console.ReadLine().ToLower().Trim();

    foreach (KeyValuePair<string, decimal> item in menu)
    {
        if (order.Contains(item.Key)) // item is in menu
        {
            cart.Add(item.Key);
            Console.WriteLine($"{item.Key} costs ${item.Value} and is added to your cart.");
            isAMatch = true;
            break;
        }
    }

    if (isAMatch == false) // item not in menu
    {
        Console.WriteLine($"{order} is not on the menu. Please try again.");
        continue;
    }

    while (true) // adding or not adding more items
    {
        Console.Write("Would you like to add another item to your cart? y/n: ");
        string addToCart = Console.ReadLine().ToLower().Trim();

        if (addToCart == "y")
        {
            isAMatch = false;
            break;
        }
        else if (addToCart == "n")  
        {
            Console.WriteLine("Thank you for your order!");
            Console.WriteLine("Here's what you got:");

            decimal sum = 0;

            foreach (string product in cart)
            {
                Console.WriteLine($"{product,-10}{menu[product],10:C}");

                sum += menu[product]; // adding sum of values              
            }
            Console.WriteLine($"Your total is {sum:C}.");                                   //Console.WriteLine(cart.Where(menu.ContainsKey).Sum(s=> menu[s])); (line 85)
            break;
        }
        else
        {
            Console.WriteLine("Invalid response.");
        }
    }
}

// no letter or number for menu
// no most/least expensive displayed
//no order by price

//https://stackoverflow.com/questions/42229272/calculating-the-sum-of-the-values-in-a-dictionary-that-exist-in-a-generic-list





















