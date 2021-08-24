using System;

namespace GenericsMadeSimple
{
    public interface IId
    {
         int Id { get; set; }
    }

    internal class Person : IId<int>
    {
         public int Id { get; set; }
    }


    class Course : IId<string>
    {
        public string Id { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    }

    class ReadOnlyCollection<T> 
    {

        T[] collection;
        int count = 0;
        public bool IsReadOnly { get; set; }
        public virtual void Add(T data)
        {
            if (IsReadOnly) throw new InvalidOperationException("fjedjfi");

            collection[count] = data;
            count++;

            
        }
    }

    class ReadOnlyIIdCollection : ReadOnlyCollection<IId>
    {
        public override void Add(IId data)
        {

            base.Add(data);

            data.Id = 1;//McolelHaIdIMSheli.NextId();
        }
    }
}
