# RobotPicker

**MARK DESCHAMPS**

Based on proximity and battery power a robot is chosen to o to packages

**API is written in .NET Core**

**API accepts POST and returns data per requirements**


Payload
![image](https://user-images.githubusercontent.com/22671656/150238521-9475c1f7-5459-420e-83da-ba83bd8983a2.png)
Response
![image](https://user-images.githubusercontent.com/22671656/150238582-649c6f3a-d250-423d-b8f9-b66cf3dadc0e.png)



**Repo README has information about what you'd do next, per above requirements**

I would see if its possible to  optimize the function FindClosetBot.


**Repo README has instructions for running and testing the API**


Run Robot_Transport in visual studios IDE

![image](https://user-images.githubusercontent.com/22671656/150238205-698f9b86-113c-4bca-8b2e-dae35ffcf42d.png)


**Running via post man**

type in the http://localhost:5001/api/robots/closest

set the header Content-Type to application/json

Add json payload to the body

![image](https://user-images.githubusercontent.com/22671656/150238150-f1fd2eea-c692-4802-a62f-cb41494607bc.png)

![image](https://user-images.githubusercontent.com/22671656/150239061-82beb92b-fa51-4569-b466-4df528f0ca29.png)


**Running via swagger**

Click the listed url
Click try out
Click exectue, json will be included and can be modified.

![image](https://user-images.githubusercontent.com/22671656/150238305-d5eb2f43-28a5-43bb-9f0c-28d28d727a94.png)

![image](https://user-images.githubusercontent.com/22671656/150238356-2b8a0500-945a-4d69-9bcc-e6e826bfddc4.png)

![image](https://user-images.githubusercontent.com/22671656/150239015-98c2ba0a-01b3-431b-aca6-c85c0eaf64e9.png)



