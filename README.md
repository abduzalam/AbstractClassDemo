# AbstractClassDemo

#### Abstract classes sits between a base class and an Interface.

First review the Initial Commit Code from this sample project

Look at SqlDataAccess and SqliteDataAccess classes , both have 3 methods in it, Say LoadConnectionString method is common in both Classes

##SqlDataAccess.cs

![image](https://user-images.githubusercontent.com/32676744/223115091-eecd3a24-240f-4582-a6b3-5b3c971a12fd.png)

##SqliteDataAccess.cs

![image](https://user-images.githubusercontent.com/32676744/223115189-106e2f26-4837-4642-a2f8-1be8a1988aca.png)


Lets say we can have a new base class to hold the LoadConnectionString method and inherit this class to SqlDataAccess and SqliteDataAccess, so we don't need to repeat the same method in the two classes

new base class DataAccess is created : DataAccess

![image](https://user-images.githubusercontent.com/32676744/223116093-5b16c115-f8e8-43cf-9ab2-c4c1c291ae5a.png)

Now instead of implementing IDataAccess , we can inherit from DataAccess like below

![image](https://user-images.githubusercontent.com/32676744/223117159-96249124-2440-437c-97ff-6d5eff10e942.png)

Notice that, the LoadConnectionString code earlier present in the SqlDataAccess is now removed from the above Code post DataAccess Inheritance

Now Back to our main program, lets try to use one of the class
you can see LoadConnectionString method in da object below

![image](https://user-images.githubusercontent.com/32676744/223117661-e13d2cc9-e1de-4443-acd7-d6323bcfc4a5.png)








