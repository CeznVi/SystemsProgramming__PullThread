namespace SystemProgramming
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button_GetListProceses = new Button();
            label1 = new Label();
            Label_CountProcess = new Label();
            listBox_Processes = new ListBox();
            label2 = new Label();
            label_CountThreads = new Label();
            listBox_Threads = new ListBox();
            label3 = new Label();
            label_CountModules = new Label();
            listBox_Modules = new ListBox();
            panel1 = new Panel();
            button_StartProc = new Button();
            textBox_arguments = new TextBox();
            textBox_Path = new TextBox();
            button_OpenfileDialog = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button_GetListProceses
            // 
            button_GetListProceses.Location = new Point(596, 12);
            button_GetListProceses.Name = "button_GetListProceses";
            button_GetListProceses.Size = new Size(201, 23);
            button_GetListProceses.TabIndex = 0;
            button_GetListProceses.Text = "Получить список процесов";
            button_GetListProceses.UseVisualStyleBackColor = true;
            button_GetListProceses.Click += button_GetListProceses_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 12);
            label1.Name = "label1";
            label1.Size = new Size(207, 15);
            label1.TabIndex = 1;
            label1.Text = "Количество запущенных процессов";
            // 
            // Label_CountProcess
            // 
            Label_CountProcess.AutoSize = true;
            Label_CountProcess.BackColor = SystemColors.ControlLight;
            Label_CountProcess.ForeColor = Color.Red;
            Label_CountProcess.Location = new Point(222, 12);
            Label_CountProcess.Name = "Label_CountProcess";
            Label_CountProcess.Size = new Size(13, 15);
            Label_CountProcess.TabIndex = 2;
            Label_CountProcess.Text = "0";
            // 
            // listBox_Processes
            // 
            listBox_Processes.FormattingEnabled = true;
            listBox_Processes.ItemHeight = 15;
            listBox_Processes.Location = new Point(9, 30);
            listBox_Processes.Name = "listBox_Processes";
            listBox_Processes.Size = new Size(483, 409);
            listBox_Processes.TabIndex = 3;
            listBox_Processes.SelectedIndexChanged += listBox_Processes_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(498, 53);
            label2.Name = "label2";
            label2.Size = new Size(236, 15);
            label2.TabIndex = 4;
            label2.Text = "Количество потоков вібраного процесса:";
            // 
            // label_CountThreads
            // 
            label_CountThreads.AutoSize = true;
            label_CountThreads.ForeColor = Color.Red;
            label_CountThreads.Location = new Point(751, 53);
            label_CountThreads.Name = "label_CountThreads";
            label_CountThreads.Size = new Size(13, 15);
            label_CountThreads.TabIndex = 5;
            label_CountThreads.Text = "0";
            // 
            // listBox_Threads
            // 
            listBox_Threads.FormattingEnabled = true;
            listBox_Threads.ItemHeight = 15;
            listBox_Threads.Location = new Point(498, 76);
            listBox_Threads.Name = "listBox_Threads";
            listBox_Threads.Size = new Size(315, 184);
            listBox_Threads.TabIndex = 6;
            listBox_Threads.SelectedIndexChanged += listBox_Threads_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(498, 263);
            label3.Name = "label3";
            label3.Size = new Size(289, 15);
            label3.TabIndex = 7;
            label3.Text = "Количество модулей сборки вібранного процесса:";
            label3.Click += label3_Click;
            // 
            // label_CountModules
            // 
            label_CountModules.AutoSize = true;
            label_CountModules.ForeColor = Color.Red;
            label_CountModules.Location = new Point(793, 263);
            label_CountModules.Name = "label_CountModules";
            label_CountModules.Size = new Size(13, 15);
            label_CountModules.TabIndex = 8;
            label_CountModules.Text = "0";
            // 
            // listBox_Modules
            // 
            listBox_Modules.FormattingEnabled = true;
            listBox_Modules.ItemHeight = 15;
            listBox_Modules.Location = new Point(498, 284);
            listBox_Modules.Name = "listBox_Modules";
            listBox_Modules.Size = new Size(309, 154);
            listBox_Modules.TabIndex = 9;
            // 
            // panel1
            // 
            panel1.Controls.Add(button_OpenfileDialog);
            panel1.Controls.Add(button_StartProc);
            panel1.Controls.Add(textBox_arguments);
            panel1.Controls.Add(textBox_Path);
            panel1.Location = new Point(9, 458);
            panel1.Name = "panel1";
            panel1.Size = new Size(798, 84);
            panel1.TabIndex = 10;
            // 
            // button_StartProc
            // 
            button_StartProc.Dock = DockStyle.Right;
            button_StartProc.Location = new Point(712, 0);
            button_StartProc.Name = "button_StartProc";
            button_StartProc.Size = new Size(86, 84);
            button_StartProc.TabIndex = 2;
            button_StartProc.Text = "Start";
            button_StartProc.UseVisualStyleBackColor = true;
            button_StartProc.Click += button_StartProc_Click;
            // 
            // textBox_arguments
            // 
            textBox_arguments.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_arguments.Location = new Point(3, 47);
            textBox_arguments.Name = "textBox_arguments";
            textBox_arguments.Size = new Size(601, 29);
            textBox_arguments.TabIndex = 1;
            // 
            // textBox_Path
            // 
            textBox_Path.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_Path.Location = new Point(0, 12);
            textBox_Path.Name = "textBox_Path";
            textBox_Path.Size = new Size(648, 29);
            textBox_Path.TabIndex = 0;
            // 
            // button_OpenfileDialog
            // 
            button_OpenfileDialog.Location = new Point(622, 51);
            button_OpenfileDialog.Name = "button_OpenfileDialog";
            button_OpenfileDialog.Size = new Size(75, 23);
            button_OpenfileDialog.TabIndex = 3;
            button_OpenfileDialog.Text = "+";
            button_OpenfileDialog.UseVisualStyleBackColor = true;
            button_OpenfileDialog.Click += button_OpenfileDialog_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(825, 613);
            Controls.Add(panel1);
            Controls.Add(listBox_Modules);
            Controls.Add(label_CountModules);
            Controls.Add(label3);
            Controls.Add(listBox_Threads);
            Controls.Add(label_CountThreads);
            Controls.Add(label2);
            Controls.Add(listBox_Processes);
            Controls.Add(Label_CountProcess);
            Controls.Add(label1);
            Controls.Add(button_GetListProceses);
            Name = "MainForm";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_GetListProceses;
        private Label label1;
        private Label Label_CountProcess;
        private ListBox listBox_Processes;
        private Label label2;
        private Label label_CountThreads;
        private ListBox listBox_Threads;
        private Label label3;
        private Label label_CountModules;
        private ListBox listBox_Modules;
        private Panel panel1;
        private Button button_StartProc;
        private TextBox textBox_arguments;
        private TextBox textBox_Path;
        private Button button_OpenfileDialog;
    }
}