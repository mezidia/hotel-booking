# Hotel Booking Project
Our hotel booking project with databases

## Table of Contents

- [Introduction](#introduction)
    - [Goal](#goal)
    - [Context](#context)
- [Description](#description)
- [Characteristics of business processes](#characteristics-of-business-processes)
    - [Purpose of the system](#purpose-of-the-system)
    - [Interaction with users](#interaction-with-users)
    - [Characteristics of business relations](#characteristics-of-business-relations)
    - [Target audience](#target-audience)
- [Functionality](#functionality)
- [API](#api)
- [Interested parties](#interested-parties)
- [Availability](#availability)
- [Reliability](#reliability)
- [Team](#team)
- [Database schema](#database-schema)
- [Creation date](#creation-date)
- [Change Log](#change-log)
- [Badges](#badges)
- [License](#license)

## Introduction

Nowadays, number of tourists are growing fast. And hotel reservations are always relevant and necessary for people. Therefore, we want to develop a convenient database with useful information and rich functionality.

### Description

Booking is an online travel agency for lodging reservations or, in other words, is a convenient way for any traveler to order a room in any part of the world without any problems. Users will be able to view each hotel and room in it to choose the most suitable option to make their trip abroad or around the country impeccable.

### Goal

- make information about hotels more public and smart
- make booking a room more easy

### Context

The user can easily book a room without seeing unnecessary information, only useful. Everything related to the booking will be notified to the user via email

## Characteristics of business processes

### Purpose of the system

Hotel Booking DB was created to facilitate the operation of online hotel reservation systems. The database will help your program or site to store all the necessary information correctly, securely and in a structured way. This system will have the function of notifying users via email as well as many other useful functions.

### Interaction with users

Interaction with the database occurs through certain functions that return the desired values or perform certain operations. By connecting Hotel Booking DB to your project, your users will be able to quickly view the hotels or reservations they need, leave a review of their favorite place to stay or add their own small motel. The registration system will include a login, password and e-mail.

### Characteristics of business relations

System management will be performed using a separate application section (for administrators only) and using a special administration team consisting of administrators and system operators. Users who have added their property to the database will be able to change the parameters of their proposals after the previous moderation.

### Target audience

The target audience of Hotel Booking DB is the developers of any hotel room reservation system.

## Functionality
### Unauthorized users can
- [Search based on hotel, apartment, inn etc for info (Address, Ratings, and Price)](https://github.com/mezidia/hotel-booking/blob/master/docs/SearchForInfo.png)
- [Check available rooms](https://github.com/mezidia/hotel-booking/blob/master/docs/CheckAvailableRooms.png)
- [Check for latest promotion and deals](https://github.com/mezidia/hotel-booking/blob/master/docs/CheckForDeals.png)
- [Sign up, log in](https://github.com/mezidia/hotel-booking/blob/master/docs/UnauthorizedUserSignUpLogIn.png)

### Authorized users can
- [Book online, pay with credit or debit card](https://github.com/mezidia/hotel-booking/blob/master/docs/AuthorizedUserBooking.png)
- [See check in and check out dates](https://github.com/mezidia/hotel-booking/blob/master/docs/AuthorizedUserCheckDates.png)
- [Leave comments and reviews, rate services](https://github.com/mezidia/hotel-booking/blob/master/docs/AuthorizedUserReview.png)
- [Cancel booking](https://github.com/mezidia/hotel-booking/blob/master/docs/AuthorizedUserCancel.png)
- [Log out](https://github.com/mezidia/hotel-booking/blob/master/docs/LogOut.png)
- [Edit customer's booking information (updating check in, check out, room preferences, bad preferences and also cancelling booking) (for hotel admins only)](https://github.com/mezidia/hotel-booking/blob/master/docs/EditBooking.png)
- [Update hotel info and prices (for hotel admins only)](https://github.com/mezidia/hotel-booking/blob/master/docs/AuthorizedUserUpdateInfo.png)  

Implementation of functions below is left for clients:  
- [Receive emails about discounts and order updates](https://github.com/mezidia/hotel-booking/blob/master/docs/AuthorizedUserOrderUpdates.png)
- [Report comments](https://github.com/mezidia/hotel-booking/blob/master/docs/ReportComment.png)

### Admins can
- [Change permissions for users or hotels](https://github.com/mezidia/hotel-booking/blob/master/docs/AdminChangePermissions.png.png)  

Implementation of functions below is left for clients:  
- [Content moderation](https://github.com/mezidia/hotel-booking/blob/master/docs/AdminModerateContent.png)
- [Users support](https://github.com/mezidia/hotel-booking/blob/master/docs/AdminSupport.png)

### [Table Of Precedents](https://github.com/mezidia/hotel-booking/blob/master/docs/table_of_precedents.jpg)  
### [E-R Diagram](https://github.com/mezidia/hotel-booking/blob/master/docs/E-R%20diagram(1).jpg)

## API

### Admin.cs

### Authorized.cs

### DBSystem.cs

### HotelAdmin.cs

### HotelOwner.cs

### Unauthorized.cs

### User.cs

## Interested parties
Below is given a list of parties, that may be interested in our project:

- People, who are searching for a bed, a room or a flat to stay for some period of time;
- Hotels, which are looking for customers.

## Availability
Hotel Booking DB is available for everyone, who will install our module and connect it to their own project.  
It has no UI yet, but connection to the server is available with the use of English and letters from us coming to your email can be different, depending on the language you choose (English, Russian, Ukrainian).  
We provide "help" command, which helps user to understand functionality of DB.

## Reliability
The reliability of this project will be extremely high, because the main language for implementing the database in it is C#, which is an OOP language. It allows you to make the data of all users strictly classified. Also, the data will be saved on the servers, which will allow you to restore them if necessary.

## Team

- [Zavalniuk Maksym](https://github.com/mezgoodle)
- [Dominskyi Valentyn](https://github.com/VsIG-official)
- [Dmytrenko Roman](https://github.com/Dmytrenko-Roman)
- [Gorbunova Yelyzaveta](https://github.com/lizardlynx)
- [Palchyk Maksym](https://github.com/La7rodectus)
- [Sichkar Tetiana](https://github.com/fhrr-sht)

## Database schema
![alt tag](https://i.imgur.com/kkd9iFk.png)

## Class diagram
[![Untitled-Document-2.png](https://i.postimg.cc/FHNCyK0c/Untitled-Document-2.png)](https://postimg.cc/RNpT94sV)

## Creation date
7.09.2020

## Change Log
[Change Log](https://github.com/mezidia/hotel-booking/blob/master/CHANGELOG.md)

## Badges
> [![Theme](https://img.shields.io/badge/Theme-DataBases-red?style=flat-square)](https://en.wikipedia.org/wiki/Database)
> [![Team](https://img.shields.io/badge/Team-Mezidia-brightgreen?style=flat-square)](https://github.com/mezidia)

## License
MIT © [mezidia](https://github.com/mezidia)
