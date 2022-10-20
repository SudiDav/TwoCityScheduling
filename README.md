# TwoCityScheduling

### Solution in made in .NET 6 console app. 
### Everything can be found under program.cs 

### Prerequisites to run the Solution. 
1. First of all will need the dotnet sdk which can be found [here](https://dotnet.microsoft.com/en-us/download). I used the .NET 6 SDK but any .NET SDK can work. 
I have tested the solution in 3.1 and 6 SDK. But for .NET 6, remember we do not need the top level statements. So if you are to run the solution in .NET 3.1 or 5; you will just need to place my soltuion under 
```namespace yournamespace
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //Place the code here
        }
    }
}
```

2. You will need to have VISUAL STUDIO or VISUAL STUDIO CODE installed. which can be found here respectively [visual studio](https://visualstudio.microsoft.com/) and [visual studio code](https://code.visualstudio.com/). If you decide to go with visual studio code, you will need to install the C# extension. I assume you have already got the SDK of your choice. You will have to run a couple of commands. For instance, you will need to do `dotnet new console -o nameOfyourApp` for creating a new console app. and `dotnet run` for running the app. 

### Note: 
The solution has already got test data. The test data is initilized as a 2 dimensional array in an `int[][] costs` variable. But you can change the its values however you want. I used the test data that was provided in the challenge
