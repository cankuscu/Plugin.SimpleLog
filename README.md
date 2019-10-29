# Simple Logger
Simple logger for Xamarin

## Description
It's a simple logger, with warn, error, critical and info methods.
You can also get log file text with **.GetLogText();**


## Example Usage
CrossSimpleLogger.Current.Critical("log this");
output to file will be, "Critical: log this 10/29/2019 11:36:35 AM\n"
to get all text from log file: 
var log = CrossSimpleLogger.Current.GetLogText();
