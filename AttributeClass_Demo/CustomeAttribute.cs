namespace Attribute_Class_Demo{
    [AttributeUsage(AttributeTargets.All)]

    internal class MyCustomAttribute:System.Attribute{
        public string DeveloperName { get; set; }
        public double Version { get; set; }
        public MyCustomAttribute(string developername, double version){
            DeveloperName = developername;
            Version = version;
        }

        public void ShowResult(){
            System.Console.WriteLine("customeAttributeMethod");
        }
    }
}