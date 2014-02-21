﻿namespace EnterpriseTraining
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
            EnterpriseTraining.ObjectManagement.NullItemEditor nullItemEditor1 = new EnterpriseTraining.ObjectManagement.NullItemEditor();
            EnterpriseTraining.ObjectManagement.NullItemFactory nullItemFactory1 = new EnterpriseTraining.ObjectManagement.NullItemFactory();
            EnterpriseTraining.ObjectManagement.NullItemRemover nullItemRemover1 = new EnterpriseTraining.ObjectManagement.NullItemRemover();
            EnterpriseTraining.ObjectManagement.NullItemSaver nullItemSaver1 = new EnterpriseTraining.ObjectManagement.NullItemSaver();
            EnterpriseTraining.ObjectManagement.NullItemEditor nullItemEditor2 = new EnterpriseTraining.ObjectManagement.NullItemEditor();
            EnterpriseTraining.ObjectManagement.NullItemFactory nullItemFactory2 = new EnterpriseTraining.ObjectManagement.NullItemFactory();
            EnterpriseTraining.ObjectManagement.NullItemRemover nullItemRemover2 = new EnterpriseTraining.ObjectManagement.NullItemRemover();
            EnterpriseTraining.ObjectManagement.NullItemSaver nullItemSaver2 = new EnterpriseTraining.ObjectManagement.NullItemSaver();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.userManager = new EnterpriseTraining.ObjectManagement.ItemListManager();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.trainingManager = new EnterpriseTraining.ObjectManagement.ItemListManager();
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 392);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Enterprise Training";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private ObjectManagement.ItemListManager userManager;
        private System.Windows.Forms.TabPage tabPage2;
        private ObjectManagement.ItemListManager trainingManager;
    }
}

