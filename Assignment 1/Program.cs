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
    #region Question04
    ////A generic method declares its own type parameter(s). It can exist in both generic and non-generic classes. The compiler often infers the type argument.
    //public static class Utilities
    //{
    //    public static void Swap<T>(ref T a, ref T b)
    //    {
    //        T temp = a;
    //        a = b;
    //        b = temp;
    //    }

    //}
    #endregion
    #region Qustion05
    //public static class Utilities
    //{

    //    public static T Max<T>(T a, T b) where T : IComparable<T>
    //    {
    //        return a.CompareTo(b) > 0 ? a : b;
    //    }
    //}
    #endregion
    #region Question06
    ////Generic interfaces define contracts with type parameters. Classes implementing them specify the actual types.
    //public interface IRepository<T> where T :class
    //{
    //    T? GetById(int id);
    //    IEnumerable<T> GetAll();
    //    void Add(T entity);


    //}
    //public class UserRepository :IRepository<User>
    //{
    //    private readonly List<User> _users = new();

    //    public User? GetById(int id)
    //        => _users.FirstOrDefault(u => u.Id == id);

    //    public IEnumerable<User> GetAll() => _users;

    //    public void Add(User entity) => _users.Add(entity);
    //}
    #endregion
    #region Question07
    //// struct (Value Types) >> where T : struct restricts T to value types only.Useful when you need value semantics(copy, no null).
    //public struct Nullable<T> where T : struct
    //{
    //    private readonly bool _hasValue;
    //    private readonly T _value;

    //    public bool HasValue => _hasValue;
    //    public T Value => _hasValue ? _value
    //        : throw new InvalidOperationException();

    //    public Nullable(T value)
    //    {
    //        _hasValue = true;
    //        _value = value;
    //    }
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
            #region Qustion04
            //int x = 5, y = 10;
            //Utilities.Swap(ref x, ref y); 
            //Console.WriteLine($"x={x}, y={y}");
            #endregion
            #region Question05
            // int x = 5, y = 10;
            //Console.WriteLine($"The max number is : {Utilities.Max(x,y)}");

            #endregion

        }
    }
}
