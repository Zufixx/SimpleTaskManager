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
        }

        private void newTaskButton_Click(object sender, EventArgs e)
        {
            int maxY = 36;

            if(checkBoxes.Count > 0)
                maxY = checkBoxes.Last().Location.Y;

            TaskItem newTask = new TaskItem(taskNameBox.Text);
            taskList.Add(newTask);

            checkBoxes.Add(new CheckBox());
            CheckBox newCheckBox = checkBoxes.Last();

            newCheckBox.Anchor = ((((AnchorStyles.Top | AnchorStyles.Left) | AnchorStyles.Right)));
            newCheckBox.AutoSize = true;
            newCheckBox.Location = new Point(3, maxY + 20);
            newCheckBox.Size = new Size(69, 21);
            newCheckBox.TabIndex = 1;
            newCheckBox.Text = newTask.name;
            newCheckBox.ForeColor = Color.White;
            newCheckBox.UseVisualStyleBackColor = true;
            newCheckBox.MouseDown += new MouseEventHandler(this.checkBoxes_MouseDown);

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

        private void checkBoxes_MouseDown(object sender, MouseEventArgs e)
        {
            CheckBox clickedCheckBox = (CheckBox)sender;

            if (e.Button == MouseButtons.Right)
            {
                clickedCheckBox.Checked = true;
                clickedCheckBox.Enabled = false;
            }
            else if (e.Button == MouseButtons.Left && clickedCheckBox.ForeColor == Color.Gray)
            {
                clickedCheckBox.ForeColor = Color.Black;
            }
            else
            {
                clickedCheckBox.ForeColor = Color.Gray;
            }
        }
    }
}
