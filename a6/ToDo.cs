namespace a6;

public class ToDo
{
    private string description = "";
    private Priority priority;
    private DateTime dueDate;

    /// <summary>
    ///  Default constructor.
    /// </summary>
    public ToDo() {}

    /// <summary>
    ///  Constructor with parameters.
    /// </summary>
    public ToDo(string description, Priority priority, DateTime dueDate) {
        this.description = description;
        this.priority = priority;
        this.dueDate = dueDate;
    }
    /// <summary>
    ///  Gets or sets the description.
    /// </summary>
    public string Description {
        get { return description; }
        set { description = value; }
    }
    /// <summary>
    ///  Gets or sets the priority.
    /// </summary>
    public Priority Priority {
        get { return priority; }
        set { priority = value; }
    }
    /// <summary>
    ///  Gets or sets the due date.
    /// </summary>
    public DateTime DueDate {
        get { return dueDate; }
        set { dueDate = value; }
    }

    /// <summary>
    ///  Returns a string representation of the object.
    ///  format:
    ///  date hour:minute priority description
    /// </summary>
    public override string ToString() {
      // with spacing
      string prio = priority.ToString().Replace("_", " ");
      return $"{dueDate.ToShortDateString(), -49} {dueDate.ToShortTimeString(), -26} {prio, -33} {description}";
    }
}
