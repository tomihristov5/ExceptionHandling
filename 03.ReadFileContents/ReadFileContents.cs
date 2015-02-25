// Problem 3. Read file contents
// Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console.
// Find in MSDN how to use System.IO.File.ReadAllText(…).
// Be sure to catch all possible exceptions and print user-friendly error messages

using System;
using System.IO;
using System.Security;

namespace _03.ReadFileContents
{
    class ReadFileContents
    {
        static void Main()
        {
            try
            {
                Console.Write("Enter file's full path: ");
                string input = Console.ReadLine();
                string file = File.ReadAllText(input);
                Console.WriteLine(file);
            }
            catch (FormatException)
            {
                Console.WriteLine("File's path is invalid!");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("File's directory not found!");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The file cannot be found!");
            }
            catch (FileLoadException)
            {
                Console.WriteLine("The file couldn't load!");
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("The file's path is too long - 248 characters are the maximum!");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("No file path is given!");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("The entered file path is not correct!");
            }
            catch (SecurityException)
            {
                Console.WriteLine("No autority or required permission to access this file!");
            }
            catch (UnauthorizedAccessException uoae)
            {
                Console.WriteLine(uoae.Message);
            }
            catch (IOException ioe)
            {
                Console.WriteLine(ioe.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
