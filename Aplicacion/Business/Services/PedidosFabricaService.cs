using AutoMapper;
using Contracts.Repositories;
using Contracts.Services;
using Domain.Enum;
using Domain.GenericEntity;
using Domain.Models;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class PedidosFabricaService : GenericService<PedidosFabricaModel>, IPedidosFabricaService
    {
        private readonly IMapper _mapper;
        private readonly IEmpleadosService _empleadosService;
        public PedidosFabricaService(IUnitOfWork unitOfWork, IMapper mapper, IEmpleadosService empleadosService)
            : base(unitOfWork, unitOfWork.GetRepository<IPedidosFabricaRepository>())
        {
            _mapper = mapper;
            _empleadosService = empleadosService;
        }

        public void AsignarODT(int idPedido)
        {
            try
            {
                var pedido = Get(x => x.ID_PedidosFabrica == idPedido,
                includeProperties: "DetallePedido,DetallePedido.Producto,DetallePedido.Transfer,DetallePedido.Producto.TelaBase,DetallePedido.Producto.TelaCombinacion,DetallePedido.Producto.BolsilloInterior,DetallePedido.Producto.CinturaInterior,DetallePedido.Producto.Collareta,DetallePedido.Producto.Lazo,DetallePedido.Producto.Vivo,DetallePedido.Producto.Forreria" +
                "", tracking: true).FirstOrDefault();

                string rutaBaseTemp = AppDomain.CurrentDomain.GetData("TempPath-ODT").ToString() + pedido.ID_PedidosFabrica.ToString();
                if (!Directory.Exists(rutaBaseTemp))
                    Directory.CreateDirectory(rutaBaseTemp);

                foreach (var detalle in pedido.DetallePedidosFabrica)
                {
                    Dictionary<string, string> dicBasico = new();
                    byte[] data = new byte[128];
                    string NombreYRutaPDF = rutaBaseTemp + "\\" + AppDomain.CurrentDomain.GetData("TempPathName-ODT").ToString();

                    dicBasico.Add("txt_orden_armado", pedido.ID_PedidosFabrica.ToString());
                    dicBasico.Add("txt_temporada", "INV-23");
                    dicBasico.Add("txt_artículo", detalle.Producto.ID_Producto.ToString());
                    dicBasico.Add("txt_descripcion", detalle.Producto.Descripcion);
                    dicBasico.Add("txt_composicion", detalle.Producto.Composicion);

                    dicBasico.Add("txt_codigo_tela_base", detalle.Producto.TelaBase.Codigo == "0" ? "NO LLEVA" : detalle.Producto.TelaBase.Codigo);
                    dicBasico.Add("txt_tela_base", detalle.Producto.TelaBase.Nombre);

                    dicBasico.Add("txt_codigo_combinacion", detalle.Producto.TelaCombinacion.Codigo == "0" ? "NO LLEVA" : detalle.Producto.TelaCombinacion.Codigo);
                    dicBasico.Add("txt_combinacion", detalle.Producto.TelaCombinacion.Nombre);

                    dicBasico.Add("txt_codigo_bolsillo_int", detalle.Producto.BolsilloInterior.Codigo == "0" ? "NO LLEVA" : detalle.Producto.BolsilloInterior.Codigo);
                    dicBasico.Add("txt_bolsillo_int", detalle.Producto.BolsilloInterior.Nombre);

                    dicBasico.Add("txt_codigo_lazo", detalle.Producto.Lazo.Codigo == "0" ? "NO LLEVA" : detalle.Producto.Lazo.Codigo);
                    dicBasico.Add("txt_lazo", detalle.Producto.Lazo.Nombre);

                    dicBasico.Add("txt_codigo_vivo", detalle.Producto.Vivo.Codigo == "0" ? "NO LLEVA" : detalle.Producto.Vivo.Codigo);
                    dicBasico.Add("txt_vivo", detalle.Producto.Vivo.Nombre);

                    dicBasico.Add("txt_codigo_forreria", detalle.Producto.Forreria.Codigo == "0" ? "NO LLEVA" : detalle.Producto.Forreria.Codigo);
                    dicBasico.Add("txt_forreria", detalle.Producto.Forreria.Nombre);

                    dicBasico.Add("txt_codigo_transfer", detalle.Transfer.Codigo == "0" ? "NO LLEVA" : detalle.Transfer.Codigo);
                    dicBasico.Add("txt_pedido_especial", "NO");

                    dicBasico.Add("img_prenda", detalle.Producto.ImagenPrenda);
                    dicBasico.Add("img_transfer", detalle.Transfer.Imagen);

                    RellenarPdf(AppDomain.CurrentDomain.GetData("TemplatePath-ODT") + "Orden-De-Trabajo.pdf", dicBasico, ref data, NombreYRutaPDF, pedido.ID_PedidosFabrica, false);
                    string pathODT = NombreYRutaPDF + pedido.ID_PedidosFabrica.ToString() + ".pdf";

                    File.WriteAllBytes(pathODT, data);
                }


                pedido.ID_EstadoPedidoFabrica = (int)EstadoPedidosFabricaEnum.EnProduccion;
                _repository.Update(pedido);
                _unitOfWork.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public string CrearPedidoParaFabrica(int DNIEmpleado, List<DetallePedidosFabricaModel> detallePedidos)
        {
            PedidosFabricaModel pedidosModel = new();
            try
            {
                var detallePedidoRepository = _unitOfWork.GetRepository<IDetallePedidosFabricaRepository>();
                var productoRepository = _unitOfWork.GetRepository<IProductosRepository>();

                var empleado = _empleadosService.Get(x => x.DNI == DNIEmpleado, tracking: false).FirstOrDefault();
                if (empleado == null)
                    return "El empleado no existe";

                pedidosModel.ID_Empleados = empleado.ID_Empleados;
                pedidosModel.CreateUser = empleado.ID_Empleados;

                Crear(pedidosModel);
                _unitOfWork.SaveChanges();
                foreach (var detallePedido in detallePedidos)
                {
                    detallePedido.ID_PedidosFabrica = pedidosModel.ID_PedidosFabrica;
                    detallePedidoRepository.Insert(detallePedido);
                    _unitOfWork.SaveChanges();
                }
                return "OK";
            }
            catch (Exception ex)
            {
                Eliminar(pedidosModel);
                _unitOfWork.SaveChanges();
                //CancelChanges(pedidosModel);
                return "Ocurrió un error al crear el pedido";
            }
        }

        public PaginatedList<PedidosFabricaModel> ObtenerPedidos(int pageIndex, int pageCount, Expression<Func<PedidosFabricaModel, dynamic>> orderByExpression, Expression<Func<PedidosFabricaModel, bool>> filterExpression, string orderBy, bool ascending)
        {
            PaginatedList<PedidosFabricaModel> ListapedidosModel = new();
            try
            {
                ListapedidosModel = _repository.GetPagedElements(pageIndex, pageCount, orderByExpression, ascending, filterExpression, "Empleados", tracking: false);
                return ListapedidosModel;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public PaginatedList<PedidosFabricaModel> ObtenerTodosLosPedidos(int pageCount)
        {
            try
            {
                var Pedidos = _repository.Get(includeProperties: "Empleados", tracking: false).ToList();
                return new PaginatedList<PedidosFabricaModel>
                {
                    TotalCount = Pedidos.Count(),
                    TotalPages = (int)Math.Ceiling(Pedidos.Count() / (double)pageCount),
                    List = Pedidos
                };
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        #region GenerarPDF
        public void RellenarPdf(string templatePathFileName, Dictionary<string, string> dicBasico, ref byte[] strFileContent, string tempPathFileName = "ArchivoPDF", int numeroIdentificador = 0, bool encripted = false)
        {
            string strFormVacioPath = templatePathFileName;
            string strFormLlenoPath = tempPathFileName + numeroIdentificador.ToString() + ".pdf";

            try
            {
                using (FileStream fileOutput = new FileStream(strFormLlenoPath, FileMode.Create))
                {
                    PdfReader pdfReader = new PdfReader(strFormVacioPath);
                    PdfStamper pdfStamper = new PdfStamper(pdfReader, fileOutput);
                    if (encripted)
                    {
                        pdfStamper.SetEncryption(PdfWriter.STRENGTH128BITS, null, "123456", PdfWriter.AllowCopy | PdfWriter.AllowPrinting);
                    }
                    AcroFields pdfFormFields = pdfStamper.AcroFields;
                    PdfContentByte pdfContentByte = pdfStamper.GetOverContent(1);
                    IDictionary<string, AcroFields.Item> dicFields = pdfFormFields.Fields;

                    foreach (var CollectionItem in dicFields)
                    {
                        if (dicBasico.ContainsKey(CollectionItem.Key))
                        {
                            if (CollectionItem.Key.StartsWith("img_"))
                            {
                                //byte[] imageArray = System.IO.File.ReadAllBytes(dicBasico[CollectionItem.Key]);
                                //string image = Convert.ToBase64String(imageArray);
                                pdfFormFields.SetField(CollectionItem.Key, dicBasico[CollectionItem.Key]);
                            }
                            else
                                pdfFormFields.SetField(CollectionItem.Key, dicBasico[CollectionItem.Key]);
                        }
                    }

                    pdfStamper.FormFlattening = false;
                    pdfStamper.Close();
                    pdfReader.Close();
                    pdfContentByte.ClosePath();
                }

                if (File.Exists(strFormLlenoPath))
                {
                    strFileContent = File.ReadAllBytes(strFormLlenoPath);
                    File.Delete(strFormLlenoPath);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
