﻿using AutoMapper;
using BookStore.Server.API.DTO;
using BookStore.Server.BLL.Interfaces;
using BookStore.Server.BLL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Threading.Tasks;

namespace BookStore.Server.API.DtoHandlers
{
    public class OrderHandler
    {
        private readonly IOrderService _orderService;
        private readonly IMapper _mapper;

        public OrderHandler(IOrderService orderService, IMapper mapper)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _orderService = orderService ?? throw new ArgumentNullException(nameof(orderService));
        }

        public async Task<List<OrderReadDto>> GetOrderListAsync()
        {
            var orderModels = await _orderService.GetOrderListAsync();
            return _mapper.Map<List<OrderReadDto>>(orderModels);
        }

        public async Task<OrderReadDto> SaveOrderAsync(OrderCreateDto orderCreateDto)
        {
            var orderModel = _mapper.Map<OrderModel>(orderCreateDto);
            await _orderService.SaveOrderAsync(orderModel);

            var orderReadDto = _mapper.Map<OrderReadDto>(orderModel);
            return orderReadDto;
        }

        public async Task DeleteOrderAsync(int id)
        {
            await _orderService.DeleteOrderAsync(id);

        }
    }
}
