# TaskManager

TaskManager is an application for managing tasks, clients, and team members within projects, built on the .NET and Blazor platforms. It enables efficient organization of workflows and supports various levels of user permissions.

## Application Features

- **User and Role Management**:
  - Roles: **Admin**, **Project Manager**, **Others**.
  - **Admin** has full access to manage users, clients, and tasks.
  - **Project Manager** can manage clients and tasks assigned to them.
  - **Others** can view and update tasks assigned to them.

| Role             | Permissions                                                |
|------------------|------------------------------------------------------------|
| **Admin**        | Full access to users, clients, tasks, and settings         |
| **Project Manager** | Manage assigned clients, create and manage tasks           |
| **Others**       | View and update assigned tasks                             |

- **Client Management**:
  - **Add New Client**: Allows input of basic client information (name, description, contact details) and assigns a project manager.
  - **Edit and Delete Clients**: Options to update client details or delete clients.
  - **Detailed Client View**: Displays all essential client information, including assigned tasks and the project manager.

- **Task Management**:
  - **Create and Edit Tasks**: Allows input of task details, due dates, and assigns tasks to specific team members.
  - **Detailed Task View**: Displays all essential task information, including assigned team member.
  - **Task Statuses**: Tasks can be marked as active or closed, with the completion date automatically set when closed.

- **Calendar and Overview**:
  - **Calendar**: Displays all tasks based on due dates with the ability to toggle between monthly and weekly views. Tasks are visually categorized as:
    - **Incomplete Task** - Incomplete tasks
    - **Completed on Time** - Tasks completed before the due date
    - **Overdue Task** - Tasks not completed before the due date
    - **Late Completed Task** - Tasks completed after the due date
  - **Client and Task Overview**: Admins have access to a comprehensive view of clients and all associated tasks, streamlining project management.

## System Requirements

- .NET SDK 8.0 or later
- SQL Server to store data on users, clients, and tasks
- Visual Studio or another C#-compatible editor
- Entity Framework Core for ORM

## Installation and Setup

1. Clone the repository to your local machine:
	```bash
   git clone https://github.com/yourusername/TaskManager
   cd TaskManager
2. Configure the database connection in the appsettings.json file:
	```bash
	{
	"ConnectionStrings": "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=TaskManagerDb;Trusted_Connection=True;MultipleActiveResultSets=true"}
	}
3. Apply database migrations.
4. Build the project and run the application.

## Project Structure

- **Account**: Manages user accounts, including login, registration, and user profiles.
- **ClientComponents**: Components for adding, editing, and viewing clients.
- **TaskComponents**: Components for creating, editing, and managing tasks and their details.
- **Calendar**: Interactive calendar component showing tasks based on due dates.
- **TeamComponents**: Components for displaying and reviewing the team by roles.
- **EntityComponents**: Shared components for confirming and deleting entities, such as clients and tasks.
- **Utilities**: Common utilities for displaying and managing Enum values, input validation, and other helper functions.
- **Database Context (ApplicationDbContext)**: Provides the database connection and Entity Framework Core management.
- **Enum Definitions**: Definitions for task statuses, work positions, and categories used across components.

## Technologies Used

- **C#**
- **Blazor and ASP.NET Core**
- **Entity Framework Core**
- **SQL Server**
- **OOP and Input Validation**

## Author

David Bøach - brasik20@seznam.cz
