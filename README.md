# FormApp

FormApp is a Windows Desktop Application built using Visual Basic that replicates the basic functionality of Google Forms. It allows users to create and view submissions. The backend server, built with TypeScript and Express, handles the storage and retrieval of submissions.

## Table of Contents

- [Features](#features)
- [Screenshots](#screenshots)
- [Installation](#installation)
- [Usage](#usage)
- [Backend API](#backend-api)
- [Keyboard Shortcuts](#keyboard-shortcuts)
- [Contributing](#contributing)


## Features

- Create new submissions with fields for Name, Email, Phone Number, GitHub repo link, and a stopwatch.
- View submissions with navigation buttons to browse through entries.
- Hosted backend to handle API requests.

## Screenshots

### Main Form

![Main Form](screenshots/main_form.png)

![Screenshot 2024-06-21 at 3 14 49 PM](https://github.com/shubhsardana29/slidely/assets/52607235/6022f8aa-00ed-46a5-b825-6db38d2d5f5b)


![Screenshot 2024-06-21 at 3 15 19 PM](https://github.com/shubhsardana29/slidely/assets/52607235/611d36a9-b0e4-4ffc-9866-60822fd57fdc)



### Create Submission Form

![Create Submission Form](screenshots/create_submission_form.png)

![Screenshot 2024-06-21 at 3 15 44 PM](https://github.com/shubhsardana29/slidely/assets/52607235/c9af8a82-baf5-43ef-833a-455982222373)


### View Submissions Form

![View Submissions Form](screenshots/view_submissions_form.png)

![Screenshot 2024-06-21 at 3 15 33 PM](https://github.com/shubhsardana29/slidely/assets/52607235/90b9b1ca-2b0e-4327-96f3-8c81ca484243)


## Installation

### Prerequisites

- [Visual Studio](https://visualstudio.microsoft.com/) (not Visual Studio Code)
- .NET Framework
- NuGet Package Manager (for installing `Newtonsoft.Json`)

### Steps

1. Clone the repository:
   ```sh
   git clone https://github.com/shubhsardana29/slidely.git
   cd FormApp
   ```
2. Open the solution file (FormApp.sln) in Visual Studio.

3. Install the Newtonsoft.Json package via NuGet Package Manager:
   - Go to Tools > NuGet Package Manager > Manage NuGet Packages for Solution.
   - Search for Newtonsoft.Json and install it.

4. Build the solution in Visual Studio.

5. Run the application.

#### Backend Setup
The backend is already hosted at https://slidely.onrender.com . If you want to run it locally:

  1. ```
     cd backend
     ```
   
2. Install dependencies:
    ```
    npm install
    ```
    
3. Run the server:
    ```
    npm start
    ```

## Usage

### Creating a New Submission:
1. Open the application.
2. Click on Create New Submission or press Ctrl + N.
3. Fill in the fields and use the Start/Stop button to control the stopwatch.
4. Click Submit or press Ctrl + S to submit the form.
   
### Viewing Submissions:
1. Open the application.
2. Click on View Submissions or press Ctrl + V.
3. Use the Previous and Next buttons to navigate through submissions.

## Backend API

### Endpoints

- GET /ping

  - Returns: true
  - Purpose: Health check

    ```
    example:
    curl -X GET https://slidely.onrender.com/ping
    ```
    
- POST /submit

  - Body Parameters:
  - name (string)
  - email (string)
  - phone (string)
  - github_link (string)
  - stopwatch_time (string)
  - Purpose: Save a new submission

    ```
    example:
    curl -X POST https://slidely.onrender.com/submit \
     -H "Content-Type: application/json" \
     -d '{
           "name": "John Doe",
           "email": "john.doe@example.com",
           "phone": "123-456-7890",
           "github_link": "https://github.com/johndoe",
           "stopwatch_time": "00:05:30"
         }'
    ```
    
- GET /read

  - Query Parameters:
    - index (integer)
  - Returns: Submission object at the specified index
  - Purpose: Retrieve a submission by index

    ```
    example:
    curl -X GET "https://slidely.onrender.com/read?index=0"
    ```

## Data Storage
The backend server stores all submissions in a JSON file (db.json) located in the backend folder. Here is an example of how data is stored:
```
[
  {
    "name": "John Doe",
    "email": "john.doe@example.com",
    "phone": "123-456-7890",
    "github_link": "https://github.com/johndoe",
    "stopwatch_time": "00:05:30"
  }
]
```
### Posting Data
When a new submission is made through the CreateSubmissionForm in the desktop application, a POST request is sent to the backend's /submit endpoint. The backend then appends the new submission to the db.json file.

### Reading Data
When the ViewSubmissionsForm in the desktop application requests a submission, it sends a GET request to the backend's /read endpoint with the index of the submission. The backend retrieves the corresponding entry from db.json and returns it.

## Keyboard Shortcuts

  - Ctrl + N: Create New Submission
  - Ctrl + V: View Submissions
  - Ctrl + S: Submit Form (on Create Submission page)

## Contributing
Contributions are welcome! Please follow these steps:

- Fork the repository.
- Create a new branch.
- Make your changes.
- Submit a pull request.
