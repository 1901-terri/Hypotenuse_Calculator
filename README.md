Hypotenuse Calculator (C#)

A simple console-based hypotenuse calculator built with C#.
This application calculates the length of the hypotenuse of a right-angled triangle using the Pythagorean Theorem.

📌 Description

This program runs in the Command Line Interface (CLI) and allows the user to:

Enter the length of Side A

Enter the length of Side B

Automatically calculate the hypotenuse (Side C)

The formula used:

c = √(a² + b²)

The program then displays the calculated hypotenuse in the console.

🛠 Technologies Used

C#

.NET Console Application

System Namespace

Math.Sqrt() method

▶️ How It Works

The program starts and displays a title message.

The user is prompted to enter Side A.

The user is prompted to enter Side B.

The program calculates:

c = Math.Sqrt((a * a) + (b * b));

The hypotenuse value is displayed.

The program waits for a key press before closing.

🚀 How to Run
Using Visual Studio

Open the project in Visual Studio.

Click Start or press F5.

Enter the values when prompted in the console.

Using .NET CLI

Open a terminal in the project directory.

Run:

dotnet run

Enter the requested values.

💻 Example Output
Hypotenuse Calculator by Terri :)

Enter Side A:
3

Enter Side B:
4

The Hypotenuse is 5
📂 Project Structure
Hypotenuse_Calculator/
│
└── Program.cs
📖 Mathematical Concept

This program is based on the Pythagorean Theorem, which states:

In a right-angled triangle,
The square of the hypotenuse equals the sum of the squares of the other two sides.

🔮 Possible Improvements

Add input validation (prevent non-numeric input)

Format output to a specific number of decimal places

Allow multiple calculations without restarting the program

Add exception handling

Convert to a GUI application (Windows Forms or WPF)

👩‍💻 Author

Terri-Lee Gounder
C# Console Application Project
