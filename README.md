# Forestfield's Books - Fullstack Project

## Introduction

This project is a full stack project about an online book store. It consists of a backend made with ASP.NET Core using PostgreSQL database and a frontend made with React.js and TypeScript. Any user is able to see books by category and by author and add them into their shopping cart, change their amount or remove them from cart. They can create an account and after logging in see their own information and order history. An admin user is able to create, modify and delete books, authors, genres, orders and users.

## Technologies

![TypeScript](https://img.shields.io/badge/TypeScript-v.4-green)
![SASS](https://img.shields.io/badge/SASS-v.4-hotpink)
![React](https://img.shields.io/badge/React-v.18-blue)
![Redux toolkit](https://img.shields.io/badge/Redux-v.1.9-brown)
![.NET Core](https://img.shields.io/badge/.NET%20Core-v.7-purple)
![EF Core](https://img.shields.io/badge/EF%20Core-v.7-cyan)
![PostgreSQL](https://img.shields.io/badge/PostgreSQL-v.14-drakblue)

* Frontend: SASS, TypeScript, React, Redux Toolkit
* Backend: ASP .NET Core, Entity Framework Core, PostgreSQL
## Project structure

This project consists of two parts, the backend and the frontend.

The structure for the backend is following:

├───bin
│   └───Debug
│       ├───net6.0
│       └───net7.0
├───Controllers
├───Database
├───DTOs
├───Helpers
├───Migrations
├───Models
├───obj
│   └───Debug
│       ├───net.6.0.401
│       │   ├───ref
│       │   ├───refint
│       │   └───staticwebassets
│       ├───net6.0
│       │   ├───ref
│       │   ├───refint
│       │   └───staticwebassets
│       └───net7.0
│           ├───ref
│           ├───refint
│           └───staticwebassets
├───Properties
├───Repositories
│   ├───AuthorRepository
│   ├───BaseRepository
│   ├───BookRepository
│   ├───GenreRepository
│   ├───OrderRepository
│   └───UserRepository
└───Services
    └───Implementations

The structure for the frontend is following:

├───public
└───src
    ├───components
    ├───pages
    ├───redux
    └───styles


## Getting started

1. This repository can be cloned with Git using command ```git clone```
2. To set up back end, first create `appsettings.json` (and `appsettings.*.json` if needed) file in the root of folder `Backend`. You can refer to the content of file `example.json`. There replace the connection string with your own database connection information.
3. Install needed packages in terminal in backend folder from https://www.nuget.org/. See that the versions match the ASP.NEt Core version in use. From The following are needed:
    * AutoMapper
    * AutoMapper.Extensions.Microsoft.DependencyInjection
    * Microsoft.EntityFrameworkCore
    * Microsoft.EntityFrameworkCore.Design
    * Npgsql.EntityFrameworkCore.PostgreSQL
4. Run the application your preferred method.
5. In frontend folder run command ```npm install``` to install the dependencies.
6. Run the frontend with command ```npm start```.


