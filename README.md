# Simple Logger
Simple logger for Xamarin

## Description
It's a simple logger, with warn, error, critical and info methods.
You can also get log file txt with **.GetLogText();** and upload it to your server.


## Constructor
You can pass **filename**, ** foldername**, **culture string** and **datetime format**
default filename is log.txt, foldername is blank, culture string is "en-US", and DateTime format is G
For **DateTime** formats click [here](https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-date-and-time-format-strings)

## Example Usage
var logger = new Logger();
logger.Warn("something happened");
output to file will be, "Warn something happened 10/29/2019 1:03:30 AM"
