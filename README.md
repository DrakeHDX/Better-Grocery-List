# Better-Grocery-List
A web application for making grocery lists.

#Overview
##Introduction

My project idea is to create a program that will make use of user input as well as a small database to be used for keeping grocery lists. This program is meant to be a useful and fun program that makes the process of keeping a grocery list more engaging and intuitive. It can also make use of the user’s common purchases to make the app even more intuitive for them in future uses.
Features
	The program will be structured based on a user interface showing the user options to create a grocery list, which can then be populated with items based on the database. The database will consist of many commonly purchased items such as milk, eggs, bread, etc. that the user can choose from quickly. The database could also contain images to accompany the grocery items. When the user selects an item from this list, the item will then be added to their active grocery list.
	I also want to implement the ability for the user to add their own items into the database, which are then accessible for them later. For example, the existing database will contain an upload of common items as a preset for the user to choose from. If desired, the user can then add their own items and images to a local database to be recalled for future grocery lists.
	Similar Software
	Some similar software includes AnyList: Grocery Shopping List, available on the Apple App Store. This app provides similar features to the ones I’ve described, as well as the ability to create and share lists. Another similar program is Our Groceries Shopping List on the App Store, which also allows for creating shopping lists and list sharing.
	Project Plans
	My plan for this project is first to review/learn the necessary skills to actually complete the product. I am thinking that this program will be an HTML based web page hosted on a sort of web server, which also makes use of a database that I will create to retrieve the existing grocery items from.
	I will start by creating the database itself and filling it with the appropriate items to be retrieved. I will then figure out how to get it hosted online to be used by my web page. I will then create the HTML user interface and implement the appropriate buttons and text boxes. I will then implement the functions that will allow the user to retrieve items from the database or to add their own, as well as display their active grocery list which consists of the user’s selected items from the existing database or ones that they’ve entered themselves.
	I also want to implement the ability to delete or check off items from the active grocery list once the user has collected them in the store. This would allow deletion from the active list, but not from the database itself.
	Conclusion
This web app aims to provide an engaging and useful way to make grocery lists that is simple to use while also being useful and can be used on the go while shopping. I feel that this idea would be something I would use while shopping, and I feel that others may find it useful as well.
-------
#User Stories

##User story 1
As a stay at home mother,
I need an easy way to keep track of the ingredients I use regularly
So that I can spend less time writing them from memory

##User story 2
As a college student,
I need a convenient way to track what items I will need for the semester
So that I can easily recall them when I’m at the store

##User story 3
As a busy 9-5 employee,
I need a way to quickly remember what items I need to buy while I’m out of the house
So that I can save time

##User story 4
As an at-home nurse,
I need a simple app for tracking the vitamins and other important care items for my patient
So that I can check off items as I go

##User story 5
As a senior citizen,
I need a simple way to keep track of my essentials
So that I will stop forgetting what I need while I’m shopping
-------

#Use cases

##Use case 1
Adding an item to a grocery list
Text box
End user
Text box accepts user input in the form of a string
The string is added to the database for use in a list

##Use case 2
Removing an item from a grocery list
‘Remove’ button
End user
User no longer needs the item, and selects ‘remove’
The item is removed from the active list, but not from the database

##Use case 3
Adding items from the database to a list
Database
End user
User wants to add an existing item to their active list, and selects it within the database
The item is then added to the running list and is shown on the UI

##Use case 4
Sort items in the running list
Item subcategories
End user and database repository
User selects a subcategory of item
The running list groups items of like subcategories together (dairy, meat, produce, etc)

##Use case 5
Start new lists
Multiple lists
End user
User creates more than one list
The app shows both lists separately and allows for edits on each one.
-------

