# Log Providers

## [Console](Console.md)

Writes log entries to standard out.

## [File](File.md)

Writes log entries to a file.

## [Rolling File](RollingFile.md)

Writes log entries to a file. Log files will then be archived based on time and filesize configuration.

## Creating New

New log providers can be created by implementing `RockLib.Logging.ILogProvider`.