using Microsoft.EntityFrameworkCore;

namespace LuqTwoList_ToDoListApp.Models
{
    public class ToDoListContext : DbContext
    {
        public ToDoListContext(DbContextOptions<ToDoListContext> optionsOpcje) : base (optionsOpcje) { }
        public DbSet<ToDoList> TodosZadania { get; set; }
    }
}
