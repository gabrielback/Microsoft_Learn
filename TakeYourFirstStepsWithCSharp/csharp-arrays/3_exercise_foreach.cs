int[] inventory = {200, 450, 700, 175, 250};
int sum = 0;
int bin = 0;

foreach (string orderID in orderIDs) {
    if(orderID.StartsWith("b".ToUpper())){
        Console.WriteLine(orderID);
    }
}

foreach (int items in inventory) {
    Console.WriteLine($"Bin {++bin} = {items} Items (Running total = {sum+=items} items");
}

Console.WriteLine($"We have {sum} items in inventory");