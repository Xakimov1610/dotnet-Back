using BookApi_With_Patch.Entities;
using BookApi_With_Patch.Service;
using Microsoft.AspNetCore.Mvc;

namespace BookApi_With_Patch.Controller;

public class BookController : ControllerBase
{
    private readonly ILogger<BookController> _logger;
    private readonly IBookService _bookService;

    public BookController(ILogger<BookController> logger, IBookService bookService)
    {
        _logger = logger;
        _bookService = bookService;
    }
    [HttpGet("api/books")]
    public async Task<IActionResult> GetAllAsync()
    {
        var books = await _bookService.GetAllAsync();
        return Ok(books);
    }

    [HttpGet("api/books/{id}", Name = "GetBook")]
    public async Task<IActionResult> GetByIdAsync(Guid id)
    {
        var book = await _bookService.GetByIdAsync(id);
        if (book == null)
        {
            _logger.LogWarning("Book with id {id} not found", id);
            return NotFound();
        }
        return Ok(book);
    }

    [HttpPost("api/PostBook")]
    public async Task<IActionResult> CreateAsync([FromBody] Book bookToCreate)
    {
        await _bookService.CreateAsync(bookToCreate);
        return CreatedAtRoute("GetBook", new { id = bookToCreate.Id }, bookToCreate);
    }
    [HttpPut("api/books/{id}")]
    // public async Task<IActionResult> UpdateAsync(Guid id, [FromBody] Book bookToUpdate)
    // {
    //     var book = await _bookService.UpdateAsync(bookToUpdate);
    //     if (book == null)
    //     {
    //         _logger.LogWarning("Book with id {id} not found", id);
    //         return NotFound();
    //     }
    //     return Ok(book);
    // }

    [HttpDelete("api/books/{id}")]
    public async Task<IActionResult> DeleteAsync(Guid id)
    {
        var book = await _bookService.GetByIdAsync(id);
        if (book == null)
        {
            _logger.LogWarning("Book with id {id} not found", id);
            return NotFound();
        }
        await _bookService.DeleteAsync(id);
        return NoContent();
    }

   
  
}