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

  ## Additional Features
  - Option for deletion of submitted forms
  - Option for editing submitted form

## Screenshots

### Main Form

![Main Form](https://github.com/shubhsardana29/slidely/assets/52607235/f67da1e3-af18-4a75-b565-d82f06fed60b)


### Create Submission Form

![Create Submission Form](https://github.com/shubhsardana29/slidely/assets/52607235/5440a1f7-4f87-4712-95c2-1aeb5f62a8c8)


### View Submissions Form

![View Submissions Form](https://github.com/shubhsardana29/slidely/assets/52607235/66d2d106-8be2-4efc-8005-34ef4f7006f0)


## Installation

### Prerequisites

- [Visual Studio](https://visualstudio.microsoft.com/) (not Visual Studio Code)
- .NET Framework
- NuGet Package Manager (for installing `Newtonsoft.Json`)

### Steps

1. Clone the repository:
   ```sh
   git clone https://github.com/shubhsardana29/slidely.git
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
   - Hosted BASE URL: https://slidely.onrender.com
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
  - GithubLink (string)
  - StopwatchTime (string)
  - Purpose: Save a new submission

    ```
    example:
    curl -X POST https://slidely.onrender.com/submit \
     -H "Content-Type: application/json" \
     -d '{
           "name": "John Doe",
           "email": "john.doe@example.com",
           "phone": "1234567890",
           "GithubLink": "https://github.com/johndoe",
           "StopwatchTime": "00:05:30"
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
    
- PUT /update

    - Query Parameters:
       - index (integer)
     - Purpose: Updates a submitted form with given index
   
       ```
       example:
       curl -X PUT https://slidely.onrender.com/update?index=0 \
        -H "Content-Type: application/json" \
        -d '{
              "name": "Updated Name",
              "email": "updatedjohn.doe@example.com",
              "phone": "1234567890",
              "GithubLink": "https://github.com/johndoe",
              "StopwatchTime": "00:05:30"
            }'
       ```
    
- DELETE /delete

    - Query Parameters:
       - index (integer)
     - Purpose: Deletes a submitted form with given index
   
       ```
       example:
       curl -X DELETE "https://slidely.onrender.com/delete?index=0"
       ```

## Data Storage
The backend server stores all submissions in a JSON file (db.json) located in the backend folder. Here is an example of how data is stored:
```
[
  {
    "name": "John Doe",
    "email": "john.doe@example.com",
    "phone": "1239457890",
    "GithubLink": "https://github.com/johndoe",
    "StopwatchTime": "00:05:30"
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
