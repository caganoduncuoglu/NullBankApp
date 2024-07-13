# NullBankApp (Desktop)

NullBankApp is a mock banking application developed using .NET - WinForms. This application demonstrates basic CRUD operations on MSSQL Server and API operations using CollectAPI. 

The architecture can be considered to fit the MVC pattern. It includes authentication and other features designed for demo purposes. This is a simple project and improvements can be made. 

Project structure will be used to create for a web project. (NullBankWebApp)

![NULL](https://github.com/user-attachments/assets/036ad903-6209-4c20-a64b-68a34e063c25)

## Features

- Basic CRUD operations for banking entities.
- Integration with CollectAPI for external data.
- User authentication (for demonstration purposes).
- Simple and intuitive user interface.
- Screenshots for each page to visualize the application.

## Project Structure

The project follows a basic structure suitable for WinForms applications. The architecture can be considered to fit the MVC pattern as follows:

- **Model**: Represents the data and the business logic (e.g., `UserSession.cs`, `CurrencyService.cs`).
- **View**: Represents the UI components (e.g., `AccountsPage.cs`, `Login.cs`, `MainMenu.cs`).
- **Controller**: Handles the interaction between the Model and View (e.g., `Transactions.cs`, `Investments.cs`).

### File Structure

- `AccountsPage.cs` - Manages the accounts view.
- `CurrencyService.cs` - Handles currency-related operations.
- `GoldPriceService.cs` - Handles operations related to gold prices.
- `Investments.cs` - Manages investment-related logic.
- `Login.cs` - Manages the login view and logic.
- `MainMenu.cs` - Manages the main menu view.
- `PersonsPage.cs` - Manages the persons view.
- `Program.cs` - The main entry point of the application.
- `Settings.cs` - Manages application settings.
- `SplashScreen.cs` - Displays the splash screen at startup.
- `Transactions.cs` - Manages transaction-related logic.
- `UserSession.cs` - Manages user session data.

## Screenshots

Here are some screenshots of the application to give you a better understanding of the UI and features:

### Login Page
![Screenshot_7](https://github.com/user-attachments/assets/ddddf2b3-b6dc-4b9a-8a8d-8677e336f381)

### Main Menu
![Screenshot_1](https://github.com/user-attachments/assets/cc4dbe9e-3037-4dc6-bf75-2ca2212e59b6)

### Accounts Page
![Screenshot_2](https://github.com/user-attachments/assets/f61917cb-aaa7-4778-9feb-42f034ffcd6e)

### Transactions Page
![Screenshot_3](https://github.com/user-attachments/assets/b763404a-1fe4-42e3-abc5-49d79812b9a5)

### Investments Page
![Screenshot_4](https://github.com/user-attachments/assets/b4c181fb-9c76-47cd-9436-5b50291bf378)

Demo:

![07132-ezgif com-optimize](https://github.com/user-attachments/assets/b30530f4-1ce2-4d72-bad9-337dd9aeb8de)

### DB Diagram

![image](https://github.com/user-attachments/assets/541ce6ed-0de4-4903-9934-bf6e3bc492eb)


## Improvements
This project is intended for demonstration purposes and can be improved in various ways, including:

- Enhancing the UI for a better user experience.
- Adding more robust authentication and security features.
- Integrating additional APIs for more functionalities.
- Improving the code structure and applying design patterns.
