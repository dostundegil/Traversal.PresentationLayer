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

## API LAYER

<img width="1141" alt="image" src="https://raw.githubusercontent.com/dostundegil/RealHouzing/master/realHouzingImages/API/1.png">
<img width="1141" alt="image" src="https://raw.githubusercontent.com/dostundegil/RealHouzing/master/realHouzingImages/API/2.png">
<img width="1141" alt="image" src="https://raw.githubusercontent.com/dostundegil/RealHouzing/master/realHouzingImages/API/3.png">
<img width="1141" alt="image" src="https://raw.githubusercontent.com/dostundegil/RealHouzing/master/realHouzingImages/API/4.png">


## API CONSUME

Home Page

<img width="1141" alt="image" src="https://raw.githubusercontent.com/dostundegil/RealHouzing/master/realHouzingImages/UI/1.png">
<img width="1141" alt="image" src="https://raw.githubusercontent.com/dostundegil/RealHouzing/master/realHouzingImages/UI/2.png">
<img width="1141" alt="image" src="https://raw.githubusercontent.com/dostundegil/RealHouzing/master/realHouzingImages/UI/3.png">
<img width="1141" alt="image" src="https://raw.githubusercontent.com/dostundegil/RealHouzing/master/realHouzingImages/UI/4.png">
<img width="1141" alt="image" src="https://raw.githubusercontent.com/dostundegil/RealHouzing/master/realHouzingImages/UI/5.png">
<img width="1141" alt="image" src="https://raw.githubusercontent.com/dostundegil/RealHouzing/master/realHouzingImages/UI/6.png">
<img width="1141" alt="image" src="https://raw.githubusercontent.com/dostundegil/RealHouzing/master/realHouzingImages/UI/7.png">
<img width="1141" alt="image" src="https://raw.githubusercontent.com/dostundegil/RealHouzing/master/realHouzingImages/UI/8.png">

Properties

<img width="1141" alt="image" src="https://raw.githubusercontent.com/dostundegil/RealHouzing/master/realHouzingImages/UI/9.png">
<img width="1141" alt="image" src="https://raw.githubusercontent.com/dostundegil/RealHouzing/master/realHouzingImages/UI/10.png">

Contact Us

<img width="1141" alt="image" src="https://raw.githubusercontent.com/dostundegil/RealHouzing/master/realHouzingImages/UI/11.png">

## Admin Panel

Properties CRUD

<img width="1141" alt="image" src="https://raw.githubusercontent.com/dostundegil/RealHouzing/master/realHouzingImages/AdminPanel/1.png">

Recieved Messages

<img width="1141" alt="image" src="https://raw.githubusercontent.com/dostundegil/RealHouzing/master/realHouzingImages/AdminPanel/2.png">

Message Details/Reply Messages

<img width="1141" alt="image" src="https://raw.githubusercontent.com/dostundegil/RealHouzing/master/realHouzingImages/AdminPanel/3.png">
<img width="1141" alt="image" src="https://raw.githubusercontent.com/dostundegil/RealHouzing/master/realHouzingImages/AdminPanel/4.png">
<img width="1141" alt="image" src="https://raw.githubusercontent.com/dostundegil/RealHouzing/master/realHouzingImages/AdminPanel/5.png">
<img width="1141" alt="image" src="https://raw.githubusercontent.com/dostundegil/RealHouzing/master/realHouzingImages/AdminPanel/6.png">

Sent Messages

<img width="1141" alt="image" src="https://raw.githubusercontent.com/dostundegil/RealHouzing/master/realHouzingImages/AdminPanel/7.png">
<img width="1141" alt="image" src="https://raw.githubusercontent.com/dostundegil/RealHouzing/master/realHouzingImages/AdminPanel/9.png">

Manager CRUD

<img width="1141" alt="image" src="https://raw.githubusercontent.com/dostundegil/RealHouzing/master/realHouzingImages/AdminPanel/10.png">

About Us CRUD

<img width="1141" alt="image" src="https://raw.githubusercontent.com/dostundegil/RealHouzing/master/realHouzingImages/AdminPanel/11.png">

Contact Us CRUD

<img width="1141" alt="image" src="https://raw.githubusercontent.com/dostundegil/RealHouzing/master/realHouzingImages/AdminPanel/12.png">

Features CRUD

<img width="1141" alt="image" src="https://raw.githubusercontent.com/dostundegil/RealHouzing/master/realHouzingImages/AdminPanel/13.png">

Services CRUD

<img width="1141" alt="image" src="https://raw.githubusercontent.com/dostundegil/RealHouzing/master/realHouzingImages/AdminPanel/14.png">

Testimonials CRUD

<img width="1141" alt="image" src="https://raw.githubusercontent.com/dostundegil/RealHouzing/master/realHouzingImages/AdminPanel/15.png">


## Contact

Ali Kaan Yayla - [@Linkedin](https://www.linkedin.com/in/ali-kaan-yayla/) 

<p align="right">(<a href="#readme-top">back to top</a>)</p>





