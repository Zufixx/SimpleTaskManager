namespace SimpleTaskManager
{
    partial class Form1
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
            this.tasksGroup1 = new System.Windows.Forms.GroupBox();
            this.taskCheckBox1 = new System.Windows.Forms.CheckBox();
            this.newTaskButton = new System.Windows.Forms.Button();
            this.newGroupButton = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.tasksGroup1.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tasksGroup1
            // 
            this.tasksGroup1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tasksGroup1.Controls.Add(this.taskCheckBox1);
            this.tasksGroup1.Controls.Add(this.newTaskButton);
            this.tasksGroup1.Location = new System.Drawing.Point(3, 3);
            this.tasksGroup1.Name = "tasksGroup1";
            this.tasksGroup1.Size = new System.Drawing.Size(410, 80);
            this.tasksGroup1.TabIndex = 0;
            this.tasksGroup1.TabStop = false;
            this.tasksGroup1.Text = "Tasks";
            // 
            // taskCheckBox1
            // 
            this.taskCheckBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.taskCheckBox1.AutoSize = true;
            this.taskCheckBox1.Location = new System.Drawing.Point(7, 52);
            this.taskCheckBox1.Name = "taskCheckBox1";
            this.taskCheckBox1.Size = new System.Drawing.Size(69, 21);
            this.taskCheckBox1.TabIndex = 1;
            this.taskCheckBox1.Text = "Task1";
            this.taskCheckBox1.UseVisualStyleBackColor = true;
            // 
            // newTaskButton
            // 
            this.newTaskButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newTaskButton.Location = new System.Drawing.Point(7, 22);
            this.newTaskButton.Name = "newTaskButton";
            this.newTaskButton.Size = new System.Drawing.Size(397, 23);
            this.newTaskButton.TabIndex = 0;
            this.newTaskButton.Text = "New Task";
            this.newTaskButton.UseVisualStyleBackColor = true;
            // 
            // newGroupButton
            // 
            this.newGroupButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newGroupButton.Location = new System.Drawing.Point(10, 89);
            this.newGroupButton.Name = "newGroupButton";
            this.newGroupButton.Size = new System.Drawing.Size(397, 23);
            this.newGroupButton.TabIndex = 1;
            this.newGroupButton.Text = "New Group";
            this.newGroupButton.UseVisualStyleBackColor = true;
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.BackColor = System.Drawing.SystemColors.Control;
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Controls.Add(this.tasksGroup1);
            this.panel.Controls.Add(this.newGroupButton);
            this.panel.Location = new System.Drawing.Point(12, 12);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(418, 350);
            this.panel.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 374);
            this.Controls.Add(this.panel);
            this.Name = "Form1";
            this.Text = "Simple Task Manager";
            this.tasksGroup1.ResumeLayout(false);
            this.tasksGroup1.PerformLayout();
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox tasksGroup1;
        private System.Windows.Forms.Button newTaskButton;
        private System.Windows.Forms.Button newGroupButton;
        private System.Windows.Forms.CheckBox taskCheckBox1;
        private System.Windows.Forms.Panel panel;
    }
}

