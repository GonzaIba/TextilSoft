using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using UI.TextilSoft.Tools.FormsTools;
using System.IO;
using UI.TextilSoft.Factory;
using Contracts.Controllers;
using Domain.Entities.ArmadoProductos;
using UI.TextilSoft.Tools.ExtensionsControls;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace UI.TextilSoft.SubForms.Produccion.GestionarAP
{
    public partial class FmGestionarTransfer : Form
    {
        private readonly IControllerFactory _factory;
        private OpenFileDialog _dialog;
        private string file64;
        public FmGestionarTransfer(IControllerFactory factory)
        {
            InitializeComponent();
            _factory = factory;
        }

        private void btnImagenPrenda_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    //If de file is not jpg or png or jpeg then show error
                    if (Path.GetExtension(dialog.FileName) != ".jpg" && Path.GetExtension(dialog.FileName) != ".png" && Path.GetExtension(dialog.FileName) != ".jpeg")
                    {
                        var centerPosition = new Point(this.Width / 2, this.Height / 2);
                        FmMessageBox fmMessageBox = new FmMessageBox(Tools.MessageBoxType.Error, "Error de imagen", "Solo se permiten archivos con extensión .jpg .png o .jpeg", centerPosition);
                        fmMessageBox.ShowDialog();
                    }
                    else
                    {
                        _dialog = new OpenFileDialog();
                        _dialog = dialog;
                        pBoxImagenTransfer.ImageLocation = dialog.FileName.ToString();
                        string path = Path.Combine(@"~\image");

                        var fileName = System.IO.Path.GetFileName(dialog.FileName);
                        path = path + fileName;

                        byte[] imageArray = System.IO.File.ReadAllBytes(dialog.FileName);
                        string base64ImageRepresentation = Convert.ToBase64String(imageArray);
                        file64 = base64ImageRepresentation;
                    }

                }
            }
            catch (Exception ex)
            {
                var centerPosition = new Point(this.Width / 2, this.Height / 2);
                FmMessageBox fmMessageBox = new FmMessageBox(Tools.MessageBoxType.Error, "Error de imagen", "No se pudo cargar el archivo", centerPosition);
                fmMessageBox.ShowDialog();
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(file64))
            {
                toolTipError.Show("Por favor, complete el campo", pBoxImagenTransfer, 0, -20, 2000);
                return;
            }
            else if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                toolTipError.Show("Por favor, complete el campo", txtCodigo, 0, -20, 2000);
                txtCodigo.Focus();
                return;
            }
            else
            {
                _factory.Use<IArmadoProductoController>().CrearTransfer(new TransferEntity
                {
                    Codigo = txtCodigo.Text,
                    Imagen = file64
                });
                var centerPosition = new Point(this.Width / 2, this.Height / 2);
                FmMessageBox fmMessageBox = new FmMessageBox(Tools.MessageBoxType.Success, "Transfer creado", "El transfer se creó correctamente", centerPosition);
                fmMessageBox.ShowDialog();
                txtCodigo.LimpiarTextbox();
                file64 = string.Empty;

            }

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Length > 4)
            {
                var posibleCodigoCreado = _factory.UseNew<IArmadoProductoController>().ObtenerTransfer(txtCodigo.Text).FirstOrDefault();
                if (posibleCodigoCreado != null)
                {
                    toolTipError.Show("Ese código ya existe!", txtCodigo, 0, -20, 2000);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var posibleCodigoCreado = _factory.UseNew<IArmadoProductoController>().ObtenerTransfer(txtTransferBuscar.Text).FirstOrDefault();
            if (posibleCodigoCreado != null)
            {
                //Convert Logo to Image
                byte[] imageBytes = Convert.FromBase64String(posibleCodigoCreado.Imagen);
                MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
                ms.Write(imageBytes, 0, imageBytes.Length);
                Image image = Image.FromStream(ms, true);
                pBoxImagenTransferBuscar.Image = image;
            }
            else
            {
                var centerPosition = new Point(this.Width / 2, this.Height / 2);
                FmMessageBox fmMessageBox = new FmMessageBox(Tools.MessageBoxType.Error, "No encontrado", "No se encontró el transfer con ese código", centerPosition);
                fmMessageBox.ShowDialog();
            }
        }
    }
}
