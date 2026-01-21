# Kurir.in - Courier Management Application

## Overview

Kurir.in is a comprehensive courier management application designed to streamline logistics and delivery operations in the era of booming online shopping. Built as a database project, it enables administrators to efficiently manage package deliveries, track shipments, and oversee couriers. Couriers (users) can access real-time information about assigned packages, ensuring smooth and reliable service. This application addresses the growing demand for fast, efficient, and trustworthy delivery solutions, enhancing the overall online shopping experience for marketplaces and end-users.

## Features

Kurir.in offers a user-friendly interface with dedicated forms for administration and courier operations. Key features include:

- **Login System**: Secure authentication for admins and couriers to access the application.
- **Admin Dashboard**: Centralized overview for managing all aspects of courier operations, including real-time status updates.
- **Couriers Management**: Form to add, edit, view, and manage courier profiles and assignments.
- **Packages Management**: Tools to create, assign, track, and update package details, including delivery status.
- **History Log**: Comprehensive records of past deliveries for auditing and reporting.
- **User (Courier) Dashboard**: Personalized view for couriers to monitor assigned packages and tasks.
- **View Courier Details**: Detailed profiles and performance metrics for individual couriers.
- **View Packages Details**: In-depth information on specific packages, including tracking history and recipient details.

The application supports efficient package tracking, assignment to couriers, and provides income opportunities for courier partners.

## Technologies Used

- **Frontend**: Windows Forms (VB.NET) – Provides a graphical user interface for the application with forms like LoadingScreenForm, AdminDashboardForm, and others.
- **Backend**: VB.NET – Handles the application logic, form navigation, and database interactions.
- **Database**: MySQL – Used for storing and managing data related to packages, couriers, and delivery history, accessed via MySql.Data.MySqlClient.
- **Other Tools**: 
  - MySql.Data.MySqlClient – A .NET data provider for MySQL to facilitate database connectivity.
  - System.Windows.Forms – For building the desktop application's user interface.
  - Bouncy Castle (Org.BouncyCastle.Asn1.Cmp) – A cryptographic library used for certificate management and secure communication protocols.

## Installation

To set up Kurir.in locally, follow these steps:

1. **Clone the Repository**:
   ```bash
   git clone https://github.com/rafifernandaa/CourierManagementSystem.git
   cd kurir-in

2. **Install Dependencies**:
   - Ensure you have the .NET Framework installed (e.g., .NET Framework 4.8 or compatible version).
   - Install the required NuGet packages in Visual Studio:
     ```bash
     Install-Package MySql.Data
     Install-Package BouncyCastle

3. **Database Setup**:
   - Install and configure a MySQL server (e.g., MySQL Community Server).
   - Create a database named `CourierApp`.
   - Import the schema from `database/schema.sql` (or create tables for `Packages`, `Couriers`, etc., as needed).
   - Configure connection details in the application (e.g., in `AdminDashboardForm.vb` or a config file):
     ```vb
     Dim connectionString As String = "Server=localhost;Database=CourierApp;Uid=root;Pwd=yourpassword;"

4. **Run the Application**:
   - Open the project in Visual Studio.
   - Build and run the solution (F5 or Start in Visual Studio).
   - The application will start with the `LoadingScreenForm` and transition to the `LoginForm`.

## Suggested Workflows
Based on the tech stack (.NET Framework, VB.NET, Windows Forms), we recommend the following GitHub Actions workflow for automating build, test, and deployment processes.
### .NET Desktop
- Purpose: Build, test, sign, and publish a desktop application built on .NET Framework.
- Workflow: A GitHub Actions workflow is available in `.github/workflows/dotnet-desktop.yml.` It automates:
  - Building the VB.NET solution using `msbuild`.
  - Restoring NuGet packages (`MySql.Data`, `BouncyCastle`).
  - (Optional) Running tests if a test project is added (e.g., using MSTest or NUnit).
  - (Optional) Signing executables with a code-signing certificate, leveraging Bouncy Castle’s cryptographic capabilities.
  - Publishing release artifacts (e.g., `.exe` files).
- Setup: Ensure the workflow file is in your repository. Check the Actions tab on GitHub to monitor builds.

To customize the workflow (e.g., add tests or signing), refer to the `.github/workflows/dotnet-desktop.yml` file in the repository.

## Usage

1. Admin Access:
   - Log in with admin credentials.
   - Use the dashboard to view total packages, active couriers, and pending deliveries.
   - Navigate to manage couriers, packages, or view history via buttons or menu options.

2. Courier Access:
   - Log in as a courier.
   - View assigned packages and update delivery statuses.

## Contributing

Contributions are welcome! To contribute:
1. Fork the repository.
2. Create a new branch (git checkout -b feature/YourFeature).
3. Commit your changes (git commit -m 'Add YourFeature').
4. Push to the branch (git push origin feature/YourFeature).
5. Open a Pull Request.
Please ensure your code follows best practices and includes relevant tests.

