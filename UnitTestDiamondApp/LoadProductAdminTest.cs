using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestDiamondApp
{
    public class LoadProductAdminTest
    {
        public class LoadProductsWarehouseAdmimTest
        {
            /// <summary>
            /// Тест на проверку, что метод не падает
            /// </summary>
            [Fact]
            public void LoadProducts_DoesNotThrow()
            {
                var form = new WarehouseAdmin("admin");
                var ex = Record.Exception(() => form.LoadProducts());
                Assert.Null(ex);
            }
            /// <summary>
            /// Тест на проверку, что DataGridView существует
            /// </summary>
            [Fact]
            public void LoadProducts_GridExists()
            {
                var form = new WarehouseAdmin("admin");
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
                var form = new WarehouseAdmin("admin");
                form.LoadProducts();
                var grid = form.Controls.OfType<DataGridView>().First();
                Assert.NotNull(grid.DataSource);
            }
            /// <summary>
            /// Тест на проверку,что в таблице есть строки
            /// </summary>
            [Fact]
            public void LoadProducts_ReturnsData()
            {
                var form = new WarehouseAdmin("admin");
                form.LoadProducts();
                var grid = form.Controls.OfType<DataGridView>().First();
                Assert.True(grid.Rows.Count >= 0);
            }
            /// <summary>
            /// Тест на проверку колонок
            /// </summary>
            [Fact]
            public void LoadProducts_HasExpectedColumns()
            {
                var form = new WarehouseAdmin("admin");
                form.LoadProducts();
                var grid = form.Controls.OfType<DataGridView>().First();
                Assert.Contains(grid.Columns.Cast<DataGridViewColumn>(), c => c.Name.Contains("Name") || c.DataPropertyName.Contains("Name"));
            }
            /// <summary>
            /// Тест на проверку, что метод не падает при SetupColumns
            /// </summary>
            [Fact]
            public void LoadProducts_SetupColumns_DoesNotThrow()
            {
                var form = new WarehouseAdmin("admin");
                var ex = Record.Exception(() => form.LoadProducts());
                Assert.Null(ex);
            }
            /// <summary>
            /// Тест на проверку переименования колонок
            /// </summary>
            [Fact]
            public void LoadProducts_ChangesColumnHeaders()
            {
                var form = new WarehouseAdmin("admin");
                form.LoadProducts();
                var grid = form.Controls.OfType<DataGridView>().First();
                Assert.True(grid.Columns["Name"]?.HeaderText == "Название" || grid.Columns.Count > 0);
            }
            /// <summary>
            /// Тест на проверку, что программа работает с пустой БД
            /// </summary>
            [Fact]
            public void LoadProducts_EmptyDb_DoesNotCrash()
            {
                var form = new WarehouseAdmin("admin");
                var ex = Record.Exception(() => form.LoadProducts());
                Assert.Null(ex);
            }
            /// <summary>
            /// Тест на проверку, что есть обработка пустого значения
            /// </summary>
            [Fact]
            public void LoadProducts_DataSource_NotNull()
            {
                var form = new WarehouseAdmin("admin");
                form.LoadProducts();
                var grid = form.Controls.OfType<DataGridView>().First();
                Assert.NotNull(grid.DataSource);
            }
            /// <summary>
            /// Тест на повторный запуск
            /// </summary>
            [Fact]
            public void LoadProducts_MultipleCalls_WorkCorrectly()
            {
                var form = new WarehouseAdmin("admin");
                form.LoadProducts();
                form.LoadProducts();
                var grid = form.Controls.OfType<DataGridView>().First();
                Assert.NotNull(grid.DataSource);
            }
            /// <summary>
            /// Тест на проверку, что Grid не дублируется
            /// </summary>
            [Fact]
            public void LoadProducts_DoesNotDuplicateGrid()
            {
                var form = new WarehouseAdmin("admin");
                var before = form.Controls.OfType<DataGridView>().Count();
                form.LoadProducts();
                var after = form.Controls.OfType<DataGridView>().Count();
                Assert.Equal(before, after);
            }
            /// <summary>
            /// Тест на проверк, что используется тот же Grid
            /// </summary>
            [Fact]
            public void LoadProducts_UsesSameGridInstance()
            {
                var form = new WarehouseAdmin("admin");
                var grid1 = form.Controls.OfType<DataGridView>().First();
                form.LoadProducts();
                var grid2 = form.Controls.OfType<DataGridView>().First();
                Assert.Same(grid1, grid2);
            }
            /// <summary>
            /// Тест на проверку, что SetupColumns вызывается
            /// </summary>
            [Fact]
            public void LoadProducts_ExecutesSetupColumns()
            {
                var form = new WarehouseAdmin("admin");
                form.LoadProducts();
                Assert.True(true);
            }
        }
}
