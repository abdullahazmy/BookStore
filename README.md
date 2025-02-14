# 📚 BookStoreAPI

A RESTful API for managing an online bookstore, built with **ASP.NET Core** and **Entity Framework Core**. Features include authentication (Identity), role-based access (Admin & Customer), book catalog management, orders, and EF Core migrations.

## 🚀 Features
- **Authentication & Authorization** (ASP.NET Identity)
- **CRUD operations** for Books, Authors, and Orders
- **Role-based Access** (Admin & Customer)
- **Swagger UI** for API Documentation
- **EF Core** with Migrations & Lazy Loading

## 🏗️ Setup
1. **Clone & Navigate**  
   ```bash
   git clone https://github.com/yourusername/BookStoreAPI.git
   cd BookStoreAPI
   ```

2. **Configure Database** in `appsettings.json`  
   ```json
   "ConnectionStrings": {
     "DefaultConnection": "Server=YOUR_SERVER;Database=BookStoreDB;Trusted_Connection=True;"
   }
   ```

3. **Apply Migrations & Run**  
   ```bash
   dotnet ef database update
   dotnet run
   ```

4. **Access API** via [Swagger UI](http://localhost:5000/swagger)

## 📌 Key Endpoints
| Method | Endpoint             | Description           |
|--------|----------------------|-----------------------|
| POST   | `/api/auth/register` | Register a new user  |
| GET    | `/api/books`         | Get all books        |
| POST   | `/api/orders`        | Place an order       |

## 📜 License
Licensed under the **MIT License**.

---

🚀 **Happy Coding!**