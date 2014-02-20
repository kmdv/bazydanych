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
            EnterpriseTraining.ListManagement.NullListItemEditor nullListItemEditor1 = new EnterpriseTraining.ListManagement.NullListItemEditor();
            EnterpriseTraining.ListManagement.NullListItemFactory nullListItemFactory1 = new EnterpriseTraining.ListManagement.NullListItemFactory();
            EnterpriseTraining.ListManagement.NullListItemRemover nullListItemRemover1 = new EnterpriseTraining.ListManagement.NullListItemRemover();
            EnterpriseTraining.ListManagement.NullListItemSaver nullListItemSaver1 = new EnterpriseTraining.ListManagement.NullListItemSaver();
            EnterpriseTraining.ListManagement.NullListItemEditor nullListItemEditor2 = new EnterpriseTraining.ListManagement.NullListItemEditor();
            EnterpriseTraining.ListManagement.NullListItemFactory nullListItemFactory2 = new EnterpriseTraining.ListManagement.NullListItemFactory();
            EnterpriseTraining.ListManagement.NullListItemRemover nullListItemRemover2 = new EnterpriseTraining.ListManagement.NullListItemRemover();
            EnterpriseTraining.ListManagement.NullListItemSaver nullListItemSaver2 = new EnterpriseTraining.ListManagement.NullListItemSaver();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.userManager = new EnterpriseTraining.ListManagement.ListManager();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.trainingManager = new EnterpriseTraining.ListManagement.ListManager();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
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
            this.userManager.ItemEditor = nullListItemEditor1;
            this.userManager.ItemFactory = nullListItemFactory1;
            this.userManager.ItemRemover = nullListItemRemover1;
            this.userManager.ItemSaver = nullListItemSaver1;
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
            this.trainingManager.ItemEditor = nullListItemEditor2;
            this.trainingManager.ItemFactory = nullListItemFactory2;
            this.trainingManager.ItemRemover = nullListItemRemover2;
            this.trainingManager.ItemSaver = nullListItemSaver2;
            this.trainingManager.Location = new System.Drawing.Point(3, 3);
            this.trainingManager.Name = "trainingManager";
            this.trainingManager.Size = new System.Drawing.Size(514, 357);
            this.trainingManager.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 392);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private ListManagement.ListManager userManager;
        private System.Windows.Forms.TabPage tabPage2;
        private ListManagement.ListManager trainingManager;
    }
}

