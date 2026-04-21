using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestDiamondApp
{
    public class UniteOfMeasureTest
    {
        /// <summary>
        /// Тест на проверку исключения
        /// </summary>
        [Fact]
        public void Constructor_Throws_NullReferenceException()
        {
            Assert.Throws<NullReferenceException>(() =>
                new UniteOfMeasureClass("Штуки")
            );
        }
        /// <summary>
        /// Тест на проверку,что ошибочное значение вызывает падение
        /// </summary>
        [Fact]
        public void Constructor_AnyValue_ThrowsException()
        {
            Assert.Throws<NullReferenceException>(() => new UniteOfMeasureClass("граммы"));
        }
        /// <summary>
        /// Тест на проверку, пустая строка падает
        /// </summary>
        [Fact]
        public void Constructor_EmptyString_ThrowsException()
        {
            Assert.Throws<NullReferenceException>(() => new UniteOfMeasureClass(""));
        }
        /// <summary>
        /// Тест на проверку Null
        /// </summary>
        [Fact]
        public void Constructor_Null_ThrowsException()
        {
            Assert.Throws<NullReferenceException>(() => new UniteOfMeasureClass(null));
        }
        /// <summary>
        /// Тест на проверку, что если объект ошибочный, то выходит ошибка
        /// </summary>
        [Fact]
        public void Constructor_Object_IsNotCreatedProperly()
        {
            try
            {
                var obj = new UniteOfMeasureClass("Штуки");
                Assert.True(false);
            }
            catch (NullReferenceException)
            {
                Assert.True(true);
            }
        }
        /// <summary>
        /// Тест на проверку, что список null, если конструктор ошибочный
        /// </summary>
        [Fact]
        public void Constructor_List_IsAlwaysNull()
        {
            try
            {
                var obj = new UniteOfMeasureClass("Штуки");
                Assert.Null(obj.UnitesOfMeasure);
            }
            catch (NullReferenceException)
            {
                Assert.True(true);
            }
        }
        /// <summary>
        /// Тест на проверку, что объект может не инициализироваться
        /// </summary>
        [Fact]
        public void Constructor_Object_CannotBeUsed()
        {
            Assert.Throws<NullReferenceException>(() =>
            {
                var obj = new UniteOfMeasureClass("штуки");
                var count = obj.UnitesOfMeasure.Count;
            });
        }
        /// <summary>
        /// Тест на проверку вводимых значений
        /// </summary>
        /// <param name="input"></param>
        [Theory]
        [InlineData("Штуки")]
        [InlineData("Кг")]
        [InlineData("Литры")]
        [InlineData("123")]
        [InlineData("")]
        public void Constructor_AllInputs_Throw(string input)
        {
            Assert.Throws<NullReferenceException>(() => new UniteOfMeasureClass(input));
        }
        /// <summary>
        /// Тест на множество вызовов
        /// </summary>
        [Fact]
        public void Constructor_MultipleCalls_AllThrow()
        {
            for (int i = 0; i < 100; i++)
            {
                Assert.Throws<NullReferenceException>(() => new UniteOfMeasureClass("Test" + i));
            }
        }
    }
}
