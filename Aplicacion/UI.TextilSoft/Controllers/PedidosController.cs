﻿using AutoMapper;
using Contracts.Controllers;
using Contracts.Services;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.TextilSoft.Controllers
{
    public class PedidosController : IPedidosController
    {
        private readonly IPedidosService _pedidosService;
        private readonly IMapper _mapper;
        public PedidosController(IPedidosService pedidosService, IMapper mapper)
        {
            _pedidosService = pedidosService;
            _mapper = mapper;
        }
        public List<ListarPedidosEntity> ObtenerPedidos()
        {
            var ListaPedidosModel = _pedidosService.Get(includeProperties:"Empleados,Clientes").ToList();
            var ListaPedidosEntity = new List<ListarPedidosEntity>();
            foreach (var item in ListaPedidosModel)
            {
                ListaPedidosEntity.Add(_mapper.Map<ListarPedidosEntity>(item));
            }
            return ListaPedidosEntity;
        }
    }
}
