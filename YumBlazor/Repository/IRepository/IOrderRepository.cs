using YumBlazor.Data;

namespace YumBlazor.Repository.IRepository
{
	public interface IOrderRepository
	{
		public Task<OrderHeader> CreateAsync(OrderHeader orderHeader);
		public Task<OrderHeader> GetAsync(int id);
		public Task<IEnumerable<OrderHeader>> GetAllAsync(String? userId = null);
		public Task<OrderHeader> UpdateStatusAsync(int orderId, string status);
	}
}
