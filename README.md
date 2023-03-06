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


If we create an object of DataAccess, we can access only LoadConnectionString method like below

![image](https://user-images.githubusercontent.com/32676744/223125712-6c6c0d55-45a4-46e5-aa46-2bf690aa0229.png)

but, the above make no sense , like what is it accessing, Sql or Sqlite classes ? its not having Load or Save methods . Its a messy code, we can leave it there or [ this is one reason to use abstract class , continue reading ]

### So lets change this DataAccess to Abstract class

![image](https://user-images.githubusercontent.com/32676744/223126571-3d9bc816-9038-42ef-872a-caff5b80360f.png)

Now if we create an Object of DataAccess like DataAccess da = new DataAccess(); //This does not allow because now DataAccess is an abstract class we can't directly instantiate an abstract class

![image](https://user-images.githubusercontent.com/32676744/223127172-75e93931-7c22-4054-acf5-55c41abbad19.png)


But we can make use of the child class to access all the details from an abstract class ; something like below:
#### this is benefit number 1 

![image](https://user-images.githubusercontent.com/32676744/223127771-3fd5f58b-c0a4-4568-84a3-5457de7d9250.png)


its a blend of interface and base class , where is the interface portion of it ?


![image](https://user-images.githubusercontent.com/32676744/223128705-4d543536-c36f-489b-b384-869d6fc977fd.png)


see the error above, this is beacuse the LoadData is not abstract at this time ( but the same load data is exist in its child classes)

its now gone 

![image](https://user-images.githubusercontent.com/32676744/223128975-0b179d49-7b4b-43f8-938b-89ee12ea0d77.png)

see the above, semi colon in the end, this is similar to Interface . here no code is added for LoadData, this may be because the LoadData may different from Sql vs Sqlite so , but we can forcefully say this LoadData should be implemented inside its child classes by decalring it as **abstract** 


Added SaveData as well

![image](https://user-images.githubusercontent.com/32676744/223129744-3dde1ce8-02ad-4db1-9e41-c1df2bba8413.png)


Now go back to our Sqlite class : see those little errors

![image](https://user-images.githubusercontent.com/32676744/223130035-05761412-bca0-40e5-ad87-441a884859a6.png)


so we need to override the methods in child classes . this means we need to implement Load&Save metods inside the child classes

![image](https://user-images.githubusercontent.com/32676744/223130301-b4a00edb-2b74-4993-8063-3a484242e5ac.png)


Modified in Sql class as well

![image](https://user-images.githubusercontent.com/32676744/223130677-c5d10f9a-a732-4840-8749-ae9e91060b32.png)

Now we have all methods in the DataAccess class, One method is fully implemented, other two methods are declared without any implementation.

## benefit number 2 here is now we can instatiate DataAccess class like below 

![image](https://user-images.githubusercontent.com/32676744/223131461-deffe036-8a71-415f-9e71-da13dd4465e2.png)

the above works, its kind of like an interface ## this is the foundation of an abstract class , belnds both the base class and an interface


so now if we use the main program like below, by changing IDataAccess to DataAccess it works..
now we have the same code which instead of using Inteface, it now use Abstract class we call.


![image](https://user-images.githubusercontent.com/32676744/223131913-aa4f0501-9646-41ca-a674-8d946ee75e7e.png)


 It has both the benefits of shared code as well as both declarations
 
 ![image](https://user-images.githubusercontent.com/32676744/223132229-814b72ec-7fd0-4ed8-8a62-cbdeec216aaa.png)

If we want to override the LoadConnectionString in DataAccess class in its child class, we need to declare the LoadConnectionString as virtual

![image](https://user-images.githubusercontent.com/32676744/223132717-44ee380a-1ee2-4315-bd74-97c848d672a0.png)


now you can overide LoadConnectionString in its child class

![image](https://user-images.githubusercontent.com/32676744/223133056-8272873e-1b38-4406-b2cf-41e1d7ffae4c.png)


If you note above, the base.LoadConn... ( this helps us to first call the base class LoadConn.. method if we want..means some of the repetative code can be moved to the base class and child specific can be include in the child class using this capability )



##Final points 

1. Do you use this everyday ? No, its something that in certain specific cases we use. People often think if they have base class and child class share some common code, then think to use abstract class to minimise the code . that not really true because we don't want to get into a messy inheritance solution

 















