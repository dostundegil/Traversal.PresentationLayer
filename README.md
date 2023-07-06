<a name="readme-top"></a>
#  TRAVERSAL - .NET CORE TRAVEL PROJECT :+1:

The Traversal project is a travel project. The project is built using .Net Core 5.0. MsSql - 2019 is used as the database. The project's back-end is very robust and also provides users with a powerful interface.

Technologies Used in the Project and Their Applications:

* MsSql was used as the database.
* Entity Framework Core was used.
* Role-based authentication and page-level authorization were implemented using Identity Core library.
* Recommended hotels for the tour details page were dynamically retrieved using Ajax and RapidAPI.
* Mimekit library was used to send emails to users.
* EPPlus library was used to allow admins to generate Excel reports.
* Data entries were validated and customized error messages were provided to users using the Fluent Validation library.
* Logging was implemented using the Serilog library.

Technical Specifications of the Project:

Database: MsSql was used.
Architecture: N-tier architecture was implemented.
Design Pattern: Repository Design Pattern, Command Query Responsibility Segregation (CQRS), and MediatR were used.
User Interface: HTML/CSS - BOOTSTRAP were utilized.
<!-- TABLE OF CONTENTS -->
<details>
  <summary>Table of Contents</summary>
  <ol>
    <li>
      <a href="#about">About</a>
    </li>
    <li>
      <a href="#used">Used</a>
    </li>
    <li>
      <a href="#home">Home Page</a>
    </li>
        <li>
      <a href="#api-layer">API Layer</a>
    </li>
        <li>
      <a href="#user-panel">API Consume</a>
    </li>
        <li>
      <a href="#admin-panel">Admin Panel</a>
    </li>
  </ol>
</details>



## Used

* MsSql was used as the database.
* Entity Framework Core was used.
* Role-based authentication and page-level authorization were implemented using Identity Core library.
* Recommended hotels for the tour details page were dynamically retrieved using Ajax and RapidAPI.
* Mimekit library was used to send emails to users.
* EPPlus library was used to allow admins to generate Excel reports.
* Data entries were validated and customized error messages were provided to users using the Fluent Validation library.
* Logging was implemented using the Serilog library.
* SignalR.

## Technical Specifications of the Project:

* Database: MsSql was used.
* Architecture: N-tier architecture was implemented.
* Design Pattern: Repository Design Pattern, Command Query Responsibility Segregation (CQRS), and MediatR were used.
* User Interface: HTML/CSS - BOOTSTRAP were utilized.

## Features of the Project:

<h3> Features for Users </h3>

* Users can register and log in to the system.
* Users can update their profiles.
* Users can upload photos to the system.
* Users can make new reservations.
* Users can view their active/pending/past reservations.
* Users can comment on shared routes.
* Users can send messages to administrators.

<h3> Features for Admins </h3>

* Dashboard for admin panel.
* Admins can view messages received from users and respond to them by sending emails to the user's email address.
* Admins can approve reservations.
* CRUD operations for reservations.
* CRUD operations for routes.
* CRUD operations for guides.
* CRUD operations for users.
* Admins can add new roles, edit existing roles, and assign roles to users.

## UI

Home Page
<img width="1141" alt="image" src="https://github.com/dostundegil/Traversal.PresentationLayer/blob/master/Traversal.PresentationLayer/wwwroot/screenshots/ui/1.png">
<img width="1141" alt="image" src="https://github.com/dostundegil/Traversal.PresentationLayer/blob/master/Traversal.PresentationLayer/wwwroot/screenshots/ui/2.png">
<img width="1141" alt="image" src="https://github.com/dostundegil/Traversal.PresentationLayer/blob/master/Traversal.PresentationLayer/wwwroot/screenshots/ui/3.png">
<img width="1141" alt="image" src="https://github.com/dostundegil/Traversal.PresentationLayer/blob/master/Traversal.PresentationLayer/wwwroot/screenshots/ui/4.png">
<img width="1141" alt="image" src="https://github.com/dostundegil/Traversal.PresentationLayer/blob/master/Traversal.PresentationLayer/wwwroot/screenshots/ui/5.png">
<img width="1141" alt="image" src="https://github.com/dostundegil/Traversal.PresentationLayer/blob/master/Traversal.PresentationLayer/wwwroot/screenshots/ui/6.png">
<img width="1141" alt="image" src="https://github.com/dostundegil/Traversal.PresentationLayer/blob/master/Traversal.PresentationLayer/wwwroot/screenshots/ui/7.png">
<img width="1141" alt="image" src="https://github.com/dostundegil/Traversal.PresentationLayer/blob/master/Traversal.PresentationLayer/wwwroot/screenshots/ui/8.png">

Destinations

<img width="1141" alt="image" src="https://github.com/dostundegil/Traversal.PresentationLayer/blob/master/Traversal.PresentationLayer/wwwroot/screenshots/ui/9.png">

Guides 

<img width="1141" alt="image" src="https://github.com/dostundegil/Traversal.PresentationLayer/blob/master/Traversal.PresentationLayer/wwwroot/screenshots/ui/10.png">

Contact Us

<img width="1141" alt="image" src="https://github.com/dostundegil/Traversal.PresentationLayer/blob/master/Traversal.PresentationLayer/wwwroot/screenshots/ui/11.png">


## Destination Details

<img width="1141" alt="image" src="https://github.com/dostundegil/Traversal.PresentationLayer/blob/master/Traversal.PresentationLayer/wwwroot/screenshots/details/1.png">
<img width="1141" alt="image" src="https://github.com/dostundegil/Traversal.PresentationLayer/blob/master/Traversal.PresentationLayer/wwwroot/screenshots/details/2.png">
<img width="1141" alt="image" src="https://github.com/dostundegil/Traversal.PresentationLayer/blob/master/Traversal.PresentationLayer/wwwroot/screenshots/details/3.png">
<img width="1141" alt="image" src="https://github.com/dostundegil/Traversal.PresentationLayer/blob/master/Traversal.PresentationLayer/wwwroot/screenshots/details/4.png">
<img width="1141" alt="image" src="https://github.com/dostundegil/Traversal.PresentationLayer/blob/master/Traversal.PresentationLayer/wwwroot/screenshots/details/5.png">

## Login - Register

<img width="1141" alt="image" src="https://github.com/dostundegil/Traversal.PresentationLayer/blob/master/Traversal.PresentationLayer/wwwroot/screenshots/login/1.png">
<img width="1141" alt="image" src="https://github.com/dostundegil/Traversal.PresentationLayer/blob/master/Traversal.PresentationLayer/wwwroot/screenshots/login/2.png">

## Member Panel
<img width="1141" alt="image" src="https://github.com/dostundegil/Traversal.PresentationLayer/blob/master/Traversal.PresentationLayer/wwwroot/screenshots/member/1.png">
<img width="1141" alt="image" src="https://github.com/dostundegil/Traversal.PresentationLayer/blob/master/Traversal.PresentationLayer/wwwroot/screenshots/member/2.png">
<img width="1141" alt="image" src="https://github.com/dostundegil/Traversal.PresentationLayer/blob/master/Traversal.PresentationLayer/wwwroot/screenshots/member/3.png">
<img width="1141" alt="image" src="https://github.com/dostundegil/Traversal.PresentationLayer/blob/master/Traversal.PresentationLayer/wwwroot/screenshots/member/4.png">
<img width="1141" alt="image" src="https://github.com/dostundegil/Traversal.PresentationLayer/blob/master/Traversal.PresentationLayer/wwwroot/screenshots/member/5.png">
<img width="1141" alt="image" src="https://github.com/dostundegil/Traversal.PresentationLayer/blob/master/Traversal.PresentationLayer/wwwroot/screenshots/member/6.png">

## Admin Panel

Dashboard
<img width="1141" alt="image" src="https://github.com/dostundegil/Traversal.PresentationLayer/blob/master/Traversal.PresentationLayer/wwwroot/screenshots/admin%20panel/1.png">
<img width="1141" alt="image" src="https://github.com/dostundegil/Traversal.PresentationLayer/blob/master/Traversal.PresentationLayer/wwwroot/screenshots/admin%20panel/2.png">
Destination Crud - Excel Report
<img width="1141" alt="image" src="https://github.com/dostundegil/Traversal.PresentationLayer/blob/master/Traversal.PresentationLayer/wwwroot/screenshots/admin%20panel/3.png">
<img width="1141" alt="image" src="https://github.com/dostundegil/Traversal.PresentationLayer/blob/master/Traversal.PresentationLayer/wwwroot/screenshots/admin%20panel/18.png">
Guide Crud
<img width="1141" alt="image" src="https://github.com/dostundegil/Traversal.PresentationLayer/blob/master/Traversal.PresentationLayer/wwwroot/screenshots/admin%20panel/4.png">
<img width="1141" alt="image" src="https://github.com/dostundegil/Traversal.PresentationLayer/blob/master/Traversal.PresentationLayer/wwwroot/screenshots/admin%20panel/5.png">
Messages 
<img width="1141" alt="image" src="https://github.com/dostundegil/Traversal.PresentationLayer/blob/master/Traversal.PresentationLayer/wwwroot/screenshots/admin%20panel/6.png">
<img width="1141" alt="image" src="https://github.com/dostundegil/Traversal.PresentationLayer/blob/master/Traversal.PresentationLayer/wwwroot/screenshots/admin%20panel/7.png">
<img width="1141" alt="image" src="https://github.com/dostundegil/Traversal.PresentationLayer/blob/master/Traversal.PresentationLayer/wwwroot/screenshots/admin%20panel/8.png">
<img width="1141" alt="image" src="https://github.com/dostundegil/Traversal.PresentationLayer/blob/master/Traversal.PresentationLayer/wwwroot/screenshots/admin%20panel/9.png">
<img width="1141" alt="image" src="https://github.com/dostundegil/Traversal.PresentationLayer/blob/master/Traversal.PresentationLayer/wwwroot/screenshots/admin%20panel/10.png">
Comment Crud
<img width="1141" alt="image" src="https://github.com/dostundegil/Traversal.PresentationLayer/blob/master/Traversal.PresentationLayer/wwwroot/screenshots/admin%20panel/11.png">
Reservation Crud
<img width="1141" alt="image" src="https://github.com/dostundegil/Traversal.PresentationLayer/blob/master/Traversal.PresentationLayer/wwwroot/screenshots/admin%20panel/12.png">
User List
<img width="1141" alt="image" src="https://github.com/dostundegil/Traversal.PresentationLayer/blob/master/Traversal.PresentationLayer/wwwroot/screenshots/admin%20panel/13.png">
Features Crud
<img width="1141" alt="image" src="https://github.com/dostundegil/Traversal.PresentationLayer/blob/master/Traversal.PresentationLayer/wwwroot/screenshots/admin%20panel/14.png">
Role Assign - Role Crud
<img width="1141" alt="image" src="https://github.com/dostundegil/Traversal.PresentationLayer/blob/master/Traversal.PresentationLayer/wwwroot/screenshots/admin%20panel/15.png">
<img width="1141" alt="image" src="https://github.com/dostundegil/Traversal.PresentationLayer/blob/master/Traversal.PresentationLayer/wwwroot/screenshots/admin%20panel/16.png">
<img width="1141" alt="image" src="https://github.com/dostundegil/Traversal.PresentationLayer/blob/master/Traversal.PresentationLayer/wwwroot/screenshots/admin%20panel/17.png">



## Contact

Ali Kaan Yayla - [@Linkedin](https://www.linkedin.com/in/ali-kaan-yayla/) 

<p align="right">(<a href="#readme-top">back to top</a>)</p>





