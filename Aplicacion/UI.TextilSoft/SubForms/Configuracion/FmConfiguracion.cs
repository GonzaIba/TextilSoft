using NAudio.Wave;
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

namespace UI.TextilSoft.SubForms.Configuracion
{
    public partial class FmConfiguracion : Form
    {
        private float volume, lastvalue;
        public FmConfiguracion()
        {
            InitializeComponent();
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
