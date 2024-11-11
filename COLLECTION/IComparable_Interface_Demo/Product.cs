// prod id, quantity, name, price


// IComparable ==> - Provides standard way to compare objects of custom data type
                // - It defines a single method, ComapareTo() which takes and object of the same type as input and returns integer value
                // - ComapareTo() --> - Returns negative integer if current object is less that obj
                                //    - Returns 0 if the current object is equal to obj
                                //    - Retuns positive integer if current object is greater than obj
                // Use Cases --> 1) Sort collections of objects 
                            //    2) Searching by using binary search
                            //    3) Maintain order of objects in collection
namespace IComparable_Interface_Demo{
    internal class Product:IComparable{
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public Product(int prodId, string name, int quantity, decimal price){
            ProductId = prodId;
            Name = name;
            Quantity = quantity;
            Price = price;
        }

        public override string ToString(){
            return $"Product Details: {ProductId} {Name} {Quantity} {Price}";
        }

        public int CompareTo(object obj){
            Product prod = obj as Product;

            return string.Compare(Name,prod.Name);
        }

    }
}