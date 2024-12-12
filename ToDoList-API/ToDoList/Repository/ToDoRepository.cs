using Microsoft.EntityFrameworkCore;
using ToDoList.Data;
using ToDoList.Dto.ToDoItem;
using ToDoList.Interface;
using ToDoList.Model;

namespace ToDoList.Repository
{
    // The ToDoRepository class adheres to the Single Responsibility Principle (SRP) by focusing solely on data access logic
    // for ToDo items. It handles CRUD operations and interacts with the database via the ApplicationDbContext.

    public class ToDoRepository : IToDoRepository
    {
        private readonly ApplicationDbContext _context;

        // Constructor Dependency Injection adheres to the Dependency Inversion Principle (DIP),
        // as the repository depends on the abstraction (IToDoRepository) rather than a concrete implementation.
        public ToDoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        // SRP: The method is responsible only for creating an item in the database.
        public async Task<ToDoItem> CreateItem(ToDoItem item)
        {
            // Add item to the database
            await _context.ToDoItems.AddAsync(item);

            // Save changes
            _context.SaveChanges();
            return item;
        }

        // SRP: The method is responsible only for deleting an item from the database.
        public async Task<ToDoItem> DeleteItem(int id)
        {
            // Find item to delete in the database
            var itemToDelete = await _context.ToDoItems.FirstOrDefaultAsync(c => c.Id == id);

            // Check if item is null
            if (itemToDelete == null)
            {
                return null;
            }

            // Remove item from the database
            _context.ToDoItems.Remove(itemToDelete);

            // Save changes
            _context.SaveChanges();
            return itemToDelete;
        }

        // SRP: The method is responsible only for retrieving a single item by ID.
        public async Task<ToDoItem> GetItemById(int id)
        {
            // Get item from the database
            return await _context.ToDoItems.FirstOrDefaultAsync(c => c.Id == id);
        }

        // SRP: The method is responsible only for retrieving a list of items.
        public async Task<List<ToDoItem>> GetItems()
        {
            // Get list of items in the database
            return await _context.ToDoItems.ToListAsync();
        }

        // SRP: The method is responsible only for checking the existence of an item.
        public async Task<bool> ItemExists(int id)
        {
            // Check if item exists
            return await _context.ToDoItems.AnyAsync(c => c.Id == id);
        }

        // SRP: The method is responsible only for updating an existing item.
        public async Task<ToDoItem> UpdateItem(int id, ItemUpdateDto updateModel)
        {
            // Find item to update in the database
            var itemToUpdate = await _context.ToDoItems.FirstOrDefaultAsync(c => c.Id == id);

            if (itemToUpdate == null)
            {
                return null;
            }

            // Update item properties
            itemToUpdate.Title = updateModel.Title;
            itemToUpdate.Description = updateModel.Description;
            itemToUpdate.DueDate = updateModel.DueDate;

            // Save changes
            await _context.SaveChangesAsync();
            return itemToUpdate;
        }
    }
}
