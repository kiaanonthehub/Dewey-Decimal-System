# Dewey Decimal Application 

## Table of Contents
1. [Software](#Software)
2. [Introduction](#Introduction)
3. [Purpose](#Purpose)
4. [Installation](#Installation)
5. [Task 1](#Task-1)  
[Technical Requirements](#Technical-Requirements)  
[Gamification Features](#Gamification-Features)
6. [Task-2](#Task-2)  
[Technical Requirements](#Technical-Requirements-1)  
[Gamification Features](#Gamification-Features-1)  
7. [Task 1 & Task 2](#Task-1-&-Task-2)  
[Bonus Features](#Bonus-Features)  
8. [Links](#Links)
9. [Contact](#Contact)
--- 

### Software
-  Visual Studio 2022
-  C# Programming Language
-  Winforms & Class Library .cproj
---

### Introduction
-  This is a Windows application built on the .NET 6 framework. 
-  The UI is built on WinForms .NET 6 C# which had a dependency on the Class Libaray .NET 6 C# which contains all the logic of the application.
-- Data is stored in a JSON File.
---

### Purpose
The Dewey Decimal System is fundamental to how everything is organised in the library.

But the head librarian has found that even novice librarians sometimes get bored when they must learn about the details of the system. 

The purpose of the training software that you will develop for the library, is to make learning about the system fun and engaging.

After using the training software, the user must be able to:

-  Identify which broad area a book belongs to.
-  Find the call number for a specific topic.
-  Correctly replace a book in its position on a shelf.
---

### Installation
1.  Download the file (FarmCentral_ST10116983.zip) or Clone the repository from GitHub  
2.  Locate the downloaded file under your downloads in File Explorer. Right click on the file and select Extract All and set the location path to your desktop.  
3.  Then you would need to open the solution explorer and right click on the solution and select "Build". - This will copy the .dll files to the bin folder.  
4.  Simplty there after press f5 on your keyboard to run the application.  
---

## Task 1

### Technical Requirements
-  Make use of a list to store the generated call numbers - I integrated a Single Linked List and List
-  I have implemented a recusive quick sort algorithm 
---

### Gamification Features
-  Leaderboard
-  Countdown Timer
-  Points System & Level Difficulty
---

## Task 2

### Technical Requirements
-  Store the call numbers and their descriptions in a dictionary.

### Gamification Features
-  Leaderboard
-  Countdown Timer
-  Points System & Level Difficulty
---
## Final POE
1.  Create a file containing the data that was gathered in the research part of this task in a format that your application can read.  
2.  Enable the Finding call numbers task.  
3.  When the user chooses Finding call numbers, the application must load the Dewey Decimal classification data into memory from the file created in Step 1.  
4.  The quiz must work as follows:  
-  For each question, randomly select a third-level entry from the data, for example, 752 Color. Display only the description, not the call number.  
-  Display four top-level options to the user to choose between, one of which must be the correct one and the other three randomly selected incorrect answers. For example: 000 General 400 Language 700 Arts & Recreation (Correct answer) 800 Literature  
- For the options, display both the call number and description. Display the options in numerical order by call number.  
- If the user selects the correct option, show them four options from the next level until the most detailed level is reached.  
- If the user selects the wrong option anywhere along the way, indicate this and then ask the next question.  
5. Implement a gamification feature to motivate users to keep using the application. You may use the same one as before or choose to implement a different one.  

### Technical Requirements
-  Binary Tree Data Structure

### Gamification Features
-  Leaderboard
-  Countdown Timer
-  Points System & Level Difficulty
---

## Task 1 , Task 2 & Final POE

### Bonus Features
-  Single Linked Lists
-  Json Serialization and Deserialization
-  Json Files for data storage
-  Advanced LINQ queries
-  Sorting Algorithms
-  Advanced UI Gestures – Drag and Drop feature
-  Custom Countdown Timer Class
---

## Links
-  Task 1 Video Presentation (https://youtu.be/VcTeVgUjbuY)   
-  Task 2 Video Presentation (https://www.youtube.com/watch?v=hzfGaSsPjNQ)
-  Final POE Video Presentation (https://youtu.be/qYSe-F0KH4s)
---

## Contact
-  Version No. 2.0.0
-  Release Date: 21/09/2022
-  Updated on : 25/10/2022
-  Author : Maharaj Kiaan
-  Contact Detail : st10116983@vcconnect.edu.za
