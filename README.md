# DVLD - Driving & Vehicle License Department

A desktop application for managing the operations of a Driving & Vehicle License Department (DVLD).

The system is designed to manage people, driving license applications, tests, licenses, and related administrative operations through a structured and user-friendly Windows Forms application.

---

## 📌 Project Overview

**DVLD** is a desktop-based management system developed using **C# and .NET Framework** with **Windows Forms**.

The application simulates the workflow of a Driving & Vehicle License Department, allowing authorized users to manage applicants, driving licenses, tests, applications, and other related processes.

The project follows a **3-Tier Architecture** to separate the user interface, business logic, and data access responsibilities.

[▶️ Watch Demo] (https://drive.google.com/file/d/1rNmwosf03ZIDglHpgOunsu5RDTxE3wL5/view?usp=drive_link)
---

## ✨ Features

### 👤 People Management

* Add new people
* Update existing people
* View person details
* Search for people
* Manage personal information
* Store nationality and country information
* Manage personal photos

### 🪪 Driving License Management

* Manage local driving license applications
* Manage international driving licenses
* View license information
* Search for licenses
* Check license status
* Handle license-related operations

### 📝 Application Management

* Create new driving license applications
* View application details
* Track application status
* Manage different application types
* Connect applications with applicants and licenses

### 🧪 Tests Management

The system supports different driving license tests, including:

* Vision Test
* Written Test
* Street Test

The application allows users to schedule and manage test appointments and record test results.

### 🚔 Detained Licenses

* Detain driving licenses
* Record detention information
* Manage fines
* Release detained licenses
* Track release dates and license status

### 👨‍💼 User Management

* User authentication
* Manage system users
* Control access to system operations

---

## 🏗️ Architecture

The project follows a **3-Tier Architecture**:

```text
┌───────────────────────────────┐
│       Presentation Layer      │
│          Windows Forms        │
└───────────────┬───────────────┘
                │
                ▼
┌───────────────────────────────┐
│        Business Layer         │
│      Business Logic / Rules   │
└───────────────┬───────────────┘
                │
                ▼
┌───────────────────────────────┐
│       Data Access Layer       │
│          ADO.NET              │
└───────────────┬───────────────┘
                │
                ▼
┌───────────────────────────────┐
│          SQL Server           │
│           Database            │
└───────────────────────────────┘
```

### Presentation Layer

Responsible for the application's user interface and user interaction.

Technologies include:

* Windows Forms
* C#
* User Controls
* Forms
* DataGridView
* ComboBox
* PictureBox
* Other Windows Forms controls

### Business Layer

Contains the application's business logic and rules.

It acts as an intermediate layer between the Presentation Layer and the Data Access Layer.

### Data Access Layer

Responsible for communicating with the SQL Server database.

The project uses **ADO.NET** and parameterized SQL queries to execute database operations.

---

## 🛠️ Technologies

| Technology               | Purpose                    |
| ------------------------ | -------------------------- |
| C#                       | Main programming language  |
| .NET Framework           | Application framework      |
| Windows Forms            | Desktop user interface     |
| SQL Server               | Database management system |
| ADO.NET                  | Database connectivity      |
| Microsoft.Data.SqlClient | SQL Server communication   |
| Git                      | Version control            |
| GitHub                   | Source code hosting        |

---

## 🗄️ Database

The application uses **Microsoft SQL Server** as its database.

The database contains information related to:

* People
* Users
* Applications
* Application Types
* Licenses
* License Classes
* Tests
* Test Appointments
* Detained Licenses
* Countries
* Other related entities

The application communicates with the database through the Data Access Layer.

---

## 🔐 Security & Database Access

The application uses **parameterized SQL queries** for database operations.

For example, user-related queries use SQL parameters instead of directly concatenating user input into SQL statements.

Database connection settings should be configured locally and sensitive credentials should **not** be committed to the repository.

---

## 📂 Project Structure

```text
DVLD/
│
├── DVLD/
│   └── Presentation Layer
│
├── DVLD_Buisness/
│   └── Business Layer
│
├── DVLD_DataAccess/
│   └── Data Access Layer
│
├── .gitignore
└── README.md
```

---

## ⚙️ Getting Started

### Prerequisites

Before running the application, make sure you have:

* Windows
* Visual Studio
* .NET Framework required by the project
* SQL Server
* SQL Server Management Studio (SSMS)

---

### 1. Clone the Repository

```bash
git clone https://github.com/ahmedghoraib1-del/Full-Project-DVLD-Driving-License-Management-System-.git
```

Then open the solution in Visual Studio.

---

### 2. Configure the Database

Create or restore the required DVLD database in SQL Server.

Then configure the database connection string in the Data Access Layer.

**Do not use real database credentials in source control.**

---

### 3. Build the Project

Open the solution in Visual Studio and build the project:

```text
Build → Build Solution
```

---

### 4. Run the Application

After successfully building the project, run the application from Visual Studio.

---

## 🎥 Demo

Click below to watch a 2-minute demonstration of the DVLD application.

[▶️ Watch Demo]([YOUR_ONEDRIVE_LINK](https://drive.google.com/file/d/1rNmwosf03ZIDglHpgOunsu5RDTxE3wL5/view?usp=drive_link))

---

## 🎯 Project Goals

This project was developed to practice and demonstrate:

* Object-Oriented Programming
* C# development
* Windows Forms development
* SQL Server database design
* ADO.NET
* 3-Tier Architecture
* Separation of concerns
* CRUD operations
* Database relationships
* Parameterized SQL queries
* Exception handling
* Reusable User Controls
* Git and GitHub
* Software project organization

---

## 🚀 Future Improvements

Possible future improvements include:

* Migrating the application to modern .NET
* Developing a Web API
* Building a modern web or mobile frontend
* Adding role-based authorization
* Improving application logging
* Adding automated testing
* Improving database security
* Adding reporting and analytics
* Deploying the system to a cloud environment

---

## 📚 What I Learned

Working on this project provided practical experience in building a complete multi-layer desktop application, from designing the user interface and implementing business rules to communicating with a relational database.

It also provided hands-on experience with software architecture, database operations, source control, and organizing a real-world software project.

---

## 👨‍💻 Author

**Ahmed Ghoraib**

This project was developed as a practical software engineering project for learning and demonstrating C#/.NET development skills.

---

## 📄 License

This project is intended for educational and portfolio purposes.
