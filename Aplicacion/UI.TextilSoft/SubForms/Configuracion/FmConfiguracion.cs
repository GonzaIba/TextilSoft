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

namespace UI.TextilSoft.SubForms.Configuracion
{
    public partial class FmConfiguracion : Form
    {
        private float volume, lastvalue;
        private readonly IControllerFactory _factory;
        private readonly Usuario _usuario;
        private readonly FmTextilSoft _fmTextilSoft;
        public FmConfiguracion(IControllerFactory factory, FmTextilSoft fmTextilSoft)
        {
            InitializeComponent();
            _factory = factory;
            _fmTextilSoft = fmTextilSoft;
            _usuario = _fmTextilSoft._user;
            macTrackBar1.Value = _usuario.Volume == 0 ? 0 : _usuario.Volume / 10;
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
            _usuario.EnableAnimators = tbAnimator.Checked;
            _usuario.EnableSlicePanel = tbSlice.Checked;
            _usuario.EnableVolume = tbSound.Checked;
            _usuario.Volume = (int)(volume * 10);
            _factory.Use<IUsuarioController>().Actualizarusuario(_usuario);
            _fmTextilSoft._user = _factory.Use<IUsuarioController>().ObtenerUsuarioConPermisos(Convert.ToInt32(_fmTextilSoft._user.DNI));
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
    }
}
