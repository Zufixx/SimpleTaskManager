namespace SimpleTaskManager
{
    partial class SimpleTaskManager
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
            this.newTaskButton = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.taskNameBox = new System.Windows.Forms.TextBox();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // newTaskButton
            // 
            this.newTaskButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newTaskButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.newTaskButton.Enabled = false;
            this.newTaskButton.ForeColor = System.Drawing.Color.White;
            this.newTaskButton.Location = new System.Drawing.Point(4, 32);
            this.newTaskButton.Name = "newTaskButton";
            this.newTaskButton.Size = new System.Drawing.Size(354, 30);
            this.newTaskButton.TabIndex = 0;
            this.newTaskButton.Text = "New Task";
            this.newTaskButton.UseVisualStyleBackColor = false;
            this.newTaskButton.Click += new System.EventHandler(this.newTaskButton_Click);
            this.newTaskButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newTaskButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.newTaskButton.FlatAppearance.BorderSize = 1;
            this.newTaskButton.ForeColor = System.Drawing.Color.White;
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.AutoScroll = true;
            this.panel.BackColor = System.Drawing.Color.Transparent;
            this.panel.Controls.Add(this.taskNameBox);
            this.panel.Controls.Add(this.newTaskButton);
            this.panel.Location = new System.Drawing.Point(12, 12);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(361, 441);
            this.panel.TabIndex = 2;
            // 
            // taskNameBox
            // 
            this.taskNameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.taskNameBox.Location = new System.Drawing.Point(4, 4);
            this.taskNameBox.Name = "taskNameBox";
            this.taskNameBox.Size = new System.Drawing.Size(354, 22);
            this.taskNameBox.TabIndex = 1;
            this.taskNameBox.TextChanged += new System.EventHandler(this.taskNameBox_TextChanged);
            // 
            // SimpleTaskManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(385, 465);
            this.Controls.Add(this.panel);
            this.Name = "SimpleTaskManager";
            this.ShowIcon = false;
            this.Text = "Simple Task Manager";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button newTaskButton;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.TextBox taskNameBox;
    }
}

