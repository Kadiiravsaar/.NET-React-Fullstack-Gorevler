List<string> sehirler = new List<string>();
sehirler.Add("Ankara");
sehirler.Add("Ankara");
sehirler.Add("Ankara");
sehirler.Add("Ankara");
sehirler.Add("Ankara");
Console.WriteLine(sehirler.Count);

MyList<string> sehirler2 = new MyList<string>();
sehirler2.Add("İst");
sehirler2.Add("İst");
sehirler2.Add("İst");
sehirler2.Add("İst");
sehirler2.Add("İst");
sehirler2.Add("İst");
Console.WriteLine(sehirler2.Count);


class MyList<T> // generic class
{
    T[] _array;
    T[] _tempArray;
    public MyList()
    {
        _array = new T[0];
    }

    public void Add(T item)
    {
        _tempArray = _array;
        _array = new T[_tempArray.Length + 1];
        for (int i = 0; i < _tempArray.Length; i++)
        {
            _array[i] = _tempArray[i];
        }
        _array[_array.Length-1] = item; // _arrayin son elemanı = bizim gönderdiğimiz item
    }

    public int Count
    {
        get { return _array.Length; }
    }
}