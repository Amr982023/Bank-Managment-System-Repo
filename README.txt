# 🏦 Banking Management System  

## 📌 Overview  
A secure and scalable **Banking Management System** built with **3-Tier Architecture** (Presentation, Business, Data Access Layers).  
The system provides client and account management, currency exchange, and integration with third-party APIs, along with security features.  

## ✨ Features  
- 👤 Client Management (create, update, delete, search with pagination)  
- 💳 Account Management (open/close accounts, transfers, balance tracking)  
- 💱 Real-time Currency Exchange using a third-party API  
- 🔐 Security: password hashing, OTP verification, role-based access control  
- 📧 Email notifications & password recovery via Gmail SMTP  
- 🗂️ Windows Registry for configuration persistence  
- 📝 Event Logger for tracking system activities  
- 📊 Detailed reports for transactions and activities  
- 🔄 DTOs with Mapster for object mapping between layers  

## 🛠️ Tech Stack  
- **Language**: C# (.NET)  
- **UI**: WinForms + Guna UI  
- **Backend**: .NET Framework 
- **Database**: SQL Server + T-SQL (Stored Procedures, Transactions)  
- **Data Access**: ADO.NET + Entity Layer  
- **Integration**: Third-party API for currency exchange  
- **Email**: SMTP (Gmail)  

## 📂 Project Structure  
- `/MyBankSystemManagmentProject` → Windows Forms UI    
- `/Data Access Layer` → Data Access Layer (ADO.NET, SQL)  
- `/Business Layer` → Business Layer (DTOs, Mapster, Logic)  
- `/Database/Backup` → Database backup (`BankDB.bak`)  
- `/Database/Schema` → Database Schema (MyBankManagmentSystemSchema.png)  

## 🚀 How to Run  
1. Clone the repository:  
   ```bash
   git clone https://github.com/username/BankingManagementSystem.git

2. Open the solution file in /MyBankSystemManagmentProject in Visual Studio.  

3. Restore NuGet packages.  

4. Update the **connection string** in:  
   - `appsettings.json` (for the API)  
   - Config file (for WinForms)  

5. Restore the **Database Backup** located in `/Database/Backup/BankDB.bak`:  
   - Open **SQL Server Management Studio (SSMS)**  
   - Right-click **Databases** → **Restore Database**  
   - Choose the `.bak` file and restore it  

6. Verify that all stored procedures and initial data are available.  

7. Build and run the project.  

8. Login using the default credentials:  
   - **Username:** `User1`  
   - **Password:** `1234`  

📌 Future Enhancements

🌐 Web & Mobile clients

🌍 Multi-language support

🔗 More third-party API integrations
