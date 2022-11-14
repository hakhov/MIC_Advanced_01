var item1 = new Items<int>("Tom", 100, "cat");
var item2 = new Items<double>("Tom", 100.54, "dog");
var item3 = new Items<decimal>("Tom", 100.54m, "dog");

class Items<T>
{
    public string? ItemName { get; set; }
    public T Price { get; set; }
    public string? TypeofItem { get; set; }

    public Items(string? itemName, T price, string? typeofItem)
    {
        ItemName = itemName;
        Price = price;
        TypeofItem = typeofItem;
    }
}
