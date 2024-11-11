namespace Reflection_CreatInstance_Runtime{
    internal class TestClass{
        private int testValue = 42;

        public int TestMethod(int numberToAdd){
            return this.testValue + numberToAdd;
        }

        public int Add(int a, int b){
            return a+b;
        }
    }
}