using Contracts.Controllers;
using Domain.Entities;
using SL.Contracts;
using SL.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.TextilSoft.Factory;
using UI.TextilSoft.Tools;
using UI.TextilSoft.Tools.FormsTools;

namespace UI.TextilSoft.SubForms.Configuracion
{
    public partial class FmLogs : Form
    {
        private readonly Usuario _usuario;
        private readonly IControllerFactory _factory;
        private int TotalLines = 0, TotalPages = 0;
        private string Archivo = string.Empty;
        private int PageCount = 15, PageIndex;
        private bool FirstTime, isLastPage, isFirstPage;
        private bool MantenerFiltroFechas, DateChanged;
        private string userFilter = "";
        private LogEnum typeMessageFilter;
        private List<string> listaLineasFatal = new();

        private int IndexBtnPrimero, IndexBtnSegundo, IndexBtnTercero;
        public FmLogs(Usuario usuario, IControllerFactory factory)
        {
            _usuario = usuario;
            _factory = factory;
            InitializeComponent();
        }

        private void FmLogs_Load(object sender, EventArgs e)
        {
            typeMessageFilter = LogEnum.All;
            PageIndex = 1;
            IndexBtnPrimero = 1;
            IndexBtnSegundo = 2;
            IndexBtnTercero = 3;

            cboxFileType.SelectedIndex = 0;
            if (cboxFileType.SelectedIndex == 0)
                Archivo = "\\LogerManager.txt";
            else
                Archivo = "\\Performance.txt";
            var Usuarios = _factory.UseNew<IUsuarioController>().ObtenerUsuarios(_usuario.IsOwner).ToList();
            cboxUsuarios.Items.Add("None");
            Usuarios.ForEach(x =>
            {
                cboxUsuarios.Items.Add(x.Nombre);
            });
            LeerLog();
            btnFinal.Text = "..." + TotalPages;
        }


        private void LeerLog()
        {
            try
            {
                lbLog.Items.Clear();
                int CantLineas = 0, pageCount = 1, totalLineas = 0;
                bool isFirstLine = true;
                using (StreamReader streamReader = new StreamReader(AppDomain.CurrentDomain.GetData("TemphLog").ToString() + Archivo))
                {
                    while (!streamReader.EndOfStream)
                    {
                        string LineaLogger = streamReader.ReadLine();
                        if (isFirstLine)
                        {
                            CantLineas--;
                            isFirstLine = false;
                        }
                        string fecha = LineaLogger != string.Empty ? LineaLogger.Substring(0, 10) : "";
                        CantLineas++;
                        if (!DateChanged)
                        {
                            if (CantLineas == PageCount)
                            {
                                pageCount++;
                                CantLineas = 0;
                            }
                            if (pageCount == PageIndex)
                            {
                                if (typeMessageFilter == LogEnum.All && LineaLogger.Contains(userFilter))
                                {
                                    lbLog.Items.Add(LineaLogger);
                                    totalLineas++;
                                }
                                else if (LineaLogger.Contains(typeMessageFilter == LogEnum.Information ? "INFO" : typeMessageFilter.ToString().ToUpper()) && LineaLogger.Contains("Usuario: " + userFilter))
                                {
                                    lbLog.Items.Add(LineaLogger);
                                    totalLineas++;
                                }
                                else
                                    CantLineas--;
                            }
                            else
                            {
                                totalLineas++;
                            }
                        }
                        else
                        {
                            if (Regex.IsMatch(fecha, "\\d{2,4}[/| -]\\d{1,2}[/| -]\\d{1,2}"))
                            {
                                if (Convert.ToDateTime(fecha) >= fmDateDesde.Value && Convert.ToDateTime(fecha) <= fmDateHasta.Value)
                                {
                                    if (CantLineas == PageCount)
                                    {
                                        pageCount++;
                                        CantLineas = 0;
                                    }
                                    if (pageCount == PageIndex)
                                    {
                                        if (typeMessageFilter == LogEnum.All && LineaLogger.Contains(userFilter))
                                        {
                                            lbLog.Items.Add(LineaLogger);
                                            totalLineas++;
                                        }
                                        else if (LineaLogger.Contains(typeMessageFilter == LogEnum.Information ? "INFO" : typeMessageFilter.ToString().ToUpper()) && LineaLogger.Contains(userFilter))
                                        {
                                            lbLog.Items.Add(LineaLogger);
                                            totalLineas++;
                                        }
                                        else
                                            CantLineas--;
                                    }
                                    else
                                    {
                                        totalLineas++;
                                    }
                                }
                                else
                                {
                                    CantLineas--;

                                }
                            }
                            else
                            {
                                //Si cae acá, es porque puede ser un mensaje largo que se incrustó en la linea de abajo
                                //Por ende tenemos que anexar esta linea con la anterior
                                if (CantLineas == PageCount)
                                {
                                    pageCount++;
                                    CantLineas = 0;
                                }

                                if (pageCount == PageIndex)
                                {
                                    lbLog.Items.Add(LineaLogger);
                                    totalLineas++;
                                }
                                else
                                {
                                    totalLineas++;
                                }
                            }
                        }
                    }
                    TotalLines = totalLineas;
                    TotalPages = (int)Math.Ceiling(TotalLines / (double)PageCount);
                    ActualizarBotones();
                    VerificarPaginas();
                    btnFinal.Text = "..." + TotalPages;
                }
            }
            catch (Exception ex)
            {
                var centerPosition = new Point(this.Width / 2, this.Height / 2);
                FmMessageBox fmMessageBox = new FmMessageBox(MessageBoxType.Error, "Error al leer el archivo de log", "Por motivos del sistema no se pudieron cargar los logs. Intente nuevamente mas tarde!", centerPosition);
                fmMessageBox.ShowDialog();
            }
            
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            listaLineasFatal = new List<string>();
            PageIndex = 1;
            IndexBtnPrimero = 1;
            IndexBtnSegundo = 2;
            IndexBtnTercero = 3;
            LeerLog();
            ActualizarBotones();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < PageCount * 2; i++) //Aca sacamos las ultimas N lineas de la lista
            {
                if (listaLineasFatal.Count - 1 > 0)
                    listaLineasFatal.RemoveAt(listaLineasFatal.Count - 1);
            }

            if (PageIndex > 1)
            {
                if (PageIndex == IndexBtnPrimero)
                {
                    IndexBtnPrimero--;
                    IndexBtnSegundo--;
                    IndexBtnTercero--;
                }
                PageIndex--;
                LeerLog();
            }
            ActualizarBotones();
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < PageCount * 2; i++) //Aca sacamos las ultimas N lineas de la lista
            {
                if (listaLineasFatal.Count - 1 > 0)
                    listaLineasFatal.RemoveAt(listaLineasFatal.Count - 1);
            }

            isLastPage = false;
            if (PageIndex == 1)
            {
                isFirstPage = true;
                PageIndex = IndexBtnPrimero;
                btnAnterior.Enabled = false;
                listaLineasFatal = new List<string>();
            }
            if (!isFirstPage)
            {
                if (IndexBtnPrimero != 1)
                {
                    IndexBtnPrimero -= 1;
                    IndexBtnSegundo -= 1;
                    IndexBtnTercero -= 1;
                    PageIndex = IndexBtnSegundo;
                    btnAnterior.Enabled = true;
                }
                else
                {
                    PageIndex = IndexBtnPrimero;
                    listaLineasFatal = new List<string>();
                }
            }
            else if (PageIndex - 1 == 1)
            {
                listaLineasFatal = new List<string>();
                PageIndex = IndexBtnPrimero;
            }


            LeerLog();
            ActualizarBotones();
        }

        private void btnSegundo_Click(object sender, EventArgs e)
        {
            isFirstPage = false;
            isLastPage = false;
            PageIndex = IndexBtnSegundo;
            LeerLog();
            ActualizarBotones();
        }

        private void btnTercero_Click(object sender, EventArgs e)
        {
            isFirstPage = false;
            if (PageIndex == TotalPages)
            {
                isLastPage = true;
                PageIndex = IndexBtnTercero;
            }
            if (!isLastPage)
            {
                if (IndexBtnTercero != TotalPages)
                {
                    IndexBtnPrimero = IndexBtnSegundo;
                    IndexBtnSegundo = IndexBtnTercero;
                    IndexBtnTercero++;
                    PageIndex = IndexBtnSegundo;
                }
                else
                    PageIndex = IndexBtnTercero;
            }
            LeerLog();
            ActualizarBotones();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (PageIndex < TotalPages)
            {
                if (PageIndex == IndexBtnTercero)
                {
                    IndexBtnPrimero++;
                    IndexBtnSegundo++;
                    IndexBtnTercero++;
                }
                PageIndex++;
                LeerLog();
            }
            ActualizarBotones();
        }

        private void btnFinal_Click(object sender, EventArgs e)
        {
            if (TotalPages > 2)
            {
                PageIndex = TotalPages;
                IndexBtnPrimero = TotalPages - 2;
                IndexBtnSegundo = TotalPages - 1;
                IndexBtnTercero = TotalPages;
            }
            PageIndex = TotalPages;
            LeerLog();
            ActualizarBotones();
        }







        private void ActualizarBotones()
        {
            btnPrimero.Text = IndexBtnPrimero.ToString();
            btnSegundo.Text = IndexBtnSegundo.ToString();
            btnTercero.Text = IndexBtnTercero.ToString();
            if (PageIndex == TotalPages)
                btnSiguiente.Enabled = false;
            else
                btnSiguiente.Enabled = true;

            if (PageIndex == 1)
                btnAnterior.Enabled = false;
            else
                btnAnterior.Enabled = true;

            if (btnPrimero.Text == PageIndex.ToString())
                btnPrimero.BackColor = Color.FromArgb(40, 40, 40);
            else
                btnPrimero.BackColor = Color.FromArgb(32, 30, 45);

            if (btnSegundo.Text == PageIndex.ToString())
                btnSegundo.BackColor = Color.FromArgb(40, 40, 40);
            else
                btnSegundo.BackColor = Color.FromArgb(32, 30, 45);

            if (btnTercero.Text == PageIndex.ToString())
                btnTercero.BackColor = Color.FromArgb(40, 40, 40);
            else
                btnTercero.BackColor = Color.FromArgb(32, 30, 45);
        }


        private void VerificarPaginas()
        {
            if (TotalPages >= 3)
            {
                btnTercero.Enabled = true;
                btnSegundo.Enabled = true;
            }
            else if (TotalPages < 2)
            {
                btnTercero.Enabled = false;
                btnSegundo.Enabled = false;
            }
            else if (TotalPages < 3)
            {
                btnTercero.Enabled = false;
                btnSegundo.Enabled = true;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cboxUsuarios.SelectedIndex = 0;
            typeMessageFilter = LogEnum.All;

            fmDateDesde.Value = fmDateHasta.Value;
            fmDateDesde.Value = fmDateDesde.Value.AddMinutes(-1);

            fmDateHasta.Value = DateTime.Now;
            fmDateHasta.Value = fmDateDesde.Value.AddMinutes(1);

            DateChanged = false;

            ReiniciarLog();
            LeerLog();
        }

        private void btnError_Click(object sender, EventArgs e)
        {
            ReiniciarLog();
            typeMessageFilter = LogEnum.Error;
            LeerLog();
        }

        private void btnWarning_Click(object sender, EventArgs e)
        {
            ReiniciarLog();
            typeMessageFilter = LogEnum.Information;
            LeerLog();
        }

        private void btnCritical_Click(object sender, EventArgs e)
        {
            ReiniciarLog();
            typeMessageFilter = LogEnum.Critical;
            LeerLog();
        }

        private void btnFatal_Click(object sender, EventArgs e)
        {
            ReiniciarLog();
            typeMessageFilter = LogEnum.Fatal;
            LeerLog();
        }

        private void cboxFileType_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxFileType.SelectedIndex == 0)
            {
                Archivo = "\\LogerManager.txt";
                cboxUsuarios.Enabled = true;
            }
            else
            {
                Archivo = "\\Performance.txt";
                cboxUsuarios.Enabled = false;
            }

            typeMessageFilter = LogEnum.All;
            ReiniciarLog();
            LeerLog();
        }

        private void cboxUsuarios_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxUsuarios.SelectedIndex == 0)
                userFilter = "";
            else
                userFilter = cboxUsuarios.Texts;

            LeerLog();
        }


        private void ReiniciarLog()
        {
            PageIndex = 1;
            IndexBtnPrimero = 1;
            IndexBtnSegundo = 2;
            IndexBtnTercero = 3;
        }

        private void fmDateHasta_ValueChanged(object sender, EventArgs e)
        {
            if (fmDateHasta.Value < fmDateDesde.Value)
            {
                var centerPosition = new Point(this.Width / 2, this.Height / 2);
                FmMessageBox fmMessageBox = new FmMessageBox(Tools.MessageBoxType.Error, "Error de fecha", "La fecha hasta no puede ser inferior a la fecha desde", centerPosition);
                fmMessageBox.ShowDialog();
                fmDateHasta.Value = DateTime.Now;
                fmDateHasta.Value = fmDateDesde.Value.AddMinutes(1);
            }
            else
            {
                DateChanged = true;
                LeerLog();
                btnFinal.Text = "..." + TotalPages.ToString();
                if (TotalPages > 2)
                {
                    IndexBtnPrimero = TotalPages - 2;
                    IndexBtnSegundo = TotalPages - 1;
                    IndexBtnTercero = TotalPages;
                }
                else
                {
                    IndexBtnPrimero = 1;
                    IndexBtnSegundo = 2;
                    IndexBtnTercero = 3;
                }
                PageIndex = 1;
                VerificarPaginas();
                ActualizarBotones();
            }
        }

        private void fmDateDesde_ValueChanged(object sender, EventArgs e)
        {
            if (fmDateDesde.Value > fmDateHasta.Value || fmDateDesde.Value > DateTime.Now)
            {
                var centerPosition = new Point(this.Width / 2, this.Height / 2);
                FmMessageBox fmMessageBox = new FmMessageBox(Tools.MessageBoxType.Error, "Error de fecha", "La fecha desde no puede ser superior a la fecha hasta o a la fecha actual", centerPosition);
                fmMessageBox.ShowDialog();
                fmDateDesde.Value = fmDateHasta.Value;
                //Sacar un minuto al datetime
                fmDateDesde.Value = fmDateDesde.Value.AddMinutes(-1);
            }
            else
            {
                DateChanged = true;
                LeerLog();
                btnFinal.Text = "..." + TotalPages.ToString();
                IndexBtnPrimero = 1;
                IndexBtnSegundo = 2;
                IndexBtnTercero = 3;
                PageIndex = 1;
                VerificarPaginas();
                ActualizarBotones();
            }
        }
    }
}
