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
            this.userManager = new EnterpriseTraining.ItemManagement.ItemListManager();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.trainingManager = new EnterpriseTraining.ItemManagement.ItemListManager();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.certificateManager = new EnterpriseTraining.ItemManagement.ItemListManager();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(528, 392);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.userManager);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(520, 363);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Users";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.userManager.Size = new System.Drawing.Size(514, 357);
            this.userManager.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.trainingManager);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(520, 363);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Trainings";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.trainingManager.Size = new System.Drawing.Size(514, 357);
            this.trainingManager.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.certificateManager);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(520, 363);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Certificates";
            this.tabPage3.UseVisualStyleBackColor = true;
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
            this.certificateManager.Size = new System.Drawing.Size(514, 357);
            this.certificateManager.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 392);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enterprise Training";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
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
    }
}

