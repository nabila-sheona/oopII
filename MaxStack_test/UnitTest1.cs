using maxstack_lab06;

namespace MaxStack_test
{
    [TestClass]
    public class MaxStack_test
    {
        [TestMethod]
        public void testing_max()
        {
            MaxStack maxStack = new MaxStack();
            maxStack.push(3);
            maxStack.push(5);
            maxStack.push(2);
            maxStack.push(1);

            Assert.AreEqual(5, maxStack.Max());
        }

        [TestMethod] 
        public void testing_popmax() {
            MaxStack Stack=new MaxStack();

            Stack.push(3);
            Stack.push(5);
            Stack.push(2);
            Stack.push(1);
            Stack.push(5);

           
            Stack.pop();




            Assert.AreEqual(5, Stack.Max());

        
        }
        [TestMethod]
        public void testing_pushmax() {
            MaxStack maxStack = new MaxStack();
            maxStack.push(12);
            maxStack.push(3);
            maxStack.push(4);

            Assert.AreEqual(12, maxStack.Max());
        
        }
    }
}

