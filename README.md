# Simple Logger
Simple logger for Xamarin

## Description
It's a simple logger, logs with **level** and **datetime** stamp.
Can be configured to suit your needs.

## Defaults
Datetime format is **"G"**,
CultureInfo is set to **"en-US"**,
Folder is not set, places txt to file to default path
Filename is **log.txt**

## Configuration
You can set **filename**, **foldername**, **culture** and **datetime format**.
ex: CrossSimpleLogger.Current.Configure("mylog.txt", "Logs", "tr-TR", "G");
[See for DateTime format strings](https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-date-and-time-format-strings)

## Other Methods
You can get logged text using **GetLogText();** method
You can get log path using **GetLogPath();** method

## Example Usage
CrossSimpleLogger.Current.Critical("log this");
output to file will be, "Critical: log this 10/29/2019 11:36:35 AM\n"
to get all text from log file: 
var log = CrossSimpleLogger.Current.GetLogText();
