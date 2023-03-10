# Student Database School Project :)

## Objective (Another boring C# Project)
To allow you to review and brush up on concepts from your C# and database classes, you need to develop a program that accesses and manipulates a Microsoft SQL Server database using SQL.

## Details of Assignment
The purpose of this assignment is to create a database to keep track of students in various courses, led by a particular instructor.  Users will logon to your system for the purpose of maintaining the list of courses, students, and instructors and be able to view them in relationship to each other.  In other words, be able to see a list of students and then see which classes the student is enrolled in with which instructor.  Or be able to get the list of students that are enrolled in a specific course.

## Application Design
Application will include 4 database tables which are defined below.  Designing and implementing the appropriate primary and foreign key constraints/relationships are integral and required.

This should be an interactive program that uses .NET to create a Windows based GUI. You may design the multiple screens as you see fit. The program should allow the following actions:


- Provide Sign Up/Registration of a new user. 
- Display a log-on screen for logging into the application. 
- Handle both proper and failed logon attempts
## Display
- The application must provide the ability to select from all the classes, students, or teachers and when selected, show all the related information in appropriate controls (e.g., labels or text boxes).  For instance, when selecting a student, controls should update with the student id, name, major, grade level and age.
- There must be the ability to show all related information for a particular entity when selected.  For instance, if a class is chosen, then the instructor and all the students should be displayed.  (HINT: A data grid might be a helpful control to use in this case).
- Be able to search for a student’s classes; for a teacher’s students; and for a class roster.  Usually, this is accomplished by entering letters/numbers into a textbox that looks for their last name one letter at a time. The members that have those letters in their name (or course number) should dynamically appear in a grid.

## Insert
- Be able to add a new course, student, or instructor into the DB

## Update
- With a current student, teacher or course information populated on the screen; allow a user to change the information and resubmit it to the database

## UX
- The user interface and screen design are important and meaningful. All processing should either prevent the possibility of making an error or display a message box which indicated an error has been made and allow the user to correct the error or continue processing without interruption
- Must be able to exit the program gracefully
