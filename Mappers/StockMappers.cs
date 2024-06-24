using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using social_media_finance_app.Dtos.Stock;
using social_media_finance_app.Models;

namespace social_media_finance_app.Mappers
{
    public static class StockMappers
    {
        public static StockDto ToStockDto(this Stock stock)
        {
            return new StockDto()
            {
                Id = stock.Id,
                Symbol = stock.Symbol,
                CompanyName = stock.CompanyName,
                Price = stock.Price,
                Purchase = stock.Purchase
            };
        }
    }
}
