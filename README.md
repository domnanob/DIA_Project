# DIA_Project

A Windows Forms application created as part of my **technical school final exam**, designed to help teachers manage student tests and grading.

---

## 🧠 Project Overview

**DIA_Project** is a desktop application built in **C# with WinForms** that enables:
- 👩‍🏫 Teachers to create and manage exam tests
- 🧑‍🎓 Students to view and submit their answers
- 📊 Teachers to review submissions, assign scores, and track student progress

The goal of the project was to deliver a **simple but functional classroom test system** with a friendly interface and basic workflow for real classroom use. :contentReference[oaicite:1]{index=1}

---

## 🛠️ Features

✔ Create and edit test questions  
✔ Students can submit answers to tests  
✔ Teachers can review and score submissions  
✔ Results and scores are stored in a local database  

---

## 🧩 Project Structure

```

DIA_Project/
├── DIA_Project.sln            # Visual Studio solution
├── /DIA_Project/              # WinForms app source code
├── dia_db.sql                 # Database schema
├── Domnánovich Bálint_Szakdolgozat_2022.pdf   # Project documentation
├── TESTING.txt                # Notes and test plan
└── .gitignore

````

---

## 💾 Database

This project uses a local SQL database defined by **dia_db.sql**, which includes the structure for storing:
- Tests
- Questions
- Student submissions
- Result entries

To set it up:
1. Import `dia_db.sql` into your SQL Server or local database engine
2. Update the connection string in the source code as needed

---

## 📦 Requirements

- Windows OS
- .NET Framework (Version supported by WinForms)
- SQL Server / Local database for data storage
- Visual Studio (to build from source)

---

## 🚀 Getting Started

1. Clone the repo:

```bash
git clone https://github.com/domnanob/DIA_Project.git
````

2. Open `DIA_Project.sln` in Visual Studio
3. Restore NuGet packages
4. Build and run the solution

---

## 📚 Documentation

The PDF file `Domnánovich Bálint_Szakdolgozat_2022.pdf` contains the **project report**, explaining the system design, database structure, and implementation details. ([GitHub][1])

---

## 📌 Notes

* This project was created for a high-school final exam and focuses on functionality and clarity rather than production-grade architecture.
* Contributions are welcome to modernize, extend features, or improve UX/UI.

---

## 🧑‍💻 About the Author

**Bálint Domnánovich** — student and developer passionate about building tools that solve real problems.
Check out my other projects on GitHub!
👉 [https://github.com/domnanob](https://github.com/domnanob)

---

🎉 *Thanks for checking out this project!*
