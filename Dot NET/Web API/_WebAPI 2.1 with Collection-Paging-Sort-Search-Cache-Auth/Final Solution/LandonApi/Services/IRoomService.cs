using LandonApi.Models;
using System;
using System.Threading.Tasks;

namespace LandonApi.Services {
    public interface IRoomService {
        Task<PagedResults<Room>> GetRoomsAsync(
            PagingOptions pagingOptions,
            SortOptions<Room, RoomEntity> sortOptions,
            SearchOptions<Room, RoomEntity> searchOptions);

        Task<Room> GetRoomAsync(Guid id);
    }
}