using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Threading;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SERV_tema1_ej2
{
    public partial class Form1 : Form
    {
        Process process;
        Process[] processes;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            string name;
            string windowTitle;
            textBox1.Text = "";
            processes = Process.GetProcesses();

            foreach (Process p in processes)
            {
                name = stringCropper(p.ProcessName);
                windowTitle = stringCropper(p.MainWindowTitle);
                textBox1.AppendText($"PID: {p.Id}, ProcessName: {name}, WindowTitle: {windowTitle} {Environment.NewLine}");
            }
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";

            try
            {
                getPID(int.Parse(textBox2.Text));
                if (process != null)
                {
                    ProcessModuleCollection modules = process.Modules;
                    ProcessThreadCollection threads = process.Threads;

                    textBox1.AppendText($"PID: {process.Id}, ProcessName: {process.ProcessName}, WindowTitle: {process.MainWindowTitle} {Environment.NewLine}");

                    foreach (ProcessThread pt in threads)
                    {
                        textBox1.AppendText($"Thread ID: {pt.Id}, StartTime: {pt.StartTime.ToShortTimeString()}, PriorityLevel: {pt.PriorityLevel}, ThreadState: {pt.ThreadState} {Environment.NewLine}");
                    }

                    foreach (ProcessModule pm in modules)
                    {
                        textBox1.AppendText($"{pm.ModuleName} ");
                    }
                }
            }
            catch (Win32Exception)
            {

            }
            catch (FormatException)
            {
                label1.Text = "(!) Programa no encontrado";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                getPID(int.Parse(textBox2.Text));

                if (process != null)
                {
                    process.CloseMainWindow();
                }
            } catch (FormatException)
            {
                label1.Text = "(!) Programa no encontrado";
            }
        }

        private void btnKill_Click(object sender, EventArgs e)
        {

            try
            {
                getPID(int.Parse(textBox2.Text));

                if (process != null)
                {
                    process.Kill();
                }
            } catch (FormatException)
            {
                label1.Text = "(!) Programa no encontrado";
            }
        }

        private void btnRunApp_Click(object sender, EventArgs e)
        {
            string programa = "";
            if (!String.IsNullOrEmpty(textBox2.Text))
            {
                programa = textBox2.Text;

                try
                {
                    process = Process.Start(programa);
                }
                catch (ArgumentException)
                {
                    label1.Text = "(!) Programa no encontrado";
                }
                catch (Win32Exception)
                {
                    label1.Text = "(!) Programa no encontrado";
                }
            } else
            {
                programa = "";
                label1.Text = "(!) Programa no encontrado";
            }
        }

        private void btnStartsWith_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            List<Process> prcs = new List<Process>();
            processes = Process.GetProcesses();

            foreach (Process p in processes)
            {
                if (p.ProcessName.StartsWith(textBox2.Text))
                {
                    prcs.Add(p);
                }
            }

            prcs.ForEach(process => textBox1.AppendText($"PID: {process.Id}, ProcessName: {process.ProcessName}, WindowTitle: {process.MainWindowTitle} {Environment.NewLine}"));
        }

        public void getPID(int pid)
        {
            try
            {
                process = Process.GetProcessById(pid);
            }
            catch (ArgumentException)
            {
                label1.Text = "(!) Programa no encontrado";
            }
            catch (Win32Exception)
            {
                label1.Text = "(!) Programa no encontrado";
            }
        }

        public string stringCropper(string titulo)
        {
            if (!string.IsNullOrEmpty(titulo) && titulo.Length > 12)
            {
                return titulo.Substring(0, 12) + "...";
            }

            return titulo;
        }
    }
}