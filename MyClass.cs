public MyClass
{
  private string m_name = null;

  public MyClass(string name)
  {
    m_name = name;
  }

  public void Rename(string newName)
  {

  }

  public string Name()
  {
    //Just return the value of m_name
    return m_name;
  }
}