using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MSIdentity.Data;
using MSIdentity.Data.Entities;
using MSIdentity.Models;
using Newtonsoft.Json;


namespace MSIdentity.Controllers;
[ApiController]
[Route("api/CategoryApi")]
//[Authorize]
public class CategoryApiController(ApplicationDbContext dbContext, ILogger<CategoryApiController> logger) : ControllerBase
{

    [HttpGet]
    [Route("Categories")]
    public IActionResult Categories()
    {

        try
        {
            var list = dbContext.Categories.ToList();//Gives IQuerable type of list
            //return Ok(list);
            return StatusCode(StatusCodes.Status200OK, list);
        }
        catch (Exception ex)
        {
            //Following method is wrong because it exposes sensitive information
            return StatusCode(StatusCodes.Status500InternalServerError,ex);
            //Correct way is to pass the custom error message with error code and 
            //log the full exception on server
            //logger.LogError(ex, "Error 1011 while getting categoriess from database");
            //return StatusCode(StatusCodes.Status500InternalServerError, new
            //{
            //    errorCode = "1011",
            //    errorMessage = "Error 1011 while getting categoriess from database"
            //});
        }
    }


    [Route("Create")]
    [HttpPost]
    public IActionResult Create(Category model)
    {
        if (ModelState.IsValid)
        {
            try
            {
                dbContext.Add(model);//it informs change tracker to add the entity
                dbContext.SaveChanges();//it asks the change tracker? what to do?
                return Ok(model);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error 1012 while adding category");
                return StatusCode(StatusCodes.Status500InternalServerError, new
                {
                    errorCode = "1012",
                    errorMessage = "Error 1012 while adding category"
                });
            }
        }
        return BadRequest(model);
    }

    [Route("GetById/{id:int}")]
    [HttpGet]
    public IActionResult GetById([FromRoute] int id)
    {
        if(id == 0)
        {
            return BadRequest("Id not received");
        }

        try
        {
            var model = dbContext.Categories.Find(id);
            return Ok(model);
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Error 1013 while getting category");
            return StatusCode(StatusCodes.Status500InternalServerError, new
            {
                errorCode = "1012",
                errorMessage = "Error 1013 while getting category"
            });
        }
    }

    [Route("Update")]
    [HttpPost]
    public IActionResult Update([FromBody] Category model)
    {
        if (ModelState.IsValid)
        {
            try
            {
                dbContext.Update(model);//tells the change tracker to note the changes
                dbContext.SaveChanges();
                return Ok(model);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error 1014 while updating category");
                return StatusCode(StatusCodes.Status500InternalServerError, new
                {
                    errorCode = "1012",
                    errorMessage = "Error 1014 while updating category"
                });
            }
        }
        return BadRequest(model);
    }

    [Route("delete/{id:int}")]
    [HttpPost]
    public IActionResult Delete([FromRoute] int id)
    {
        var record = dbContext.Categories.Find(id);
        //var record = new Category();
        if(record is not null)
        {
            try
            {
                dbContext.Remove(record);//tells the change tracker to note this change 
                dbContext.SaveChanges();
                return Ok();
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error 1015 while deleting category");
                return StatusCode(StatusCodes.Status500InternalServerError, new
                {
                    errorCode = "1012",
                    errorMessage = "Error 1015 while deleting category"
                });
            }
        }
        return BadRequest("Failed to delete record. Record not found");
    }
    [Authorize]
    [HttpPost]
    [Route("Add/{a:int}/{b:int}")]
    public IActionResult Add([FromRoute] int a, [FromRoute] int b)
    {
        var result = a + b;
        return Ok(result);
    }
    //From Query
    [Route("Method1")]
    [HttpPost]
    public IActionResult Method1([FromQuery] int a, [FromQuery] int b)
    {
        var result = a + b;
        return Ok(result);
    }
    //From Route
    [Route("Method2/a/{a:int}/b/{b:int}")]
    [HttpPost]
    public IActionResult Method2([FromRoute] int a, [FromRoute] int b)
    {
        var result = a + b;
        return Ok(result);
    }
    //From Body
    [Route("Method3")]
    [HttpPost]
    public IActionResult Method3([FromBody] Method3Class obj)
    {
        var result = obj.A + obj.B;
        return Ok(result);
    }
    //From Header
    [Route("Method4")]
    [HttpPost]
    public IActionResult Method4([FromHeader] int a, [FromHeader] int b)
    {
        var result = a + b;
        return Ok(result);
    }
}
public class Method3Class
{
    public int A { get; set; }
    public int B { get; set; }
}
//Parameters are passed using query or route
//configuration information is passed using headers
//Data is passed using body