using BookReadingEventSystemDTO.Data;
using BookReadingEventSystemDTO.Models;

namespace BookReadingEventSystemDTO.Operations
{
    public class UserOperations
    {
        private BookReadingEventSystemContext _context;

        public UserOperations(BookReadingEventSystemContext bookReadingEventSystemContext)
        {
            _context = bookReadingEventSystemContext;
        }

        public bool AddUser(User user)
        {
            return true;
        }

    }
}
