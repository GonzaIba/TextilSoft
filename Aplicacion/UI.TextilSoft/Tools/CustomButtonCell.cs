using Domain.Entities;
using FontAwesome.Sharp;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.TextilSoft.Tools.FormsTools;

namespace UI.TextilSoft.Tools
{
    public class CustomButtonCell : DataGridViewCell
    {
        private IconButton btnModificar;
        private IconButton btnEliminar;
        //private IconButton button3;

        public CustomButtonCell()
        {
            //this.btnModificar = new IconButton();
            //this.btnModificar.IconChar = IconChar.PenSquare;
            //this.btnModificar.IconSize = 30;
            //this.btnModificar.Click += new EventHandler(btnModificar_Click);

            //this.btnEliminar = new IconButton();
            //this.btnEliminar.IconChar = IconChar.Trash;
            //this.btnEliminar.IconSize = 30;
            //this.btnEliminar.Click += new EventHandler(btnEliminar_Click);

            this.btnModificar = new IconButton();
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.IconChar = IconChar.PencilAlt;
            this.btnModificar.IconColor = Color.White;
            this.btnModificar.BackColor = Color.FromArgb(32,30,45);
            this.btnModificar.IconSize = 23;
            this.btnModificar.FlatStyle = FlatStyle.Flat;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.Click += new EventHandler(btnModificar_Click);

            this.btnEliminar = new IconButton();
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.IconChar = IconChar.Trash;
            this.btnEliminar.BackColor = Color.FromArgb(32, 30, 45);
            this.btnEliminar.IconSize = 23;
            this.btnEliminar.IconColor = Color.White;
            this.btnEliminar.FlatStyle = FlatStyle.Flat;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.Click += new EventHandler(btnEliminar_Click);
        }

        protected override void Paint(Graphics graphics, Rectangle clipBounds, Rectangle cellBounds, int rowIndex, DataGridViewElementStates elementState, object value, object formattedValue, string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts)
        {
            base.Paint(graphics, clipBounds, cellBounds, rowIndex, elementState, value, formattedValue, errorText, cellStyle, advancedBorderStyle, paintParts);

            int buttonWidth = 40;
            int buttonHeight = 25;
            int buttonMargin = 5;

            Rectangle rectModificar = new Rectangle(cellBounds.X + buttonMargin, cellBounds.Y + (cellBounds.Height - buttonHeight) / 2, buttonWidth, buttonHeight);
            Rectangle rectEliminar = new Rectangle(cellBounds.X + cellBounds.Width - buttonWidth - buttonMargin, cellBounds.Y + (cellBounds.Height - buttonHeight) / 2, buttonWidth, buttonHeight);

            this.btnModificar.Bounds = rectModificar;
            this.btnEliminar.Bounds = rectEliminar;

            this.btnModificar.Visible = true;
            this.btnEliminar.Visible = true;

            this.btnModificar.Enabled = this.DataGridView.Enabled;
            this.btnEliminar.Enabled = this.DataGridView.Enabled;

            this.DataGridView.Controls.Add(this.btnModificar);
            this.DataGridView.Controls.Add(this.btnEliminar);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            // Code for handling the "Modificar" button click
            // You can access the row index using the RowIndex property of the cell
            int rowIndex = this.RowIndex;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Code for handling the "Modificar" button click
            // You can access the row index using the RowIndex property of the cell        
            var centerPosition = new Point(this.DataGridView.Width / 2, this.DataGridView.Height / 2);
            FmMessageBox fmMessageBox = new FmMessageBox(Tools.MessageBoxType.Warning, "Eliminar", "Esta seguro que desea eliminarlo?", centerPosition,true);
            fmMessageBox.ShowDialog();

            if (fmMessageBox.btnAceptar)
            {
                int rowIndex = 0;
                // Obtener el DataSource del DataGridView
                var dataSource = DataGridView.DataSource;

                // Comprobar que es una lista
                if (dataSource is IList list)
                {
                    // Eliminar los botones de la fila correspondiente
                    foreach (var buttonCell in DataGridView.Rows[rowIndex].Cells)
                    {
                        if (buttonCell is CustomButtonCell)
                        {
                            var button = (CustomButtonCell)buttonCell;
                            foreach (var boton in button.DataGridView.Controls.OfType<IconButton>().ToList())
                            {
                                DataGridView.Controls.Remove(boton);
                            }
                        }
                    }
                    // Eliminar el elemento correspondiente a esa fila
                    list.RemoveAt(rowIndex);

                    // Volver a asignar la lista modificada al DataSource del DataGridView
                    if(list.Count > 0)
                    {
                        DataGridView.DataSource = null;  // Desenlazar temporalmente el DataSource
                        DataGridView.DataSource = list;  // Volver a enlazar con la lista modificada
                    }
                    else
                    {
                        DataGridView.DataSource = new List<DetallePedidosYFabricaEntity>();  // Desenlazar temporalmente el DataSource
                    }
                }
            }
        }

        //private void Button3_Click(object sender, EventArgs e)
        //{
        //    // Do something when button 3 is clicked
        //}
    }
}
