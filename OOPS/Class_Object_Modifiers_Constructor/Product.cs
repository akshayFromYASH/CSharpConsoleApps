using System.Runtime.InteropServices;

namespace Class_Object_Modifiers_Constructor{
    public class Product{
        public int ProdId { get; set; }
        public string ProdName {get;set;}
        public string Company { get; set; }
        public decimal Price { get; set; }
        public enum Category{
            Grocery, Electric, Electronic, Clothing 
        }
        public Category Cat {get;set;}

        public Date MDate {get;set;}
        public Date EDate {get;set;}

        public static int count2{get;set;}

        public Product()
        {
            ProdId = 1;
            ProdName = "Tshirt";
            Company = "Levis";
            Price = 500;
            Cat = Category.Clothing;
            MDate = new Date();
            EDate = new Date();
            count2++;
        }

        public Product(int Id, string name, string comapany, decimal price, Category cat, Date mDate, Date eDate){
            ProdId = Id;
            ProdName = name;
            Company = comapany;
            Price = price;
            Cat = cat;
            MDate = mDate;
            EDate = eDate;
            count2++;
        }

        public override string ToString()
        {
            return $"Product Details : {ProdId} {ProdName} {Company} {Price} {Cat} {MDate} {EDate}";
        }

        public static int showCount(){
            return count2;
        }
    }
}