1. **Download the application** and open it in **Visual Studio 2022** (since the application is developed in **.NET Core 6.0**).
2. Once the project is open, run the **migration command**. If it is not working, install **Microsoft.EntityFrameworkCore.Tools** locally.
3. After that, run the command `dotnet ef database update` to create the database.
4. Finally, run the application. You can test it using the **Swagger API**.
5. Use the **Swagger API UI** to call the **Login API** and obtain the token.
6. Click the **Authorization** button in Swagger, enter the token in the value field, and authorize it.
7. Now, you can call any API in the Employee Management System section, which provides simple CRUD operations.
