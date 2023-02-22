Console.WriteLine("Enter the time in hours and minutes (separated by a space):");

string[] timeInput = Console.ReadLine().Split(' ');

int hours = int.Parse(timeInput[0]);
int minutes = int.Parse(timeInput[1]);

double hourAngle = (hours % 12 + minutes / 60.0) * 30; // Each hour mark on a clock is 30 degrees apart
double minuteAngle = minutes * 6; // Each minute mark on a clock is 6 degrees apart

double angle = Math.Abs(hourAngle - minuteAngle);

if (angle > 180)
{
    angle = 360 - angle;
}

Console.WriteLine($"The lesser angle between the hour and minute hand is {angle} degrees.");


//! Task explanation
/*
When the program runs, it prompts the user to enter the time in hours and minutes, separated by a space. 
It then calculates the angles of the hour and minute hands, and finds the difference between them. 
If the angle is greater than 180 degrees, the program subtracts the angle from 360 to get the lesser angle. 
Finally, it outputs the result to the console window.
*/

 