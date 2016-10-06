using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
// Fake cmd by xTylerCodes.
// I suggest using JustinOBoyle's RunHijacker to overwrite the original cmd.
// I do not take any responsibility when using this program, and it was designed to run in a disposable VM.
namespace Command_Prompt
{
    public partial class Form1 : Form
    {
        public string currDirectory = "C:\\Users\\PC";
        public string currText = "Microsoft Windows[Version 10.0.10586]\n(c)2015 Microsoft Corporation. All rights reserved.\n\nC:\\Users\\PC>";
        public Form1()
        {
            this.KeyPreview = true;
            InitializeComponent();
        }

        public void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        public string cmd;
        private async void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                richTextBox1.Select(0, richTextBox1.Text.Length);
                richTextBox1.SelectionProtected = false;
                richTextBox1.DeselectAll();
                cmd = richTextBox1.Text.Replace(currText, "");
                // Command switch is here. What you put in the case quotes will be the command.
                switch (cmd)
                {
                    case "tree":
                        richTextBox1.Text += "\nPlease Wait...";
                        await Task.Delay(3000);
                        richTextBox1.Text += "\n                                                 .\r\n                                      .         ;  \r\n         .              .              ;%     ;;   \r\n           ,           ,                :;%  %;   \r\n            :         ;                   :;%;\'     .,   \r\n   ,.        %;     %;            ;        %;\'    ,;\r\n     ;       ;%;  %%;        ,     %;    ;%;    ,%\'\r\n      %;       %;%;      ,  ;       %;  ;%;   ,%;\' \r\n       ;%;      %;        ;%;        % ;%;  ,%;\'\r\n        `%;.     ;%;     %;\'         `;%%;.%;\'\r\n         `:;%.    ;%%. %@;        %; ;@%;%\'\r\n            `:%;.  :;bd%;          %;@%;\'\r\n              `@%:.  :;%.         ;@@%;\'   \r\n                `@%.  `;@%.      ;@@%;         \r\n                  `@%%. `@%%    ;@@%;        \r\n                    ;@%. :@%%  %@@%;       \r\n                      %@bd%%%bd%%:;     \r\n                        #@%%%%%:;;\r\n                        %@@%%%::;\r\n                        %@@@%(o);  . \'         \r\n                        %@@@o%;:(.,\'         \r\n                    `.. %@@@o%::;         \r\n                       `)@@@o%::;         \r\n                        %@@(o)::;        \r\n                       .%@@@@%::;         \r\n                       ;%@@@@%::;.          \r\n                      ;%@@@@%%:;;;. \r\n                  ...;%@@@@@%%:;;;;,..\n\nLook!  It's your tree!";
                        break;
                    case "netstat":
                        richTextBox1.Text += "\nNETWORK VIRUS FOUND... STARTING REMOVAL PROCESS";
                        await Task.Delay(500);
                        richTextBox1.Text += "\nProccessing errors...";
                        await Task.Delay(750);
                        richTextBox1.Text += "\nRemoving files...";
                        await Task.Delay(1200);
                        richTextBox1.Text += "\nCleaning up...";
                        for (int i = 0; i < 100; i++)
                        {
                            Random rnd = new Random();
                            await Task.Delay(rnd.Next(50, 200));
                            richTextBox1.Text += ".";
                        }
                        await Task.Delay(1000);
                        richTextBox1.Text += "\n";
                        string problem = "It has been determined that the technician is the problem, not the computer.";
                        for (int i = 0; i < problem.Length; i++)
                        {
                            await Task.Delay(50);
                            richTextBox1.Text += problem[i];
                        }
                        break;
                    case "dir /s":
                        for(int i = 0; i < 1000; i++)
                        {
                            Random rnd = new Random();
                            await Task.Delay(10);
                            richTextBox1.Text += "\n" + DateTime.Today + "    " + "YOU ARE AN IDIOT " + rnd.Next(0, 10000000);
                            richTextBox1.SelectionStart = richTextBox1.Text.Length; // add some logic if length is 0
                            richTextBox1.SelectionLength = 0;
                        }
                        break;
                    case "cd ../":
                        currDirectory = "C:\\";
                        break;
                    case "clear":
                        richTextBox1.Text = "";
                        break;
                    default:
                        richTextBox1.Text += "\n\"" + cmd + "\" was not recognized as an internal or external command, operable program or batch file.";
                        break;
                }
                richTextBox1.Text += "\n" + currDirectory + ">";
                currText = richTextBox1.Text;
                richTextBox1.Select(0, richTextBox1.Text.Length);
                richTextBox1.SelectionProtected = true;
                richTextBox1.DeselectAll();
                richTextBox1.SelectionStart = richTextBox1.Text.Length; // add some logic if length is 0
                richTextBox1.SelectionLength = 0;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = currText;
            richTextBox1.Select(0, richTextBox1.Text.Length);
            richTextBox1.SelectionProtected = true;
            richTextBox1.DeselectAll();
            richTextBox1.SelectionStart = richTextBox1.Text.Length; // add some logic if length is 0
            richTextBox1.SelectionLength = 0;
        }
    }
}
