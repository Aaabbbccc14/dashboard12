
# WPF Dashboard Application

This is a WPF dashboard application built using .NET and Syncfusion charts. It supports:

- 📊 Data visualization (Syncfusion)
- 🗄️ SQLite database integration
- 🌐 API call to external service (https://jsonplaceholder.typicode.com)
- 🖱️ Simple modern UI

## 🧩 Features

- Add users (Name + Email) to local database
- View all users stored in database
- Fetch users from external API
- Display all users in an elegant WPF interface

## 🖼️ Screenshots

### Main Dashboard
![Dashboard Screenshot](screenshots/dashboard.png)

## 🚀 How to Run

1. Download the latest release from [Releases](https://github.com/YOUR_USERNAME/YOUR_REPO/releases)
2. Extract and run `WpfDashboard.exe`
3. Use the buttons to interact with the database or load API data

## 🧱 Built With

- WPF (.NET 8)
- SQLite (`System.Data.SQLite`)
- HttpClient for API requests
- Syncfusion.WPF.Charts

## 📁 Project Structure

- `DataAccess/` – SQLite and API helper classes
- `MainWindow.xaml` – Main UI layout
- `MainWindow.xaml.cs` – Code-behind for logic
- `dashboard.db` – SQLite database file

---

**MIT License**
