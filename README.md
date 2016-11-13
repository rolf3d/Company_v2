# Company_v2

Clone the C# project Company_v2. 

Initially, the project is rather simple – it just contains the class Employee. This class is supposed to serve as a base class for a number of derived classes, just in the above exercise  

1. Examine the Employee class. You can see that an employee just has a name, nothing more. The rules for how a salary is calculated are now completely “free”, and should be made concrete in the derived classes. However, there are some very general rules for salary calculation:  Part of the salary is considered to be a bonus  The bonus is paid if a certain condition is met.  

2. The above rules for calculating the salary are quite vague, and the Employee class can therefore not contain any specific implementation of salary calculation. However, a number of abstract methods relating to salary calculation are included in the Employee class. Since the methods are abstract, the Employee class itself becomes abstract. Can you then create an Employee object?  

3. We now wish to define a class Worker, to represent a worker-type employee. A worker has the following characteristics with regards to salary:  A worker is paid a fixed amount per hour  A worker works a fixed number of hours per month  A Worker does not receive a bonus 

4. Given the above definitions, implement the Worker class – it will be derived from the Employee class. You will need to include some instance fields for hourly pay and hours worked per month, and provide concrete implementations for the abstract methods. Should you be able to create a Worker object?  

5. We now wish to define a Manager class. A manager is somewhat more weakly defined than a worker with regards to salary:  A manager has a fixed monthly base salary  A manager has a fixed monthly bonus  The condition for when the bonus is paid out may vary, depending on the specific type of manager (so Manager might become a base class…?)  

6. Given the above definitions, implement the Manager class – it will be derived from the Employee class. You will need to include some instance fields for monthly base salary and monthly bonus, and provide concrete implementations for some of the abstract methods. Should you be able to create a Manager object (probably not, and why not…?)? Should the Manager class then become an abstract class?  

7. We now wish to define a JuniorManager class. This class will be derived from the Manager class. A junior manager will have the bonus paid out if (s)he has worked more than 180 hours during the month. So, we will need to add an instance field to hold the number of hours worked, a way of setting this value, and – very importantly – to provide a concrete implementation of the IsBonusPaidOut() method. Should you be able to create a JuniorManager object (you probably should…)?  

8. We now wish to define a SeniorManager class. This class will be derived from the Manager class. A senior manager will have the bonus paid out if (s)he has a “performance level” of at least 6 during the month. So, we will need to add an instance field to hold the performance level, a way of setting this value, and – very importantly – to provide a concrete implementation of the IsBonusPaidOut() method. Should you be able to create a SeniorManager object (you probably should…)?  

9. Create a test of the classes, as usual in the myCode method in the InsertCodeHere class. More specifically, you should  Create a list which can hold Employee objects.  Create some Worker objects, and add them to the list  Create some JuniorManager objects, set the hours worked, and add them to the list  Create some SeniorManager objects, set the performance level, and add them to the list  Using a loop statement, print out the content of the list, like “(name) has a salary of (salary)”   
