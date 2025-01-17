namespace OperatorOverloading_demo{
    
    internal class Rational{
        public int N { get; set; }
        public int D { get; set; }

        public Rational(int x, int y){
            N=x;
            D=y;
        }

        public static Rational operator + (Rational r1, Rational r2){
            Rational r3 = new Rational(0,0);
            r3.N = r1.N*r2.D + r2.N*r1.D;
            r3.D = r1.D*r2.D;

            return r3;
        }

        public static Rational operator - (Rational r1, Rational r2){
            Rational r3 = new Rational(0,0);
            r3.N = r1.N*r2.D - r2.N*r1.D;
            r3.D = r1.D*r2.D;

            return r3;
        }

        public static Rational operator * (Rational r1, Rational r2){
            Rational r3 = new Rational(0,0);
            r3.N = r1.N*r2.N;
            r3.D = r1.D*r2.D;

            return r3;
        }

        public static Rational operator / (Rational r1, Rational r2){
            Rational r3 = new Rational(0,0);
            r3.N = r1.N*r2.D;
            r3.D = r1.D*r2.N;

            return r3;
        }

         public override string ToString(){
            return $"{N}/{D}";
        }

    }
}
