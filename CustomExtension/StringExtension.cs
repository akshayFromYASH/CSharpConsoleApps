namespace CustomExtensionLib{
    public static class StringExtension{

        // this is extnesion method
        // the first parameter takes the this modifier 
        // and specifies the type for which the method is define


        public static int WordCount(this string str){
            return str.Split(new char[] {' ', '.', '?'}, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public static char Convert(char c){

            if(c>='a' && c <= 'z'){
                c = (char)(c - 32);
                return c;
            }
            else{
                return c;
            }
        }

        public static string ToSentenceCase(this string str){
            
            string[] str1 = str.Split(' ');
            string str2 = "";

            foreach (var item in str1){
                char[] ch = item.ToCharArray();
                ch[0] = Convert(ch[0]);

                str2 = str2 + new string(ch) + " ";
            }

            return str2;
        }
    }
}