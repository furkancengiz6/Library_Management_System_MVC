# Library Management System

## Project Overview
The **Library Management System** is a simple web application designed to manage books and authors in a library setting. The application provides the ability to add, edit, delete, and list books and authors. It allows users to view details about books and authors, as well as manage their data.

### Project Purpose
This project aims to streamline the management of books and authors for libraries, schools, and universities, using a simple and intuitive interface.

### Target Audience
Libraries, schools, universities, and anyone who needs a simple book and author management system.

---

## Technical Architecture and Technologies Used

- **ASP.NET Core MVC**: For backend development.
- **C#**: Used for business logic and server-side processing.
- **Visual Studio 2022**: The development environment.
- **HTML, CSS, JavaScript**: For frontend and UI design.
- **Model-View-Controller (MVC) Pattern**: Follows the MVC architecture for better structure and separation of concerns.
- **OOP (Object-Oriented Programming)**: Applied to ensure clean, maintainable, and reusable code.
- **DRY Principle**: The ViewModels are used to avoid repetition of code.

---

## Application Features and Functionalities

### Author Management
- **List Authors**: View all authors.
- **View Author Details**: View details like name, birth date, and books written by the author.
- **Add Author**: Add a new author to the system.
- **Edit Author**: Modify existing author details.
- **Delete Author**: Remove an author from the system.

### Book Management
- **List Books**: View all books in the library.
- **View Book Details**: See details like title, author, ISBN, genre, etc.
- **Add Book**: Add a new book to the library.
- **Edit Book**: Modify book details.
- **Delete Book**: Remove a book from the library.

---

## Data Structures and Models

- **Author Model**: Contains details about the author such as name, surname, birth date, etc.
- **Book Model**: Contains details about the book such as title, author, genre, ISBN, and copies.
- **ViewModels**:
  - `AuthorViewModel`: Carries basic author details.
  - `BookListViewModel`: Carries a list of books with basic details.
  - `BookDetailsViewModel`: Carries book details.
  - `BookCreateViewModel`: Used for adding new books.

---

## Code Structure and Layers

- **Controller Layer**:
  - `AuthorController`: Manages author-related actions.
  - `BookController`: Manages book-related actions.
- **Model Layer**: Contains the models for books and authors.
- **View Layer**: Displays data to the user via HTML pages.
- **ViewModel Layer**: Contains classes for organizing data for views.

---

## User Interface (UI)

- **Forms**: Forms for adding and editing authors and books.
- **Listing Pages**: Pages that display lists of authors and books.
- **Validations**: Both server-side and client-side validations are implemented to ensure correct data input.
- **Responsive Design**: The application adapts to different screen sizes, including mobile devices.

---

## Installation and Usage

### Installation Steps
1. Open the project in **Visual Studio 2022**.
2. No additional setup or NuGet packages are required, as they are already included.

### Running the Application
- The application can be run directly in **Visual Studio 2022**.
- It can be accessed in a browser at `http://localhost:5000`.

---

## Author List


![Author List](https://github.com/user-attachments/assets/122d6220-398e-40be-838f-c22e095baf0e)
 

## Author Update


![Author Update](https://github.com/user-attachments/assets/ab5d552a-0a8b-44a7-a5f7-f56c906e3977)


## Author Add


![Author Create](https://github.com/user-attachments/assets/40e0f6c7-a759-460a-97ce-4e952171cd7b)


## Author Delete


![Author Delete](https://github.com/user-attachments/assets/d3430997-eff0-4c9d-9553-fb6d927de6c8)


## Author Details


![Author Details](https://github.com/user-attachments/assets/25b12d43-0409-4a62-9be6-383519f3fc11)



## Book List


![Book List](https://github.com/user-attachments/assets/d74e0f2f-e0cd-499a-b5f1-97cbfa696128)


## Book Add


![Book Create](https://github.com/user-attachments/assets/81a2c8b0-b6c6-4089-a909-defa993d5863)


## Book Delete


![Book Delete](https://github.com/user-attachments/assets/08c423be-d999-4e3d-8349-ee9d257273fd)


## Book Details


![Book Details](https://github.com/user-attachments/assets/f2572216-6827-4a95-a4db-e7475f00b056)


## Book Update


![Book Update](https://github.com/user-attachments/assets/3170c59f-bb6c-4735-bb5f-d985307cdfdd)


## Banner Partial


![Banner Partial](https://github.com/user-attachments/assets/bab6a63b-2c40-4830-97ac-11992aa0b04a)


## License and Copyright

- **License**: This project is licensed under the [Project License] (if applicable).
- **Copyright**: All rights reserved.
