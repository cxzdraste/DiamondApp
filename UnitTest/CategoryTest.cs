using DiamonApp.Classes;
namespace UnitTest
{
    public class CategoryTest
    {
        /// <summary>
        /// Тест на проверку исключения
        /// </summary>
        [Fact]
        public void CategoryProductTest()
        {
            string categoryName = "TestCategory";
            var ex = Assert.Throws<NullReferenceException>(() =>
            {
                var category = new CategoryClass(categoryName);
            });
        }
        /// <summary>
        /// Тест на проверку разных вводных значений
        /// </summary>
        /// <param name="input"></param>
        [Theory]
        [InlineData("Test")]
        [InlineData("")]
        [InlineData("   ")]
        [InlineData(null)]
        public void Constructor_Category(string input)
        {
            Assert.Throws<NullReferenceException>(() =>
                new CategoryClass(input));
        }
        /// <summary>
        /// Тест на проверку, что объект не создается при исключении
        /// </summary>
        [Fact]
        public void Constructor_DoesNotReturnObject_WhenExceptionThrown()
        {
            CategoryClass result = null;
            Assert.Throws<NullReferenceException>(() =>
            {
                result = new CategoryClass("Test");
            });
            Assert.Null(result);
        }
        /// <summary>
        /// Проверка на множество вызовов
        /// </summary>
        [Fact]
        public void Constructor_MultipleCalls_AlwaysThrow()
        {
            for (int i = 0; i < 5; i++)
            {
                Assert.Throws<NullReferenceException>(() => new CategoryClass("Test"));
            }
        }
    }
}