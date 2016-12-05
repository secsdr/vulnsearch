using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vulnsearch
{
    class FileCrawler
    {
        static List<String> Engine(String[] lines,List<String> commands)
        {
            List<String> Vars = new List<String>(); //Varname,Vartype,Varlength
            List<String> Defines = new List<String>();

            try
            {
                 foreach(String line in lines)
                {
                    foreach(String command in commands)
                    {
                        if(line.Contains(command))
                        {
                            return null;
                        }
                    }
                }
                return null;
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }
        static String[] ReadFile(String file)
        {
            try
            {
                String[] lines = File.ReadAllLines(file);
                return lines;
            }
            catch(Exception e)
            {
                Console.Write(e);
                return null;
            }
            
        }
        static List<String>[] FileSearch(string sDir)
        {
            //Return[0] -> Files    Return[1] -> Directories
            List<String>[] Return = new List<String>[2];
            List<String> Files = new List<string>();
            List<String> Directories = new List<string>();
            try
            {
                foreach (string d in Directory.GetDirectories(sDir))
                {
                    Directories.Add(d);
                    foreach (string f in Directory.GetFiles(d))
                    {
                        Files.Add(f);
                    }
                    FileSearch(d);
                }
                Return[0] = Files;
                Return[1] = Directories;
                return Return;
            }
                catch (System.Exception excpt)
                {
                Console.WriteLine(excpt.Message);
                return null;
            }
        }
    }
}
