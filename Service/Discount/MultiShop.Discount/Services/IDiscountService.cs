using MultiShop.Discount.Dtos;

namespace MultiShop.Discount.Services
{
    public interface IDiscountService
    {
        Task<List<ResultCouponDto>> GetAllDiscountCouponAsync();
        Task CreateDiscountCouponAsync(CreateCouponDto createCouponDto);
        Task UpdateDiscountCouponAsync(UpdateCouponDto updateCouponDto);
        Task DeleteDiscountCouponAsync(int id);
        Task<GetByIdCouponDto> GetByIdDiscountCouponAsync(int id);
    }
}
