
# Dictionary Application

This project is a simple Dictionary Application designed as part of an assessment for a .NET Developer role. It enables users to translate English words or phrases into Hungarian.

## Features
- Frontend built with React to handle user input and display translations or error messages.
- Backend developed with C# .NET Core that connects to a MySQL database to retrieve translations.
- MySQL database containing the dictionary data for English-Hungarian translations.
- Seamless integration between frontend and backend via API calls.

## Project Overview
The application works as follows:
1. The user enters an English word in the frontend.
2. The frontend sends a request to the backend API.
3. The backend queries the MySQL database for the translation.
4. The result (translation or error message) is sent back to the frontend and displayed to the user.

## Tools and Technologies Used
- **Frontend**: React
- **Backend**: C# .NET Core
- **Database**: MySQL
- **Environment**: Node.js for frontend setup and development

## Database
A MySQL database named `DictionaryDB` was created with a table containing the following columns:
- `Id` (Primary Key, Auto Increment)
- `English` (Text)
- `Hungarian` (Text)

### Loading the Database
The provided translation data was in `.xlsx` format (Translation_Template.xlsx). This file was converted to `.csv` format and loaded into the MySQL database using the MySQL Workbench import functionality.

## Frontend
The frontend application was created using React:
- A form allows users to input an English word.
- The app makes an API call to the backend to fetch the corresponding Hungarian translation.
- If no translation is found, an error message is displayed.

## Backend
The backend API was created using C# .NET Core:
- It exposes an endpoint that receives a word from the frontend, queries the MySQL database, and returns the translation or an error response.
- CORS policy was configured to allow communication between the React frontend and the backend.

## Deployment
The React frontend was built for production using the following command:
```
npm run build
```
This created a `build` folder containing the production-ready static files.

## How to Run the Application
1. Clone the repository from GitHub.
2. Import the provided SQL file to set up the MySQL database.
3. Run the backend:
   - Navigate to the backend folder and start the API using:
     ```
     dotnet run
     ```
   - The backend will run on `https://localhost:7263`.
4. Run the frontend:
   - Navigate to the frontend folder and start the React app using:
     ```
     npm start
     ```
   - The frontend will run on `http://localhost:3000`.

## Additional Notes
- Ensure that MySQL, .NET, and Node.js are properly installed and configured.
- The provided code includes error handling for API communication and database queries.

## Contact
For further assistance, feel free to reach out to me via GitHub or email.
