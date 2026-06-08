namespace TheeScript;

public class Program
{
    public static void Main(string[] args)
    {
        if (args.Length < 1)
        {
            Console.WriteLine(@"

TheeScript
=========================================

A scripting language that exists mostly out of spite.

Usage:
  theescript run <file>
  theescript -v | --version

");
        } else
        {
            string command = args[0];

            switch (command)
            {
                case "--version":
                case "-v":
                    Console.WriteLine("Version 0.1.0");
                    break;

                case "run":
                    // RunFile(args[1]);
                    break;
            }
        }
    }
}