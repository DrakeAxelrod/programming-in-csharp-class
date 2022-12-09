namespace a6;

public class ToDoManager {
  private List<ToDo> toDoList = new List<ToDo>();

  /// <summary>
  ///  Default constructor.
  /// </summary>
  public ToDoManager() {}

  /// <summary>
  ///  Adds a ToDo to the list.
  /// </summary>
  public void Add(ToDo toDo) {
    toDoList.Add(toDo);
  }

  /// <summary>
  ///  Removes a ToDo from the list.
  /// </summary>
  public void Remove(ToDo toDo) {
    toDoList.Remove(toDo);
  }

  /// <summary>
  ///  Returns a list of ToDos.
  /// </summary>
  public List<ToDo> GetToDos() {
    return toDoList;
  }

  /// <summary>
  /// Search removal by description.
  /// </summary>
  public void RemoveByDescription(string description) {
    for (int i = 0; i < toDoList.Count; i++) {
      if (toDoList[i].Description == description) {
        toDoList.RemoveAt(i);
        i--;
      }
    }
  }
}
