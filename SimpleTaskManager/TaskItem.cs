using System;
using System.Windows.Forms;

public class TaskItem
{
    public string name;
    public string group;
    public bool isDone;

	public TaskItem(string name, string group)
	{
        this.name = name;
        this.group = group;
        isDone = false;
	}
}
