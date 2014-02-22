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
            EnterpriseTraining.ItemManagement.NullItemEditor nullItemEditor1 = new EnterpriseTraining.ItemManagement.NullItemEditor();
            EnterpriseTraining.ItemManagement.NullItemFactory nullItemFactory1 = new EnterpriseTraining.ItemManagement.NullItemFactory();
            EnterpriseTraining.ItemManagement.NullItemRemover nullItemRemover1 = new EnterpriseTraining.ItemManagement.NullItemRemover();
            EnterpriseTraining.ItemManagement.NullItemSaver nullItemSaver1 = new EnterpriseTraining.ItemManagement.NullItemSaver();
            EnterpriseTraining.ItemManagement.NullItemEditor nullItemEditor2 = new EnterpriseTraining.ItemManagement.NullItemEditor();
            EnterpriseTraining.ItemManagement.NullItemFactory nullItemFactory2 = new EnterpriseTraining.ItemManagement.NullItemFactory();
            EnterpriseTraining.ItemManagement.NullItemRemover nullItemRemover2 = new EnterpriseTraining.ItemManagement.NullItemRemover();
            EnterpriseTraining.ItemManagement.NullItemSaver nullItemSaver2 = new EnterpriseTraining.ItemManagement.NullItemSaver();
            EnterpriseTraining.ItemManagement.NullItemEditor nullItemEditor3 = new EnterpriseTraining.ItemManagement.NullItemEditor();
            EnterpriseTraining.ItemManagement.NullItemFactory nullItemFactory3 = new EnterpriseTraining.ItemManagement.NullItemFactory();
            EnterpriseTraining.ItemManagement.NullItemRemover nullItemRemover3 = new EnterpriseTraining.ItemManagement.NullItemRemover();
            EnterpriseTraining.ItemManagement.NullItemSaver nullItemSaver3 = new EnterpriseTraining.ItemManagement.NullItemSaver();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
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
            this.userManager = new EnterpriseTraining.ItemManagement.ItemListManager();
            this.trainingManager = new EnterpriseTraining.ItemManagement.ItemListManager();
            this.certificateManager = new EnterpriseTraining.ItemManagement.ItemListManager();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(532, 405);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.userManager);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(524, 376);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Users";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.trainingManager);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(524, 376);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Trainings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.certificateManager);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(524, 376);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Certificates";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox2);
            this.tabPage4.Controls.Add(this.groupBox1);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(524, 376);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Report";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.printButton);
            this.groupBox2.Location = new System.Drawing.Point(18, 21);
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
            this.groupBox1.Location = new System.Drawing.Point(18, 123);
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
            this.tabPage5.Size = new System.Drawing.Size(524, 376);
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
            // userManager
            // 
            this.userManager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userManager.ItemEditor = nullItemEditor1;
            this.userManager.ItemFactory = nullItemFactory1;
            this.userManager.ItemRemover = nullItemRemover1;
            this.userManager.ItemSaver = nullItemSaver1;
            this.userManager.Location = new System.Drawing.Point(3, 3);
            this.userManager.Name = "userManager";
            this.userManager.Size = new System.Drawing.Size(518, 370);
            this.userManager.TabIndex = 0;
            // 
            // trainingManager
            // 
            this.trainingManager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trainingManager.ItemEditor = nullItemEditor2;
            this.trainingManager.ItemFactory = nullItemFactory2;
            this.trainingManager.ItemRemover = nullItemRemover2;
            this.trainingManager.ItemSaver = nullItemSaver2;
            this.trainingManager.Location = new System.Drawing.Point(3, 3);
            this.trainingManager.Name = "trainingManager";
            this.trainingManager.Size = new System.Drawing.Size(518, 370);
            this.trainingManager.TabIndex = 0;
            // 
            // certificateManager
            // 
            this.certificateManager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.certificateManager.ItemEditor = nullItemEditor3;
            this.certificateManager.ItemFactory = nullItemFactory3;
            this.certificateManager.ItemRemover = nullItemRemover3;
            this.certificateManager.ItemSaver = nullItemSaver3;
            this.certificateManager.Location = new System.Drawing.Point(3, 3);
            this.certificateManager.Name = "certificateManager";
            this.certificateManager.Size = new System.Drawing.Size(518, 370);
            this.certificateManager.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 405);
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
    }
}

