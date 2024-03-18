using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryPet.Data
{
    public class Coin
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public async Task<decimal> GetPriceCoin(string nameCoin)
        {
            using (ConnectDb db = new ConnectDb())
            {
                Coin coin = await Task.Run(() => db.Coins.FirstOrDefaultAsync(x => x.Name == nameCoin));
                if (coin != null)
                {
                    return coin.Price;
                }
                return 0;
            }
        }
    }
}
