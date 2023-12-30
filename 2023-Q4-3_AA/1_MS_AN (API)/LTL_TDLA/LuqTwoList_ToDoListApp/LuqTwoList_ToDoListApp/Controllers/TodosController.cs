using LuqTwoList_ToDoListApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LuqTwoList_ToDoListApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        private readonly ToDoListContext _contextZawartosc;
        public TodosController(ToDoListContext contextZawartosc)
        {
            _contextZawartosc = contextZawartosc;
        }

        // GET: api/<TodosController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ToDoList>>> GetTodos()
        {
            return await _contextZawartosc.TodosZadania.ToListAsync();
        }

        // GET api/<TodosController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ToDoList>> GetTodo(int id)
        {
            var todoZadanie = await _contextZawartosc.TodosZadania.FindAsync(id);
            if(todoZadanie == null)
            {
                return NotFound();
            }
            return todoZadanie;
        }

        // POST api/<TodosController>
        [HttpPost]
        public async Task<ActionResult<ToDoList>> PostTodo(ToDoList todoZadanie)
        {
            _contextZawartosc.TodosZadania.Add(todoZadanie);
            await _contextZawartosc.SaveChangesAsync();

            return CreatedAtAction("GetTodo", new { id = todoZadanie.Id }, todoZadanie);
        }

        // PUT api/<TodosController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<ToDoList>> PutTodo(int id, ToDoList todoZadanie)
        {
            if ( id != todoZadanie.Id )
            {
                return BadRequest();
            }

            _contextZawartosc.Entry(todoZadanie).State = EntityState.Modified;

            try
            {
                await _contextZawartosc.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ToDoListExist(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return todoZadanie;
        }

        // DELETE api/<TodosController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTodo(int id)
        {
            var todoZadanie = await _contextZawartosc.TodosZadania.FindAsync(id);
            if(todoZadanie == null)
            {
                return NotFound();
            }

            _contextZawartosc.TodosZadania.Remove(todoZadanie);
            await _contextZawartosc.SaveChangesAsync();

            return NoContent();
        }

        private bool ToDoListExist(int id)
        {
            return _contextZawartosc.TodosZadania.Any(e => e.Id == id);
        }
    }
}
