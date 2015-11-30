using System;

public class Project
{
    private string projectName;
    private DateTime startDate;
    private string details;
    private bool isClosed;

    public Project(string name, DateTime start, string details)
    {
        this.ProjectName = name;
        this.StartDate = start;
        this.Details = details;
        this.isClosed = false;
    }

    public string ProjectName { get; set; }
    public DateTime StartDate { get; private set; }
    public string Details { get; set; }
    public bool IsClosed { get; private set; }

    public void CloseProject()
    {
        this.isClosed = true;
    }
}