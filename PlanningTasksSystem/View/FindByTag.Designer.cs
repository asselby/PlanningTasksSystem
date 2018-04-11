namespace PlanningTasksSystem.View
{
    partial class FindByTag
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
            this.label = new System.Windows.Forms.Label();
            this.tagTextBox = new System.Windows.Forms.TextBox();
            this.findButton = new System.Windows.Forms.Button();
            this.tagListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.Location = new System.Drawing.Point(12, 27);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(199, 20);
            this.label.TabIndex = 0;
            this.label.Text = "Введите тэг для поиска:";
            // 
            // tagTextBox
            // 
            this.tagTextBox.Location = new System.Drawing.Point(217, 19);
            this.tagTextBox.Multiline = true;
            this.tagTextBox.Name = "tagTextBox";
            this.tagTextBox.Size = new System.Drawing.Size(206, 41);
            this.tagTextBox.TabIndex = 1;
            // 
            // findButton
            // 
            this.findButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.findButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.findButton.Location = new System.Drawing.Point(447, 24);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(77, 33);
            this.findButton.TabIndex = 2;
            this.findButton.Text = "Найти";
            this.findButton.UseVisualStyleBackColor = true;
            // 
            // tagListView
            // 
            this.tagListView.Location = new System.Drawing.Point(12, 66);
            this.tagListView.Name = "tagListView";
            this.tagListView.Size = new System.Drawing.Size(462, 235);
            this.tagListView.TabIndex = 3;
            this.tagListView.UseCompatibleStateImageBehavior = false;
            // 
            // FindByTag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 313);
            this.Controls.Add(this.tagListView);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.tagTextBox);
            this.Controls.Add(this.label);
            this.Name = "FindByTag";
            this.Text = "FindByTag";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label;
        public System.Windows.Forms.TextBox tagTextBox;
        public System.Windows.Forms.Button findButton;
        public System.Windows.Forms.ListView tagListView;
    }
}