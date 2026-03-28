class DataContaincer<T> where T : DataItem
{
    List<T> _dataList;

    public DataContaincer()
    {
        _dataList = new List<T>();
    }

    public void AddItem(T newItem)
    {
        _dataList.Add(newItem);
    }

    public long GetTotalSize()
    {
        long res = 0;
        foreach(T e in _dataList)
            res += e.GetSize();
        return res;
    }
}