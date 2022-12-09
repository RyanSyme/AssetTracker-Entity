using Microsoft.EntityFrameworkCore;
using AssetTracker_Entity;
using Microsoft.Identity.Client.Extensions.Msal;
using System.Linq;
using System.Reflection.PortableExecutable;

MyDbContext Context = new MyDbContext();

bool RunProgram = true;

while (RunProgram)
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("Please enter a number to choose an option:");
    Console.WriteLine();
    Console.WriteLine("[1]: To display a list of your current assets Press 1");
    Console.WriteLine("[2]: To add a new asset Press 2:");
    Console.WriteLine("[3]: To edit a previously entered asset Press 3");
    Console.WriteLine("[4]: To Delete an asset from the database Press 4");
    Console.WriteLine("[5]: To Exit the application Press 5");
    Console.WriteLine("---------------------------------------");
    Console.Write("Make your choice now: ");

    string userinput = (Console.ReadLine() ?? "").Trim().ToLower();

    if (userinput == "1")
    {
        DisplayWithoutId();
    }
    else if (userinput == "2")
    {
        //Creates a new Asset
        Asset NewAsset = new Asset();
        //Makes sure user always chooses one of three asset types
        Console.WriteLine("Please enter asset type - Desktop, Laptop or Phone:");
        string userEntry = (Console.ReadLine() ?? "").Trim().ToLower();
        string firstChar = userEntry.Substring(0, 1);
        bool isCorrect = false;
        string type = "";
        do
        {

            if (firstChar == "d")
            {
                type = "Desktop";
                isCorrect = true;
            }
            else if (firstChar == "l")
            {
                type = "Laptop";
                isCorrect = true;
            }
            else if (firstChar == "p")
            {
                type = "Phone";
                isCorrect = true;
            }
            else
            {
                Console.WriteLine("Please enter a valid option - (D)esktop, (L)aptop or (P)hone:");
                userEntry = (Console.ReadLine() ?? "").Trim().ToLower();
                firstChar = userEntry.Substring(0, 1);
            }
        }
        while (!isCorrect);

        Console.WriteLine("Please enter the assets brand:");
        string brand = (Console.ReadLine() ?? "").Trim().ToLower();

        Console.WriteLine("Please enter the assets model name:");
        string model = (Console.ReadLine() ?? "").Trim().ToLower();
        //makes sure the user chooses one of three offices
        Console.WriteLine("Please enter which office the asset was purchased for (USA, Germany, Sweden):");
        userEntry = (Console.ReadLine() ?? "").Trim().ToLower();
        firstChar = userEntry.Substring(0, 1);
        string office = "";
        isCorrect = false;
        do
        {
            if (firstChar == "u")
            {
                office = "USA";
                isCorrect = true;
            }
            else if (firstChar == "g")
            {
                office = "Germany";
                isCorrect = true;
            }
            else if (firstChar == "s")
            {
                office = "Sweden";
                isCorrect = true;
            }
            else
            {
                Console.WriteLine("Please enter a valid option - (U)sa, (G)ermany or (S)weden:");
                userEntry = (Console.ReadLine() ?? "").Trim().ToLower();
                firstChar = userEntry.Substring(0, 1);
            }
        }
        while (!isCorrect);
        //Checks that the user has entered an int
        Console.WriteLine("Please enter the assets cost in USD:");
        bool isInt = false;
        string userPrice = "";
        int price = 0;
        while(!isInt)
        {
            userPrice = (Console.ReadLine() ?? "").Trim().ToLower();
            if (int.TryParse(userPrice, out price))
            {
                isInt = true;
            }
            else
            {
                Console.WriteLine("Please use a number for this entry.");
            }

        }
        //Creates a DateTime and check the user has entered the details correctly
        Console.WriteLine("Please enter the assets purchase date (YYYY-MM-DD):");
        isCorrect = false;
        string userTime = "";
        DateTime purchaseDate = new DateTime();
        while (!isCorrect)
        {
            userTime = (Console.ReadLine() ?? "").Trim().ToLower();
            if (DateTime.TryParse(userTime, out purchaseDate))
            {
                isCorrect = true;
            }
            else
            {
                Console.WriteLine("Invalid Date");
            }
        }
        //passes all user info into the new Asset
        NewAsset.Type = type;
        NewAsset.Brand = brand;
        NewAsset.Model = model;
        NewAsset.Office = office;
        NewAsset.Price = price;
        NewAsset.PurchaseDate = purchaseDate;
        //Passes the new user info into the Asset list
        Context.Assets.Add(NewAsset);
        Context.SaveChanges();

        Console.WriteLine("---------------------------------------");
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("A new Asset was entered successfully!");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine();
        Console.WriteLine("---------------------------------------");
        Console.WriteLine();
    }
    else if(userinput == "3")
    {
        DisplayWithId();

        Console.WriteLine();
        Console.WriteLine("Please enter the #ID of the Asset you wish to edit:");
        Console.WriteLine();
        //Compares user input to database to return the correct asset to edit, then runs through the edit process
        string editAsset = (Console.ReadLine() ?? "");
        Asset? updatedAsset = Context.Assets.FirstOrDefault(x => x.Id == Convert.ToInt32(editAsset));
        Console.WriteLine("Please enter the new data:");
        Console.WriteLine("Please enter asset type - Desktop, Laptop or Phone:");
        string userEntry = (Console.ReadLine() ?? "").Trim().ToLower();
        string firstChar = userEntry.Substring(0, 1);
        bool isCorrect = false;
        string type = "";
        do
        {

            if (firstChar == "d")
            {
                type = "Desktop";
                isCorrect = true;
            }
            else if (firstChar == "l")
            {
                type = "Laptop";
                isCorrect = true;
            }
            else if (firstChar == "p")
            {
                type = "Phone";
                isCorrect = true;
            }
            else
            {
                Console.WriteLine("Please enter a valid option - (D)esktop, (L)aptop or (P)hone:");
                userEntry = (Console.ReadLine() ?? "").Trim().ToLower();
                firstChar = userEntry.Substring(0, 1);
            }
        }
        while (!isCorrect);
        Console.WriteLine("Please enter the assets brand:");
        string brand = (Console.ReadLine() ?? "");
        Console.WriteLine("Please enter the assets model name:");
        string model = (Console.ReadLine() ?? "");
        Console.WriteLine("Please enter which office the asset was purchased for (USA, Germany, Sweden):");
        userEntry = (Console.ReadLine() ?? "").Trim().ToLower();
        firstChar = userEntry.Substring(0, 1);
        string office = "";
        isCorrect = false;
        do
        {
            if (firstChar == "u")
            {
                office = "USA";
                isCorrect = true;
            }
            else if (firstChar == "g")
            {
                office = "Germany";
                isCorrect = true;
            }
            else if (firstChar == "s")
            {
                office = "Sweden";
                isCorrect = true;
            }
            else
            {
                Console.WriteLine("Please enter a valid option - (U)sa, (G)ermany or (S)weden:");
                userEntry = (Console.ReadLine() ?? "").Trim().ToLower();
                firstChar = userEntry.Substring(0, 1);
            }
        }
        while (!isCorrect);
        Console.WriteLine("Please enter the assets cost in USD:");
        bool isInt = false;
        string userPrice = "";
        int price = 0;
        while (!isInt)
        {
            userPrice = (Console.ReadLine() ?? "").Trim().ToLower();
            if (int.TryParse(userPrice, out price))
            {
                isInt = true;
            }
            else
            {
                Console.WriteLine("Please use a number for this entry.");
            }

        }
        Console.WriteLine("Please enter the assets purchase date (YYYY-MM-DD):");
        isCorrect = false;
        string userTime = "";
        DateTime purchaseDate = new DateTime();
        while (!isCorrect)
        {
            userTime = (Console.ReadLine() ?? "").Trim().ToLower();
            if (DateTime.TryParse(userTime, out purchaseDate))
            {
                isCorrect = true;
            }
            else
            {
                Console.WriteLine("Invalid Date");
            }
        }
        //Adds, updates and saves the updated asset info into the original database
        updatedAsset.Type = type;
        updatedAsset.Brand = brand;
        updatedAsset.Model = model;
        updatedAsset.Office = office;
        updatedAsset.Price = price;
        updatedAsset.PurchaseDate = purchaseDate;
        Context.Assets.Update(updatedAsset);
        Context.SaveChanges();
        Console.WriteLine("---------------------------------------");
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Asset successfully updated!");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine();
        Console.WriteLine("---------------------------------------");
        Console.WriteLine();
    }
    else if (userinput == "4")
    {
        DisplayWithId();

        Console.WriteLine();
        Console.WriteLine("Please enter the ID number of the Asset you wish to delete:");
        Console.WriteLine();
        //Compares user input to database to return the correct asset to delete, then runs through the delete process
        string deleteAsset = (Console.ReadLine() ?? "").Trim().ToLower();
        Asset? AssetToDelete = Context.Assets.FirstOrDefault(x => x.Id == Convert.ToInt32(deleteAsset));
        if (AssetToDelete != null) 
        {
            Context.Assets.Remove(AssetToDelete);
        }
        Context.SaveChanges();
        Console.WriteLine("---------------------------------------");
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Asset successfully deleted from database!");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine();
        Console.WriteLine("---------------------------------------");
        Console.WriteLine();
    }
    else if (userinput == "5")
    {
        RunProgram = false;
        Console.WriteLine();
        Console.WriteLine("---------------------------------------");
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("Bye for now, See you next time");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine();
        Console.WriteLine("---------------------------------------");
        Console.WriteLine();
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("---------------------------------------");
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("You must choose a number between 1 - 5");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine();
        Console.WriteLine("---------------------------------------");
        Console.WriteLine();
    }
}

// Sets out the console display for option 1 - display assets and displays ordered by office then purchase date
void DisplayWithoutId()
{
    List<Asset> Assets = Context.Assets.OrderBy(x => x.Office).ThenBy(x =>x.PurchaseDate).ToList();
    Console.WriteLine();
    Console.WriteLine(" " + "Type".PadRight(12) + "Brand".PadRight(12) + "Model".PadRight(12) + "Office".PadRight(10) + "Price".PadRight(9) + "Local Price".PadRight(18) + "Date");
    Console.WriteLine("--------------------------------------------------------------------------------");
    foreach (Asset A in Assets)
    {
        //dateExpire is added to each line to check how old each asset is
        dateExpire(A);
        Console.WriteLine($" {A.Type,-12}{A.Brand,-12}{A.Model,-12}{A.Office,-10}${A.Price.ToString(),-8}{A.getCurrency(),-5}{A.covertCurrency().ToString("0.00"),-10} {A.PurchaseDate.ToString("yyyy-MM-dd")}");
    }
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine();
}

// Sets out the console display for options 3 & 4 - Edit & Delete adding the Id number to the display and displaying in id order
void DisplayWithId()
{
    List<Asset> Assets = Context.Assets.ToList();
    Console.WriteLine();
    Console.WriteLine(" " + "ID".PadRight(4) + "Type".PadRight(12) + "Brand".PadRight(12) + "Model".PadRight(12) + "Office".PadRight(10) + "Price".PadRight(9) + "Local Price".PadRight(18) + "Date");
    foreach (Asset A in Assets)
    {
        dateExpire(A);
        Console.WriteLine($" {A.Id.ToString(),-4}{A.Type,-12}{A.Brand,-12}{A.Model,-12}{A.Office,-10}${A.Price.ToString(),-8}{A.getCurrency(),-5}{A.covertCurrency().ToString("0.00"),-10} {A.PurchaseDate.ToString("yyyy-MM-dd")}");
    }
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine();
}

// Creates a datetime and checks each asset
void dateExpire(Asset asset)
{
    DateTime currentDate = new DateTime();
    currentDate = DateTime.Now;
    DateTime expirationDate = asset.PurchaseDate.AddYears(3);
    TimeSpan timeRemaining = expirationDate - currentDate;
    if (timeRemaining.TotalDays < 90)
    {
        Console.ForegroundColor = ConsoleColor.Red;
    }
    else if (timeRemaining.TotalDays < 180)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.White;
    }
}