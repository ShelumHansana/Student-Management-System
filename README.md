<div align="center">

<img src="https://capsule-render.vercel.app/api?type=waving&color=0:2193b0,100:6dd5ed&height=200&section=header&text=Student%20Management%20System&fontSize=42&fontColor=ffffff&animation=fadeIn&fontAlignY=35&desc=IT%20Diploma%20Final%20Project%20%E2%80%94%20ESOFT%20Metro%20Campus&descSize=16&descAlignY=55&descColor=e0f7ff" width="100%" />

<br/>

[![License: MIT](https://img.shields.io/badge/License-MIT-2193b0.svg?style=for-the-badge)](LICENSE)
[![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=csharp&logoColor=white)]()
[![.NET](https://img.shields.io/badge/.NET_Framework-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)]()
[![SQL Server](https://img.shields.io/badge/SQL_Server-CC2927?style=for-the-badge&logo=microsoftsqlserver&logoColor=white)]()
[![WinForms](https://img.shields.io/badge/Windows_Forms-0078D6?style=for-the-badge&logo=windows&logoColor=white)]()

**A desktop-based student management system with role-based access for Teachers, Students, and Parents.**
**Built with C# Windows Forms and Microsoft SQL Server.**

</div>

---

## 📋 Table of Contents

- [Overview](#-overview)
- [Features](#-features)
- [Tech Stack](#-tech-stack)
- [Architecture](#-architecture)
- [Database Schema](#-database-schema)
- [Getting Started](#-getting-started)
- [Screenshots](#-screenshots)
- [Project Structure](#-project-structure)
- [Roadmap](#-roadmap)
- [License](#-license)

---

## 🔍 Overview

The **Student Management System** is a comprehensive Windows desktop application developed as the final project for the IT Diploma program at ESOFT Metro Campus. It provides a complete solution for managing student records, academic marks, and user authentication with three distinct user roles.

### 🎯 Problem Statement

Schools and educational institutions face challenges with:
- Manual, paper-based student registration
- Difficulty tracking student academic performance
- Lack of separate access portals for teachers, students, and parents
- No centralized system for notes and communication

### 💡 Solution

A role-based desktop application that digitizes student management:
- **Teachers** can register students, manage records (CRUD), and enter academic marks
- **Students** can view their marks, calculate grades, and manage personal notes
- **Parents** can monitor their child's academic progress and maintain notes

---

## ✨ Features

<div align="center">

| 👨‍🏫 **Teacher Portal** | 🎒 **Student Portal** | 👨‍👩‍👧 **Parent Portal** |
|---|---|---|
| Student Registration (CRUD) | View Academic Marks | View Child's Marks |
| Auto-generated Index Numbers | Total & Percentage Calculator | Personal Notes (CRUD) |
| Search Students by Index No | Built-in Calculator Tool | Contact Information |
| Enter Subject Marks | Personal Notes (CRUD) | Secure Login |
| Data Grid View | Secure Login & Signup | Signup via Index Verification |

</div>

### Key Highlights

- 🔐 **Role-Based Authentication** — Separate login portals for Teacher, Student, and Parent
- 📝 **Full CRUD Operations** — Create, Read, Update, Delete student records
- 🔢 **Auto Index Number Generation** — Automatic sequential index number assignment (`SIst000001`, `SIst000002`...)
- 📊 **Academic Progress Tracking** — View marks for Mathematics, Science, Sinhala, Buddhism, History, English
- 📱 **Index Number Verification** — Students/Parents must verify their index number before signup
- 🧮 **Built-in Calculator** — Addition, Subtraction, Multiplication, Division, Percentage
- 📓 **Notes System** — Date-based notes with Save, Search, and Delete functionality
- ✅ **Input Validation** — NIC number validation, phone number validation, gender selection checks
- 🔒 **Password Security** — Show/hide password toggle with system password characters

---

## 🛠️ Tech Stack

<div align="center">

| Layer | Technology | Purpose |
|---|---|---|
| **Language** | ![C#](https://img.shields.io/badge/C%23-239120?style=flat-square&logo=csharp&logoColor=white) | Application logic |
| **Framework** | ![.NET](https://img.shields.io/badge/.NET_Framework_4.7+-512BD4?style=flat-square&logo=dotnet&logoColor=white) | Runtime framework |
| **UI** | ![WinForms](https://img.shields.io/badge/Windows_Forms-0078D6?style=flat-square&logo=windows&logoColor=white) | Desktop GUI |
| **Database** | ![SQL Server](https://img.shields.io/badge/SQL_Server_2019-CC2927?style=flat-square&logo=microsoftsqlserver&logoColor=white) | Data storage |
| **ORM** | ![ADO.NET](https://img.shields.io/badge/ADO.NET-512BD4?style=flat-square&logo=dotnet&logoColor=white) | Database connectivity |
| **IDE** | ![Visual Studio](https://img.shields.io/badge/Visual_Studio_2022-5C2D91?style=flat-square&logo=visualstudio&logoColor=white) | Development environment |

</div>

---

## 🏗️ Architecture

```mermaid
graph TB
    subgraph Presentation["🖥️ Presentation Layer (Windows Forms)"]
        TL["Teacher Login & Dashboard"]
        SL["Student Login & Dashboard"]
        PL["Parent Login & Dashboard"]
    end

    subgraph Business["⚙️ Business Logic Layer"]
        Auth["Authentication Manager"]
        CRUD["Student CRUD Manager"]
        Marks["Marks Manager"]
        Notes["Notes Manager"]
        Calc["Calculator Engine"]
        IDGen["Index Number Generator"]
    end

    subgraph Data["💾 Data Access Layer (ADO.NET)"]
        DB["SQL Server Database"]
    end

    TL --> Auth
    SL --> Auth
    PL --> Auth
    TL --> CRUD
    TL --> Marks
    TL --> IDGen
    SL --> Marks
    SL --> Notes
    SL --> Calc
    PL --> Marks
    PL --> Notes
    Auth --> DB
    CRUD --> DB
    Marks --> DB
    Notes --> DB
```

---

## 🗄️ Database Schema

The system uses **7 database tables** for complete data management:

```mermaid
erDiagram
    TeacherLogin {
        int ID PK
        string Username
        string Password
    }
    StudentSignup {
        int ID PK
        string IndexNo FK
        string Username
        string Password
    }
    ParentSignup {
        int ID PK
        string IndexNo FK
        string Username
        string Password
    }
    StudentRegistration {
        int ID PK
        string IndexNo UK
        string FullName
        string NIC
        string Gender
        string Address
        string PhoneNo
    }
    StudentMarks {
        int ID PK
        string IndexNo FK
        int Mathematics
        int Science
        int Sinhala
        int Buddhism
        int History
        int English
    }
    StudentNotes {
        int ID PK
        string IndexNo FK
        date NoteDate
        string NoteContent
    }
    ParentNotes {
        int ID PK
        string IndexNo FK
        date NoteDate
        string NoteContent
    }

    TeacherLogin ||--o{ StudentRegistration : "manages"
    StudentRegistration ||--o| StudentMarks : "has"
    StudentRegistration ||--o{ StudentNotes : "writes"
    StudentRegistration ||--o| StudentSignup : "creates"
    StudentRegistration ||--o| ParentSignup : "creates"
    StudentRegistration ||--o{ ParentNotes : "linked"
```

---

## 🚀 Getting Started

### Prerequisites

- **Visual Studio 2019+** (Community Edition or higher)
- **Microsoft SQL Server 2017+** (Express Edition works)
- **SQL Server Management Studio (SSMS)** — for database setup
- **.NET Framework 4.7+** runtime

### Installation

```bash
# 1. Clone the repository
git clone https://github.com/ShelumHansana/Student-Management-System.git
cd Student-Management-System
```

### Database Setup

1. Open **SQL Server Management Studio (SSMS)**
2. Connect to your SQL Server instance
3. Create a new database named `StudentManagementDB`
4. Run the SQL scripts in the `/Database` folder (if available), or create the tables using the schema above
5. Update the connection string in the project:

```csharp
// Update in your connection string configuration
string connectionString = "Data Source=YOUR_SERVER;Initial Catalog=StudentManagementDB;Integrated Security=True";
```

### Running the Application

1. Open `StudentManagementSystem.sln` in **Visual Studio**
2. Restore NuGet packages if prompted
3. Set the startup project
4. Press **F5** or click **Start** to run

### Default Credentials

| Role | Username | Password |
|---|---|---|
| Teacher | `admin` | `admin123` |

> **Note:** Students and Parents must register via the signup form after verifying their index number.

---

## 📸 Screenshots

> **📌 Coming Soon** — Screenshots of each portal will be added here.

<!--
Uncomment and add your screenshots:

<div align="center">

### Teacher Portal
<img src="screenshots/teacher-login.png" width="45%" />
<img src="screenshots/teacher-dashboard.png" width="45%" />

### Student Portal
<img src="screenshots/student-login.png" width="45%" />
<img src="screenshots/student-marks.png" width="45%" />

### Parent Portal
<img src="screenshots/parent-login.png" width="45%" />
<img src="screenshots/parent-view.png" width="45%" />

</div>
-->

---

## 📁 Project Structure

```
Student-Management-System/
├── Database/
│   └── setup.sql              # Database creation scripts
├── Properties/
│   └── AssemblyInfo.cs        # Assembly metadata
├── Resources/
│   └── images/                # UI icons & backgrounds
├── Forms/
│   ├── LoginForm.cs           # Main login selection
│   ├── TeacherLogin.cs        # Teacher authentication
│   ├── TeacherDashboard.cs    # Student CRUD & marks entry
│   ├── StudentLogin.cs        # Student authentication
│   ├── StudentSignup.cs       # Student registration
│   ├── StudentDashboard.cs    # Marks view & calculator
│   ├── ParentLogin.cs         # Parent authentication
│   ├── ParentSignup.cs        # Parent registration
│   ├── ParentDashboard.cs     # Child progress view
│   ├── Calculator.cs          # Built-in calculator
│   └── Notes.cs               # Notes management
├── Helpers/
│   ├── DatabaseHelper.cs      # ADO.NET database operations
│   ├── ValidationHelper.cs    # Input validation utilities
│   └── IndexGenerator.cs      # Auto index number logic
├── App.config                 # Connection string & settings
├── Program.cs                 # Application entry point
├── StudentManagementSystem.sln # Solution file
└── README.md
```

---

## 🗺️ Roadmap

- [x] Role-based authentication (Teacher, Student, Parent)
- [x] Student registration with CRUD operations
- [x] Auto-generated index numbers
- [x] Subject marks entry & viewing
- [x] Built-in calculator
- [x] Personal notes system
- [x] Input validation (NIC, phone, etc.)
- [ ] Export reports to PDF/Excel
- [ ] Grade calculation & GPA system
- [ ] Email notifications to parents
- [ ] Attendance tracking module
- [ ] Migrate to WPF for modern UI

---

## 📄 License

This project is licensed under the **MIT License** — see the [LICENSE](LICENSE) file for details.

---

<div align="center">

**Built with ❤️ by [Shelum Hansana](https://github.com/ShelumHansana)**

*IT Diploma Final Project — ESOFT Metro Campus*

<img src="https://capsule-render.vercel.app/api?type=waving&color=0:2193b0,100:6dd5ed&height=120&section=footer" width="100%" />

</div>
