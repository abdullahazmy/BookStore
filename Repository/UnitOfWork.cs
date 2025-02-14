using BookStore.Models;

namespace BookStore.Repository
{
    public class UnitOfWork
    {
        BookStoreDbContext _context;


        GenericRepository<Book> BookRepository;
        GenericRepository<Catalog> CatalogRepository;
        GenericRepository<Author> AuthorRepository;
        GenericRepository<Order> OrderRepository;
        GenericRepository<OrderDetails> OrderDetailsRepository;
        GenericRepository<Admin> AdminRepository;
        GenericRepository<Customer> CustomerRepository;

        public UnitOfWork(BookStoreDbContext context) =>
            _context = context;

        public GenericRepository<Book> BookRepo
        {
            get
            {
                if (BookRepository == null)
                    BookRepository = new GenericRepository<Book>(_context);
                return BookRepository;
            }
        }

        public GenericRepository<Catalog> CatalogRepo
        {
            get
            {
                if (CatalogRepository == null)
                    CatalogRepository = new GenericRepository<Catalog>(_context);
                return CatalogRepository;
            }
        }

        public GenericRepository<Author> AuthorRepo
        {
            get
            {
                if (AuthorRepository == null)
                    AuthorRepository = new GenericRepository<Author>(_context);
                return AuthorRepository;
            }
        }

        public GenericRepository<Order> OrderRepo
        {
            get
            {
                if (OrderRepository == null)
                    OrderRepository = new GenericRepository<Order>(_context);
                return OrderRepository;
            }
        }

        public GenericRepository<OrderDetails> OrderDetailsRepo
        {
            get
            {
                if (OrderDetailsRepository == null)
                    OrderDetailsRepository = new GenericRepository<OrderDetails>(_context);
                return OrderDetailsRepository;
            }
        }

        public GenericRepository<Admin> AdminRepo
        {
            get
            {
                if (AdminRepository == null)
                    AdminRepository = new GenericRepository<Admin>(_context);
                return AdminRepository;
            }
        }

        public GenericRepository<Customer> CustomerRepo
        {
            get
            {
                if (CustomerRepository == null)
                    CustomerRepository = new GenericRepository<Customer>(_context);
                return CustomerRepository;
            }
        }

        public Task SaveAsync() => _context.SaveChangesAsync();
    }
}
