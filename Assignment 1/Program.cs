namespace Assignment_1
{
    #region Question02
    //public class Container<T>
    // {
    //     private List<T> _items = new();
    //     public void Add(T item) => _items.Add(item);
    //     public T Get(int index) =>_items[index];
    // }
    #endregion
    #region Question03
    //A generic class uses type parameters that are replaced with actual types when you create an instance. The type parameter T acts as a placeholder.
    //public class Pair<TKey , TValue>
    //{
    //    public TKey Key { get; }
    //    public TValue Value { get; }
    //    public Pair(TKey key, TValue value)
    //    {
    //        Key = key;
    //        Value = value;
    //    }
    //    public override string ToString() => $"{Key} : {Value}";
       
 
    //}
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01
            //A generic class uses type parameters that are replaced with actual types when you create an instance. The type parameter T acts as a placeholder.
            //Benefit >>	Description
            //Type Safety >> Compile - time type checking
            //Performance >> No boxing / unboxing for value types
            //Code Reuse >>  One implementation for all types
            //IntelliSense >>    Better IDE support and discovery
            #endregion

            //Usage
            #region Question03
            //var Pair = new Pair<string, int>("Score", 99);
            //Console.WriteLine(Pair);
            #endregion
        }
    }
}
