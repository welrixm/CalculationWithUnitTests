namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            
                int a = 25;
                int b = 25;
                string sum = (a + b).ToString();
                Assert.True(sum == "50");
            
        }
        [Fact]
        public void Test2()
        {

            int a = 25;
            int b = 10;
            string sum = (a - b).ToString();
            Assert.True(sum == "15");

        }

    }
}