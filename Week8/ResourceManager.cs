class ResourceManager<T> where T : Resource
{
    List<T> _resources;

    public ResourceManager()
    {
        _resources = new List<T>();
    }

    public void Add(T newRes)
    {
        _resources.Add(newRes);
    }

    public void OpenAll()
    {
        foreach(T res in _resources)
        {
            res.Open();
        }
    }

    public void CloseAll()
    {
        foreach(T res in _resources)
        {
            res.Close();
        }
    }
}