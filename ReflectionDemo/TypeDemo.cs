// //See https://aka.ms/new-console-template for more information
// using System.Reflection;

// namespace ReflectionDemo{

//     // Type class ==> - Used extensively in reflection scenarios
//                 // - Allowing you to inspect and manipulate types dynamically at runtime
//                 // - Obtain information about a type's members, create instances of the type, and invoke its methods.
    
// //      Properties:
//             // Name: Gets the fully qualified name of the type, including the namespace.
//             // Namespace: Gets the namespace of the type.
//             // FullName: Gets the fully qualified name of the type, including the assembly name.
//             // BaseType: Gets the base type of the type, or null if it has no base type.
//             // IsValueType: Indicates whether the type is a value type.
//             // IsReferenceType: Indicates whether the type is a reference type.
//             // IsInterface: Indicates whether the type is an interface.
//             // IsEnum: Indicates whether the type is an enum.
//             // IsArray: Indicates whether the type is an array.
//             // IsGenericType: Indicates whether the type is a generic type.
//             // IsClass: Indicates whether the type is a class.
//             // IsAbstract: Indicates whether the type is abstract.
//             // IsSealed: Indicates whether the type is sealed.

// //      Methods:
//             // GetMethods(): Gets an array of all public methods defined in the type.
//             // GetProperties(): Gets an array of all public properties defined in the type.
//             // GetFields(): Gets an array of all public fields defined in the type.
//             // GetConstructors(): Gets an array of all public constructors defined in the type.
//             // InvokeMember(): Invokes a member (method, property, or field) of the type at runtime.
//             // MakeGenericType(): Creates a generic type instance from a generic type definition.
//             // IsAssignableFrom(): Determines if a type is assignable to another type.
//     internal class TypeDemo{
//         static void Main(string[] args){

//             // typeof operator ==> - Unary operator that takes a type as an operand and returns a Type object representing that type
//                                 // - typeof operator is evaluated at compile time, so the type must be known at compile time.
//             // get typeof Enumerable and load it to Type variable t
//             Type t = typeof(Double);
//             Type p = typeof(Person);

//             // The Type class properties return the information about the Enumerable Type
//             System.Console.WriteLine($"Name: {t.Name}");
//             System.Console.WriteLine($"Namespace: {t.Namespace}");
//             System.Console.WriteLine($"Base Type: {t.BaseType}");
//             System.Console.WriteLine();

//             System.Console.WriteLine($"Name: {p.Name}");
//             System.Console.WriteLine($"Namespace: {p.Namespace}");
//             System.Console.WriteLine($"Base Type: {p.BaseType}");
//         }
//     }
// }
