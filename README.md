# Book-Reading-Event-System

This Book Reading Event App is a combination of tools and processes that manage book-reading events across India. A book reading event where book lovers come together for a community reading of their favorite book. One or more readers read the book loudly and optionally people even play roles from the book.

INTRODUCTION

A book reading event app is an online web application that is a single-point entry for all book lovers across India. Any registered and verified user who wants to keep a book reading event can create an event, invite people they know by specifying their email ids, or can keep the event open for all. The invited people need not be registered users. Due to some problem, if someone is not able to create an event, s/he can ask some other registered user to keep an event on their behalf of her/him. The registered user can check for the public events happening by just browsing into to portal and for private events, one can check the invited list of events by logging into the portal as well as by checking their invitation mail. Admin can see all the events (whether it is public or private) and all the registered users. As per the requirement, the admin can Edit as well as Delete any future public or private event details.

OBJECTIVE

The objective of this Book Reading Event System Project was to manage all the book reading events properties created by one user and send an invitation to the guests by entering their email ids or by keeping an event public. Managing these resources may itself be sufficient enough to give any user a big jump in terms of efficiency. The objective was to build a web application for people that makes use of it to manage their hectic schedule and make the best use of it in a smooth and efficient manner.

FUNCTIONALITY

The project will manage the intellectual property by creating a database of all the users and events, helping users to create an event, edit the event details, delete an event, add comment(s) on the event, invite the guest(s) for the event and to see any book reading event details happening around. Admin simultaneously verifies details of events as well as users. Admin can also edit and delete the event whenever required. Book Reading Event App has two types of users: Registered users, and Admin users.

Registered users are the normal user of the application who has the following rights:

View Past and Upcoming Public events
Log in to the system using “Email id” and “Password”
Create an Event and send the invites by specifying email ids
Edit the events created by him/her
View the events invitation list along with the details
View the list of events created by him/her
Add Comments to the Event
Admin Users have all rights throughout the application as follows:

View Past and Upcoming Public events
Log in to the system using “Email id” and “Password”
Create an Event and send the invites by specifying email ids
Edit any upcoming event’s detail
View the events invitation list along with the details
View the list of events created by him/her
Add Comments to the Event
View list of all the users
View a list of all the events
METHODOLOGY AND APPROACH
The following technologies were used for building this project:

Frontend – Hypertext Markup Language (HTML) CSS (Cascading Style Sheets), JavaScript, Bootstrap
Backend – ASP.NET (Active Server Page) Model View Controller (MVC)
Database – Structured Query Language (SQL) Server
Framework – Entity framework is used to connect to the database which helps in object-relational mapping
This project is built in an MVC pattern where M is the model which determines the classes, V is a view that determines views shown to the user and C stands for the controller which is used to handle the request. This project follows three layered architecture. The first layer is the presentation layer which includes views, and the second layer is the business layer which includes the services which work as a mediator between the presentation and data access layer. And the third layer is the data access layer which directly interacts with the SQL server database using entity framework and code first approach.

OBSERVATIONS

Graphical User Interface (GUI) – The website contains many links and tabs for various requirements like Create Event, Edit Event, View Invitations, etc. The users of the application consist of users from India. It will lay stress on each

page’s layout and the features to be depicted on that page.

HOME PAGE:

This is the first landing page. Any user can see the Public Book Reading Events without logging into the system by using the Past Events and Upcoming Events links. The past Events link redirects to the Past Public Events and the Upcoming Events link redirects to the Upcoming Public Events along with their details.

PAST EVENTS:

This page is landing by clicking on Past Events on the home page. Any user can land on this page without logging into the system. But one cannot add comments without logging into the system. Users can see the list of Past Public Events along with the details of each event. The working of Upcoming Events on the home page is the same.

A registered user or admin can log in using their credentials.
Depending on the type of user, s/he will have access to various functionalities of the application. In case the email id and password typed by the user do not match any record in the database, a login failure message will be displayed. If not registered already, a user can sign up by clicking on “Signup”.

USER SIGN UP

A user can register using their credentials. After successful registration user will be redirected to the login page. In case of failing the validation requirements of email id or password, a failure message will be displayed. If registered already, a user can log in by clicking on “Login”.

HOME PAGE AFTER LOGIN:

This is the landing page after the user logs in to the system. PAST EVENTS redirect to the page containing the list of past events which either the user invited, or was a public event. UPCOMING EVENTS redirects to the page containing the list of upcoming events to which either the user is invited, or it is a public event.

Navigation bar: Contains the button for CREATE EVENT, MY EVENTS, INVITATIONS, HELP, USER DETAIL and
LOGOUT functionalities.

Only user with Administrator rights has some additional button for some additional functionalities available in the navigation bar are ALL USERS and ALL EVENTS button.

CREATE EVENT:

Users can create a new event. The user just needs to enter some necessary details like Title, Date, Location, Time, Type of event, and some other optional details like Description, and Other Details. Users can invite guests to the event by entering their email ids separated by a comma. Users must provide the creator id for whom they are creating the event. If the user wants to create an event for himself/herself only, then he/she can check the creator id by clicking on DEAR – XXXXX. If the user is creating an event for someone else, then the admin will verify the details with whose creator id has been entered. If the BACK TO LIST button is clicked, the user will be redirected to the HOME PAGE.

MY EVENTS:

Users can see the complete list of events created using their own creator id. From here user can Edit/Delete his/her any upcoming event by clicking on the Edit/Delete button. Users can also create events by the button provided just under the tile MY EVENTS.

COMMENT. And can also see the comments posted by others in the COMMENTS section. The comments in the COMMENTS section are shown anonymously sorted by date and time.

EDIT EVENT:

Users can edit the details of any upcoming events from the list of events provided on the MY EVENTS page. Users can edit any of the details provided in create event form except the creator id. The layout of the page is exactly the same as CREATE EVENT page. Users can return to the MY EVENTS page using the BACK button.

INVITATIONS:

Users can see the complete list of events to he/she is invited. The list of events being shown is sorted by the date and time of the event. As this page proved to be much helpful to users in order to plan their future activities. By clicking on the DETAILS button, the user will be redirected to the EVENT DETAILS page. On the EVENT DETAILS page, users will find some additional information regarding the events such as the type of event(public/private), the number of invitees invited, and the creator of the event.

EVENT DETAILS:

Users can see all the available information regarding the event he/she invited to by clicking on the Details button available on the INVITATIONS page. Here one can find some additional information such as the type of event(public/private), the number of invitees invited, and the creator of the event. Users can also add comments for this particular event by clicking on ADD

USER DETAILS:

Users can check his/her own details by clicking on the DEAR – XXXXX button. One needs to check their user id for creating their event, so here they can find it out. Here the button name is extracted from the email id by which the user has login into the system. As it is clearly visible from the image, if someone logged into the system with xxxx@gmail.com then the name before @ is shown after the Dear – button like “Dear – XXXX”. The name visible in the button is the extracted from user’s email id leaving the part from @ symbol.

ALL USERS – ADMIN ONLY:

Only users with administrator rights can access this page. This page can be accessed by clicking on the button ALL USERS available in the navigation bar. On this page, the admin user can see the whole list of users who may or may not be an admin. Admin can see each user’s name, id, and email id.

ALL EVENTS – ADMIN ONLY:

Only users with administrator rights can access this page. This page can be accessed by clicking on the button ALL EVENTS available in the navigation bar. On this page, the admin user can see the complete list of events. The list contains both public as well private events. The list contains both past and upcoming events. The events in the list are sorted by date and time. Admin can use create event functionality here also by clicking on CREATE NEW EVENT button.

Admin can see details like Title, Date, Location, Start Time, Type of Event, Duration, Description, Other Details, No. of Invitees invited, and Creator id of all the events. For some specific requirements, the admin can see the details for a particular event by clicking on the DETAILS button available in that event’s particular row which will be redirected to the EVENT DETAILS PAGE as shown before. Admin can not only edit the events created by him/her but also edit events created by other users/admins. Admin can edit any upcoming event by clicking on the EDIT button for that particular event which will redirect to the EDIT EVENT page. Admin can also edit the creator id for the event.

After being done with the usage of the portal, the user/admin can log out from the system by clicking on the LOGOUT button available in the navigation bar. After clicking on the LOGOUT button, the user will be redirected to the HOME PAGE. Users can again use the system any number of times by logging into the system using the same credentials used for the first time.

CONCLUSION

This Book Reading Event system is a user-friendly software that can be used in any locality for any user to arrange the event and to send an invite to guests just by entering their email ids. Due to some problem, if someone might not be able to create an event and send an invite or somebody might not have email ids available for all the guests, in this case, the book reading event app provides functionality to a user to create an event on behalf of someone else and it will be verified by an admin before sending an invitation to the guests and posting that event on the portal.

Allowing all the users to have access to such web-based application software can help anyone who wants to keep an event busy with the preparation of the event can easily send invitations to the guests and save his/her time. Further, this software can be developed to add more functionalities in the future, like setting a reminder for the events and notifying the user time by time, and setting a flag for the events one is interested in. This project can be further extended to keep any event (i.e., House-Party, Get to Gather) and not just only for book reading. The sheer possibility of scaling this application is immense and will definitely go to be proven the most useful software in the future times.
