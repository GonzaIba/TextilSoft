using SL.Contracts;
using SL.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.TextilSoft.Tools.FormsTools;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace UI.TextilSoft.SubForms.Configuracion
{
    public partial class FmCompanyConfig : Form
    {
        private readonly ICompanyController _companyController;
        private readonly AuthenticationConfig _authenticationConfig;
        private OpenFileDialog _dialog;
        private CompanyCustomizeEntity _companyCustomizeEntity;
        private string file64;
        public FmCompanyConfig(ICompanyController companyController)
        {
            InitializeComponent();
            _companyController = companyController;
            _authenticationConfig = _companyController.GetAuthenticationConfig();
        }
        private void FmCompanyConfig_Load(object sender, EventArgs e)
        {
            try
            {
                tgBtnEspecial.Checked = _authenticationConfig.PasswordConfig.RequireNonAlphanumeric;
                tgBtnMayus.Checked = _authenticationConfig.PasswordConfig.RequireUppercase;
                tgBtnMinuscula.Checked = _authenticationConfig.PasswordConfig.RequireLowercase;
                tgBtnNumero.Checked = _authenticationConfig.PasswordConfig.RequireDigit;
                txtCarMinimo.Text = _authenticationConfig.PasswordConfig.CountLength.ToString();
                txtMaxFail.Text = _authenticationConfig.MaxFailedAccessAttempts.ToString();
                tgBtnEmailConfirmed.Checked = _authenticationConfig.SignInRequireConfirmedAccount;

                _companyCustomizeEntity = _companyController.GetCustomizeCompany();

                txtColor.BackColor = _companyCustomizeEntity.Color;

                if (_companyCustomizeEntity.Logo != null && _companyCustomizeEntity.Logo != string.Empty)
                {
                    byte[] imageBytes = Convert.FromBase64String(_companyCustomizeEntity.Logo);
                    MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
                    ms.Write(imageBytes, 0, imageBytes.Length);
                    Image image = Image.FromStream(ms, true);
                    pboxLogo.Image = image;
                }

            }
            catch (Exception ex)
            {
                var centerPosition = new Point(this.Width / 2, this.Height / 2);
                FmMessageBox fmMessageBox = new FmMessageBox(Tools.MessageBoxType.Error, "Error de datos", "No se pudo cargar la personalización de la compañía", centerPosition);
                fmMessageBox.ShowDialog();
            }
        }

        private void toggleButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSavePrefPW_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtCarMinimo.Text.Length >= 0)
                {
                    PasswordConfig passwordConfig = new PasswordConfig();
                    passwordConfig.RequireUppercase = tgBtnMayus.Checked;
                    passwordConfig.RequireLowercase = tgBtnMinuscula.Checked;
                    passwordConfig.RequireDigit = tgBtnNumero.Checked;
                    passwordConfig.RequireNonAlphanumeric = tgBtnEspecial.Checked;
                    passwordConfig.CountLength = Convert.ToInt32(txtCarMinimo.Text);
                    _companyController.SavePasswordConfig(passwordConfig);
                    var centerPosition = new Point(this.Width / 2, this.Height / 2);
                    FmMessageBox fmMessageBox = new FmMessageBox(Tools.MessageBoxType.Success, "Guardado con éxito", "Se guardó las preferencias de la contraseñas correctamente!", centerPosition);
                    fmMessageBox.ShowDialog();
                }
                else
                {
                    var centerPosition = new Point(this.Width / 2, this.Height / 2);
                    FmMessageBox fmMessageBox = new FmMessageBox(Tools.MessageBoxType.Error, "Formato inválido", "El mínimo de caracteres para la contraseña deben ser mayor a 0", centerPosition);
                    fmMessageBox.ShowDialog();
                }

            }
            catch (Exception ex)
            {
                var centerPosition = new Point(this.Width / 2, this.Height / 2);
                FmMessageBox fmMessageBox = new FmMessageBox(Tools.MessageBoxType.Error, "Error de guardado", "Ocurrió un error al guardar las preferencias de contraseñas", centerPosition);
                fmMessageBox.ShowDialog();
            }
        }

        private void txtCarMinimo_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtCarMinimo.Text, "[^0-9]"))
            {
                toolTipError.Show("Por favor, solo ingrese números", txtCarMinimo, 2, 2, 2000);
                txtCarMinimo.Text = txtCarMinimo.Text.Remove(txtCarMinimo.Text.Length - 1);
            }
        }

        private void btnChangeColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
                txtColor.BackColor = colorDialog.Color;
        }

        private void btnLogo_Click(object sender, EventArgs e)
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
                        //If file is jpg or png or jpeg then save it to the database
                        pboxLogo.ImageLocation = dialog.FileName.ToString();
                        string path = Path.Combine(@"~\image");

                        //if (!Directory.Exists(path))
                        //{
                        //    Directory.CreateDirectory(path);
                        //}
                        var fileName = System.IO.Path.GetFileName(dialog.FileName);
                        path = path + fileName;
                        //if (Directory.Exists(dialog.FileName+path))
                        //{
                        //    File.Copy(dialog.FileName, path);
                        //}


                        //Convert file to base 64
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

        private void btnSavePersonalization_Click(object sender, EventArgs e)
        {
            try
            {
                CompanyCustomizeEntity companyCustomizeEntity = new CompanyCustomizeEntity();
                if (file64 != string.Empty && file64 != null)
                    companyCustomizeEntity.Logo = file64;
                else
                    companyCustomizeEntity.Logo = _companyCustomizeEntity.Logo;

                companyCustomizeEntity.Color = txtColor.BackColor;

                _companyController.SaveCustomizeCompany(companyCustomizeEntity);

                var centerPosition = new Point(this.Width / 2, this.Height / 2);
                FmMessageBox fmMessageBox = new FmMessageBox(Tools.MessageBoxType.Success, "Guardado con éxito", "Se guardó la personalización de la compañía correctamente!", centerPosition);
                fmMessageBox.ShowDialog();
            }
            catch (Exception ex)
            {
                var centerPosition = new Point(this.Width / 2, this.Height / 2);
                FmMessageBox fmMessageBox = new FmMessageBox(Tools.MessageBoxType.Error, "Error de guardado", ex.Message, centerPosition);
                fmMessageBox.ShowDialog();
            }
        }

        private void txtMaxFail_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtMaxFail.Text, "[^0-9]"))
            {
                toolTipError.Show("Por favor, solo ingrese números", txtMaxFail, 0, -20, 2000);
                txtMaxFail.Text = txtMaxFail.Text.Remove(txtMaxFail.Text.Length - 1);
            }
        }

        private void btnSavePrefAuth_Click(object sender, EventArgs e)
        {
            try
            {
                AuthenticationConfig authenticationConfig = new();
                authenticationConfig.SignInRequireConfirmedAccount = tgBtnEmailConfirmed.Checked;
                authenticationConfig.MaxFailedAccessAttempts = Convert.ToInt32(txtMaxFail.Text);
                _companyController.SaveAuthenticationConfig(authenticationConfig);
                var centerPosition = new Point(this.Width / 2, this.Height / 2);
                FmMessageBox fmMessageBox = new FmMessageBox(Tools.MessageBoxType.Success, "Guardado con éxito", "Se guardó las preferencias de autenticación correctamente!", centerPosition);
                fmMessageBox.ShowDialog();
            }
            catch (Exception ex)
            {
                var centerPosition = new Point(this.Width / 2, this.Height / 2);
                FmMessageBox fmMessageBox = new FmMessageBox(Tools.MessageBoxType.Error, "Error de guardado", ex.Message, centerPosition);
                fmMessageBox.ShowDialog();
            }

        }
    }
}
