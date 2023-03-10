﻿using FarmFresh.Application.Dto.Request.Products;
using FarmFresh.Application.Dto.Response.Products;
using FarmFresh.Application.Interfaces.Services.Products;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FarmFresh.Api.Controllers.Products
{
    [Route("api/order-management")]
    [ApiController]
    [Authorize]
    public class OrderController : ApiControllerBase
    {
        #region Fields
        private readonly IOrderService _orderService;
        #endregion Fields

        #region Constructor

        public OrderController(
                IOrderService orderService
            )
        {
            _orderService = orderService;
        }

        #endregion Constructor

        #region Save
        [HttpPost]
        [Route("order")]
        [ProducesResponseType(typeof(Int32), StatusCodes.Status200OK)]
        public async Task<IActionResult> Save([FromBody] OrderRequest request)
        {
            try
            {
                var order = await _orderService.OrderAsync(request, UserId);
                return Ok(order);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        #endregion Save

        #region Get

        [HttpGet("orders")]

        [ProducesResponseType(typeof(List<OrderResponse>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetOrders()
        {
            try
            {
                var orders = await _orderService.GetOrdersByUserIdAsync(UserId);
                return Ok(orders);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("users-order")]
        [Authorize(Roles = "Admin")]
        [ProducesResponseType(typeof(List<OrderResponse>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetOrdersOfAllUsers()
        {
            try
            {
                var orders = await _orderService.GetOrdersOfAllUsersAsync();
                return Ok(orders);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        #endregion

    }
}
