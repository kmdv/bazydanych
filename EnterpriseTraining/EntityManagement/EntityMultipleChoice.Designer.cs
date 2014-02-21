namespace EnterpriseTraining.EntityManagement
{
    partial class EntityMultipleChoice
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntityMultipleChoice));
            this.itemMultipleChoice = new EnterpriseTraining.ItemManagement.ItemMultipleChoice();
            this.SuspendLayout();
            // 
            // itemMultipleChoice
            // 
            this.itemMultipleChoice.CheckedIndices = ((System.Collections.Generic.IList<int>)(resources.GetObject("itemMultipleChoice.CheckedIndices")));
            this.itemMultipleChoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemMultipleChoice.Items = ((System.Collections.Generic.IList<EnterpriseTraining.ItemManagement.IItem>)(resources.GetObject("itemMultipleChoice.Items")));
            this.itemMultipleChoice.Location = new System.Drawing.Point(0, 0);
            this.itemMultipleChoice.Name = "itemMultipleChoice";
            this.itemMultipleChoice.Size = new System.Drawing.Size(313, 229);
            this.itemMultipleChoice.TabIndex = 0;
            // 
            // EntityMultipleChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.itemMultipleChoice);
            this.Name = "EntityMultipleChoice";
            this.Size = new System.Drawing.Size(313, 229);
            this.ResumeLayout(false);

        }

        #endregion

        private ItemManagement.ItemMultipleChoice itemMultipleChoice;
    }
}
