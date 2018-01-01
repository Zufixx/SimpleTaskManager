using System;
using System.Windows.Forms;

public class TaskItem
{
    public string name;
    public bool isDone;

	public TaskItem(string name)
	{
        this.name = name;
        isDone = false;
	}
}
