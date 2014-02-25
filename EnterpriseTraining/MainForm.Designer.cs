namespace EnterpriseTraining
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            EnterpriseTraining.ItemManagement.NullItemEditor nullItemEditor19 = new EnterpriseTraining.ItemManagement.NullItemEditor();
            EnterpriseTraining.ItemManagement.NullItemFactory nullItemFactory19 = new EnterpriseTraining.ItemManagement.NullItemFactory();
            EnterpriseTraining.ItemManagement.NullItemRemover nullItemRemover19 = new EnterpriseTraining.ItemManagement.NullItemRemover();
            EnterpriseTraining.ItemManagement.NullItemSaver nullItemSaver19 = new EnterpriseTraining.ItemManagement.NullItemSaver();
            EnterpriseTraining.ItemManagement.NullItemEditor nullItemEditor20 = new EnterpriseTraining.ItemManagement.NullItemEditor();
            EnterpriseTraining.ItemManagement.NullItemFactory nullItemFactory20 = new EnterpriseTraining.ItemManagement.NullItemFactory();
            EnterpriseTraining.ItemManagement.NullItemRemover nullItemRemover20 = new EnterpriseTraining.ItemManagement.NullItemRemover();
            EnterpriseTraining.ItemManagement.NullItemSaver nullItemSaver20 = new EnterpriseTraining.ItemManagement.NullItemSaver();
            EnterpriseTraining.ItemManagement.NullItemEditor nullItemEditor21 = new EnterpriseTraining.ItemManagement.NullItemEditor();
            EnterpriseTraining.ItemManagement.NullItemFactory nullItemFactory21 = new EnterpriseTraining.ItemManagement.NullItemFactory();
            EnterpriseTraining.ItemManagement.NullItemRemover nullItemRemover21 = new EnterpriseTraining.ItemManagement.NullItemRemover();
            EnterpriseTraining.ItemManagement.NullItemSaver nullItemSaver21 = new EnterpriseTraining.ItemManagement.NullItemSaver();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.userManager = new EnterpriseTraining.ItemManagement.ItemListManager();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.trainingManager = new EnterpriseTraining.ItemManagement.ItemListManager();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.certificateManager = new EnterpriseTraining.ItemManagement.ItemListManager();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.queryButton7 = new System.Windows.Forms.Button();
            this.queryButton6 = new System.Windows.Forms.Button();
            this.queryButton5 = new System.Windows.Forms.Button();
            this.queryButton4 = new System.Windows.Forms.Button();
            this.queryButton3 = new System.Windows.Forms.Button();
            this.queryButton2 = new System.Windows.Forms.Button();
            this.queryButton1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.printButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.printToFileButton = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(688, 606);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.userManager);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(673, 626);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Users";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // userManager
            // 
            this.userManager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userManager.ItemEditor = nullItemEditor19;
            this.userManager.ItemFactory = nullItemFactory19;
            this.userManager.ItemRemover = nullItemRemover19;
            this.userManager.ItemSaver = nullItemSaver19;
            this.userManager.Location = new System.Drawing.Point(3, 3);
            this.userManager.Name = "userManager";
            this.userManager.Size = new System.Drawing.Size(667, 620);
            this.userManager.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.trainingManager);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(673, 626);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Trainings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // trainingManager
            // 
            this.trainingManager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trainingManager.ItemEditor = nullItemEditor20;
            this.trainingManager.ItemFactory = nullItemFactory20;
            this.trainingManager.ItemRemover = nullItemRemover20;
            this.trainingManager.ItemSaver = nullItemSaver20;
            this.trainingManager.Location = new System.Drawing.Point(3, 3);
            this.trainingManager.Name = "trainingManager";
            this.trainingManager.Size = new System.Drawing.Size(667, 620);
            this.trainingManager.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.certificateManager);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(673, 626);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Certificates";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // certificateManager
            // 
            this.certificateManager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.certificateManager.ItemEditor = nullItemEditor21;
            this.certificateManager.ItemFactory = nullItemFactory21;
            this.certificateManager.ItemRemover = nullItemRemover21;
            this.certificateManager.ItemSaver = nullItemSaver21;
            this.certificateManager.Location = new System.Drawing.Point(3, 3);
            this.certificateManager.Name = "certificateManager";
            this.certificateManager.Size = new System.Drawing.Size(667, 620);
            this.certificateManager.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox3);
            this.tabPage4.Controls.Add(this.groupBox2);
            this.tabPage4.Controls.Add(this.groupBox1);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(680, 577);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Report";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.queryButton7);
            this.groupBox3.Controls.Add(this.queryButton6);
            this.groupBox3.Controls.Add(this.queryButton5);
            this.groupBox3.Controls.Add(this.queryButton4);
            this.groupBox3.Controls.Add(this.queryButton3);
            this.groupBox3.Controls.Add(this.queryButton2);
            this.groupBox3.Controls.Add(this.queryButton1);
            this.groupBox3.Location = new System.Drawing.Point(8, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(419, 299);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Queries";
            // 
            // queryButton7
            // 
            this.queryButton7.Location = new System.Drawing.Point(6, 253);
            this.queryButton7.Name = "queryButton7";
            this.queryButton7.Size = new System.Drawing.Size(407, 31);
            this.queryButton7.TabIndex = 6;
            this.queryButton7.Text = "Users which are trainers AND trainees";
            this.queryButton7.UseVisualStyleBackColor = true;
            this.queryButton7.Click += new System.EventHandler(this.queryButton7_Click);
            // 
            // queryButton6
            // 
            this.queryButton6.Location = new System.Drawing.Point(6, 216);
            this.queryButton6.Name = "queryButton6";
            this.queryButton6.Size = new System.Drawing.Size(407, 31);
            this.queryButton6.TabIndex = 5;
            this.queryButton6.Text = "All trainers";
            this.queryButton6.UseVisualStyleBackColor = true;
            this.queryButton6.Click += new System.EventHandler(this.queryButton6_Click);
            // 
            // queryButton5
            // 
            this.queryButton5.Location = new System.Drawing.Point(6, 179);
            this.queryButton5.Name = "queryButton5";
            this.queryButton5.Size = new System.Drawing.Size(407, 31);
            this.queryButton5.TabIndex = 4;
            this.queryButton5.Text = "All trainees";
            this.queryButton5.UseVisualStyleBackColor = true;
            this.queryButton5.Click += new System.EventHandler(this.queryButton5_Click);
            // 
            // queryButton4
            // 
            this.queryButton4.Location = new System.Drawing.Point(6, 142);
            this.queryButton4.Name = "queryButton4";
            this.queryButton4.Size = new System.Drawing.Size(407, 31);
            this.queryButton4.TabIndex = 3;
            this.queryButton4.Text = "Available certificates";
            this.queryButton4.UseVisualStyleBackColor = true;
            this.queryButton4.Click += new System.EventHandler(this.queryButton4_Click);
            // 
            // queryButton3
            // 
            this.queryButton3.Location = new System.Drawing.Point(6, 105);
            this.queryButton3.Name = "queryButton3";
            this.queryButton3.Size = new System.Drawing.Size(407, 31);
            this.queryButton3.TabIndex = 2;
            this.queryButton3.Text = "Trainings by cost";
            this.queryButton3.UseVisualStyleBackColor = true;
            this.queryButton3.Click += new System.EventHandler(this.queryButton3_Click);
            // 
            // queryButton2
            // 
            this.queryButton2.Location = new System.Drawing.Point(6, 68);
            this.queryButton2.Name = "queryButton2";
            this.queryButton2.Size = new System.Drawing.Size(407, 31);
            this.queryButton2.TabIndex = 1;
            this.queryButton2.Text = "Top 5 most active trainees (with at least 3 trainings)";
            this.queryButton2.UseVisualStyleBackColor = true;
            this.queryButton2.Click += new System.EventHandler(this.queryButton2_Click);
            // 
            // queryButton1
            // 
            this.queryButton1.Location = new System.Drawing.Point(6, 31);
            this.queryButton1.Name = "queryButton1";
            this.queryButton1.Size = new System.Drawing.Size(407, 31);
            this.queryButton1.TabIndex = 0;
            this.queryButton1.Text = "Top 5 users with highest number of certifices";
            this.queryButton1.UseVisualStyleBackColor = true;
            this.queryButton1.Click += new System.EventHandler(this.queryButton1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.printButton);
            this.groupBox2.Location = new System.Drawing.Point(8, 311);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(419, 96);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Printing";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "You will be asked to select printer";
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(138, 21);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(140, 44);
            this.printButton.TabIndex = 5;
            this.printButton.Text = "Print...";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.printToFileButton);
            this.groupBox1.Location = new System.Drawing.Point(8, 413);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(419, 102);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Printing to file";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(258, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "You will be asked to choose file location";
            // 
            // printToFileButton
            // 
            this.printToFileButton.Location = new System.Drawing.Point(138, 31);
            this.printToFileButton.Name = "printToFileButton";
            this.printToFileButton.Size = new System.Drawing.Size(140, 44);
            this.printToFileButton.TabIndex = 1;
            this.printToFileButton.Text = "Print to file...";
            this.printToFileButton.UseVisualStyleBackColor = true;
            this.printToFileButton.Click += new System.EventHandler(this.printToFileButton_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label2);
            this.tabPage5.Controls.Add(this.label1);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(673, 626);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "About";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sekcja: Karol Medwecki, Krzysztof Chadynka";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Projekt zrealizowany na potrzeby przedmiotu Bazy Danych";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "txt";
            this.saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All files|*.*";
            // 
            // printDialog
            // 
            this.printDialog.Document = this.printDocument;
            this.printDialog.UseEXDialog = true;
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 606);
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(550, 450);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enterprise Training";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private ItemManagement.ItemListManager userManager;
        private System.Windows.Forms.TabPage tabPage2;
        private ItemManagement.ItemListManager trainingManager;
        private System.Windows.Forms.TabPage tabPage3;
        private ItemManagement.ItemListManager certificateManager;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button printToFileButton;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button queryButton3;
        private System.Windows.Forms.Button queryButton2;
        private System.Windows.Forms.Button queryButton1;
        private System.Windows.Forms.Button queryButton7;
        private System.Windows.Forms.Button queryButton6;
        private System.Windows.Forms.Button queryButton5;
        private System.Windows.Forms.Button queryButton4;
    }
}

