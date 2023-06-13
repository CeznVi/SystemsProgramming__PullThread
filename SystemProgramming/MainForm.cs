using System.Diagnostics;

namespace SystemProgramming
{
    public partial class MainForm : Form
    {
        private Process[] _processes;


        public MainForm()
        {
            InitializeComponent();
        }

        private void button_GetListProceses_Click(object sender, EventArgs e)
        {
            _processes = Process.GetProcesses();
            Label_CountProcess.Text = _processes.Length.ToString();

            listBox_Processes.Items.Clear();

            foreach (Process process in _processes)
            {
                listBox_Processes.Items.Add($"Id - {process.Id}; Name -  {process.ProcessName};");

            }
        }

        private void listBox_Processes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                listBox_Threads.Items.Clear();
                Process selectedProcess = _processes[listBox_Processes.SelectedIndex];

                label_CountThreads.Text = selectedProcess.Threads.Count.ToString();


                foreach (ProcessThread item in selectedProcess.Threads)
                {
                    listBox_Threads.Items.Add($"Id - {item.Id}, Priority - {item.CurrentPriority}");
                }

                listBox_Modules.Items.Clear();

                label_CountModules.Text = selectedProcess.Modules.Count.ToString();

                foreach (ProcessModule oneModule in selectedProcess.Modules)
                {
                    listBox_Modules.Items.Add($"{oneModule.ModuleName}");
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listBox_Threads_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button_StartProc_Click(object sender, EventArgs e)
        {
            if (!File.Exists(textBox_Path.Text))
            {
                MessageBox.Show("”казан≥й файл не сущенствует", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Process.Start(textBox_commands.Text);

            ProcessStartInfo processStartInfo = new ProcessStartInfo();

            processStartInfo.FileName = textBox_Path.Text;

            ///for start non execute files
            processStartInfo.UseShellExecute = true;

            processStartInfo.Arguments = textBox_arguments.Text;

            Process.Start(processStartInfo);



        }

        private void button_OpenfileDialog_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "EXE Files|*.exe;";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ProcessStartInfo processStartInfo = new ProcessStartInfo();

                processStartInfo.FileName = openFileDialog.FileName;
                textBox_Path.Text = openFileDialog.FileName;

                ///for start non execute files
                processStartInfo.UseShellExecute = true;

                processStartInfo.Arguments = textBox_arguments.Text;

                Process.Start(processStartInfo);
            }
        }
    }
}