# Driving License Management System

**Description:**  
The Driving License Management System is a robust desktop application built using **C# (Windows Forms)** and **SQL Server**. Designed with a **three-tier architecture**, the system streamlines the process of managing driving license-related operations, such as issuing licenses, managing applications, and handling user accounts. The project includes more than **45 forms and controls**, making it a comprehensive solution for license management.

---

## Key Features

### 1. Login System
- **Remember Me Feature:** Stores username and password in a text file if login credentials are correct.
- **Validation:** Only stores credentials for successful logins.
- **Database Integration:** Authenticates user credentials directly with the database.

### 2. License Management
- Issue new driving licenses (two types: **Local** and **International**).
- Renew existing licenses.
- Replace lost or damaged licenses.
- Issue temporary driving licenses.
- Retake driving tests.

### 3. Application Workflow
- **Person Registration:**
  - Collects personal information, including name, national ID, country, address, and photo.
- **Application Submission:**
  - Includes three mandatory tests:
    - **Vision Test**
    - **Written Test**
    - **Street Test**
  - Tracks test results, associated fees, and notes.
- **License Issuance:**
  - After passing all tests, users can apply for a license.

### 4. License Classes
Supports multiple driving license classes, including:
- Heavy Motors
- Ordinary Vehicles
- Trucks and Buses
- Small Bikes
- Additional classes (customizable).

### 5. Application Management
- View, update, or delete submitted applications.
- Manage various application types:
  - New licenses (Local/International).
  - Renewals.
  - Replacements.

### 6. Driver Management
- Converts registered persons into drivers upon license issuance.
- Tracks all driver-related information.

### 7. User Management
- Add, update, or delete system users.
- Assign specific permissions for application usage.

### 8. Account Settings
- Displays current user information dynamically using a **global class**.
- Allows users to update account details and log out.

---


## Forms and Classes
This project includes more than 45 forms and classes, each serving specific functionalities within the application. Below are the key forms and classes:

### Forms
- **Login and User Management**:
  - `frmLoginScreen`
  - `frmAddEditUser`
  - `frmManageUsers`
  
- **Driving License Services**:
  - `frmApplicationDetails`
  - `frmDrivingLicenseInfo`
  - `frmNewLocalDrivingLicenseApplication`
  - `frmNewInternationalDrivingLicenseApplication`
  - `frmRenewLicenseApplication`
  - `frmReplacementForDamagedOrLost`
  
- **Testing and Scheduling**:
  - `frmTestAppointment`
  - `frmScheduleTest`
  - `frmVisionTest`
  - `frmWrittenTest`
  - `frmStreetTest`
  
- **Administrative Tools**:
  - `frmManageApplicationsTypes`
  - `frmDetainLicense`
  - `frmManageDetailedLicense`
  - `frmAccountSettings`
  
### Classes
- **Business Logic Layer (BLL)**:
  - Implements core logic and validation for managing licenses, tests, and users.

- **Data Access Layer (DAL)**:
  - Handles communication with the SQL Server database.
  - Contains methods for CRUD operations.

---

## Controls
This project features multiple user controls that enhance modularity and reusability:

- **Custom User Controls**:
  - `ucLoginInfo`: Displays login-related information dynamically.
  - `ucPersonInfo`: Captures and displays personal details of applicants.
  - `ucApplicationBasicInfo`: Displays essential details about driving license applications.
  - `ucInternationalDriverInfo`: Specialized control for handling international license data.
  - `ucLicenseFilter`: Provides filtering options for managing licenses effectively.

---

## Technologies Used
- **Programming Language**: C#
- **Framework**: Windows Forms
- **Database**: SQL Server
- **Architecture**: Three-Tier (Presentation Layer, Business Logic Layer, Data Access Layer)

---

## How to Use

## Installation and Usage
1. Clone the repository: 
   ```bash
   git clone https://github.com/babader24/DVLD.git

### Prerequisites
- **Software:**
  - Microsoft SQL Server (database setup required).
  - Visual Studio for running the application.

### Steps
1. **Set up the database:** Import the SQL script provided to initialize the database.
2. ** Add Conncetion string to clsDataAccessSetting and add your sqlServer Password and ID
3. **Run the application:** Open the project in Visual Studio and start the application.
4. **Login:** User Ahmed password 123 Or take it from database 
5. **Manage Data:** Use the various forms to register persons, manage applications, issue licenses, and more.

---

## Code Example

Here’s an example of how the Remember Me feature stores credentials in a text file in the Login Form:

```csharp



  private void btnLogin_Click(object sender, EventArgs e)
  {
      clsUser user= clsUser.FindByUsernameAndPassword(txtUserName.Text.Trim(),txtPassword.Text.Trim());

      if (user != null) 
      { 

          if (chkRememberMe.Checked )
          {
              //store username and password
              clsGlobal.RememberUsernameAndPassword(txtUserName.Text.Trim(), txtPassword.Text.Trim());

          } 
            else
          {
              //store empty username and password
              clsGlobal.RememberUsernameAndPassword("", "");

          }

          //incase the user is not active
          if (!user.IsActive )
          {

              txtUserName.Focus();
              MessageBox.Show("Your accound is not Active, Contact Admin.", "In Active Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
              return;
          }

           clsGlobal.CurrentUser = user;
           this.Hide();
           frmMain frm = new frmMain(this);
           frm.ShowDialog();


      } else
      {
          txtUserName.Focus();
          MessageBox.Show("Invalid Username/Password.", "Wrong Credintials", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }    

  }

```
Here’s the Code In Global Class 

```csharp

  public static bool RememberUsernameAndPassword(string Username, string Password)
  {

      try
      {
          //this will get the current project directory folder.
          string currentDirectory = System.IO.Directory.GetCurrentDirectory();


          // Define the path to the text file where you want to save the data
          string filePath = currentDirectory + "\\data.txt";

          //incase the username is empty, delete the file
          if (Username=="" && File.Exists(filePath)) 
          { 
               File.Delete(filePath);
              return true;

          }

          // concatonate username and passwrod withe seperator.
          string dataToSave = Username + "#//#"+Password ;

          // Create a StreamWriter to write to the file
          using (StreamWriter writer = new StreamWriter(filePath))
          {
              // Write the data to the file
              writer.WriteLine(dataToSave);
             
            return true;
          }
      }
      catch (Exception ex)
      {
         MessageBox.Show ($"An error occurred: {ex.Message}");
          return false;
      }

  }

  public static bool GetStoredCredential(ref string Username, ref string Password)
  {
      //this will get the stored username and password and will return true if found and false if not found.
      try
      {
          //gets the current project's directory
          string currentDirectory = System.IO.Directory.GetCurrentDirectory();

          // Path for the file that contains the credential.
          string filePath  = currentDirectory + "\\data.txt";

          // Check if the file exists before attempting to read it
          if (File.Exists(filePath))
          {
              // Create a StreamReader to read from the file
              using (StreamReader reader = new StreamReader(filePath))
              {
                  // Read data line by line until the end of the file
                  string line;
                  while ((line = reader.ReadLine()) != null)
                  {
                      Console.WriteLine(line); // Output each line of data to the console
                      string[] result = line.Split(new string[] { "#//#" }, StringSplitOptions.None);

                      Username = result[0];
                      Password = result[1];
                  }
                  return true;
              }
          }
          else
          {
              return false;
          }
      }
      catch (Exception ex)
      {
          MessageBox.Show ($"An error occurred: {ex.Message}");
          return false;   
      }

  }

```

