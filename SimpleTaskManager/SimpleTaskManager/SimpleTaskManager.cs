using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace SimpleTaskManager
{
    public partial class SimpleTaskManager : Form
    {
        private List<TaskItem> taskList = new List<TaskItem>();
        private List<CheckBox> checkBoxes = new List<CheckBox>();

        public SimpleTaskManager()
        {
            InitializeComponent();

            for(int i = 0; i < taskList.Count; i++)
            {
                checkBoxes.Add(new CheckBox());
                CheckBox cb = checkBoxes[i];

                cb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
|               System.Windows.Forms.AnchorStyles.Right)));
                cb.AutoSize = true;
                cb.Location = new System.Drawing.Point(3, 20 * i + 32);
                cb.Size = new System.Drawing.Size(69, 21);
                cb.TabIndex = 1;
                cb.Text = taskList[i].name;
                cb.UseVisualStyleBackColor = true;
                cb.Click += new System.EventHandler(this.checkBoxes_Click);

                panel.Controls.Add(checkBoxes[i]);
            }
        }

        private void checkBoxes_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;

            if (me.Button == MouseButtons.Right)
                Debug.WriteLine("Rightclick!");

            if (me.Button == MouseButtons.Left)
                Debug.WriteLine("Leftclick!");
        }

        private void newTaskButton_Click(object sender, EventArgs e)
        {
            int maxY = 30;

            if(checkBoxes.Count > 0)
                maxY = checkBoxes.Last().Location.Y;

            TaskItem newTask = new TaskItem(taskNameBox.Text);
            taskList.Add(newTask);

            checkBoxes.Add(new CheckBox());
            CheckBox newCheckBox = checkBoxes.Last();

            newCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
|           System.Windows.Forms.AnchorStyles.Right)));
            newCheckBox.AutoSize = true;
            newCheckBox.Location = new System.Drawing.Point(3, maxY + 20);
            newCheckBox.Size = new System.Drawing.Size(69, 21);
            newCheckBox.TabIndex = 1;
            newCheckBox.Text = newTask.name;
            newCheckBox.UseVisualStyleBackColor = true;
            newCheckBox.Click += new System.EventHandler(this.checkBoxes_Click);

            panel.Controls.Add(newCheckBox);

            taskNameBox.Text = "";
        }

        private void taskNameBox_TextChanged(object sender, EventArgs e)
        {
            if (taskNameBox.Text != "")
                newTaskButton.Enabled = true;
            else
                newTaskButton.Enabled = false;
        }
    }
}
