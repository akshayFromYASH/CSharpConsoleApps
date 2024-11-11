using System.Collections;

// IEnumerable ==> - Defines the mos basic interface for enumerating sequence fo elements
                // - GetEnumerator() --> Returns an IEnumerator object that cann be used to iterate through the elements of the collection
                // - Any collection that implements IEnumerable can be used in a foreach loop to iterate over its elements
                // - Foundation class of classes --> ICollection, IList, IQueryable
namespace Collections_Demo{
    internal class IEnumerableDemo{ 
        public static void Main(string[] args){
            Batch b1 = new Batch();

            IEnumerator Er = b1.GetEnumerator();

            Student? s = Er.Current as Student;
            Er.MoveNext();
            System.Console.WriteLine(s);

            Er.MoveNext();
            // s = Er.Current as Student;
            System.Console.WriteLine(Er.Current);

            Er.MoveNext();
            s = Er.Current as Student;
            System.Console.WriteLine(s);

            
        }
    }
}