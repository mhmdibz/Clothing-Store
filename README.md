# 👕 Mezo Store - Interactive Clothing Shopping Console

A simple yet elegant C# console application for browsing and purchasing clothing items with real-time cart management and price calculation.

![C#](https://img.shields.io/badge/C%23-239120?style=flat&logo=c-sharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-512BD4?style=flat&logo=dotnet&logoColor=white)
![Console](https://img.shields.io/badge/Console-App-blue?style=flat)

## 🌟 Features

### Shopping Features
- 🛍️ **Product Catalog** - Browse 20 different clothing items
- 💰 **Real-time Cart Total** - Track your spending as you shop
- 📝 **Product Details** - View name, category, price, and size
- ✅ **Purchase Confirmation** - Confirm before adding items to cart
- 🔄 **Continue Shopping** - Add multiple items in one session
- 🚪 **Easy Exit** - Exit anytime during shopping

### Technical Features
- 🎯 **Anonymous Types** - Efficient product data structure
- ✨ **Input Validation** - Robust user input handling
- 🔁 **Interactive Loops** - Smooth shopping experience
- 💵 **Decimal Precision** - Accurate price calculations

## 🎯 Product Catalog

### Available Categories
- **Top** - T-Shirts, Hoodies, Shirts, Polo Shirts, Tank Tops, Cardigans, Sweaters
- **Bottom** - Jeans, Sweatpants, Shorts, Skirts, Leggings, Cargo Pants
- **Outerwear** - Jackets, Blazers, Coats, Raincoats
- **One-Piece** - Dresses, Overalls
- **Set** - Tracksuits

### Price Range
- **Budget**: $14.99 - $29.99
- **Mid-Range**: $34.99 - $59.99
- **Premium**: $79.99 - $149.99

### Sizes Available
- S (Small)
- M (Medium)
- L (Large)
- XL (Extra Large)

## 🚀 Getting Started

### Prerequisites

```
- .NET 6.0 or higher
- Visual Studio 2022 / VS Code / Visual Studio Code
- Windows / Linux / macOS
```

### Installation

1. **Clone the repository**
```bash
git clone https://github.com/yourusername/mezo-clothing-store.git
cd mezo-clothing-store
```

2. **Build the project**
```bash
dotnet build
```

3. **Run the application**
```bash
dotnet run
```

Or simply open in Visual Studio and press F5!

## 📖 How to Use

### Step-by-Step Shopping Guide

1. **Welcome Screen**
   ```
   Welcome in Mezo Store
   Continue: 1    End: 0
   ```
   - Enter `1` to start shopping
   - Enter `0` to exit

2. **Browse Products**
   ```
   Here is the available Products
   1-T-Shirt
   2-Jeans
   3-Hoodie
   ...
   20-Overalls
   ```
   - View all 20 products with numbers

3. **Select a Product**
   ```
   Please enter a number from 1 to 20
   > 3
   ```
   - Enter product number (1-20)

4. **Review & Confirm**
   ```
   Here is your order
   { Name = Hoodie, Category = Top, Price = 39.99, Size = XL }
   Do you want to buy it?
   Yes: 1    No: 0
   ```
   - Enter `1` to add to cart
   - Enter `0` to skip

5. **View Total**
   ```
   total price is: $39.99
   ```
   - See running total after each item

6. **Continue or Checkout**
   ```
   Do you want to buy something else
   Yes: 1    No: 0
   ```
   - Enter `1` to shop more
   - Enter `0` to finish

### Example Shopping Session

```
Welcome in Mezo Store
Continue: 1    End: 0
> 1

Here is the available Products
1-T-Shirt
2-Jeans
3-Hoodie
...
Please enter a number from 1 to 20
> 1

Here is your order
{ Name = T-Shirt, Category = Top, Price = 19.99, Size = M }
Do you want to buy it?
Yes: 1    No: 0
> 1

total price is: $19.99

Do you want to buy something else
Yes: 1    No: 0
> 1

Please enter a number from 1 to 20
> 2

Here is your order
{ Name = Jeans, Category = Bottom, Price = 49.99, Size = L }
Do you want to buy it?
Yes: 1    No: 0
> 1

total price is: $69.98

Do you want to buy something else
Yes: 1    No: 0
> 0

Thank you for shopping at Mezo Store!
```

## 🏗️ Project Structure

```
MezoClothingStore/
│
├── Program.cs              # Main application logic
├── ConsoleApp3.csproj      # Project configuration
└── README.md               # Documentation
```

## 🔧 Technologies Used

- **C# 10+** - Modern C# language features
- **.NET 6.0/7.0/8.0** - Cross-platform framework
- **Anonymous Types** - Lightweight data structures
- **LINQ** - Data querying capabilities
- **Console I/O** - User interaction

## 💻 Code Highlights

### Anonymous Type Product Definition
```csharp
var clothes = new[]
{
    new { Name = "T-Shirt", Category = "Top", Price = 19.99m, Size = "M" },
    new { Name = "Jeans", Category = "Bottom", Price = 49.99m, Size = "L" },
    // ... more products
};
```

### Input Validation Pattern
```csharp
int inputOfProduct;
do
{
    Console.WriteLine("Please enter a number from 1 to 20");
    int.TryParse(Console.ReadLine(), out inputOfProduct);
}
while (inputOfProduct <= 0 || inputOfProduct > 20);
```

### Cart Management
```csharp
if (willBuy == 1)
{
    TotalPrice += clothes[inputOfProduct - 1].Price;
}
Console.WriteLine($"total price is: {TotalPrice}");
```

## 📊 Product List

| # | Product | Category | Price | Size |
|---|---------|----------|-------|------|
| 1 | T-Shirt | Top | $19.99 | M |
| 2 | Jeans | Bottom | $49.99 | L |
| 3 | Hoodie | Top | $39.99 | XL |
| 4 | Sweatpants | Bottom | $29.99 | M |
| 5 | Jacket | Outerwear | $89.99 | L |
| 6 | Shorts | Bottom | $24.99 | S |
| 7 | Blazer | Outerwear | $129.99 | XL |
| 8 | Shirt | Top | $34.99 | M |
| 9 | Polo Shirt | Top | $25.99 | L |
| 10 | Tank Top | Top | $14.99 | S |
| 11 | Skirt | Bottom | $39.99 | M |
| 12 | Dress | One-Piece | $59.99 | L |
| 13 | Cardigan | Top | $49.99 | XL |
| 14 | Leggings | Bottom | $19.99 | M |
| 15 | Sweater | Top | $44.99 | L |
| 16 | Coat | Outerwear | $149.99 | XL |
| 17 | Cargo Pants | Bottom | $59.99 | M |
| 18 | Tracksuit | Set | $79.99 | L |
| 19 | Raincoat | Outerwear | $99.99 | M |
| 20 | Overalls | One-Piece | $69.99 | L |

## 🔮 Future Enhancements

### Planned Features
- [ ] Shopping cart summary at checkout
- [ ] Remove items from cart
- [ ] Search products by category
- [ ] Filter by size
- [ ] Sort by price
- [ ] Discount codes / Coupons
- [ ] Payment methods
- [ ] Order history
- [ ] Product inventory management
- [ ] User accounts and login
- [ ] Wishlist functionality
- [ ] Product ratings and reviews
- [ ] Multiple quantity per item
- [ ] Tax calculation
- [ ] Shipping cost estimation

### Technical Improvements
- [ ] Move products to external file (JSON/XML)
- [ ] Database integration (SQL Server/SQLite)
- [ ] Class-based product model
- [ ] Unit tests
- [ ] Configuration file
- [ ] Logging system
- [ ] GUI version (WPF/WinForms)
- [ ] Web API backend
- [ ] Mobile app integration

## ✨ Key Features Explained

### Input Validation
Every user input is validated to ensure:
- ✅ Only numeric values accepted
- ✅ Range validation (1-20 for products, 0-1 for decisions)
- ✅ Prevents application crashes
- ✅ User-friendly error handling

### Anonymous Types
Benefits:
- 💡 No need to create separate classes
- 🚀 Quick prototyping
- 📦 Lightweight data structures
- 🎯 Type-safe at compile time

### Cart Logic
```csharp
decimal TotalPrice = 0;  // Initialize cart
TotalPrice += clothes[inputOfProduct - 1].Price;  // Add item
Console.WriteLine($"total price is:{TotalPrice}");  // Display total
```

## 🐛 Known Issues

- ❌ No ability to remove items from cart
- ❌ Cannot view cart contents before checkout
- ❌ Products hardcoded in application
- ❌ No inventory tracking (unlimited stock)
- ❌ No order confirmation or receipt
- ❌ Limited error messages

## 🎓 Learning Outcomes

This project demonstrates:
- ✅ Anonymous types in C#
- ✅ Array manipulation
- ✅ Do-while loops for validation
- ✅ String interpolation
- ✅ Decimal type for currency
- ✅ Boolean logic
- ✅ User input handling with TryParse
- ✅ Console formatting
- ✅ Flow control (if/else, loops)

## 🤝 Contributing

Contributions are welcome! Here's how:

1. Fork the repository
2. Create feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit changes (`git commit -m 'Add AmazingFeature'`)
4. Push to branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

### Contribution Ideas
- Add more products
- Implement category filtering
- Add size selection
- Create product classes
- Improve UI/UX
- Add unit tests

 
 
## 🙏 Acknowledgments

- Inspired by real-world e-commerce applications
- Built as a learning project for C# beginners
- Perfect for console application tutorials
 
## 🌐 System Requirements

- **OS**: Windows 10/11, Linux, macOS
- **RAM**: 256MB minimum
- **Storage**: 10MB free space
- **Framework**: .NET 6.0 or higher

## 📈 Version History

### Version 1.0.0 (Current)
- ✅ 20 clothing products
- ✅ Interactive shopping experience
- ✅ Real-time cart total
- ✅ Input validation
- ✅ Multiple purchase support

## 💡 Usage Tips

1. **Best Practices**
   - Review product details before confirming
   - Check total price regularly
   - Take your time browsing

2. **Common Mistakes**
   - Entering 0 or numbers > 20 (will prompt again)
   - Not confirming purchase (item won't be added)

3. **Pro Tips**
   - Note down product numbers you like
   - Plan your budget before shopping
   - Use the continue option for multiple items

---

⭐ **If you find this project helpful, please give it a star!** ⭐

**Happy Shopping at Mezo Store!** 🛍️👕
