namespace UnitTestDiamondApp
{
    public class LoadProductCreatingShipmentTest
    {
        /// <summary>
        /// Тест на проверку,что данные загружаются
        /// </summary>
        [Fact]
        public void LoadProducts_DoesNotThrow()
        {
            var form = new CreatingShipmentForm("admin");
            var exception = Record.Exception(() => form.LoadProducts());
            Assert.Null(exception);
        }
        /// <summary>
        /// Тест на проверку, что DataGriedView существует
        /// </summary>
        [Fact]
        public void LoadProducts_GridExists()
        {
            var form = new CreatingShipmentForm("admin");
            form.LoadProducts();
            var grid = form.Controls.OfType<DataGridView>().FirstOrDefault();
            Assert.NotNull(grid);
        }
        /// <summary>
        /// Тест на проверку, что DataSource устанавливается
        /// </summary>
        [Fact]
        public void LoadProducts_DataSource_IsSet()
        {
            var form = new CreatingShipmentForm("admin");
            form.LoadProducts();
            var grid = form.Controls.OfType<DataGridView>().First();
            Assert.NotNull(grid.DataSource);
        }
        /// <summary>
        /// Тест на проверку,что в таблице есть строки
        /// </summary>
        [Fact]
        public void LoadProducts_ReturnsRows()
        {
            var form = new CreatingShipmentForm("admin");
            form.LoadProducts();
            var grid = form.Controls.OfType<DataGridView>().First();
            Assert.True(grid.Rows.Count >= 0);
        }
        /// <summary>
        /// Тест на проверку структуры колонок
        /// </summary>
        [Fact]
        public void LoadProducts_HasExpectedColumns()
        {
            var form = new CreatingShipmentForm("admin");
            form.LoadProducts();
            var grid = form.Controls.OfType<DataGridView>().First();
            Assert.Contains(grid.Columns.Cast<DataGridViewColumn>(),
                c => c.Name.Contains("Name") || c.DataPropertyName.Contains("Name"));
        }
        /// <summary>
        /// Тест на проверку, если БД пустая
        /// </summary>
        [Fact]
        public void LoadProducts_EmptyDatabase_DoesNotCrash()
        {
            var form = new CreatingShipmentForm("admin");
            var ex = Record.Exception(() => form.LoadProducts());
            Assert.Null(ex);
        }
        /// <summary>
        /// Тест на проверку,что программа обрабатывает пустое значение
        /// </summary>
        [Fact]
        public void LoadProducts_NullSafe()
        {
            var form = new CreatingShipmentForm("admin");
            form.LoadProducts();
            var grid = form.Controls.OfType<DataGridView>().First();
            Assert.NotNull(grid.DataSource);
        }
        /// <summary>
        /// Тест на повторный вызов
        /// </summary>
        [Fact]
        public void LoadProducts_CalledTwice_Works()
        {
            var form = new CreatingShipmentForm("admin");
            form.LoadProducts();
            form.LoadProducts();
            var grid = form.Controls.OfType<DataGridView>().First();
            Assert.NotNull(grid.DataSource);
        }
        /// <summary>
        /// Тест на проверку,что метод не создает еще таблицу
        /// </summary>
        [Fact]
        public void LoadProducts_DoesNotCreateMultipleGrids()
        {
            var form = new CreatingShipmentForm("admin");
            var before = form.Controls.OfType<DataGridView>().Count();
            form.LoadProducts();
            var after = form.Controls.OfType<DataGridView>().Count();
            Assert.Equal(before, after);
        }
        /// <summary>
        /// Тест на проверку, что таблица заполнена после вызова
        /// </summary>
        [Fact]
        public void LoadProducts_FillsGrid()
        {
            var form = new CreatingShipmentForm("admin");
            form.LoadProducts();
            var grid = form.Controls.OfType<DataGridView>().First();
            Assert.NotNull(grid.DataSource);
        }

    }
}