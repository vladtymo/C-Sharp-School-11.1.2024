int price1 = 1200;
int price2 = 456;
int price3 = 99;
int price4 = 12;

Console.WriteLine(price1 + price2 + price3);

// Робота з масивами

int[] prices = { 120, 77, 34500, 90, 1230, 55, 66 };

Console.WriteLine("Elements: " + prices.Length); // 7
Console.WriteLine(prices.Sum());

prices[0] = 340;

Console.WriteLine(prices[0]);
Console.WriteLine(prices[1]);
Console.WriteLine(prices[2]);
Console.WriteLine(prices[3]);
Console.WriteLine(prices[4]);

Console.WriteLine("----------- Prices -------------");
for (int i = 0; i < prices.Length; ++i)
{
    Console.WriteLine(prices[i]);
}

// --------- 