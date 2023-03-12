using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.TextilSoft.Tools
{
    public class CustomButtonColumn : DataGridViewColumn
    {
        private const int BUTTON_COLUMN_WIDTH = 80; // Defina aquí el ancho deseado para la columna de botones
        public CustomButtonColumn(string nameColumn)
        {
            this.CellTemplate = new CustomButtonCell();
            this.HeaderText = nameColumn;
            this.Name = nameColumn;
            this.Width = 20;
        }
        protected override void OnDataGridViewChanged()
        {
            base.OnDataGridViewChanged();

            if (this.DataGridView != null)
            {
                this.Width = BUTTON_COLUMN_WIDTH;
            }
        }
    }
}
