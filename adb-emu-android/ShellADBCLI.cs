using System;

using System.IO;
using System.Text;
using CliWrap;
using System.Diagnostics;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace adb_emu_android
{
    class ShellADBCLI
    {
        private String pathFileAdb;

        private ShellADBCLI()
        {

        }

        public ShellADBCLI(string pathFileAdb)
        {
            this.pathFileAdb = pathFileAdb;
            
            CheckFile();
        }

        private void CheckFile() 
        {
            if ( !(File.Exists(this.pathFileAdb)))
            {
                throw new FileNotFoundException("Check Path File "+ this.pathFileAdb);
            }
        }

        public async Task<string[]> GetListOfIp()
        {
            string[] commandparameter = new string[] { "devices" };
            StringBuilder stdOutBuffer = new StringBuilder();
            
            await Cli.Wrap(this.pathFileAdb)
             .WithArguments(commandparameter)
             .WithStandardOutputPipe(PipeTarget.ToStringBuilder(stdOutBuffer))
             .ExecuteAsync();

           return FilterIp(stdOutBuffer.ToString());

        }

        private string[] FilterIp(string word)
        {
            List<string> result = new List<string>();
            Regex pattern = new Regex(@"\b\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}:\d{1,5}\b");

            if (!String.IsNullOrEmpty(word.ToString()))
            {
                string[] lines = word.Split(new string[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
                int size = lines.Length;
              
                for (int i = 0; i < size; i++)
                {
                    MatchCollection m = pattern.Matches(lines[i]);
                    Debug.WriteLine(lines[i]);
                    
                    if (m.Count > 0)
                    {
                        result.Add(m[0].Value);
                    }
                }
            }
            return result.ToArray(); 
        }


        public async void Click( string device ,int x,int y)
        {
            if (!String.IsNullOrEmpty(device))
            {
                string commandparameter = "-s" + " " + device + " " + "shell input tap" + " " + x + " " + y;

                await Cli.Wrap(this.pathFileAdb)
                .WithArguments(commandparameter)
                .ExecuteAsync();
            }
             
        }
      


    }
}
