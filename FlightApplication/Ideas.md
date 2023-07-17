# How to imporve this

The design could include returing the whole user with the ticket and registering the ticket only,adding user data with the request.
All the current controller method's code should be in a seperate service. Call the service method inside the  controllers.
Validations can be written as seperate methods and called inside the service methods.
Unit tests - tried to implement unit tests, but for some reason the latest .net framework they support is v4 ( the error I got). These can be written using different testing framework ( such as NUnit or xUnit)
Sending user email - add email field to the user model and use that field to send the email about the ticket and the user registration. 
Database and mail configuration should go inside seperate .env file with .gitignore on them.
Enumerations should have fields that implement constant values.
User search by api call - we can deserialze the receieved data to a JSON object in .NET and do the filtering like inside the regular object, sending the filtered data as a result.
Changing the codes based by flight time - we could have a single field for the time the flight takes. After that, we would check if the time mark has value between 22h and 06 hours. We save 
the flight codes according to the validation result (the simplest way is to get the code value and convert it to lover case in code).
