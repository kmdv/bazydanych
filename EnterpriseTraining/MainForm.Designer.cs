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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listManager1 = new EnterpriseTraining.ListManagement.ListManager();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(528, 392);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listManager1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(520, 363);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Users";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listManager1
            // 
            this.listManager1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listManager1.ItemEditor = nullListItemEditor1;
            this.listManager1.ItemFactory = nullListItemFactory1;
            this.listManager1.ItemRemover = nullListItemRemover1;
            this.listManager1.ItemSaver = nullListItemSaver1;
            this.listManager1.Location = new System.Drawing.Point(3, 3);
            this.listManager1.Name = "listManager1";
            this.listManager1.Size = new System.Drawing.Size(514, 357);
            this.listManager1.TabIndex = 0;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private ListManagement.ListManager listManager1;
    }
}

