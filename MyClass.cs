public MyClass
{
  private string m_name = null;

  public MyClass(string name)
  {
    m_name = name;
  }

  public void Rename(string newName)
  {
    m_name = newName;
  }

  public string Name()
  {

  }
}