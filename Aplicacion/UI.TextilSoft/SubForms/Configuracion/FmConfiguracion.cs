using NAudio.Wave;
using SL.Contracts;
using SL.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using UI.TextilSoft.Factory;
using UI.TextilSoft.MainForm;
using UI.TextilSoft.Tools.FormsTools;

namespace UI.TextilSoft.SubForms.Configuracion
{
    public partial class FmConfiguracion : Form
    {
        private float volume, lastvalue;
        private readonly IControllerFactory _factory;
        private readonly Usuario _usuario;
        private readonly UsuarioInformacion _usuarioInformacion;
        private readonly FmTextilSoft _fmTextilSoft;
        public FmConfiguracion(IControllerFactory factory, FmTextilSoft fmTextilSoft)
        {
            InitializeComponent();
            _factory = factory;
            _fmTextilSoft = fmTextilSoft;
            _usuario = _fmTextilSoft._user;
            _usuarioInformacion = _factory.Use<IUsuarioController>().ObtenerInformacionUsuario(_usuario);
            txtNombre.Text = _usuarioInformacion.Nombre;
            txtEmail.Text = _usuarioInformacion.Email;
            txtCelular.Text = _usuarioInformacion.Celular;
            txtDNI.Text = _usuarioInformacion.DNI.ToString();

            tbAnimator.Checked = _usuarioInformacion.EnableAnimators;
            tbSlice.Checked = _usuarioInformacion.EnableSlicePanel;
            tbSound.Checked = _usuarioInformacion.EnableVolume;

            macTrackBar1.Value = _usuario.Volume == 0 ? 0 : _usuario.Volume / 10;
            _fmTextilSoft.Size = new Size(1050, 600);
        }

        private async void macTrackBar1_ValueChanged(object sender, decimal value)
        {
            volume = (float)value / 10;
            if (volume == 0)
                iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.VolumeMute;
            else
            {
                if (volume < 0.5)
                    iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.VolumeDown;
                else
                    iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.VolumeUp;
            }

        }

        private async Task SonidoForm()
        {
            await Task.Run(() =>
            {
                using (var waveOut = new WaveOutEvent())
                using (var fileStream = new WaveFileReader("D:/Repositorios-SmartGit/TextilSoft/Aplicacion/UI.TextilSoft/bin/Debug/net5.0-windows/SoundForms/AbrirFormulario.wav"))
                {
                    waveOut.Init(fileStream);
                    waveOut.Volume = volume;
                    waveOut.Play();
                    while (waveOut.PlaybackState == PlaybackState.Playing)
                    {
                        System.Threading.Thread.Sleep(10);
                    }
                }
            });
        }

        private void btnSavePrefApp_Click(object sender, EventArgs e)
        {
            try
            {
                _usuario.EnableAnimators = tbAnimator.Checked;
                _usuario.EnableSlicePanel = tbSlice.Checked;
                _usuario.EnableVolume = tbSound.Checked;
                _usuario.Volume = (int)(volume * 10);

                UsuarioInformacion usuarioInformacion = new();
                usuarioInformacion.Id = _usuario.Id;
                usuarioInformacion.EnableAnimators = tbAnimator.Checked;
                usuarioInformacion.EnableSlicePanel = tbSlice.Checked;
                usuarioInformacion.EnableVolume = tbSound.Checked;
                usuarioInformacion.Volume = (int)(volume * 10);

                _factory.Use<IUsuarioController>().ActualizarConfiguracionUsuario(usuarioInformacion);
                _fmTextilSoft._user = _factory.Use<IUsuarioController>().ObtenerUsuarioConPermisos(Convert.ToInt32(_fmTextilSoft._user.DNI));
                _fmTextilSoft._usuarioInformacion = _factory.Use<IUsuarioController>().ObtenerInformacionUsuario(_usuario);
                var centerPosition = new Point(this.Width / 2, this.Height / 2);
                FmMessageBox fmMessageBox = new FmMessageBox(Tools.MessageBoxType.Success, "Guardado exitoso", "Se guardaron tus preferencias de aplicación correctamente", centerPosition);
                fmMessageBox.ShowDialog();
            }
            catch (Exception)
            {
                var centerPosition = new Point(this.Width / 2, this.Height / 2);
                FmMessageBox fmMessageBox = new FmMessageBox(Tools.MessageBoxType.Error, "Error de aplicación", "No pudo guardar las configuraciones, intente mas tarde o contacte con el soporte", centerPosition);
                fmMessageBox.ShowDialog();
            }
        }

        private void macTrackBar1_MouseUp(object sender, MouseEventArgs e)
        {
            if (lastvalue != volume)
            {
                SonidoForm();
                // Ejecutar el sonido aquí
            }
            lastvalue = volume;
        }

        private void btnSaveUserData_Click(object sender, EventArgs e)
        {
            try
            {
                //var centerPosition = new Point(this.Width / 2, this.Height / 2);
                //FmInput fmInput = new FmInput("Ingrese su contraseña para guardar los cambios",
                //                                Color.Black,
                //                                centerPosition,
                //                                null,
                //                                _factory.Use<IUsuarioController>().CambiarContraseña,
                //                                "Contraseña",
                //                                "Guardar"
                //                                );
                //fmInput.ShowDialog();
            }
            catch (Exception)
            {
                var centerPosition = new Point(this.Width / 2, this.Height / 2);
                FmMessageBox fmMessageBox = new FmMessageBox(Tools.MessageBoxType.Error, "Error de aplicación", "No pudo guardar las configuraciones, intente mas tarde o contacte con el soporte", centerPosition);
                fmMessageBox.ShowDialog();
            }
        }

        private void FmConfiguracion_Load(object sender, EventArgs e)
        {

        }

        private void btnSaveNewPassword_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtOldPassword.Text) || string.IsNullOrEmpty(txtNewPassword.Text) || string.IsNullOrEmpty(txtConfirmNewPassword.Text))
            {
                var centerPosition = new Point(this.Width / 2, this.Height / 2);
                FmMessageBox fmMessageBox = new FmMessageBox(Tools.MessageBoxType.Warning, "Campos vacios", "Por favor complete los campos vacios", centerPosition);
                fmMessageBox.ShowDialog();
            }
            else if (txtNewPassword.Text == txtConfirmNewPassword.Text)
            {
                var centerPosition = new Point(this.Width / 2, this.Height / 2);
                FmMessageBox fmMessageBox = new FmMessageBox(Tools.MessageBoxType.Warning, "Cambiar contraseña", "Esta seguro que quiere cambiar su contraseña?", centerPosition, true);
                fmMessageBox.ShowDialog();
                var result = fmMessageBox.btnAceptar;
                if (result)
                {
                    bool IsChanged = false;
                    IsChanged = _factory.Use<IUsuarioController>().CambiarContraseña(_usuario.Id, txtOldPassword.Text, txtNewPassword.Text);
                    if (IsChanged)
                    {
                        FmMessageBox fmMessageBox2 = new FmMessageBox(Tools.MessageBoxType.Success, "Guardado exitoso", "Las contraseña se guardó correctamente", centerPosition);
                        fmMessageBox2.ShowDialog();
                    }
                    else
                    {
                        FmMessageBox fmMessageBox2 = new FmMessageBox(Tools.MessageBoxType.Error, "Error de guardado", "Las contraseñas no coinciden o la contraseña es igual a la anterior", centerPosition);
                        fmMessageBox2.ShowDialog();
                    }
                }

            }
            else
            {
                var centerPosition = new Point(this.Width / 2, this.Height / 2);
                FmMessageBox fmMessageBox = new FmMessageBox(Tools.MessageBoxType.Error, "Error de contraseña", "Las contraseñas no coinciden", centerPosition);
                fmMessageBox.ShowDialog();
            }
        }
    }
}
