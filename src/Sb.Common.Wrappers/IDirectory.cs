using System.Collections.Generic;
using System;
using System.IO;

namespace Sb.Common.Wrappers
{
    public interface IDirectory
    {
        //
        // Summary:
        //     Creates all directories and subdirectories in the specified path unless they
        //     already exist.
        //
        // Parameters:
        //   path:
        //     The directory to create.
        //
        // Returns:
        //     An object that represents the directory at the specified path. This object is
        //     returned regardless of whether a directory at the specified path already exists.
        //
        //
        // Exceptions:
        //   T:System.IO.IOException:
        //     The directory specified by path is a file. -or- The network name is not known.
        //
        //
        //   T:System.UnauthorizedAccessException:
        //     The caller does not have the required permission.
        //
        //   T:System.ArgumentException:
        //     path is a zero-length string, contains only white space, or contains one or more
        //     invalid characters. You can query for invalid characters by using the System.IO.Path.GetInvalidPathChars
        //     method. -or- path is prefixed with, or contains, only a colon character (:).
        //
        //
        //   T:System.ArgumentNullException:
        //     path is null.
        //
        //   T:System.IO.PathTooLongException:
        //     The specified path, file name, or both exceed the system-defined maximum length.
        //
        //
        //   T:System.IO.DirectoryNotFoundException:
        //     The specified path is invalid (for example, it is on an unmapped drive).
        //
        //   T:System.NotSupportedException:
        //     path contains a colon character (:) that is not part of a drive label ("C:\").
        DirectoryInfo CreateDirectory(string path);
        //
        // Summary:
        //     Deletes an empty directory from a specified path.
        //
        // Parameters:
        //   path:
        //     The name of the empty directory to remove. This directory must be writable and
        //     empty.
        //
        // Exceptions:
        //   T:System.IO.IOException:
        //     A file with the same name and location specified by path exists. -or- The directory
        //     is the application's current working directory. -or- The directory specified
        //     by path is not empty. -or- The directory is read-only or contains a read-only
        //     file. -or- The directory is being used by another process.
        //
        //   T:System.UnauthorizedAccessException:
        //     The caller does not have the required permission.
        //
        //   T:System.ArgumentException:
        //     path is a zero-length string, contains only white space, or contains one or more
        //     invalid characters. You can query for invalid characters by using the System.IO.Path.GetInvalidPathChars
        //     method.
        //
        //   T:System.ArgumentNullException:
        //     path is null.
        //
        //   T:System.IO.PathTooLongException:
        //     The specified path, file name, or both exceed the system-defined maximum length.
        //
        //
        //   T:System.IO.DirectoryNotFoundException:
        //     path does not exist or could not be found. -or- The specified path is invalid
        //     (for example, it is on an unmapped drive).
        void Delete(string path);
        //
        // Summary:
        //     Deletes the specified directory and, if indicated, any subdirectories and files
        //     in the directory.
        //
        // Parameters:
        //   path:
        //     The name of the directory to remove.
        //
        //   recursive:
        //     true to remove directories, subdirectories, and files in path; otherwise, false.
        //
        //
        // Exceptions:
        //   T:System.IO.IOException:
        //     A file with the same name and location specified by path exists. -or- The directory
        //     specified by path is read-only, or recursive is false and path is not an empty
        //     directory. -or- The directory is the application's current working directory.
        //     -or- The directory contains a read-only file. -or- The directory is being used
        //     by another process.
        //
        //   T:System.UnauthorizedAccessException:
        //     The caller does not have the required permission.
        //
        //   T:System.ArgumentException:
        //     path is a zero-length string, contains only white space, or contains one or more
        //     invalid characters. You can query for invalid characters by using the System.IO.Path.GetInvalidPathChars
        //     method.
        //
        //   T:System.ArgumentNullException:
        //     path is null.
        //
        //   T:System.IO.PathTooLongException:
        //     The specified path, file name, or both exceed the system-defined maximum length.
        //
        //
        //   T:System.IO.DirectoryNotFoundException:
        //     path does not exist or could not be found. -or- The specified path is invalid
        //     (for example, it is on an unmapped drive).
        void Delete(string path, bool recursive);
        //
        // Summary:
        //     Returns an enumerable collection of directory names in a specified path.
        //
        // Parameters:
        //   path:
        //     The relative or absolute path to the directory to search. This string is not
        //     case-sensitive.
        //
        // Returns:
        //     An enumerable collection of the full names (including paths) for the directories
        //     in the directory specified by path.
        //
        // Exceptions:
        //   T:System.ArgumentException:
        //     path is a zero-length string, contains only white space, or contains invalid
        //     characters. You can query for invalid characters by using the System.IO.Path.GetInvalidPathChars
        //     method.
        //
        //   T:System.ArgumentNullException:
        //     path is null.
        //
        //   T:System.IO.DirectoryNotFoundException:
        //     path is invalid, such as referring to an unmapped drive.
        //
        //   T:System.IO.IOException:
        //     path is a file name.
        //
        //   T:System.IO.PathTooLongException:
        //     The specified path, file name, or combined exceed the system-defined maximum
        //     length.
        //
        //   T:System.Security.SecurityException:
        //     The caller does not have the required permission.
        //
        //   T:System.UnauthorizedAccessException:
        //     The caller does not have the required permission.
        IEnumerable<string> EnumerateDirectories(string path);
        //
        // Summary:
        //     Returns an enumerable collection of directory names that match a search pattern
        //     in a specified path.
        //
        // Parameters:
        //   path:
        //     The relative or absolute path to the directory to search. This string is not
        //     case-sensitive.
        //
        //   searchPattern:
        //     The search string to match against the names of directories in path. This parameter
        //     can contain a combination of valid literal path and wildcard (* and ?) characters,
        //     but it doesn't support regular expressions.
        //
        // Returns:
        //     An enumerable collection of the full names (including paths) for the directories
        //     in the directory specified by path and that match the specified search pattern.
        //
        //
        // Exceptions:
        //   T:System.ArgumentException:
        //     path is a zero-length string, contains only white space, or contains invalid
        //     characters. You can query for invalid characters with the System.IO.Path.GetInvalidPathChars
        //     method. -or- searchPattern does not contain a valid pattern.
        //
        //   T:System.ArgumentNullException:
        //     path is null. -or- searchPattern is null.
        //
        //   T:System.IO.DirectoryNotFoundException:
        //     path is invalid, such as referring to an unmapped drive.
        //
        //   T:System.IO.IOException:
        //     path is a file name.
        //
        //   T:System.IO.PathTooLongException:
        //     The specified path, file name, or combined exceed the system-defined maximum
        //     length.
        //
        //   T:System.Security.SecurityException:
        //     The caller does not have the required permission.
        //
        //   T:System.UnauthorizedAccessException:
        //     The caller does not have the required permission.
        IEnumerable<string> EnumerateDirectories(string path, string searchPattern);
        //
        // Parameters:
        //   path:
        //
        //   searchPattern:
        //
        //   enumerationOptions:
        IEnumerable<string> EnumerateDirectories(string path, string searchPattern, EnumerationOptions enumerationOptions);
        //
        // Summary:
        //     Returns an enumerable collection of directory names that match a search pattern
        //     in a specified path, and optionally searches subdirectories.
        //
        // Parameters:
        //   path:
        //     The relative or absolute path to the directory to search. This string is not
        //     case-sensitive.
        //
        //   searchPattern:
        //     The search string to match against the names of directories in path. This parameter
        //     can contain a combination of valid literal path and wildcard (* and ?) characters,
        //     but it doesn't support regular expressions.
        //
        //   searchOption:
        //     One of the enumeration values that specifies whether the search operation should
        //     include only the current directory or should include all subdirectories. The
        //     default value is System.IO.SearchOption.TopDirectoryOnly.
        //
        // Returns:
        //     An enumerable collection of the full names (including paths) for the directories
        //     in the directory specified by path and that match the specified search pattern
        //     and option.
        //
        // Exceptions:
        //   T:System.ArgumentException:
        //     path is a zero-length string, contains only white space, or contains invalid
        //     characters. You can query for invalid characters by using the System.IO.Path.GetInvalidPathChars
        //     method. -or- searchPattern does not contain a valid pattern.
        //
        //   T:System.ArgumentNullException:
        //     path is null. -or- searchPattern is null.
        //
        //   T:System.ArgumentOutOfRangeException:
        //     searchOption is not a valid System.IO.SearchOption value.
        //
        //   T:System.IO.DirectoryNotFoundException:
        //     path is invalid, such as referring to an unmapped drive.
        //
        //   T:System.IO.IOException:
        //     path is a file name.
        //
        //   T:System.IO.PathTooLongException:
        //     The specified path, file name, or combined exceed the system-defined maximum
        //     length.
        //
        //   T:System.Security.SecurityException:
        //     The caller does not have the required permission.
        //
        //   T:System.UnauthorizedAccessException:
        //     The caller does not have the required permission.
        IEnumerable<string> EnumerateDirectories(string path, string searchPattern, SearchOption searchOption);
        //
        // Summary:
        //     Returns an enumerable collection of file names that match a search pattern in
        //     a specified path, and optionally searches subdirectories.
        //
        // Parameters:
        //   path:
        //     The relative or absolute path to the directory to search. This string is not
        //     case-sensitive.
        //
        //   searchPattern:
        //     The search string to match against the names of files in path. This parameter
        //     can contain a combination of valid literal path and wildcard (* and ?) characters,
        //     but it doesn't support regular expressions.
        //
        //   searchOption:
        //     One of the enumeration values that specifies whether the search operation should
        //     include only the current directory or should include all subdirectories. The
        //     default value is System.IO.SearchOption.TopDirectoryOnly.
        //
        // Returns:
        //     An enumerable collection of the full names (including paths) for the files in
        //     the directory specified by path and that match the specified search pattern and
        //     option.
        //
        // Exceptions:
        //   T:System.ArgumentException:
        //     path is a zero-length string, contains only white space, or contains invalid
        //     characters. You can query for invalid characters by using the System.IO.Path.GetInvalidPathChars
        //     method. -or- searchPattern does not contain a valid pattern.
        //
        //   T:System.ArgumentNullException:
        //     path is null. -or- searchPattern is null.
        //
        //   T:System.ArgumentOutOfRangeException:
        //     searchOption is not a valid System.IO.SearchOption value.
        //
        //   T:System.IO.DirectoryNotFoundException:
        //     path is invalid, such as referring to an unmapped drive.
        //
        //   T:System.IO.IOException:
        //     path is a file name.
        //
        //   T:System.IO.PathTooLongException:
        //     The specified path, file name, or combined exceed the system-defined maximum
        //     length.
        //
        //   T:System.Security.SecurityException:
        //     The caller does not have the required permission.
        //
        //   T:System.UnauthorizedAccessException:
        //     The caller does not have the required permission.
        IEnumerable<string> EnumerateFiles(string path, string searchPattern, SearchOption searchOption);
        //
        // Parameters:
        //   path:
        //
        //   searchPattern:
        //
        //   enumerationOptions:
        IEnumerable<string> EnumerateFiles(string path, string searchPattern, EnumerationOptions enumerationOptions);
        //
        // Summary:
        //     Returns an enumerable collection of file names in a specified path.
        //
        // Parameters:
        //   path:
        //     The relative or absolute path to the directory to search. This string is not
        //     case-sensitive.
        //
        // Returns:
        //     An enumerable collection of the full names (including paths) for the files in
        //     the directory specified by path.
        //
        // Exceptions:
        //   T:System.ArgumentException:
        //     path is a zero-length string, contains only white space, or contains invalid
        //     characters. You can query for invalid characters by using the System.IO.Path.GetInvalidPathChars
        //     method.
        //
        //   T:System.ArgumentNullException:
        //     path is null.
        //
        //   T:System.IO.DirectoryNotFoundException:
        //     path is invalid, such as referring to an unmapped drive.
        //
        //   T:System.IO.IOException:
        //     path is a file name.
        //
        //   T:System.IO.PathTooLongException:
        //     The specified path, file name, or combined exceed the system-defined maximum
        //     length.
        //
        //   T:System.Security.SecurityException:
        //     The caller does not have the required permission.
        //
        //   T:System.UnauthorizedAccessException:
        //     The caller does not have the required permission.
        IEnumerable<string> EnumerateFiles(string path);
        //
        // Summary:
        //     Returns an enumerable collection of file names that match a search pattern in
        //     a specified path.
        //
        // Parameters:
        //   path:
        //     The relative or absolute path to the directory to search. This string is not
        //     case-sensitive.
        //
        //   searchPattern:
        //     The search string to match against the names of files in path. This parameter
        //     can contain a combination of valid literal path and wildcard (* and ?) characters,
        //     but it doesn't support regular expressions.
        //
        // Returns:
        //     An enumerable collection of the full names (including paths) for the files in
        //     the directory specified by path and that match the specified search pattern.
        //
        //
        // Exceptions:
        //   T:System.ArgumentException:
        //     path is a zero-length string, contains only white space, or contains invalid
        //     characters. You can query for invalid characters by using the System.IO.Path.GetInvalidPathChars
        //     method. -or- searchPattern does not contain a valid pattern.
        //
        //   T:System.ArgumentNullException:
        //     path is null. -or- searchPattern is null.
        //
        //   T:System.IO.DirectoryNotFoundException:
        //     path is invalid, such as referring to an unmapped drive.
        //
        //   T:System.IO.IOException:
        //     path is a file name.
        //
        //   T:System.IO.PathTooLongException:
        //     The specified path, file name, or combined exceed the system-defined maximum
        //     length.
        //
        //   T:System.Security.SecurityException:
        //     The caller does not have the required permission.
        //
        //   T:System.UnauthorizedAccessException:
        //     The caller does not have the required permission.
        IEnumerable<string> EnumerateFiles(string path, string searchPattern);
        //
        // Summary:
        //     Returns an enumerable collection of file names and directory names in a specified
        //     path.
        //
        // Parameters:
        //   path:
        //     The relative or absolute path to the directory to search. This string is not
        //     case-sensitive.
        //
        // Returns:
        //     An enumerable collection of file-system entries in the directory specified by
        //     path.
        //
        // Exceptions:
        //   T:System.ArgumentException:
        //     path is a zero-length string, contains only white space, or contains invalid
        //     characters. You can query for invalid characters by using the System.IO.Path.GetInvalidPathChars
        //     method.
        //
        //   T:System.ArgumentNullException:
        //     path is null.
        //
        //   T:System.IO.DirectoryNotFoundException:
        //     path is invalid, such as referring to an unmapped drive.
        //
        //   T:System.IO.IOException:
        //     path is a file name.
        //
        //   T:System.IO.PathTooLongException:
        //     The specified path, file name, or combined exceed the system-defined maximum
        //     length.
        //
        //   T:System.Security.SecurityException:
        //     The caller does not have the required permission.
        //
        //   T:System.UnauthorizedAccessException:
        //     The caller does not have the required permission.
        IEnumerable<string> EnumerateFileSystemEntries(string path);
        //
        // Summary:
        //     Returns an enumerable collection of file names and directory names that match
        //     a search pattern in a specified path.
        //
        // Parameters:
        //   path:
        //     The relative or absolute path to the directory to search. This string is not
        //     case-sensitive.
        //
        //   searchPattern:
        //     The search string to match against the names of file-system entries in path.
        //     This parameter can contain a combination of valid literal path and wildcard (*
        //     and ?) characters, but it doesn't support regular expressions.
        //
        // Returns:
        //     An enumerable collection of file-system entries in the directory specified by
        //     path and that match the specified search pattern.
        //
        // Exceptions:
        //   T:System.ArgumentException:
        //     path is a zero-length string, contains only white space, or contains invalid
        //     characters. You can query for invalid characters by using the System.IO.Path.GetInvalidPathChars
        //     method. -or- searchPattern does not contain a valid pattern.
        //
        //   T:System.ArgumentNullException:
        //     path is null. -or- searchPattern is null.
        //
        //   T:System.IO.DirectoryNotFoundException:
        //     path is invalid, such as referring to an unmapped drive.
        //
        //   T:System.IO.IOException:
        //     path is a file name.
        //
        //   T:System.IO.PathTooLongException:
        //     The specified path, file name, or combined exceed the system-defined maximum
        //     length.
        //
        //   T:System.Security.SecurityException:
        //     The caller does not have the required permission.
        //
        //   T:System.UnauthorizedAccessException:
        //     The caller does not have the required permission.
        IEnumerable<string> EnumerateFileSystemEntries(string path, string searchPattern);
        //
        // Parameters:
        //   path:
        //
        //   searchPattern:
        //
        //   enumerationOptions:
        IEnumerable<string> EnumerateFileSystemEntries(string path, string searchPattern, EnumerationOptions enumerationOptions);
        //
        // Summary:
        //     Returns an enumerable collection of file names and directory names that match
        //     a search pattern in a specified path, and optionally searches subdirectories.
        //
        //
        // Parameters:
        //   path:
        //     The relative or absolute path to the directory to search. This string is not
        //     case-sensitive.
        //
        //   searchPattern:
        //     The search string to match against file-system entries in path. This parameter
        //     can contain a combination of valid literal path and wildcard (* and ?) characters,
        //     but it doesn't support regular expressions.
        //
        //   searchOption:
        //     One of the enumeration values that specifies whether the search operation should
        //     include only the current directory or should include all subdirectories. The
        //     default value is System.IO.SearchOption.TopDirectoryOnly.
        //
        // Returns:
        //     An enumerable collection of file-system entries in the directory specified by
        //     path and that match the specified search pattern and option.
        //
        // Exceptions:
        //   T:System.ArgumentException:
        //     path is a zero-length string, contains only white space, or contains invalid
        //     characters. You can query for invalid characters by using the System.IO.Path.GetInvalidPathChars
        //     method. -or- searchPattern does not contain a valid pattern.
        //
        //   T:System.ArgumentNullException:
        //     path is null. -or- searchPattern is null.
        //
        //   T:System.ArgumentOutOfRangeException:
        //     searchOption is not a valid System.IO.SearchOption value.
        //
        //   T:System.IO.DirectoryNotFoundException:
        //     path is invalid, such as referring to an unmapped drive.
        //
        //   T:System.IO.IOException:
        //     path is a file name.
        //
        //   T:System.IO.PathTooLongException:
        //     The specified path, file name, or combined exceed the system-defined maximum
        //     length.
        //
        //   T:System.Security.SecurityException:
        //     The caller does not have the required permission.
        //
        //   T:System.UnauthorizedAccessException:
        //     The caller does not have the required permission.
        IEnumerable<string> EnumerateFileSystemEntries(string path, string searchPattern, SearchOption searchOption);
        //
        // Summary:
        //     Determines whether the given path refers to an existing directory on disk.
        //
        // Parameters:
        //   path:
        //     The path to test.
        //
        // Returns:
        //     true if path refers to an existing directory; false if the directory does not
        //     exist or an error occurs when trying to determine if the specified directory
        //     exists.
        bool Exists(string path);
        //
        // Summary:
        //     Gets the creation date and time of a directory.
        //
        // Parameters:
        //   path:
        //     The path of the directory.
        //
        // Returns:
        //     A structure that is set to the creation date and time for the specified directory.
        //     This value is expressed in local time.
        //
        // Exceptions:
        //   T:System.UnauthorizedAccessException:
        //     The caller does not have the required permission.
        //
        //   T:System.ArgumentException:
        //     path is a zero-length string, contains only white space, or contains one or more
        //     invalid characters. You can query for invalid characters by using the System.IO.Path.GetInvalidPathChars
        //     method.
        //
        //   T:System.ArgumentNullException:
        //     path is null.
        //
        //   T:System.IO.PathTooLongException:
        //     The specified path, file name, or both exceed the system-defined maximum length.
        DateTime GetCreationTime(string path);
        //
        // Summary:
        //     Gets the creation date and time, in Coordinated Universal Time (UTC) format,
        //     of a directory.
        //
        // Parameters:
        //   path:
        //     The path of the directory.
        //
        // Returns:
        //     A structure that is set to the creation date and time for the specified directory.
        //     This value is expressed in UTC time.
        //
        // Exceptions:
        //   T:System.UnauthorizedAccessException:
        //     The caller does not have the required permission.
        //
        //   T:System.ArgumentException:
        //     path is a zero-length string, contains only white space, or contains one or more
        //     invalid characters. You can query for invalid characters by using the System.IO.Path.GetInvalidPathChars
        //     method.
        //
        //   T:System.ArgumentNullException:
        //     path is null.
        //
        //   T:System.IO.PathTooLongException:
        //     The specified path, file name, or both exceed the system-defined maximum length.
        DateTime GetCreationTimeUtc(string path);
        //
        // Summary:
        //     Gets the current working directory of the application.
        //
        // Returns:
        //     A string that contains the absolute path of the current working directory, and
        //     does not end with a backslash (\).
        //
        // Exceptions:
        //   T:System.UnauthorizedAccessException:
        //     The caller does not have the required permission.
        //
        //   T:System.NotSupportedException:
        //     The operating system is Windows CE, which does not have current directory functionality.
        //     This method is available in the .NET Compact Framework, but is not currently
        //     supported.
        string GetCurrentDirectory();
        //
        // Parameters:
        //   path:
        //
        //   searchPattern:
        //
        //   enumerationOptions:
        string[] GetDirectories(string path, string searchPattern, EnumerationOptions enumerationOptions);
        //
        // Summary:
        //     Returns the names of the subdirectories (including their paths) that match the
        //     specified search pattern in the specified directory, and optionally searches
        //     subdirectories.
        //
        // Parameters:
        //   path:
        //     The relative or absolute path to the directory to search. This string is not
        //     case-sensitive.
        //
        //   searchPattern:
        //     The search string to match against the names of subdirectories in path. This
        //     parameter can contain a combination of valid literal and wildcard characters,
        //     but it doesn't support regular expressions.
        //
        //   searchOption:
        //     One of the enumeration values that specifies whether the search operation should
        //     include all subdirectories or only the current directory.
        //
        // Returns:
        //     An array of the full names (including paths) of the subdirectories that match
        //     the specified criteria, or an empty array if no directories are found.
        //
        // Exceptions:
        //   T:System.ArgumentException:
        //     path is a zero-length string, contains only white space, or contains one or more
        //     invalid characters. You can query for invalid characters by using the System.IO.Path.GetInvalidPathChars
        //     method. -or- searchPattern does not contain a valid pattern.
        //
        //   T:System.ArgumentNullException:
        //     path or searchPattern is null.
        //
        //   T:System.ArgumentOutOfRangeException:
        //     searchOption is not a valid System.IO.SearchOption value.
        //
        //   T:System.UnauthorizedAccessException:
        //     The caller does not have the required permission.
        //
        //   T:System.IO.PathTooLongException:
        //     The specified path, file name, or both exceed the system-defined maximum length.
        //
        //
        //   T:System.IO.IOException:
        //     path is a file name.
        //
        //   T:System.IO.DirectoryNotFoundException:
        //     The specified path is invalid (for example, it is on an unmapped drive).
        string[] GetDirectories(string path, string searchPattern, SearchOption searchOption);
        //
        // Summary:
        //     Returns the names of subdirectories (including their paths) in the specified
        //     directory.
        //
        // Parameters:
        //   path:
        //     The relative or absolute path to the directory to search. This string is not
        //     case-sensitive.
        //
        // Returns:
        //     An array of the full names (including paths) of subdirectories in the specified
        //     path, or an empty array if no directories are found.
        //
        // Exceptions:
        //   T:System.UnauthorizedAccessException:
        //     The caller does not have the required permission.
        //
        //   T:System.ArgumentException:
        //     path is a zero-length string, contains only white space, or contains one or more
        //     invalid characters. You can query for invalid characters by using the System.IO.Path.GetInvalidPathChars
        //     method.
        //
        //   T:System.ArgumentNullException:
        //     path is null.
        //
        //   T:System.IO.PathTooLongException:
        //     The specified path, file name, or both exceed the system-defined maximum length.
        //
        //
        //   T:System.IO.IOException:
        //     path is a file name.
        //
        //   T:System.IO.DirectoryNotFoundException:
        //     The specified path is invalid (for example, it is on an unmapped drive).
        string[] GetDirectories(string path);
        //
        // Summary:
        //     Returns the names of subdirectories (including their paths) that match the specified
        //     search pattern in the specified directory.
        //
        // Parameters:
        //   path:
        //     The relative or absolute path to the directory to search. This string is not
        //     case-sensitive.
        //
        //   searchPattern:
        //     The search string to match against the names of subdirectories in path. This
        //     parameter can contain a combination of valid literal and wildcard characters,
        //     but it doesn't support regular expressions.
        //
        // Returns:
        //     An array of the full names (including paths) of the subdirectories that match
        //     the search pattern in the specified directory, or an empty array if no directories
        //     are found.
        //
        // Exceptions:
        //   T:System.UnauthorizedAccessException:
        //     The caller does not have the required permission.
        //
        //   T:System.ArgumentException:
        //     path is a zero-length string, contains only white space, or contains one or more
        //     invalid characters. You can query for invalid characters by using System.IO.Path.GetInvalidPathChars.
        //     -or- searchPattern doesn't contain a valid pattern.
        //
        //   T:System.ArgumentNullException:
        //     path or searchPattern is null.
        //
        //   T:System.IO.PathTooLongException:
        //     The specified path, file name, or both exceed the system-defined maximum length.
        //
        //
        //   T:System.IO.IOException:
        //     path is a file name.
        //
        //   T:System.IO.DirectoryNotFoundException:
        //     The specified path is invalid (for example, it is on an unmapped drive).
        string[] GetDirectories(string path, string searchPattern);
        //
        // Summary:
        //     Returns the volume information, root information, or both for the specified path.
        //
        //
        // Parameters:
        //   path:
        //     The path of a file or directory.
        //
        // Returns:
        //     A string that contains the volume information, root information, or both for
        //     the specified path.
        //
        // Exceptions:
        //   T:System.UnauthorizedAccessException:
        //     The caller does not have the required permission.
        //
        //   T:System.ArgumentException:
        //     path is a zero-length string, contains only white space, or contains one or more
        //     invalid characters. You can query for invalid characters with System.IO.Path.GetInvalidPathChars.
        //
        //
        //   T:System.ArgumentNullException:
        //     path is null.
        //
        //   T:System.IO.PathTooLongException:
        //     The specified path, file name, or both exceed the system-defined maximum length.
        string GetDirectoryRoot(string path);
        //
        // Summary:
        //     Returns the names of files (including their paths) in the specified directory.
        //
        //
        // Parameters:
        //   path:
        //     The relative or absolute path to the directory to search. This string is not
        //     case-sensitive.
        //
        // Returns:
        //     An array of the full names (including paths) for the files in the specified directory,
        //     or an empty array if no files are found.
        //
        // Exceptions:
        //   T:System.IO.IOException:
        //     path is a file name. -or- A network error has occurred.
        //
        //   T:System.UnauthorizedAccessException:
        //     The caller does not have the required permission.
        //
        //   T:System.ArgumentException:
        //     path is a zero-length string, contains only white space, or contains one or more
        //     invalid characters. You can query for invalid characters by using the System.IO.Path.GetInvalidPathChars
        //     method.
        //
        //   T:System.ArgumentNullException:
        //     path is null.
        //
        //   T:System.IO.PathTooLongException:
        //     The specified path, file name, or both exceed the system-defined maximum length.
        //
        //
        //   T:System.IO.DirectoryNotFoundException:
        //     The specified path is not found or is invalid (for example, it is on an unmapped
        //     drive).
        string[] GetFiles(string path);
        //
        // Summary:
        //     Returns the names of files (including their paths) that match the specified search
        //     pattern in the specified directory.
        //
        // Parameters:
        //   path:
        //     The relative or absolute path to the directory to search. This string is not
        //     case-sensitive.
        //
        //   searchPattern:
        //     The search string to match against the names of files in path. This parameter
        //     can contain a combination of valid literal path and wildcard (* and ?) characters,
        //     but it doesn't support regular expressions.
        //
        // Returns:
        //     An array of the full names (including paths) for the files in the specified directory
        //     that match the specified search pattern, or an empty array if no files are found.
        //
        //
        // Exceptions:
        //   T:System.IO.IOException:
        //     path is a file name. -or- A network error has occurred.
        //
        //   T:System.UnauthorizedAccessException:
        //     The caller does not have the required permission.
        //
        //   T:System.ArgumentException:
        //     path is a zero-length string, contains only white space, or contains one or more
        //     invalid characters. You can query for invalid characters by using System.IO.Path.GetInvalidPathChars.
        //     -or- searchPattern doesn't contain a valid pattern.
        //
        //   T:System.ArgumentNullException:
        //     path or searchPattern is null.
        //
        //   T:System.IO.PathTooLongException:
        //     The specified path, file name, or both exceed the system-defined maximum length.
        //
        //
        //   T:System.IO.DirectoryNotFoundException:
        //     The specified path is not found or is invalid (for example, it is on an unmapped
        //     drive).
        string[] GetFiles(string path, string searchPattern);
        //
        // Parameters:
        //   path:
        //
        //   searchPattern:
        //
        //   enumerationOptions:
        string[] GetFiles(string path, string searchPattern, EnumerationOptions enumerationOptions);
        //
        // Summary:
        //     Returns the names of files (including their paths) that match the specified search
        //     pattern in the specified directory, using a value to determine whether to search
        //     subdirectories.
        //
        // Parameters:
        //   path:
        //     The relative or absolute path to the directory to search. This string is not
        //     case-sensitive.
        //
        //   searchPattern:
        //     The search string to match against the names of files in path. This parameter
        //     can contain a combination of valid literal path and wildcard (* and ?) characters,
        //     but it doesn't support regular expressions.
        //
        //   searchOption:
        //     One of the enumeration values that specifies whether the search operation should
        //     include all subdirectories or only the current directory.
        //
        // Returns:
        //     An array of the full names (including paths) for the files in the specified directory
        //     that match the specified search pattern and option, or an empty array if no files
        //     are found.
        //
        // Exceptions:
        //   T:System.ArgumentException:
        //     path is a zero-length string, contains only white space, or contains one or more
        //     invalid characters. You can query for invalid characters with the System.IO.Path.GetInvalidPathChars
        //     method. -or- searchPattern does not contain a valid pattern.
        //
        //   T:System.ArgumentNullException:
        //     path or searchpattern is null.
        //
        //   T:System.ArgumentOutOfRangeException:
        //     searchOption is not a valid System.IO.SearchOption value.
        //
        //   T:System.UnauthorizedAccessException:
        //     The caller does not have the required permission.
        //
        //   T:System.IO.DirectoryNotFoundException:
        //     The specified path is not found or is invalid (for example, it is on an unmapped
        //     drive).
        //
        //   T:System.IO.PathTooLongException:
        //     The specified path, file name, or both exceed the system-defined maximum length.
        //
        //
        //   T:System.IO.IOException:
        //     path is a file name. -or- A network error has occurred.
        string[] GetFiles(string path, string searchPattern, SearchOption searchOption);
        //
        // Summary:
        //     Returns the names of all files and subdirectories in a specified path.
        //
        // Parameters:
        //   path:
        //     The relative or absolute path to the directory to search. This string is not
        //     case-sensitive.
        //
        // Returns:
        //     An array of the names of files and subdirectories in the specified directory,
        //     or an empty array if no files or subdirectories are found.
        //
        // Exceptions:
        //   T:System.UnauthorizedAccessException:
        //     The caller does not have the required permission.
        //
        //   T:System.ArgumentException:
        //     path is a zero-length string, contains only white space, or contains one or more
        //     invalid characters. You can query for invalid characters with System.IO.Path.GetInvalidPathChars.
        //
        //
        //   T:System.ArgumentNullException:
        //     path is null.
        //
        //   T:System.IO.PathTooLongException:
        //     The specified path, file name, or both exceed the system-defined maximum length.
        //
        //
        //   T:System.IO.IOException:
        //     path is a file name.
        //
        //   T:System.IO.DirectoryNotFoundException:
        //     The specified path is invalid (for example, it is on an unmapped drive).
        string[] GetFileSystemEntries(string path);
        //
        // Summary:
        //     Returns an array of file names and directory names that match a search pattern
        //     in a specified path.
        //
        // Parameters:
        //   path:
        //     The relative or absolute path to the directory to search. This string is not
        //     case-sensitive.
        //
        //   searchPattern:
        //     The search string to match against the names of file and directories in path.
        //     This parameter can contain a combination of valid literal path and wildcard (*
        //     and ?) characters, but it doesn't support regular expressions.
        //
        // Returns:
        //     An array of file names and directory names that match the specified search criteria,
        //     or an empty array if no files or directories are found.
        //
        // Exceptions:
        //   T:System.UnauthorizedAccessException:
        //     The caller does not have the required permission.
        //
        //   T:System.ArgumentException:
        //     path is a zero-length string, contains only white space, or contains one or more
        //     invalid characters. You can query for invalid characters with the System.IO.Path.GetInvalidPathChars
        //     method. -or- searchPattern does not contain a valid pattern.
        //
        //   T:System.ArgumentNullException:
        //     path or searchPattern is null.
        //
        //   T:System.IO.PathTooLongException:
        //     The specified path, file name, or both exceed the system-defined maximum length.
        //
        //
        //   T:System.IO.IOException:
        //     path is a file name.
        //
        //   T:System.IO.DirectoryNotFoundException:
        //     The specified path is invalid (for example, it is on an unmapped drive).
        string[] GetFileSystemEntries(string path, string searchPattern);
        //
        // Parameters:
        //   path:
        //
        //   searchPattern:
        //
        //   enumerationOptions:
        string[] GetFileSystemEntries(string path, string searchPattern, EnumerationOptions enumerationOptions);
        //
        // Summary:
        //     Returns an array of all the file names and directory names that match a search
        //     pattern in a specified path, and optionally searches subdirectories.
        //
        // Parameters:
        //   path:
        //     The relative or absolute path to the directory to search. This string is not
        //     case-sensitive.
        //
        //   searchPattern:
        //     The search string to match against the names of files and directories in path.
        //     This parameter can contain a combination of valid literal path and wildcard (*
        //     and ?) characters, but it doesn't support regular expressions.
        //
        //   searchOption:
        //     One of the enumeration values that specifies whether the search operation should
        //     include only the current directory or should include all subdirectories. The
        //     default value is System.IO.SearchOption.TopDirectoryOnly.
        //
        // Returns:
        //     An array of file the file names and directory names that match the specified
        //     search criteria, or an empty array if no files or directories are found.
        //
        // Exceptions:
        //   T:System.ArgumentException:
        //     path is a zero-length string, contains only white space, or contains invalid
        //     characters. You can query for invalid characters by using the System.IO.Path.GetInvalidPathChars
        //     method. -or- searchPattern does not contain a valid pattern.
        //
        //   T:System.ArgumentNullException:
        //     path is null. -or- searchPattern is null.
        //
        //   T:System.ArgumentOutOfRangeException:
        //     searchOption is not a valid System.IO.SearchOption value.
        //
        //   T:System.IO.DirectoryNotFoundException:
        //     path is invalid, such as referring to an unmapped drive.
        //
        //   T:System.IO.IOException:
        //     path is a file name.
        //
        //   T:System.IO.PathTooLongException:
        //     The specified path, file name, or combined exceed the system-defined maximum
        //     length.
        //
        //   T:System.Security.SecurityException:
        //     The caller does not have the required permission.
        //
        //   T:System.UnauthorizedAccessException:
        //     The caller does not have the required permission.
        string[] GetFileSystemEntries(string path, string searchPattern, SearchOption searchOption);
        //
        // Summary:
        //     Returns the date and time the specified file or directory was last accessed.
        //
        //
        // Parameters:
        //   path:
        //     The file or directory for which to obtain access date and time information.
        //
        // Returns:
        //     A structure that is set to the date and time the specified file or directory
        //     was last accessed. This value is expressed in local time.
        //
        // Exceptions:
        //   T:System.UnauthorizedAccessException:
        //     The caller does not have the required permission.
        //
        //   T:System.ArgumentException:
        //     path is a zero-length string, contains only white space, or contains one or more
        //     invalid characters. You can query for invalid characters with the System.IO.Path.GetInvalidPathChars
        //     method.
        //
        //   T:System.ArgumentNullException:
        //     path is null.
        //
        //   T:System.IO.PathTooLongException:
        //     The specified path, file name, or both exceed the system-defined maximum length.
        //
        //
        //   T:System.NotSupportedException:
        //     The path parameter is in an invalid format.
        DateTime GetLastAccessTime(string path);
        //
        // Summary:
        //     Returns the date and time, in Coordinated Universal Time (UTC) format, that the
        //     specified file or directory was last accessed.
        //
        // Parameters:
        //   path:
        //     The file or directory for which to obtain access date and time information.
        //
        // Returns:
        //     A structure that is set to the date and time the specified file or directory
        //     was last accessed. This value is expressed in UTC time.
        //
        // Exceptions:
        //   T:System.UnauthorizedAccessException:
        //     The caller does not have the required permission.
        //
        //   T:System.ArgumentException:
        //     path is a zero-length string, contains only white space, or contains one or more
        //     invalid characters. You can query for invalid characters with the System.IO.Path.GetInvalidPathChars
        //     method.
        //
        //   T:System.ArgumentNullException:
        //     path is null.
        //
        //   T:System.IO.PathTooLongException:
        //     The specified path, file name, or both exceed the system-defined maximum length.
        //
        //
        //   T:System.NotSupportedException:
        //     The path parameter is in an invalid format.
        DateTime GetLastAccessTimeUtc(string path);
        //
        // Summary:
        //     Returns the date and time the specified file or directory was last written to.
        //
        //
        // Parameters:
        //   path:
        //     The file or directory for which to obtain modification date and time information.
        //
        //
        // Returns:
        //     A structure that is set to the date and time the specified file or directory
        //     was last written to. This value is expressed in local time.
        //
        // Exceptions:
        //   T:System.UnauthorizedAccessException:
        //     The caller does not have the required permission.
        //
        //   T:System.ArgumentException:
        //     path is a zero-length string, contains only white space, or contains one or more
        //     invalid characters. You can query for invalid characters with the System.IO.Path.GetInvalidPathChars
        //     method.
        //
        //   T:System.ArgumentNullException:
        //     path is null.
        //
        //   T:System.IO.PathTooLongException:
        //     The specified path, file name, or both exceed the system-defined maximum length.
        DateTime GetLastWriteTime(string path);
        //
        // Summary:
        //     Returns the date and time, in Coordinated Universal Time (UTC) format, that the
        //     specified file or directory was last written to.
        //
        // Parameters:
        //   path:
        //     The file or directory for which to obtain modification date and time information.
        //
        //
        // Returns:
        //     A structure that is set to the date and time the specified file or directory
        //     was last written to. This value is expressed in UTC time.
        //
        // Exceptions:
        //   T:System.UnauthorizedAccessException:
        //     The caller does not have the required permission.
        //
        //   T:System.ArgumentException:
        //     path is a zero-length string, contains only white space, or contains one or more
        //     invalid characters. You can query for invalid characters with the System.IO.Path.GetInvalidPathChars
        //     method.
        //
        //   T:System.ArgumentNullException:
        //     path is null.
        //
        //   T:System.IO.PathTooLongException:
        //     The specified path, file name, or both exceed the system-defined maximum length.
        DateTime GetLastWriteTimeUtc(string path);
        //
        // Summary:
        //     Retrieves the names of the logical drives on this computer in the form "<drive
        //     letter>:\".
        //
        // Returns:
        //     The logical drives on this computer.
        //
        // Exceptions:
        //   T:System.IO.IOException:
        //     An I/O error occurred (for example, a disk error).
        //
        //   T:System.UnauthorizedAccessException:
        //     The caller does not have the required permission.
        string[] GetLogicalDrives();
        //
        // Summary:
        //     Retrieves the parent directory of the specified path, including both absolute
        //     and relative paths.
        //
        // Parameters:
        //   path:
        //     The path for which to retrieve the parent directory.
        //
        // Returns:
        //     The parent directory, or null if path is the root directory, including the root
        //     of a UNC server or share name.
        //
        // Exceptions:
        //   T:System.IO.IOException:
        //     The directory specified by path is read-only.
        //
        //   T:System.UnauthorizedAccessException:
        //     The caller does not have the required permission.
        //
        //   T:System.ArgumentException:
        //     path is a zero-length string, contains only white space, or contains one or more
        //     invalid characters. You can query for invalid characters with the System.IO.Path.GetInvalidPathChars
        //     method.
        //
        //   T:System.ArgumentNullException:
        //     path is null.
        //
        //   T:System.IO.PathTooLongException:
        //     The specified path, file name, or both exceed the system-defined maximum length.
        //     For more information, see the System.IO.PathTooLongException topic.
        //
        //   T:System.IO.DirectoryNotFoundException:
        //     The specified path was not found.
        //
        //   T:System.NotSupportedException:
        //     path is in an invalid format.
        //
        //   T:System.Security.SecurityException:
        //     .NET Framework only: The caller does not have the required permissions.
        DirectoryInfo GetParent(string path);
        //
        // Summary:
        //     Moves a file or a directory and its contents to a new location.
        //
        // Parameters:
        //   sourceDirName:
        //     The path of the file or directory to move.
        //
        //   destDirName:
        //     The path to the new location for sourceDirName. If sourceDirName is a file, then
        //     destDirName must also be a file name.
        //
        // Exceptions:
        //   T:System.IO.IOException:
        //     An attempt was made to move a directory to a different volume. -or- destDirName
        //     already exists. See the Note in the Remarks section. -or- The sourceDirName and
        //     destDirName parameters refer to the same file or directory. -or- The directory
        //     or a file within it is being used by another process.
        //
        //   T:System.UnauthorizedAccessException:
        //     The caller does not have the required permission.
        //
        //   T:System.ArgumentException:
        //     sourceDirName or destDirName is a zero-length string, contains only white space,
        //     or contains one or more invalid characters. You can query for invalid characters
        //     with the System.IO.Path.GetInvalidPathChars method.
        //
        //   T:System.ArgumentNullException:
        //     sourceDirName or destDirName is null.
        //
        //   T:System.IO.PathTooLongException:
        //     The specified path, file name, or both exceed the system-defined maximum length.
        //
        //
        //   T:System.IO.DirectoryNotFoundException:
        //     The path specified by sourceDirName is invalid (for example, it is on an unmapped
        //     drive).
        void Move(string sourceDirName, string destDirName);
        //
        // Summary:
        //     Sets the creation date and time for the specified file or directory.
        //
        // Parameters:
        //   path:
        //     The file or directory for which to set the creation date and time information.
        //
        //
        //   creationTime:
        //     The date and time the file or directory was last written to. This value is expressed
        //     in local time.
        //
        // Exceptions:
        //   T:System.IO.FileNotFoundException:
        //     The specified path was not found.
        //
        //   T:System.ArgumentException:
        //     path is a zero-length string, contains only white space, or contains one or more
        //     invalid characters. You can query for invalid characters with the System.IO.Path.GetInvalidPathChars
        //     method.
        //
        //   T:System.ArgumentNullException:
        //     path is null.
        //
        //   T:System.IO.PathTooLongException:
        //     The specified path, file name, or both exceed the system-defined maximum length.
        //
        //
        //   T:System.UnauthorizedAccessException:
        //     The caller does not have the required permission.
        //
        //   T:System.ArgumentOutOfRangeException:
        //     creationTime specifies a value outside the range of dates or times permitted
        //     for this operation.
        //
        //   T:System.PlatformNotSupportedException:
        //     The current operating system is not Windows NT or later.
        void SetCreationTime(string path, DateTime creationTime);
        //
        // Summary:
        //     Sets the creation date and time, in Coordinated Universal Time (UTC) format,
        //     for the specified file or directory.
        //
        // Parameters:
        //   path:
        //     The file or directory for which to set the creation date and time information.
        //
        //
        //   creationTimeUtc:
        //     The date and time the directory or file was created. This value is expressed
        //     in local time.
        //
        // Exceptions:
        //   T:System.IO.FileNotFoundException:
        //     The specified path was not found.
        //
        //   T:System.ArgumentException:
        //     path is a zero-length string, contains only white space, or contains one or more
        //     invalid characters. You can query for invalid characters with the System.IO.Path.GetInvalidPathChars
        //     method.
        //
        //   T:System.ArgumentNullException:
        //     path is null.
        //
        //   T:System.IO.PathTooLongException:
        //     The specified path, file name, or both exceed the system-defined maximum length.
        //
        //
        //   T:System.UnauthorizedAccessException:
        //     The caller does not have the required permission.
        //
        //   T:System.ArgumentOutOfRangeException:
        //     creationTime specifies a value outside the range of dates or times permitted
        //     for this operation.
        //
        //   T:System.PlatformNotSupportedException:
        //     The current operating system is not Windows NT or later.
        void SetCreationTimeUtc(string path, DateTime creationTimeUtc);
        //
        // Summary:
        //     Sets the application's current working directory to the specified directory.
        //
        //
        // Parameters:
        //   path:
        //     The path to which the current working directory is set.
        //
        // Exceptions:
        //   T:System.IO.IOException:
        //     An I/O error occurred.
        //
        //   T:System.ArgumentException:
        //     path is a zero-length string, contains only white space, or contains one or more
        //     invalid characters. You can query for invalid characters with the System.IO.Path.GetInvalidPathChars
        //     method.
        //
        //   T:System.ArgumentNullException:
        //     path is null.
        //
        //   T:System.IO.PathTooLongException:
        //     The specified path, file name, or both exceed the system-defined maximum length.
        //
        //
        //   T:System.Security.SecurityException:
        //     The caller does not have the required permission to access unmanaged code.
        //
        //   T:System.IO.FileNotFoundException:
        //     The specified path was not found.
        //
        //   T:System.IO.DirectoryNotFoundException:
        //     The specified directory was not found.
        void SetCurrentDirectory(string path);
        //
        // Summary:
        //     Sets the date and time the specified file or directory was last accessed.
        //
        // Parameters:
        //   path:
        //     The file or directory for which to set the access date and time information.
        //
        //
        //   lastAccessTime:
        //     An object that contains the value to set for the access date and time of path.
        //     This value is expressed in local time.
        //
        // Exceptions:
        //   T:System.IO.FileNotFoundException:
        //     The specified path was not found.
        //
        //   T:System.ArgumentException:
        //     path is a zero-length string, contains only white space, or contains one or more
        //     invalid characters. You can query for invalid characters with the System.IO.Path.GetInvalidPathChars
        //     method.
        //
        //   T:System.ArgumentNullException:
        //     path is null.
        //
        //   T:System.IO.PathTooLongException:
        //     The specified path, file name, or both exceed the system-defined maximum length.
        //
        //
        //   T:System.UnauthorizedAccessException:
        //     The caller does not have the required permission.
        //
        //   T:System.PlatformNotSupportedException:
        //     The current operating system is not Windows NT or later.
        //
        //   T:System.ArgumentOutOfRangeException:
        //     lastAccessTime specifies a value outside the range of dates or times permitted
        //     for this operation.
        void SetLastAccessTime(string path, DateTime lastAccessTime);
        //
        // Summary:
        //     Sets the date and time, in Coordinated Universal Time (UTC) format, that the
        //     specified file or directory was last accessed.
        //
        // Parameters:
        //   path:
        //     The file or directory for which to set the access date and time information.
        //
        //
        //   lastAccessTimeUtc:
        //     An object that contains the value to set for the access date and time of path.
        //     This value is expressed in UTC time.
        //
        // Exceptions:
        //   T:System.IO.FileNotFoundException:
        //     The specified path was not found.
        //
        //   T:System.ArgumentException:
        //     path is a zero-length string, contains only white space, or contains one or more
        //     invalid characters. You can query for invalid characters with the System.IO.Path.GetInvalidPathChars
        //     method.
        //
        //   T:System.ArgumentNullException:
        //     path is null.
        //
        //   T:System.IO.PathTooLongException:
        //     The specified path, file name, or both exceed the system-defined maximum length.
        //
        //
        //   T:System.UnauthorizedAccessException:
        //     The caller does not have the required permission.
        //
        //   T:System.PlatformNotSupportedException:
        //     The current operating system is not Windows NT or later.
        //
        //   T:System.ArgumentOutOfRangeException:
        //     lastAccessTimeUtc specifies a value outside the range of dates or times permitted
        //     for this operation.
        void SetLastAccessTimeUtc(string path, DateTime lastAccessTimeUtc);
        //
        // Summary:
        //     Sets the date and time a directory was last written to.
        //
        // Parameters:
        //   path:
        //     The path of the directory.
        //
        //   lastWriteTime:
        //     The date and time the directory was last written to. This value is expressed
        //     in local time.
        //
        // Exceptions:
        //   T:System.IO.FileNotFoundException:
        //     path was not found (for example, the directory doesn't exist or it is on an unmapped
        //     drive).
        //
        //   T:System.IO.DirectoryNotFoundException:
        //     path was not found (for example, the directory doesn't exist or it is on an unmapped
        //     drive).
        //
        //   T:System.ArgumentException:
        //     path is a zero-length string, contains only white space, or contains one or more
        //     invalid characters. You can query for invalid characters with the System.IO.Path.GetInvalidPathChars
        //     method.
        //
        //   T:System.ArgumentNullException:
        //     path is null.
        //
        //   T:System.IO.PathTooLongException:
        //     The specified path, file name, or both exceed the system-defined maximum length.
        //
        //
        //   T:System.UnauthorizedAccessException:
        //     The caller does not have the required permission.
        //
        //   T:System.PlatformNotSupportedException:
        //     The current operating system is not Windows NT or later.
        //
        //   T:System.ArgumentOutOfRangeException:
        //     lastWriteTime specifies a value outside the range of dates or times permitted
        //     for this operation.
        void SetLastWriteTime(string path, DateTime lastWriteTime);
        //
        // Summary:
        //     Sets the date and time, in Coordinated Universal Time (UTC) format, that a directory
        //     was last written to.
        //
        // Parameters:
        //   path:
        //     The path of the directory.
        //
        //   lastWriteTimeUtc:
        //     The date and time the directory was last written to. This value is expressed
        //     in UTC time.
        //
        // Exceptions:
        //   T:System.IO.FileNotFoundException:
        //     path was not found (for example, the directory doesn't exist or it is on an unmapped
        //     drive).
        //
        //   T:System.IO.DirectoryNotFoundException:
        //     path was not found (for example, the directory doesn't exist or it is on an unmapped
        //     drive).
        //
        //   T:System.ArgumentException:
        //     path is a zero-length string, contains only white space, or contains one or more
        //     invalid characters. You can query for invalid characters with the System.IO.Path.GetInvalidPathChars
        //     method.
        //
        //   T:System.ArgumentNullException:
        //     path is null.
        //
        //   T:System.IO.PathTooLongException:
        //     The specified path, file name, or both exceed the system-defined maximum length.
        //
        //
        //   T:System.UnauthorizedAccessException:
        //     The caller does not have the required permission.
        //
        //   T:System.PlatformNotSupportedException:
        //     The current operating system is not Windows NT or later.
        //
        //   T:System.ArgumentOutOfRangeException:
        //     lastWriteTimeUtc specifies a value outside the range of dates or times permitted
        //     for this operation.
        void SetLastWriteTimeUtc(string path, DateTime lastWriteTimeUtc);
    }
}
