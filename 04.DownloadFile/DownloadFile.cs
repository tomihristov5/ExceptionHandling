// Problem 4. Download file
// Write a program that downloads a file from Internet (e.g. Ninja image) and stores it the current directory.
// Find in Google how to download files in C#.
// Be sure to catch all exceptions and to free any used resources in the finally block.

using System;
using System.Net;

namespace _04.DownloadFile
{
    class DownloadFile
    {
        static void Main()
        {
            using (WebClient webClient = new WebClient())
            {
                try
                {
                    Console.WriteLine("Enter the file's full path: ");
                    string url = Console.ReadLine();
                    string[] filePath = url.Split('/');
                    string fileName = filePath[filePath.Length - 1];
                    webClient.DownloadFile(url, @"../../" + fileName);
                }

                catch (WebException)
                {
                    Console.Error.WriteLine("The address is invalid.");
                }

                catch (NotSupportedException ex)
                {
                    Console.Error.WriteLine(ex.Message);
                }
            }
        }
    }
}
