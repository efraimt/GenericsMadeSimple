namespace GenericsMadeSimple
{
    interface IId<T>
    {
        public T Id { get; set; }
    }

    class Person : IId<int>
    {
        public int Id { get; set; }
    }


    class Course : IId<string>
    {
        public string Id { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    }
}
