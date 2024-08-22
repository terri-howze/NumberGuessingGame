# Number Guessing Game

Welcome to the Number Guessing Game! This is a simple console application built with C# where you attempt to guess a randomly generated number between 1 and 10. If you guess correctly, you win the game!

## Overview

In this game, the program generates a random number between 1 and 10. You need to guess the number by inputting your guesses into the console. The program will give you hints whether your guess is too high or too low until you find the correct number.

## Features

- Random number generation between 1 and 10.
- User input to guess the number.
- Hints provided for each guess (too high or too low).
- Congratulatory message upon guessing the correct number.

## Getting Started

### Prerequisites

- .NET Core or .NET Framework (any version compatible with C#)

### How to Run

1. **Clone the Repository**: Clone this repository to your local machine.
    ```bash
    git clone https://github.com/yourusername/numberguessinggame.git
    ```

2. **Navigate to the Project Directory**:
    ```bash
    cd numberguessinggame
    ```

3. **Build and Run the Project**:
    - Open the project in Visual Studio or your preferred C# IDE.
    - Build and run the project. If you're using the command line, you can use the following commands:
      ```bash
      dotnet build
      dotnet run
      ```

4. **Play the Game**:
    - The console will prompt you to enter your guess.
    - Input a number between 1 and 10.
    - Follow the hints provided by the program until you guess the correct number.

## Code Overview

- **`Program.cs`**: Contains the main game logic, including:
  - Generation of a random number between 1 and 10.
  - Input handling for user guesses.
  - Providing feedback on whether the guess is too high or too low.
  - Congratulating the user upon guessing the correct number.

## Example Usage

