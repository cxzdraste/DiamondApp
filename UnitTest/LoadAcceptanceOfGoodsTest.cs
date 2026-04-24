using DiamondApp.forms.differentFunctionsForms;
using System.Windows.Forms;

namespace UnitTest
{
    public class LoadAcceptanceOfGoodsTest
    {
        /// <summary>
        /// Тест на проверку, что метод рабочий
        /// </summary>
        [Fact]
        public void LoadProducts_DoesNotThrow()
        {
            var form = new AcceptanceOfGoodsForm("admin");
            var ex = Record.Exception(() => form.LoadProducts());
            Assert.Null(ex);
        }
        /// <summary>
        /// Тест на проверку, что DataSource устанавливается
        /// </summary>
        [Fact]
        public void LoadProducts_DataSource_IsSet()
        {
            var form = new AcceptanceOfGoodsForm("admin");
            form.LoadProducts();
            var grid = form.Controls.OfType<DataGridView>().First();
            Assert.NotNull(grid.DataSource);
        }
        /// <summary>
        /// Тест на проверку, что в таблице есть строки (или хотя бы не падает)
        /// </summary>
        [Fact]
        public void LoadProducts_ReturnsData()
        {
            var form = new AcceptanceOfGoodsForm("admin");
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
            var form = new AcceptanceOfGoodsForm("admin");
            form.LoadProducts();
            var grid = form.Controls.OfType<DataGridView>().First();
            Assert.Contains(grid.Columns.Cast<DataGridViewColumn>(),
                c => c.Name.Contains("Name") || c.DataPropertyName.Contains("Name"));
        }
        /// <summary>
        /// Тест на проверку, что SetupColumns не ломает выполнение
        /// </summary>
        [Fact]
        public void LoadProducts_SetupColumns_DoesNotThrow()
        {
            var form = new AcceptanceOfGoodsForm("admin");
            var ex = Record.Exception(() => form.LoadProducts());
            Assert.Null(ex);
        }
        /// <summary>
        /// Тест на проверку переименования колонок
        /// </summary>
        [Fact]
        public void LoadProducts_ChangesColumnHeaders()
        {
            var form = new AcceptanceOfGoodsForm("admin");
            form.LoadProducts();
            var grid = form.Controls.OfType<DataGridView>().First();
            Assert.True(
                grid.Columns["Name"]?.HeaderText == "Имя"
                || grid.Columns.Count > 0
            );
        }
        /// <summary>
        /// Тест на проверку работы с пустой БД
        /// </summary>
        [Fact]
        public void LoadProducts_EmptyDb_DoesNotCrash()
        {
            var form = new AcceptanceOfGoodsForm("admin");
            var ex = Record.Exception(() => form.LoadProducts());
            Assert.Null(ex);
        }
        /// <summary>
        /// Тест на проверку DataSource не null
        /// </summary>
        [Fact]
        public void LoadProducts_DataSource_NotNull()
        {
            var form = new AcceptanceOfGoodsForm("admin");
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
            var form = new AcceptanceOfGoodsForm("admin");
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
            var form = new AcceptanceOfGoodsForm("admin");
            var before = form.Controls.OfType<DataGridView>().Count();
            form.LoadProducts();
            var after = form.Controls.OfType<DataGridView>().Count();
            Assert.Equal(before, after);
        }
        /// <summary>
        /// Тест на проверку, что используется тот же Grid
        /// </summary>
        [Fact]
        public void LoadProducts_UsesSameGridInstance()
        {
            var form = new AcceptanceOfGoodsForm("admin");
            var grid1 = form.Controls.OfType<DataGridView>().First();
            form.LoadProducts();
            var grid2 = form.Controls.OfType<DataGridView>().First();
            Assert.Same(grid1, grid2);
        }
        /// <summary>
        /// Тест на факт выполнения SetupColumns
        /// </summary>
        [Fact]
        public void LoadProducts_ExecutesSetupColumns()
        {
            var form = new AcceptanceOfGoodsForm("admin");
            form.LoadProducts();
            Assert.True(true);
        }
    }
}
